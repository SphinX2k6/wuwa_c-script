using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02006A65 RID: 27237
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceJoystickInput
	{
		// Token: 0x06043B88 RID: 277384 RVA: 0x01093950 File Offset: 0x01091B50
		public void RegisterMovePress(Action<ESeekTraceMoveDirection> onMovePress)
		{
			this.OnMovePress = onMovePress;
		}

		// Token: 0x06043B89 RID: 277385 RVA: 0x01093959 File Offset: 0x01091B59
		public void MoveAxisInput(ESeekTraceMoveDirection direction, double value)
		{
			if (direction == ESeekTraceMoveDirection.Up || direction == ESeekTraceMoveDirection.Down)
			{
				this.InputY = value;
				return;
			}
			this.InputX = value;
		}

		// Token: 0x06043B8A RID: 277386 RVA: 0x01093972 File Offset: 0x01091B72
		public void Tick(double delta)
		{
			this.TickAxis(delta);
			if (this.IsTickRepeatAction)
			{
				this.RepeatPressHandle(this.ActionDirection, delta);
			}
		}

		// Token: 0x06043B8B RID: 277387 RVA: 0x01093990 File Offset: 0x01091B90
		private void TickAxis(double delta)
		{
			if (this.IsTickRepeatAction)
			{
				return;
			}
			double inputY = this.InputY;
			double inputX = this.InputX;
			if (this.IsSmallerThenPressThreshold(inputX) && this.IsSmallerThenPressThreshold(inputY) && !this.IsPress)
			{
				return;
			}
			if (this.IsSmallerThenReleaseThreshold(inputX) && this.IsSmallerThenReleaseThreshold(inputY) && this.IsPress)
			{
				this.IsPress = false;
				this.AxisDirection = ESeekTraceMoveDirection.None;
				this.RepeatPressTime = 0.0;
				return;
			}
			this.HandleDirectionPress(inputX, inputY);
			this.RepeatPressHandle(this.AxisDirection, delta);
			this.IsPress = true;
		}

		// Token: 0x06043B8C RID: 277388 RVA: 0x01093A24 File Offset: 0x01091C24
		private void HandleDirectionPress(double inputX, double inputY)
		{
			bool flag = this.IsSmallerThenPressThreshold(inputX);
			bool flag2 = this.IsSmallerThenPressThreshold(inputY);
			if (flag && flag2)
			{
				return;
			}
			ESeekTraceMoveDirection eseekTraceMoveDirection = ESeekTraceMoveDirection.Left;
			this.TempVector.Set(flag ? 0.0 : inputX, flag2 ? 0.0 : inputY, 0.0);
			double angleByVector2D = Vector.GetAngleByVector2D(this.TempVector);
			if (angleByVector2D >= -143.0 && angleByVector2D < -37.0)
			{
				eseekTraceMoveDirection = ESeekTraceMoveDirection.Down;
			}
			else if (angleByVector2D >= -37.0 && angleByVector2D < 37.0)
			{
				eseekTraceMoveDirection = ESeekTraceMoveDirection.Right;
			}
			else if (angleByVector2D >= 37.0 && angleByVector2D < 143.0)
			{
				eseekTraceMoveDirection = ESeekTraceMoveDirection.Up;
			}
			if (eseekTraceMoveDirection == this.AxisDirection)
			{
				return;
			}
			this.AxisDirection = eseekTraceMoveDirection;
			this.RepeatPressTime = 0.0;
			this.PressInterval = 500;
			this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
			Action<ESeekTraceMoveDirection> onMovePress = this.OnMovePress;
			if (onMovePress == null)
			{
				return;
			}
			onMovePress(eseekTraceMoveDirection);
		}

		// Token: 0x06043B8D RID: 277389 RVA: 0x01093B21 File Offset: 0x01091D21
		private bool IsSmallerThenPressThreshold(double value)
		{
			return Math.Abs(value) < 0.7;
		}

		// Token: 0x06043B8E RID: 277390 RVA: 0x01093B34 File Offset: 0x01091D34
		private bool IsSmallerThenReleaseThreshold(double value)
		{
			return Math.Abs(value) < 0.2;
		}

		// Token: 0x06043B8F RID: 277391 RVA: 0x01093B48 File Offset: 0x01091D48
		private void RepeatPressHandle(ESeekTraceMoveDirection direction, double delta)
		{
			if (direction == ESeekTraceMoveDirection.None)
			{
				return;
			}
			this.RepeatPressTime += delta;
			InputDistributeDefine.EActionType? targetActionType = this.TargetActionType;
			InputDistributeDefine.EActionType eactionType = InputDistributeDefine.EActionType.Press;
			if (targetActionType.GetValueOrDefault() == eactionType & targetActionType != null)
			{
				if (this.RepeatPressTime > 100.0)
				{
					this.RepeatPressTime -= 100.0;
					this.PressInterval = 100;
					this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
					Action<ESeekTraceMoveDirection> onMovePress = this.OnMovePress;
					if (onMovePress == null)
					{
						return;
					}
					onMovePress(direction);
				}
				return;
			}
			if (this.TargetActionType.GetValueOrDefault() == InputDistributeDefine.EActionType.Release && this.RepeatPressTime > (double)this.PressInterval)
			{
				this.RepeatPressTime -= (double)this.PressInterval;
				this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x06043B90 RID: 277392 RVA: 0x01093C10 File Offset: 0x01091E10
		public void MoveActionInput(ESeekTraceMoveDirection direction, bool isPress)
		{
			if (this.IsPress)
			{
				return;
			}
			if (this.ActionDirection != ESeekTraceMoveDirection.None && this.ActionDirection != direction)
			{
				return;
			}
			if (!isPress)
			{
				this.ActionDirection = ESeekTraceMoveDirection.None;
				this.IsTickRepeatAction = false;
				this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
				return;
			}
			this.ActionDirection = direction;
			this.IsTickRepeatAction = true;
			this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
			this.RepeatPressTime = 0.0;
			this.PressInterval = 500;
			Action<ESeekTraceMoveDirection> onMovePress = this.OnMovePress;
			if (onMovePress == null)
			{
				return;
			}
			onMovePress(direction);
		}

		// Token: 0x06043B91 RID: 277393 RVA: 0x01093C9B File Offset: 0x01091E9B
		public void ResetMoveActionInput()
		{
			if (this.ActionDirection != ESeekTraceMoveDirection.None)
			{
				this.ActionDirection = ESeekTraceMoveDirection.None;
				this.IsTickRepeatAction = false;
				this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x04023609 RID: 144905
		private const double PRESS_THRESHOLD = 0.7;

		// Token: 0x0402360A RID: 144906
		private const double RELEASE_THRESHOLD = 0.2;

		// Token: 0x0402360B RID: 144907
		private const int FIRST_PRESS_INTERVAL = 500;

		// Token: 0x0402360C RID: 144908
		private const int REPEAT_PRESS_INTERVAL = 100;

		// Token: 0x0402360D RID: 144909
		private const int RELEASE_INTERVAL = 100;

		// Token: 0x0402360E RID: 144910
		private double InputX;

		// Token: 0x0402360F RID: 144911
		private double InputY;

		// Token: 0x04023610 RID: 144912
		private ESeekTraceMoveDirection AxisDirection;

		// Token: 0x04023611 RID: 144913
		private int PressInterval;

		// Token: 0x04023612 RID: 144914
		private double RepeatPressTime;

		// Token: 0x04023613 RID: 144915
		private InputDistributeDefine.EActionType? TargetActionType;

		// Token: 0x04023614 RID: 144916
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04023615 RID: 144917
		private bool IsPress;

		// Token: 0x04023616 RID: 144918
		private ESeekTraceMoveDirection ActionDirection;

		// Token: 0x04023617 RID: 144919
		private bool IsTickRepeatAction;

		// Token: 0x04023618 RID: 144920
		[Nullable(2)]
		private Action<ESeekTraceMoveDirection> OnMovePress;
	}
}
