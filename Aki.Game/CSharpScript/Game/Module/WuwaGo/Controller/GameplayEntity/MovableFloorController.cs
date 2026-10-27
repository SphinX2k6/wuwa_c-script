using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Movement;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004773 RID: 18291
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MovableFloorController : GameplayEntityControllerBase
	{
		// Token: 0x0602FD20 RID: 195872 RVA: 0x00B14A7B File Offset: 0x00B12C7B
		public MovableFloorController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x1700776D RID: 30573
		// (get) Token: 0x0602FD21 RID: 195873 RVA: 0x00B14A91 File Offset: 0x00B12C91
		private WuWaGoMovableFloorEntity MovableFloor
		{
			get
			{
				return this.Entity as WuWaGoMovableFloorEntity;
			}
		}

		// Token: 0x0602FD22 RID: 195874 RVA: 0x00B14A9E File Offset: 0x00B12C9E
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			base.ResetActorToEntityConfigInitialTransform();
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x0602FD23 RID: 195875 RVA: 0x00B14AB8 File Offset: 0x00B12CB8
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.StopMoveSmokeEffect(true);
			this.RestoreInitialPosition();
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602FD24 RID: 195876 RVA: 0x00B14AD4 File Offset: 0x00B12CD4
		protected override UniTask OnExecuteAction()
		{
			MovableFloorController.<OnExecuteAction>d__6 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<MovableFloorController.<OnExecuteAction>d__6>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD25 RID: 195877 RVA: 0x00B14B10 File Offset: 0x00B12D10
		[NullableContext(2)]
		public IMovableFloorMoveRequest CreateMoveRequest()
		{
			if (!this.MovableFloor.NeedMove)
			{
				return null;
			}
			WuWaGoGridController gridControllerById = this.GameMode.GetGridControllerById(this.Entity.StandGridId);
			if (gridControllerById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "移动板关联GridController不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.Entity.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.MovableFloor.CancelPendingMove();
				return null;
			}
			Vector targetCoordinate = this.MovableFloor.GetTargetCoordinate();
			if (targetCoordinate == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.WuWaGo;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "移动板目标坐标不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", this.Entity.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.MovableFloor.CancelPendingMove();
				return null;
			}
			return new MovableFloorMoveRequest
			{
				Controller = this,
				RelocationRequest = gridControllerById.CreateRelocationRequest(targetCoordinate)
			};
		}

		// Token: 0x0602FD26 RID: 195878 RVA: 0x00B14BFA File Offset: 0x00B12DFA
		public void FinishMoveRequest()
		{
			this.MovableFloor.FinishMove();
		}

		// Token: 0x0602FD27 RID: 195879 RVA: 0x00B14C07 File Offset: 0x00B12E07
		public void CancelPendingMove()
		{
			this.MovableFloor.CancelPendingMove();
		}

		// Token: 0x0602FD28 RID: 195880 RVA: 0x00B14C14 File Offset: 0x00B12E14
		public void PlayMoveAudio()
		{
			base.PostAudioEventOnEntity(EWuWaGoAudioEventIndex.MovableFloorMove);
			this.PlayMoveSmokeEffect();
		}

		// Token: 0x0602FD29 RID: 195881 RVA: 0x00B14C24 File Offset: 0x00B12E24
		public void StopMoveSmokeEffect(bool immediately)
		{
			foreach (int handle in this.MoveSmokeEffectHandles.ToList<int>())
			{
				this.StopMoveSmokeEffectByHandle(handle, "WuWaGo.MovableFloor.MoveSmoke.Stop", immediately);
			}
			this.MoveSmokeEffectHandles.Clear();
		}

		// Token: 0x0602FD2A RID: 195882 RVA: 0x00B14C90 File Offset: 0x00B12E90
		private void PlayMoveSmokeEffect()
		{
			MovableFloorController.<>c__DisplayClass12_0 CS$<>8__locals1 = new MovableFloorController.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			string text = (setting != null) ? setting.MoveFloorFx.ToAssetPathName() : null;
			if (text == null || StringUtils.IsBlank(text))
			{
				return;
			}
			AActor aactor = this.Entity.GetActorAsObject() as AActor;
			if (aactor == null || !aactor.IsValid())
			{
				return;
			}
			MovableFloorController.<>c__DisplayClass12_0 CS$<>8__locals2 = CS$<>8__locals1;
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(aactor.D_GetTransform());
			CS$<>8__locals2.handle = instance.SpawnEffect(world, ftransformDouble, text, "WuWaGo.MovableFloor.MoveSmoke", new EffectContext(null, aactor, false), EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(CS$<>8__locals1.handle))
			{
				return;
			}
			this.MoveSmokeEffectHandles.Add(CS$<>8__locals1.handle);
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(CS$<>8__locals1.handle);
			AActor parent = aactor;
			FName? fname = null;
			effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, false);
			EffectSystem.Instance.AddFinishCallback(CS$<>8__locals1.handle, delegate(int _)
			{
				CS$<>8__locals1.<>4__this.CleanupMoveSmokeEffectHandle(CS$<>8__locals1.handle);
			});
		}

		// Token: 0x0602FD2B RID: 195883 RVA: 0x00B14D90 File Offset: 0x00B12F90
		private void StopMoveSmokeEffectByHandle(int handle, string reason, bool immediately)
		{
			this.MoveSmokeEffectHandles.Remove(handle);
			if (EffectSystem.Instance.IsValid(handle))
			{
				EffectSystem.Instance.StopEffectById(handle, reason, immediately, null);
			}
		}

		// Token: 0x0602FD2C RID: 195884 RVA: 0x00B14DCE File Offset: 0x00B12FCE
		private void CleanupMoveSmokeEffectHandle(int handle)
		{
			this.MoveSmokeEffectHandles.Remove(handle);
		}

		// Token: 0x0602FD2D RID: 195885 RVA: 0x00B14DE0 File Offset: 0x00B12FE0
		private void RestoreInitialPosition()
		{
			Vector initialCoordinate = this.MovableFloor.GetInitialCoordinate();
			if (initialCoordinate == null)
			{
				return;
			}
			WuWaGoGameData gameData = this.GameData;
			WuWaGoGridController gridControllerById = this.GameMode.GetGridControllerById(this.Entity.StandGridId);
			if (gridControllerById == null)
			{
				this.MovableFloor.ResetToInitialState();
				return;
			}
			WuWaGoGrid grid = gridControllerById.Grid;
			if (!grid.Coordinate.Equals(initialCoordinate, 9.999999747378752E-05))
			{
				IWuWaGoGridRelocationRequest wuWaGoGridRelocationRequest = gridControllerById.CreateRelocationRequest(initialCoordinate);
				Transform originTransform = gameData.OriginTransform;
				if (originTransform != null)
				{
					this.MovableFloor.SetActorWorldLocation(WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, initialCoordinate, null), false);
				}
				gameData.RelocateGridKey(grid, initialCoordinate);
				foreach (IWuWaGoGridMoveParticipant wuWaGoGridMoveParticipant in wuWaGoGridRelocationRequest.Participants)
				{
					Action<IWuWaGoGridRelocationContext> commitGridMove = wuWaGoGridMoveParticipant.CommitGridMove;
					if (commitGridMove != null)
					{
						commitGridMove(wuWaGoGridRelocationRequest);
					}
				}
				gameData.RebuildAllGridLinks();
			}
			this.MovableFloor.ResetToInitialState();
		}

		// Token: 0x04019CC5 RID: 105669
		private readonly HashSet<int> MoveSmokeEffectHandles = new HashSet<int>();
	}
}
