using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BC2 RID: 23490
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceJoystickInput
	{
		// Token: 0x06039BD6 RID: 236502 RVA: 0x01038184 File Offset: 0x01036384
		public void RegisterMovePress(Action<ESeekTraceMoveDirection> onMovePress)
		{
			this.OnMovePress = onMovePress;
		}

		// Token: 0x06039BD7 RID: 236503 RVA: 0x0103818D File Offset: 0x0103638D
		public void MoveAxisInput(ESeekTraceMoveDirection direction, double value)
		{
			if (direction == ESeekTraceMoveDirection.Up || direction == ESeekTraceMoveDirection.Down)
			{
				this.InputY = value;
				return;
			}
			this.InputX = value;
		}

		// Token: 0x06039BD8 RID: 236504 RVA: 0x010381A6 File Offset: 0x010363A6
		public void Tick(double delta)
		{
			this.TickAxis(delta);
			if (this.IsTickRepeatAction)
			{
				this.RepeatPressHandle(this.ActionDirection, delta);
			}
		}

		// Token: 0x06039BD9 RID: 236505 RVA: 0x010381C4 File Offset: 0x010363C4
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

		// Token: 0x06039BDA RID: 236506 RVA: 0x01038258 File Offset: 0x01036458
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

		// Token: 0x06039BDB RID: 236507 RVA: 0x01038355 File Offset: 0x01036555
		private bool IsSmallerThenPressThreshold(double value)
		{
			return Math.Abs(value) < 0.7;
		}

		// Token: 0x06039BDC RID: 236508 RVA: 0x01038368 File Offset: 0x01036568
		private bool IsSmallerThenReleaseThreshold(double value)
		{
			return Math.Abs(value) < 0.2;
		}

		// Token: 0x06039BDD RID: 236509 RVA: 0x0103837C File Offset: 0x0103657C
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

		// Token: 0x06039BDE RID: 236510 RVA: 0x01038444 File Offset: 0x01036644
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

		// Token: 0x06039BDF RID: 236511 RVA: 0x010384CF File Offset: 0x010366CF
		public void ResetMoveActionInput()
		{
			if (this.ActionDirection != ESeekTraceMoveDirection.None)
			{
				this.ActionDirection = ESeekTraceMoveDirection.None;
				this.IsTickRepeatAction = false;
				this.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x0401E7FB RID: 124923
		private const double PRESS_THRESHOLD = 0.7;

		// Token: 0x0401E7FC RID: 124924
		private const double RELEASE_THRESHOLD = 0.2;

		// Token: 0x0401E7FD RID: 124925
		private const int FIRST_PRESS_INTERVAL = 500;

		// Token: 0x0401E7FE RID: 124926
		private const int REPEAT_PRESS_INTERVAL = 100;

		// Token: 0x0401E7FF RID: 124927
		private const int RELEASE_INTERVAL = 100;

		// Token: 0x0401E800 RID: 124928
		private double InputX;

		// Token: 0x0401E801 RID: 124929
		private double InputY;

		// Token: 0x0401E802 RID: 124930
		private ESeekTraceMoveDirection AxisDirection;

		// Token: 0x0401E803 RID: 124931
		private int PressInterval;

		// Token: 0x0401E804 RID: 124932
		private double RepeatPressTime;

		// Token: 0x0401E805 RID: 124933
		private InputDistributeDefine.EActionType? TargetActionType;

		// Token: 0x0401E806 RID: 124934
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401E807 RID: 124935
		private bool IsPress;

		// Token: 0x0401E808 RID: 124936
		private ESeekTraceMoveDirection ActionDirection;

		// Token: 0x0401E809 RID: 124937
		private bool IsTickRepeatAction;

		// Token: 0x0401E80A RID: 124938
		[Nullable(2)]
		private Action<ESeekTraceMoveDirection> OnMovePress;
	}
}
