using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004965 RID: 18789
	public class FormationEditSortMoveComponent : FormationEditSortBaseComponent, IStaticVariableResetter
	{
		// Token: 0x06031034 RID: 200756 RVA: 0x00B612CF File Offset: 0x00B5F4CF
		static FormationEditSortMoveComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormationEditSortMoveComponent.CreateStaticDefaultValue), new Action(FormationEditSortMoveComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06031035 RID: 200757 RVA: 0x00B612EE File Offset: 0x00B5F4EE
		public FormationEditSortMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031036 RID: 200758 RVA: 0x00B612F7 File Offset: 0x00B5F4F7
		protected override void OnPress(HotKeyMap config)
		{
			this.StartMove((config.AxisDirection == 1) ? -1 : 1);
		}

		// Token: 0x06031037 RID: 200759 RVA: 0x00B6130D File Offset: 0x00B5F50D
		protected override void OnRelease(HotKeyMap config)
		{
			this.StopMove();
		}

		// Token: 0x06031038 RID: 200760 RVA: 0x00B61318 File Offset: 0x00B5F518
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (axisName != base.GetAxisName())
			{
				return;
			}
			float num = Math.Abs(value);
			if (num <= 0.2f)
			{
				this.StopMove();
				return;
			}
			if (num < 0.7f)
			{
				return;
			}
			this.StartMove((value > 0f) ? -1 : 1);
		}

		// Token: 0x06031039 RID: 200761 RVA: 0x00B61365 File Offset: 0x00B5F565
		[NullableContext(1)]
		protected override void OnFinishInputAxis(string axisName)
		{
			this.StopMove();
		}

		// Token: 0x0603103A RID: 200762 RVA: 0x00B6136D File Offset: 0x00B5F56D
		protected override void OnUnRegisterMe()
		{
			this.StopMove();
		}

		// Token: 0x0603103B RID: 200763 RVA: 0x00B61375 File Offset: 0x00B5F575
		protected override void OnClear()
		{
			this.StopMove();
		}

		// Token: 0x0603103C RID: 200764 RVA: 0x00B6137D File Offset: 0x00B5F57D
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}

		// Token: 0x0603103D RID: 200765 RVA: 0x00B61384 File Offset: 0x00B5F584
		private void StartMove(int direction)
		{
			FormationEditSortMoveComponent activeComponent = FormationEditSortMoveComponent.ActiveComponent;
			if (activeComponent != null && activeComponent != this)
			{
				return;
			}
			if (this.MoveDirection == direction)
			{
				return;
			}
			this.MoveDirection = direction;
			FormationEditSortMoveComponent.ActiveComponent = this;
			this.ClearRepeatTimer();
			this.MoveSort(0f);
			if (this.CanContinueMove())
			{
				this.RepeatTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.StartRepeat), 500f, null, null, true, 1f);
			}
		}

		// Token: 0x0603103E RID: 200766 RVA: 0x00B613F8 File Offset: 0x00B5F5F8
		private void StartRepeat(float _)
		{
			this.RepeatTimer = null;
			if (!this.CanContinueMove())
			{
				this.StopMove();
				return;
			}
			this.MoveSort(0f);
			this.RepeatTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.MoveSort), 200f, 1f, null, null, true);
		}

		// Token: 0x0603103F RID: 200767 RVA: 0x00B6144F File Offset: 0x00B5F64F
		private void MoveSort(float _ = 0f)
		{
			if (!this.CanContinueMove())
			{
				this.StopMove();
				return;
			}
			FormationEditSortController.MoveSort(this.MoveDirection);
		}

		// Token: 0x06031040 RID: 200768 RVA: 0x00B6146B File Offset: 0x00B5F66B
		private bool CanContinueMove()
		{
			return FormationEditSortMoveComponent.ActiveComponent == this && this.MoveDirection != 0 && base.IsHotKeyActive() && FormationEditSortController.IsSortMode;
		}

		// Token: 0x06031041 RID: 200769 RVA: 0x00B6148C File Offset: 0x00B5F68C
		private void StopMove()
		{
			this.MoveDirection = 0;
			this.ClearRepeatTimer();
			if (FormationEditSortMoveComponent.ActiveComponent == this)
			{
				FormationEditSortMoveComponent.ActiveComponent = null;
			}
		}

		// Token: 0x06031042 RID: 200770 RVA: 0x00B614A9 File Offset: 0x00B5F6A9
		private void ClearRepeatTimer()
		{
			if (this.RepeatTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RepeatTimer);
				this.RepeatTimer = null;
			}
		}

		// Token: 0x06031043 RID: 200771 RVA: 0x00B614CB File Offset: 0x00B5F6CB
		public static void CreateStaticDefaultValue()
		{
			FormationEditSortMoveComponent.ActiveComponent = null;
		}

		// Token: 0x06031044 RID: 200772 RVA: 0x00B614D3 File Offset: 0x00B5F6D3
		public static void ResetStaticDefaultValue()
		{
			FormationEditSortMoveComponent.ActiveComponent = null;
		}

		// Token: 0x0401A489 RID: 107657
		private const float AXIS_PRESS_THRESHOLD = 0.7f;

		// Token: 0x0401A48A RID: 107658
		private const float AXIS_RELEASE_THRESHOLD = 0.2f;

		// Token: 0x0401A48B RID: 107659
		private const float FIRST_REPEAT_DELAY = 500f;

		// Token: 0x0401A48C RID: 107660
		private const float REPEAT_INTERVAL = 200f;

		// Token: 0x0401A48D RID: 107661
		[Nullable(2)]
		private static FormationEditSortMoveComponent ActiveComponent;

		// Token: 0x0401A48E RID: 107662
		private int MoveDirection;

		// Token: 0x0401A48F RID: 107663
		[Nullable(2)]
		private TimerHandle RepeatTimer;
	}
}
