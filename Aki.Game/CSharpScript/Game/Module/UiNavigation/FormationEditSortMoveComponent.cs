using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DD RID: 14557
	public class FormationEditSortMoveComponent : FormationEditSortBaseComponent, IStaticVariableResetter
	{
		// Token: 0x06025B64 RID: 154468 RVA: 0x00A9C1AF File Offset: 0x00A9A3AF
		static FormationEditSortMoveComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormationEditSortMoveComponent.CreateStaticDefaultValue), new Action(FormationEditSortMoveComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06025B65 RID: 154469 RVA: 0x00A9C1CE File Offset: 0x00A9A3CE
		public FormationEditSortMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B66 RID: 154470 RVA: 0x00A9C1D7 File Offset: 0x00A9A3D7
		protected override void OnPress(HotKeyMap config)
		{
			this.StartMove((config.AxisDirection == 1) ? -1 : 1);
		}

		// Token: 0x06025B67 RID: 154471 RVA: 0x00A9C1ED File Offset: 0x00A9A3ED
		protected override void OnRelease(HotKeyMap config)
		{
			this.StopMove();
		}

		// Token: 0x06025B68 RID: 154472 RVA: 0x00A9C1F8 File Offset: 0x00A9A3F8
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

		// Token: 0x06025B69 RID: 154473 RVA: 0x00A9C245 File Offset: 0x00A9A445
		[NullableContext(1)]
		protected override void OnFinishInputAxis(string axisName)
		{
			this.StopMove();
		}

		// Token: 0x06025B6A RID: 154474 RVA: 0x00A9C24D File Offset: 0x00A9A44D
		protected override void OnUnRegisterMe()
		{
			this.StopMove();
		}

		// Token: 0x06025B6B RID: 154475 RVA: 0x00A9C255 File Offset: 0x00A9A455
		protected override void OnClear()
		{
			this.StopMove();
		}

		// Token: 0x06025B6C RID: 154476 RVA: 0x00A9C25D File Offset: 0x00A9A45D
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}

		// Token: 0x06025B6D RID: 154477 RVA: 0x00A9C264 File Offset: 0x00A9A464
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

		// Token: 0x06025B6E RID: 154478 RVA: 0x00A9C2D8 File Offset: 0x00A9A4D8
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

		// Token: 0x06025B6F RID: 154479 RVA: 0x00A9C32F File Offset: 0x00A9A52F
		private void MoveSort(float _ = 0f)
		{
			if (!this.CanContinueMove())
			{
				this.StopMove();
				return;
			}
			FormationEditSortController.MoveSort(this.MoveDirection);
		}

		// Token: 0x06025B70 RID: 154480 RVA: 0x00A9C34B File Offset: 0x00A9A54B
		private bool CanContinueMove()
		{
			return FormationEditSortMoveComponent.ActiveComponent == this && this.MoveDirection != 0 && base.IsHotKeyActive() && FormationEditSortController.IsSortMode;
		}

		// Token: 0x06025B71 RID: 154481 RVA: 0x00A9C36C File Offset: 0x00A9A56C
		private void StopMove()
		{
			this.MoveDirection = 0;
			this.ClearRepeatTimer();
			if (FormationEditSortMoveComponent.ActiveComponent == this)
			{
				FormationEditSortMoveComponent.ActiveComponent = null;
			}
		}

		// Token: 0x06025B72 RID: 154482 RVA: 0x00A9C389 File Offset: 0x00A9A589
		private void ClearRepeatTimer()
		{
			if (this.RepeatTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RepeatTimer);
				this.RepeatTimer = null;
			}
		}

		// Token: 0x06025B73 RID: 154483 RVA: 0x00A9C3AB File Offset: 0x00A9A5AB
		public static void CreateStaticDefaultValue()
		{
			FormationEditSortMoveComponent.ActiveComponent = null;
		}

		// Token: 0x06025B74 RID: 154484 RVA: 0x00A9C3B3 File Offset: 0x00A9A5B3
		public static void ResetStaticDefaultValue()
		{
			FormationEditSortMoveComponent.ActiveComponent = null;
		}

		// Token: 0x04014CFC RID: 85244
		private const float AXIS_PRESS_THRESHOLD = 0.7f;

		// Token: 0x04014CFD RID: 85245
		private const float AXIS_RELEASE_THRESHOLD = 0.2f;

		// Token: 0x04014CFE RID: 85246
		private const float FIRST_REPEAT_DELAY = 500f;

		// Token: 0x04014CFF RID: 85247
		private const float REPEAT_INTERVAL = 200f;

		// Token: 0x04014D00 RID: 85248
		[Nullable(2)]
		private static FormationEditSortMoveComponent ActiveComponent;

		// Token: 0x04014D01 RID: 85249
		private int MoveDirection;

		// Token: 0x04014D02 RID: 85250
		[Nullable(2)]
		private TimerHandle RepeatTimer;
	}
}
