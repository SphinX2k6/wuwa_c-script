using System;
using System.Collections.Generic;
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
	// Token: 0x020036A4 RID: 13988
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MovableFloorController : GameplayEntityControllerBase
	{
		// Token: 0x060244EA RID: 148714 RVA: 0x00A44AEF File Offset: 0x00A42CEF
		public MovableFloorController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x060244EB RID: 148715 RVA: 0x00A44B05 File Offset: 0x00A42D05
		private WuWaGoMovableFloorEntity MovableFloor
		{
			get
			{
				return this.Entity as WuWaGoMovableFloorEntity;
			}
		}

		// Token: 0x060244EC RID: 148716 RVA: 0x00A44B12 File Offset: 0x00A42D12
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

		// Token: 0x060244ED RID: 148717 RVA: 0x00A44B2C File Offset: 0x00A42D2C
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.StopMoveSmokeEffect(true);
			this.RestoreInitialPosition();
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x060244EE RID: 148718 RVA: 0x00A44B48 File Offset: 0x00A42D48
		protected override UniTask OnExecuteAction()
		{
			MovableFloorController.<OnExecuteAction>d__6 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<MovableFloorController.<OnExecuteAction>d__6>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x060244EF RID: 148719 RVA: 0x00A44B84 File Offset: 0x00A42D84
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

		// Token: 0x060244F0 RID: 148720 RVA: 0x00A44C6E File Offset: 0x00A42E6E
		public void FinishMoveRequest()
		{
			this.MovableFloor.FinishMove();
		}

		// Token: 0x060244F1 RID: 148721 RVA: 0x00A44C7B File Offset: 0x00A42E7B
		public void CancelPendingMove()
		{
			this.MovableFloor.CancelPendingMove();
		}

		// Token: 0x060244F2 RID: 148722 RVA: 0x00A44C88 File Offset: 0x00A42E88
		public void PlayMoveAudio()
		{
			base.PostAudioEventOnEntity(EWuWaGoAudioEventIndex.MovableFloorMove);
			this.PlayMoveSmokeEffect();
		}

		// Token: 0x060244F3 RID: 148723 RVA: 0x00A44C98 File Offset: 0x00A42E98
		public void StopMoveSmokeEffect(bool immediately)
		{
			int[] array = new int[this.MoveSmokeEffectHandles.Count];
			this.MoveSmokeEffectHandles.CopyTo(array, 0);
			foreach (int handle in array)
			{
				this.StopMoveSmokeEffectByHandle(handle, "WuWaGo.MovableFloor.MoveSmoke.Stop", immediately);
			}
			this.MoveSmokeEffectHandles.Clear();
		}

		// Token: 0x060244F4 RID: 148724 RVA: 0x00A44CF0 File Offset: 0x00A42EF0
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

		// Token: 0x060244F5 RID: 148725 RVA: 0x00A44DF0 File Offset: 0x00A42FF0
		private void StopMoveSmokeEffectByHandle(int handle, string reason, bool immediately)
		{
			this.MoveSmokeEffectHandles.Remove(handle);
			if (EffectSystem.Instance.IsValid(handle))
			{
				EffectSystem.Instance.StopEffectById(handle, reason, immediately, null);
			}
		}

		// Token: 0x060244F6 RID: 148726 RVA: 0x00A44E2E File Offset: 0x00A4302E
		private void CleanupMoveSmokeEffectHandle(int handle)
		{
			this.MoveSmokeEffectHandles.Remove(handle);
		}

		// Token: 0x060244F7 RID: 148727 RVA: 0x00A44E40 File Offset: 0x00A43040
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

		// Token: 0x04014375 RID: 82805
		private readonly HashSet<int> MoveSmokeEffectHandles = new HashSet<int>();
	}
}
