using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.Command;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200637C RID: 25468
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFollowerFollowShooterHandler : PlayerFollowerSwallowHandler, IPlayerFollowerFollowShooterHandler, IPlayerFollowerHandler
	{
		// Token: 0x0603DB6E RID: 252782 RVA: 0x011E22FC File Offset: 0x011E04FC
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

		// Token: 0x0603DB6F RID: 252783 RVA: 0x011E2354 File Offset: 0x011E0554
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

		// Token: 0x0603DB70 RID: 252784 RVA: 0x011E236D File Offset: 0x011E056D
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

		// Token: 0x0603DB71 RID: 252785 RVA: 0x011E2386 File Offset: 0x011E0586
		public override bool HasFollower(long creatureDataId)
		{
			return this.CurrentFollowerCreatureDataId == creatureDataId;
		}

		// Token: 0x0603DB72 RID: 252786 RVA: 0x011E2391 File Offset: 0x011E0591
		public override void OnClear()
		{
			this.UnPossessFollower();
			this.FollowShooters.Clear();
		}

		// Token: 0x0603DB73 RID: 252787 RVA: 0x011E23A4 File Offset: 0x011E05A4
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

		// Token: 0x0603DB74 RID: 252788 RVA: 0x011E2406 File Offset: 0x011E0606
		private void PossessFollower(long creatureDataId, EntityHandle entityHandle)
		{
			this.CurrentFollowerCreatureDataId = creatureDataId;
			this.WaitFollowShooterEntityFinish(creatureDataId, entityHandle).Forget();
		}

		// Token: 0x0603DB75 RID: 252789 RVA: 0x011E241C File Offset: 0x011E061C
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

		// Token: 0x0603DB76 RID: 252790 RVA: 0x011E2470 File Offset: 0x011E0670
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

		// Token: 0x0603DB77 RID: 252791 RVA: 0x011E24DC File Offset: 0x011E06DC
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

		// Token: 0x0603DB78 RID: 252792 RVA: 0x011E255E File Offset: 0x011E075E
		[NullableContext(2)]
		public EntityHandle GetFollowShooter()
		{
			return this.CurrentFollowerHandle;
		}

		// Token: 0x0603DB79 RID: 252793 RVA: 0x011E2566 File Offset: 0x011E0766
		public bool IsFollowShooterEnable()
		{
			IFollower currentFollower = this.CurrentFollower;
			return currentFollower != null && currentFollower.GetEnable();
		}

		// Token: 0x0603DB7A RID: 252794 RVA: 0x011E2579 File Offset: 0x011E0779
		public void AddFollowShooterCustomEntityId(string customKey, int entityId)
		{
			BulletModel.Instance.SetCustomBulletAttacker(customKey, entityId);
		}

		// Token: 0x0603DB7B RID: 252795 RVA: 0x011E2587 File Offset: 0x011E0787
		public bool RemoveFollowShooterCustomEntityId(string customKey)
		{
			return BulletModel.Instance.RemoveCustomBulletAttacker(customKey);
		}

		// Token: 0x0603DB7C RID: 252796 RVA: 0x011E2594 File Offset: 0x011E0794
		public int? GetFollowShooterCustomEntityId(string customKey)
		{
			return BulletModel.Instance.GetCustomBulletAttacker(customKey);
		}

		// Token: 0x04020B99 RID: 134041
		private long CurrentFollowerCreatureDataId;

		// Token: 0x04020B9A RID: 134042
		private readonly bool? IsAutonomousProxy;

		// Token: 0x04020B9B RID: 134043
		private readonly int PlayerId;

		// Token: 0x04020B9C RID: 134044
		[Nullable(2)]
		private EntityHandle CurrentFollowerHandle;

		// Token: 0x04020B9D RID: 134045
		[Nullable(2)]
		private IFollower CurrentFollower;

		// Token: 0x04020B9E RID: 134046
		[Nullable(2)]
		private WaitEntityTask WaitEntityTask;

		// Token: 0x04020B9F RID: 134047
		private readonly PriorityQueue<PlayerFollowerInfo> FollowShooters;

		// Token: 0x0200BB64 RID: 47972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040399E6 RID: 236006
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<PlayerFollowerInfo> <0>__Compare;
		}
	}
}
