using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Data.Fight.Enum;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Utils.Command;
using CSharpScript.Game.Utils.ResponsibilityChain;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006376 RID: 25462
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayerFollowableComponent : EntityComponent, IFollowable, IStaticVariableResetter
	{
		// Token: 0x0603DAEF RID: 252655 RVA: 0x011DEBEC File Offset: 0x011DCDEC
		static PlayerFollowableComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerFollowableComponent.CreateStaticDefaultValue), new Action(PlayerFollowableComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603DAF0 RID: 252656 RVA: 0x011DEC53 File Offset: 0x011DCE53
		[Obsolete]
		public EntityHandle GetFollower()
		{
			return FollowUtils.GetPlayerFollowShooter(this.PlayerId);
		}

		// Token: 0x0603DAF1 RID: 252657 RVA: 0x011DEC60 File Offset: 0x011DCE60
		[Obsolete]
		public bool IsFollowerEnable()
		{
			return FollowUtils.IsFollowShooterEnable(this.PlayerId);
		}

		// Token: 0x0603DAF2 RID: 252658 RVA: 0x011DEC70 File Offset: 0x011DCE70
		public static void CreateStaticDefaultValue()
		{
			PlayerFollowableComponent.getHandlerTypeChain = new RegardAsFollowShooterHandler();
			PlayerFollowableComponent.getHandlerTypeChain.SetNext(new RegardAsVehicleHandler()).SetNext(new RegardAsChairHandler());
			PlayerFollowableComponent.FollowerHandlerFactory = new Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandlerFactory<IPlayerFollowerHandler>>
			{
				{
					EPlayerFollowerHandlerType.FollowShooter,
					new PlayerFollowerFollowShooterHandlerFactory()
				},
				{
					EPlayerFollowerHandlerType.Vehicle,
					new PlayerFollowerVehicleHandlerFactory()
				},
				{
					EPlayerFollowerHandlerType.Chair,
					new PlayerFollowerChairHandlerFactory()
				}
			};
		}

		// Token: 0x0603DAF3 RID: 252659 RVA: 0x011DECCF File Offset: 0x011DCECF
		public static void ResetStaticDefaultValue()
		{
			PlayerFollowableComponent.getHandlerTypeChain = null;
			PlayerFollowableComponent.FollowerHandlerFactory = null;
		}

		// Token: 0x0603DAF4 RID: 252660 RVA: 0x011DECE0 File Offset: 0x011DCEE0
		public IPlayerFollowerHandler GetOrCreateHandlerByCreatureDataId(long creatureDataId)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
			if (entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[PlayerFollowableComponent] UpdatePlayerFollowers 无实体Handle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EntityHandleParameterContext entityHandleParameterContext = new EntityHandleParameterContext(entity);
			PlayerFollowableComponent.getHandlerTypeChain.Handle(entityHandleParameterContext);
			if (entityHandleParameterContext.OutPlayerFollowerHandlerType == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Entity;
				ELogAuthor author2 = ELogAuthor.XDW;
				string message2 = "[PlayerFollowableComponent] UpdatePlayerFollowers 无handler类型";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return this.GetOrCreateHandler(entityHandleParameterContext.OutPlayerFollowerHandlerType.Value);
		}

		// Token: 0x0603DAF5 RID: 252661 RVA: 0x011DED8C File Offset: 0x011DCF8C
		[NullableContext(1)]
		[return: Nullable(2)]
		public T GetOrCreateHandler<T>() where T : class, IPlayerFollowerHandler
		{
			EPlayerFollowerHandlerType handlerType;
			if (PlayerFollowableComponent.PlayerFollowerHandlerTypeNameToEnum.TryGetValue(typeof(T), out handlerType))
			{
				return this.GetOrCreateHandler(handlerType) as T;
			}
			return default(T);
		}

		// Token: 0x0603DAF6 RID: 252662 RVA: 0x011DEDCC File Offset: 0x011DCFCC
		public IPlayerFollowerHandler GetOrCreateHandler(EPlayerFollowerHandlerType handlerType)
		{
			Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler> followerHandlesMap = this.FollowerHandlesMap;
			if (followerHandlesMap != null && followerHandlesMap.ContainsKey(handlerType))
			{
				return this.FollowerHandlesMap.GetValueOrDefault(handlerType);
			}
			IPlayerFollowerHandlerFactory<IPlayerFollowerHandler> valueOrDefault = PlayerFollowableComponent.FollowerHandlerFactory.GetValueOrDefault(handlerType);
			if (valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[PlayerFollowableComponent] UpdatePlayerFollowers handler工厂旷工";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandlerType", handlerType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			IPlayerFollowerHandler playerFollowerHandler = valueOrDefault.Create(this.PlayerId);
			if (playerFollowerHandler == null)
			{
				return null;
			}
			if (this.FollowerHandlesMap != null)
			{
				this.FollowerHandlesMap[handlerType] = playerFollowerHandler;
			}
			return playerFollowerHandler;
		}

		// Token: 0x0603DAF7 RID: 252663 RVA: 0x011DEE60 File Offset: 0x011DD060
		[NullableContext(1)]
		public void UpdatePlayerFollowers(IEnumerable<IPlayerFollowerItemInfo> followers)
		{
			if (this.FollowersMap == null || this.FollowerHandlesMap == null)
			{
				return;
			}
			CommandInvoker commandInvoker = this.CommandInvoker;
			if (commandInvoker != null)
			{
				commandInvoker.ClearAllCommand();
			}
			foreach (IPlayerFollowerItemInfo playerFollowerItemInfo in followers)
			{
				long num = MathUtils.Instance.LongToNumber(playerFollowerItemInfo.EntityId);
				if (num <= 0L)
				{
					if (this.FollowersMap.ContainsKey(playerFollowerItemInfo.Type))
					{
						long valueOrDefault = this.FollowersMap.GetValueOrDefault(playerFollowerItemInfo.Type, 0L);
						this.FollowersMap.Remove(playerFollowerItemInfo.Type);
						IGameCommandWithReceivers<ICommandTypeRemoveFollower> gameCommandWithReceivers = GameCommandFactory.CreateGameCommandWithReceivers<ICommandTypeRemoveFollower>(new TCommandHandleParamsRemoveFollower
						{
							CreatureDataId = valueOrDefault
						});
						foreach (IPlayerFollowerHandler playerFollowerHandler in this.FollowerHandlesMap.Values)
						{
							gameCommandWithReceivers.AddReceiver(playerFollowerHandler.RemoveFollowerReceiver());
						}
						CommandInvoker commandInvoker2 = this.CommandInvoker;
						if (commandInvoker2 != null)
						{
							commandInvoker2.SubmitCommand<ICommandTypeRemoveFollower>(gameCommandWithReceivers, false);
						}
					}
				}
				else
				{
					long num2;
					if (this.FollowersMap.TryGetValue(playerFollowerItemInfo.Type, out num2) && num2 != num)
					{
						IGameCommandWithReceivers<ICommandTypeRemoveFollower> gameCommandWithReceivers2 = GameCommandFactory.CreateGameCommandWithReceivers<ICommandTypeRemoveFollower>(new TCommandHandleParamsRemoveFollower
						{
							CreatureDataId = num2
						});
						foreach (IPlayerFollowerHandler playerFollowerHandler2 in this.FollowerHandlesMap.Values)
						{
							gameCommandWithReceivers2.AddReceiver(playerFollowerHandler2.RemoveFollowerReceiver());
						}
						CommandInvoker commandInvoker3 = this.CommandInvoker;
						if (commandInvoker3 != null)
						{
							commandInvoker3.SubmitCommand<ICommandTypeRemoveFollower>(gameCommandWithReceivers2, false);
						}
					}
					this.FollowersMap[playerFollowerItemInfo.Type] = num;
				}
			}
			foreach (KeyValuePair<int, long> keyValuePair in this.FollowersMap)
			{
				int num3;
				long num4;
				keyValuePair.Deconstruct(out num3, out num4);
				int key = num3;
				long creatureDataId = num4;
				int? valueOrNull = FollowDefine.PlayerFollowerPriority.GetValueOrNull(key);
				IGameCommandWithReceivers<ICommandTypeAddFollower> gameCommandWithReceivers3 = GameCommandFactory.CreateGameCommandWithReceivers<ICommandTypeAddFollower>(new TCommandHandleParamsAddFollower
				{
					PlayerFollowerInfo = new PlayerFollowerInfo(creatureDataId, valueOrNull)
				});
				foreach (IPlayerFollowerHandler playerFollowerHandler3 in this.FollowerHandlesMap.Values)
				{
					gameCommandWithReceivers3.AddReceiver(playerFollowerHandler3.AddFollowerReceiver());
				}
				CommandInvoker commandInvoker4 = this.CommandInvoker;
				if (commandInvoker4 != null)
				{
					commandInvoker4.SubmitCommand<ICommandTypeAddFollower>(gameCommandWithReceivers3, false);
				}
			}
			IGameCommandWithReceivers<ICommandTypeFlushFollower> gameCommandWithReceivers4 = GameCommandFactory.CreateGameCommandWithReceivers<ICommandTypeFlushFollower>(new TCommandHandleParamsFlushFollower());
			foreach (IPlayerFollowerHandler playerFollowerHandler4 in this.FollowerHandlesMap.Values)
			{
				gameCommandWithReceivers4.AddReceiver(playerFollowerHandler4.FlushFollowerReceiver());
			}
			CommandInvoker commandInvoker5 = this.CommandInvoker;
			if (commandInvoker5 != null)
			{
				commandInvoker5.SubmitCommand<ICommandTypeFlushFollower>(gameCommandWithReceivers4, false);
			}
			CommandInvoker commandInvoker6 = this.CommandInvoker;
			if (commandInvoker6 == null)
			{
				return;
			}
			commandInvoker6.ExecuteAllCommand();
		}

		// Token: 0x0603DAF8 RID: 252664 RVA: 0x011DF1EC File Offset: 0x011DD3EC
		public long GetFollowerCreatureDataId(EClientPlayerFollower type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull((int)type) : null).GetValueOrDefault();
		}

		// Token: 0x0603DAF9 RID: 252665 RVA: 0x011DF21C File Offset: 0x011DD41C
		public long GetFollowerCreatureDataId(EPlayerFollower type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull((int)type) : null).GetValueOrDefault();
		}

		// Token: 0x0603DAFA RID: 252666 RVA: 0x011DF24C File Offset: 0x011DD44C
		public long GetFollowerCreatureDataId(int type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull(type) : null).GetValueOrDefault();
		}

		// Token: 0x0603DAFB RID: 252667 RVA: 0x011DF27C File Offset: 0x011DD47C
		[Obsolete]
		public void SetFollowerEnable(bool enable)
		{
			FollowUtils.SetPlayerFollowShooterEnable(this.PlayerId, enable, BPEEnableFollowShooter.GameAbility, "");
		}

		// Token: 0x0603DAFC RID: 252668 RVA: 0x011DF294 File Offset: 0x011DD494
		protected override bool OnInitData(IEntityArgs args = null)
		{
			base.OnInitData(args);
			this.FollowersMap = new Dictionary<int, long>();
			this.FollowerHandlesMap = new Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler>();
			this.CommandInvoker = new CommandInvoker();
			CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
			this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
			foreach (EPlayerFollowerHandlerType handlerType in PlayerFollowableComponent.FollowerHandlerFactory.Keys)
			{
				this.GetOrCreateHandler(handlerType);
			}
			RepeatedField<PlayerFollowerPb> repeatedField;
			if (creatureDataComponent == null)
			{
				repeatedField = null;
			}
			else
			{
				PlayerFollowersComponentPb playerFollowersInfo = creatureDataComponent.PlayerFollowersInfo;
				repeatedField = ((playerFollowersInfo != null) ? playerFollowersInfo.ListPlayerFollowerPb : null);
			}
			RepeatedField<PlayerFollowerPb> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				List<PlayerFollowerItemInfo> list = new List<PlayerFollowerItemInfo>();
				foreach (PlayerFollowerPb playerFollowerPb in repeatedField2)
				{
					if (playerFollowerPb != null)
					{
						list.Add(new PlayerFollowerItemInfo
						{
							Type = (int)playerFollowerPb.Type,
							EntityId = playerFollowerPb.EntityId
						});
					}
				}
				this.UpdatePlayerFollowers(list);
			}
			return true;
		}

		// Token: 0x0603DAFD RID: 252669 RVA: 0x011DF3C0 File Offset: 0x011DD5C0
		protected override bool OnClear()
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			if (followersMap != null)
			{
				followersMap.Clear();
			}
			this.FollowersMap = null;
			if (this.FollowerHandlesMap != null)
			{
				foreach (IPlayerFollowerHandler playerFollowerHandler in this.FollowerHandlesMap.Values)
				{
					playerFollowerHandler.OnClear();
				}
			}
			CommandInvoker commandInvoker = this.CommandInvoker;
			if (commandInvoker != null)
			{
				commandInvoker.ClearAllCommand();
			}
			this.CommandInvoker = null;
			Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler> followerHandlesMap = this.FollowerHandlesMap;
			if (followerHandlesMap != null)
			{
				followerHandlesMap.Clear();
			}
			this.FollowerHandlesMap = null;
			return base.OnClear();
		}

		// Token: 0x0603DAFE RID: 252670 RVA: 0x011DF46C File Offset: 0x011DD66C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerFollowableComponent playerFollowableComponent = (PlayerFollowableComponent)componentTemplate;
			if (playerFollowableComponent.CommandInvoker == null)
			{
				this.CommandInvoker = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommandInvoker), "CommandInvoker"))
			{
				return false;
			}
			if (playerFollowableComponent.FollowerHandlesMap == null)
			{
				this.FollowerHandlesMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FollowerHandlesMap), "FollowerHandlesMap"))
			{
				return false;
			}
			if (playerFollowableComponent.FollowersMap == null)
			{
				this.FollowersMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FollowersMap), "FollowersMap"))
			{
				return false;
			}
			this.PlayerId = playerFollowableComponent.PlayerId;
			return true;
		}

		// Token: 0x1700751B RID: 29979
		// (get) Token: 0x0603DAFF RID: 252671 RVA: 0x011DF519 File Offset: 0x011DD719
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020B65 RID: 133989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IParameterHandler<EntityHandleParameterContext> getHandlerTypeChain;

		// Token: 0x04020B66 RID: 133990
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandlerFactory<IPlayerFollowerHandler>> FollowerHandlerFactory;

		// Token: 0x04020B67 RID: 133991
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<Type, EPlayerFollowerHandlerType> PlayerFollowerHandlerTypeNameToEnum = new Dictionary<Type, EPlayerFollowerHandlerType>
		{
			{
				typeof(IPlayerFollowerFollowShooterHandler),
				EPlayerFollowerHandlerType.FollowShooter
			},
			{
				typeof(IPlayerFollowerVehicleHandler),
				EPlayerFollowerHandlerType.Vehicle
			},
			{
				typeof(IPlayerFollowerChairHandler),
				EPlayerFollowerHandlerType.Chair
			}
		};

		// Token: 0x04020B68 RID: 133992
		public CommandInvoker CommandInvoker;

		// Token: 0x04020B69 RID: 133993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler> FollowerHandlesMap;

		// Token: 0x04020B6A RID: 133994
		private Dictionary<int, long> FollowersMap;

		// Token: 0x04020B6B RID: 133995
		private int PlayerId;
	}
}
