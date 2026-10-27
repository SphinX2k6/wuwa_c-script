using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF1 RID: 23793
	public class BattleSkillSlideControlItem : UiPanelBase
	{
		// Token: 0x0603C406 RID: 246790 RVA: 0x00E6C5F4 File Offset: 0x00E6A7F4
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

		// Token: 0x0603C407 RID: 246791 RVA: 0x00E6C67E File Offset: 0x00E6A87E
		protected override void OnStart()
		{
			this.tweenAnimPlayer.InitTweenAnim(1, base.GetItem(1), false);
			this.tweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
			this.SetComponentActive(this.TargetActive);
		}

		// Token: 0x0603C408 RID: 246792 RVA: 0x00E6C6B4 File Offset: 0x00E6A8B4
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

		// Token: 0x0603C409 RID: 246793 RVA: 0x00E6C72C File Offset: 0x00E6A92C
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

		// Token: 0x0603C40A RID: 246794 RVA: 0x00E6C786 File Offset: 0x00E6A986
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

		// Token: 0x0603C40B RID: 246795 RVA: 0x00E6C7B8 File Offset: 0x00E6A9B8
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

		// Token: 0x0603C40C RID: 246796 RVA: 0x00E6C838 File Offset: 0x00E6AA38
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

		// Token: 0x0603C40D RID: 246797 RVA: 0x00E6C890 File Offset: 0x00E6AA90
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

		// Token: 0x0401F65C RID: 128604
		private const double CHECK_IN_TOUCH_INTERVAL = 500.0;

		// Token: 0x0401F65D RID: 128605
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer tweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401F65E RID: 128606
		public bool TargetActive;

		// Token: 0x0401F65F RID: 128607
		private bool IsFirstShow = true;

		// Token: 0x0401F660 RID: 128608
		[Nullable(2)]
		private string LastInputAction;

		// Token: 0x0401F661 RID: 128609
		private double NextCheckInTouchTime;

		// Token: 0x0200BF50 RID: 48976
		private enum EChildItem
		{
			// Token: 0x04039B34 RID: 236340
			DragItem,
			// Token: 0x04039B35 RID: 236341
			AniArrowIn,
			// Token: 0x04039B36 RID: 236342
			AniArrowOut
		}
	}
}
