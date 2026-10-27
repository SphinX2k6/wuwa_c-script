using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.Command;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200714E RID: 29006
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFollowerFollowShooterHandler : PlayerFollowerSwallowHandler, IPlayerFollowerFollowShooterHandler, IPlayerFollowerHandler
	{
		// Token: 0x06046D14 RID: 290068 RVA: 0x011D9148 File Offset: 0x011D7348
		public PlayerFollowerFollowShooterHandler(int playerId)
		{
			Comparison<PlayerFollowerInfo> compare;
			if ((compare = PlayerFollowerFollowShooterHandler.<>O.<0>__Compare) == null)
			{
				compare = (PlayerFollowerFollowShooterHandler.<>O.<0>__Compare = new Comparison<PlayerFollowerInfo>(PlayerFollowerInfo.Compare));
			}
			this.FollowShooters = new PriorityQueue<PlayerFollowerInfo>(compare);
			base..ctor();
			this.PlayerId = playerId;
			this.IsAutonomousProxy = new bool?(playerId == CreatureModel.Instance.GetPlayerId());
		}

		// Token: 0x06046D15 RID: 290069 RVA: 0x011D91A0 File Offset: 0x011D73A0
		public override IReceiver<ICommandTypeAddFollower> AddFollowerReceiver()
		{
			return new Receiver<ICommandTypeAddFollower>
			{
				ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeAddFollower> @params)
				{
					TCommandHandleParamsAddFollower tcommandHandleParamsAddFollower = (TCommandHandleParamsAddFollower)@params;
					this.FollowShooters.Push(tcommandHandleParamsAddFollower.PlayerFollowerInfo);
				}
			};
		}

		// Token: 0x06046D16 RID: 290070 RVA: 0x011D91B9 File Offset: 0x011D73B9
		public override IReceiver<ICommandTypeFlushFollower> FlushFollowerReceiver()
		{
			return new Receiver<ICommandTypeFlushFollower>
			{
				ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeFlushFollower> @params)
				{
					if (this.FollowShooters.Empty)
					{
						this.UnPossessFollower();
						return;
					}
					PlayerFollowerInfo top = this.FollowShooters.Top;
					if (top.CreatureDataId != this.CurrentFollowerCreatureDataId)
					{
						this.UnPossessFollower();
						this.WaitFollower(top.CreatureDataId);
					}
					this.FollowShooters.Clear();
				}
			};
		}

		// Token: 0x06046D17 RID: 290071 RVA: 0x011D91D2 File Offset: 0x011D73D2
		public override bool HasFollower(long creatureDataId)
		{
			return this.CurrentFollowerCreatureDataId == creatureDataId;
		}

		// Token: 0x06046D18 RID: 290072 RVA: 0x011D91DD File Offset: 0x011D73DD
		public override void OnClear()
		{
			this.UnPossessFollower();
			this.FollowShooters.Clear();
		}

		// Token: 0x06046D19 RID: 290073 RVA: 0x011D91F0 File Offset: 0x011D73F0
		private void WaitFollower(long creatureDataId)
		{
			WaitEntityTask waitEntityTask = this.WaitEntityTask;
			if (waitEntityTask != null)
			{
				waitEntityTask.Cancel();
			}
			this.WaitEntityTask = null;
			this.WaitEntityTask = WaitEntityTask.Create("PlayerFollowerFollowShooterHandler.WaitFollower", creatureDataId, delegate(bool? result)
			{
				this.WaitEntityTask = null;
				if (!result.GetValueOrDefault())
				{
					return;
				}
				EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
				if (entity == null || !entity.Valid || !FollowUtils.IsFollowShooter(entity))
				{
					return;
				}
				this.PossessFollower(creatureDataId, entity);
			}, 90000, false, true);
		}

		// Token: 0x06046D1A RID: 290074 RVA: 0x011D9252 File Offset: 0x011D7452
		private void PossessFollower(long creatureDataId, EntityHandle entityHandle)
		{
			this.CurrentFollowerCreatureDataId = creatureDataId;
			this.WaitFollowShooterEntityFinish(creatureDataId, entityHandle).Forget();
		}

		// Token: 0x06046D1B RID: 290075 RVA: 0x011D9268 File Offset: 0x011D7468
		private UniTask WaitFollowShooterEntityFinish(long creatureDataId, EntityHandle entityHandle)
		{
			PlayerFollowerFollowShooterHandler.<WaitFollowShooterEntityFinish>d__14 <WaitFollowShooterEntityFinish>d__;
			<WaitFollowShooterEntityFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFollowShooterEntityFinish>d__.<>4__this = this;
			<WaitFollowShooterEntityFinish>d__.creatureDataId = creatureDataId;
			<WaitFollowShooterEntityFinish>d__.entityHandle = entityHandle;
			<WaitFollowShooterEntityFinish>d__.<>1__state = -1;
			<WaitFollowShooterEntityFinish>d__.<>t__builder.Start<PlayerFollowerFollowShooterHandler.<WaitFollowShooterEntityFinish>d__14>(ref <WaitFollowShooterEntityFinish>d__);
			return <WaitFollowShooterEntityFinish>d__.<>t__builder.Task;
		}

		// Token: 0x06046D1C RID: 290076 RVA: 0x011D92BC File Offset: 0x011D74BC
		private void UnPossessFollower()
		{
			WaitEntityTask waitEntityTask = this.WaitEntityTask;
			if (waitEntityTask != null)
			{
				waitEntityTask.Cancel();
			}
			this.WaitEntityTask = null;
			if (this.CurrentFollower != null && this.IsAutonomousProxy.GetValueOrDefault())
			{
				this.CurrentFollower.UnPossessed();
				EventSystem.Instance.Emit(EEventName.OnPlayerFollowerUnPossessed);
			}
			this.CurrentFollowerCreatureDataId = 0L;
			this.CurrentFollowerHandle = null;
			this.CurrentFollower = null;
		}

		// Token: 0x06046D1D RID: 290077 RVA: 0x011D9328 File Offset: 0x011D7528
		public unsafe bool SetFollowShooterEnable(bool enable, BPEEnableFollowShooter enableType, string reason = "")
		{
			if (this.CurrentFollower == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "SetFollowShooterEnable: CurrentFollower is undefined";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerId", this.PlayerId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return this.CurrentFollower.SetEnable(enable, enableType, reason);
		}

		// Token: 0x06046D1E RID: 290078 RVA: 0x011D93AA File Offset: 0x011D75AA
		[NullableContext(2)]
		public EntityHandle GetFollowShooter()
		{
			return this.CurrentFollowerHandle;
		}

		// Token: 0x06046D1F RID: 290079 RVA: 0x011D93B2 File Offset: 0x011D75B2
		public bool IsFollowShooterEnable()
		{
			IFollower currentFollower = this.CurrentFollower;
			return currentFollower != null && currentFollower.GetEnable();
		}

		// Token: 0x06046D20 RID: 290080 RVA: 0x011D93C5 File Offset: 0x011D75C5
		public void AddFollowShooterCustomEntityId(string customKey, int entityId)
		{
			BulletModel.Instance.SetCustomBulletAttacker(customKey, entityId);
		}

		// Token: 0x06046D21 RID: 290081 RVA: 0x011D93D3 File Offset: 0x011D75D3
		public bool RemoveFollowShooterCustomEntityId(string customKey)
		{
			return BulletModel.Instance.RemoveCustomBulletAttacker(customKey);
		}

		// Token: 0x06046D22 RID: 290082 RVA: 0x011D93E0 File Offset: 0x011D75E0
		public int? GetFollowShooterCustomEntityId(string customKey)
		{
			return BulletModel.Instance.GetCustomBulletAttacker(customKey);
		}

		// Token: 0x040252B6 RID: 152246
		private long CurrentFollowerCreatureDataId;

		// Token: 0x040252B7 RID: 152247
		private readonly bool? IsAutonomousProxy;

		// Token: 0x040252B8 RID: 152248
		private readonly int PlayerId;

		// Token: 0x040252B9 RID: 152249
		[Nullable(2)]
		private EntityHandle CurrentFollowerHandle;

		// Token: 0x040252BA RID: 152250
		[Nullable(2)]
		private IFollower CurrentFollower;

		// Token: 0x040252BB RID: 152251
		[Nullable(2)]
		private WaitEntityTask WaitEntityTask;

		// Token: 0x040252BC RID: 152252
		private readonly PriorityQueue<PlayerFollowerInfo> FollowShooters;

		// Token: 0x0200CE9C RID: 52892
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E2DC RID: 254684
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<PlayerFollowerInfo> <0>__Compare;
		}
	}
}
