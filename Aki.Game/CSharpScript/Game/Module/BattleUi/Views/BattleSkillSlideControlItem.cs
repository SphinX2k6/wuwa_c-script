using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD3 RID: 19667
	public class BattleSkillSlideControlItem : UiPanelBase
	{
		// Token: 0x0603135C RID: 201564 RVA: 0x00DBCBA8 File Offset: 0x00DBADA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603135D RID: 201565 RVA: 0x00DBCC32 File Offset: 0x00DBAE32
		protected override void OnStart()
		{
			this.tweenAnimPlayer.InitTweenAnim(1, base.GetItem(1), false);
			this.tweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
			this.SetComponentActive(this.TargetActive);
		}

		// Token: 0x0603135E RID: 201566 RVA: 0x00DBCC68 File Offset: 0x00DBAE68
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			BattleUiSlideControlData slideControlData = BattleUiModel.Instance.SlideControlData;
			this.RootItem.SetAnchorOffset(slideControlData.Position.ToUeVector2D(false));
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.SlideControl, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.Formation,
				EBattleUiChild.SkillButton
			}), false, true, 0);
			this.tweenAnimPlayer.StopTweenAnim(2);
			this.tweenAnimPlayer.PlayTweenAnim(1);
		}

		// Token: 0x0603135F RID: 201567 RVA: 0x00DBCCE0 File Offset: 0x00DBAEE0
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.InputAction(null);
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.SlideControl, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.Formation,
				EBattleUiChild.SkillButton
			}), true, true, 0);
			this.tweenAnimPlayer.StopTweenAnim(1);
			this.tweenAnimPlayer.PlayTweenAnim(2);
		}

		// Token: 0x06031360 RID: 201568 RVA: 0x00DBCD3A File Offset: 0x00DBAF3A
		public void SetComponentActive(bool visibility)
		{
			if (this.TargetActive == visibility && !this.IsFirstShow)
			{
				return;
			}
			this.TargetActive = visibility;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.IsFirstShow = false;
			this.SetActive(visibility);
		}

		// Token: 0x06031361 RID: 201569 RVA: 0x00DBCD6C File Offset: 0x00DBAF6C
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (!this.CheckInTouch())
			{
				BattleUiModel.Instance.SlideControlData.ForceStop();
				return;
			}
			Vector2D touchMoveDir = BattleUiModel.Instance.SlideControlData.TouchMoveDir;
			if (touchMoveDir.Y <= -10.0)
			{
				this.InputAction("跳跃");
				return;
			}
			if (touchMoveDir.Y > 10.0)
			{
				this.InputAction("下降");
				return;
			}
			this.InputAction(null);
		}

		// Token: 0x06031362 RID: 201570 RVA: 0x00DBCDEC File Offset: 0x00DBAFEC
		[NullableContext(2)]
		private void InputAction(string inputAction)
		{
			if (this.LastInputAction == inputAction)
			{
				return;
			}
			if (this.LastInputAction != null)
			{
				InputDistributeController.Instance.InputAction(this.LastInputAction, false);
				this.LastInputAction = null;
				return;
			}
			if (inputAction != null)
			{
				InputDistributeController.Instance.InputAction(inputAction, true);
			}
			this.LastInputAction = inputAction;
		}

		// Token: 0x06031363 RID: 201571 RVA: 0x00DBCE44 File Offset: 0x00DBB044
		private bool CheckInTouch()
		{
			if (Time.Instance.Now < this.NextCheckInTouchTime)
			{
				return true;
			}
			this.NextCheckInTouchTime = Time.Instance.Now + 500.0;
			int touchId = BattleUiModel.Instance.SlideControlData.TouchId;
			TsCharacterController characterController = Global.CharacterController;
			return characterController != null && characterController.IsInTouch((float)touchId);
		}

		// Token: 0x0401A115 RID: 106773
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401A116 RID: 106774
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer tweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A117 RID: 106775
		public bool TargetActive;

		// Token: 0x0401A118 RID: 106776
		private bool IsFirstShow = true;

		// Token: 0x0401A119 RID: 106777
		[Nullable(2)]
		private string LastInputAction;

		// Token: 0x0401A11A RID: 106778
		private double NextCheckInTouchTime;

		// Token: 0x0200A956 RID: 43350
		private enum EChildItem
		{
			// Token: 0x040344F6 RID: 214262
			DragItem,
			// Token: 0x040344F7 RID: 214263
			AniArrowIn,
			// Token: 0x040344F8 RID: 214264
			AniArrowOut
		}
	}
}
