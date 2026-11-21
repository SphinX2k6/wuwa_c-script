using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001EB1 RID: 7857
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputGamepad : RouletteInputBase
{
	// Token: 0x06013641 RID: 79425 RVA: 0x005A87E4 File Offset: 0x005A69E4
	[NullableContext(2)]
	public RouletteInputGamepad(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, touchId, limit)
	{
		this.GamepadDeadLimit = (limit ?? this.GamepadDeadLimit);
	}

	// Token: 0x06013642 RID: 79426 RVA: 0x005A8833 File Offset: 0x005A6A33
	public override void OnInit()
	{
		this.GamepadVectorPos.Set(0.0, 0.0, 0.0);
	}

	// Token: 0x06013643 RID: 79427 RVA: 0x005A885C File Offset: 0x005A6A5C
	public override void BindEvent()
	{
		if (this.RouletteViewType == ERouletteViewType.Assembly)
		{
			this.BindAxisList = new List<string>
			{
				"UiMoveForward",
				"UiMoveRight"
			};
		}
		else
		{
			this.BindAxisList = new List<string>
			{
				"UiScroll1",
				"UiScroll2"
			};
		}
		InputDistributeController.Instance.BindAxes(this.BindAxisList, new TInputHandle<float>(this.OnInputNavigationAxis));
	}

	// Token: 0x06013644 RID: 79428 RVA: 0x005A88D1 File Offset: 0x005A6AD1
	protected override void UnBindEvent()
	{
		if (this.BindAxisList != null)
		{
			InputDistributeController.Instance.UnBindAxes(this.BindAxisList, new TInputHandle<float>(this.OnInputNavigationAxis));
		}
	}

	// Token: 0x06013645 RID: 79429 RVA: 0x005A88F8 File Offset: 0x005A6AF8
	private void OnInputNavigationAxis(string axisName, float value, InputIdentification inputIdentification)
	{
		if (axisName == "UiMoveForward")
		{
			this.GamepadVectorPos.Y = (double)(-(double)value);
			return;
		}
		if (axisName == "UiScroll1")
		{
			this.GamepadVectorPos.Y = (double)value;
			return;
		}
		if (axisName == "UiMoveRight")
		{
			this.GamepadVectorPos.X = (double)value;
			return;
		}
		if (axisName == "UiScroll2")
		{
			this.GamepadVectorPos.X = (double)value;
		}
	}

	// Token: 0x06013646 RID: 79430 RVA: 0x005A8974 File Offset: 0x005A6B74
	protected override void InputTick(float delta)
	{
		if (!this.NeedEmptyChoose && this.GamepadVectorPos.X == 0.0 && this.GamepadVectorPos.Y == 0.0)
		{
			return;
		}
		if (this.NeedEmptyChoose && Math.Abs(this.GamepadVectorPos.X) <= (double)this.GamepadDeadLimit && Math.Abs(this.GamepadVectorPos.Y) <= (double)this.GamepadDeadLimit)
		{
			this.AreaIndex = 0;
			return;
		}
		this.Angle = (int)AngleCalculator.GetVectorAngle(this.ForwardVector, this.GamepadVectorPos);
		this.AreaIndex = AngleCalculator.AngleToAreaIndex((double)this.Angle);
	}

	// Token: 0x0400A618 RID: 42520
	private readonly Vector GamepadVectorPos = Vector.Create();

	// Token: 0x0400A619 RID: 42521
	private float GamepadDeadLimit = 0.4f;

	// Token: 0x0400A61A RID: 42522
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> BindAxisList;
}
