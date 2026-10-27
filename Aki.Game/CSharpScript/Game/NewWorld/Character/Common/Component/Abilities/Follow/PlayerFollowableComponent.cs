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
	// Token: 0x02007148 RID: 29000
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayerFollowableComponent : EntityComponent, IFollowable, IStaticVariableResetter
	{
		// Token: 0x06046C9E RID: 289950 RVA: 0x011D61D8 File Offset: 0x011D43D8
		static PlayerFollowableComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerFollowableComponent.CreateStaticDefaultValue), new Action(PlayerFollowableComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06046C9F RID: 289951 RVA: 0x011D623F File Offset: 0x011D443F
		[Obsolete]
		public EntityHandle GetFollower()
		{
			return FollowUtils.GetPlayerFollowShooter(this.PlayerId);
		}

		// Token: 0x06046CA0 RID: 289952 RVA: 0x011D624C File Offset: 0x011D444C
		[Obsolete]
		public bool IsFollowerEnable()
		{
			return FollowUtils.IsFollowShooterEnable(this.PlayerId);
		}

		// Token: 0x06046CA1 RID: 289953 RVA: 0x011D625C File Offset: 0x011D445C
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

		// Token: 0x06046CA2 RID: 289954 RVA: 0x011D62BB File Offset: 0x011D44BB
		public static void ResetStaticDefaultValue()
		{
			PlayerFollowableComponent.getHandlerTypeChain = null;
			PlayerFollowableComponent.FollowerHandlerFactory = null;
		}

		// Token: 0x06046CA3 RID: 289955 RVA: 0x011D62CC File Offset: 0x011D44CC
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

		// Token: 0x06046CA4 RID: 289956 RVA: 0x011D6378 File Offset: 0x011D4578
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

		// Token: 0x06046CA5 RID: 289957 RVA: 0x011D63B8 File Offset: 0x011D45B8
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

		// Token: 0x06046CA6 RID: 289958 RVA: 0x011D644C File Offset: 0x011D464C
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

		// Token: 0x06046CA7 RID: 289959 RVA: 0x011D67D8 File Offset: 0x011D49D8
		public long GetFollowerCreatureDataId(EClientPlayerFollower type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull((int)type) : null).GetValueOrDefault();
		}

		// Token: 0x06046CA8 RID: 289960 RVA: 0x011D6808 File Offset: 0x011D4A08
		public long GetFollowerCreatureDataId(EPlayerFollower type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull((int)type) : null).GetValueOrDefault();
		}

		// Token: 0x06046CA9 RID: 289961 RVA: 0x011D6838 File Offset: 0x011D4A38
		public long GetFollowerCreatureDataId(int type)
		{
			Dictionary<int, long> followersMap = this.FollowersMap;
			return ((followersMap != null) ? followersMap.GetValueOrNull(type) : null).GetValueOrDefault();
		}

		// Token: 0x06046CAA RID: 289962 RVA: 0x011D6868 File Offset: 0x011D4A68
		[Obsolete]
		public void SetFollowerEnable(bool enable)
		{
			FollowUtils.SetPlayerFollowShooterEnable(this.PlayerId, enable, BPEEnableFollowShooter.GameAbility, "");
		}

		// Token: 0x06046CAB RID: 289963 RVA: 0x011D6880 File Offset: 0x011D4A80
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

		// Token: 0x06046CAC RID: 289964 RVA: 0x011D69AC File Offset: 0x011D4BAC
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

		// Token: 0x06046CAD RID: 289965 RVA: 0x011D6A58 File Offset: 0x011D4C58
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerFollowableComponent playerFollowableComponent = (PlayerFollowableComponent)componentTemplate;
			if (base.CanResetComponentProperty("CommandInvoker"))
			{
				if (playerFollowableComponent.CommandInvoker == null)
				{
					this.CommandInvoker = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CommandInvoker>(this.CommandInvoker), "CommandInvoker"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FollowerHandlesMap"))
			{
				if (playerFollowableComponent.FollowerHandlesMap == null)
				{
					this.FollowerHandlesMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler>>(this.FollowerHandlesMap), "FollowerHandlesMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FollowersMap"))
			{
				if (playerFollowableComponent.FollowersMap == null)
				{
					this.FollowersMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, long>>(this.FollowersMap), "FollowersMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PlayerId"))
			{
				this.PlayerId = playerFollowableComponent.PlayerId;
			}
			return true;
		}

		// Token: 0x04025285 RID: 152197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IParameterHandler<EntityHandleParameterContext> getHandlerTypeChain;

		// Token: 0x04025286 RID: 152198
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandlerFactory<IPlayerFollowerHandler>> FollowerHandlerFactory;

		// Token: 0x04025287 RID: 152199
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

		// Token: 0x04025288 RID: 152200
		public CommandInvoker CommandInvoker;

		// Token: 0x04025289 RID: 152201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EPlayerFollowerHandlerType, IPlayerFollowerHandler> FollowerHandlesMap;

		// Token: 0x0402528A RID: 152202
		private Dictionary<int, long> FollowersMap;

		// Token: 0x0402528B RID: 152203
		private int PlayerId;
	}
}
