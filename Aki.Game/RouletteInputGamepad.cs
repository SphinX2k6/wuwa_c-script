using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002936 RID: 10550
[NullableContext(1)]
[Nullable(0)]
public class RouletteInputGamepad : RouletteInputBase
{
	// Token: 0x06015C3C RID: 89148 RVA: 0x0057D7A4 File Offset: 0x0057B9A4
	[NullableContext(2)]
	public RouletteInputGamepad(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null) : base(pos, rouletteViewType, touchId, limit)
	{
		this.GamepadDeadLimit = (limit ?? this.GamepadDeadLimit);
	}

	// Token: 0x06015C3D RID: 89149 RVA: 0x0057D7F3 File Offset: 0x0057B9F3
	public override void OnInit()
	{
		this.GamepadVectorPos.Set(0.0, 0.0, 0.0);
	}

	// Token: 0x06015C3E RID: 89150 RVA: 0x0057D81C File Offset: 0x0057BA1C
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

	// Token: 0x06015C3F RID: 89151 RVA: 0x0057D891 File Offset: 0x0057BA91
	protected override void UnBindEvent()
	{
		if (this.BindAxisList != null)
		{
			InputDistributeController.Instance.UnBindAxes(this.BindAxisList, new TInputHandle<float>(this.OnInputNavigationAxis));
		}
	}

	// Token: 0x06015C40 RID: 89152 RVA: 0x0057D8B8 File Offset: 0x0057BAB8
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

	// Token: 0x06015C41 RID: 89153 RVA: 0x0057D934 File Offset: 0x0057BB34
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

	// Token: 0x0400A22D RID: 41517
	private readonly Vector GamepadVectorPos = Vector.Create();

	// Token: 0x0400A22E RID: 41518
	private float GamepadDeadLimit = 0.4f;

	// Token: 0x0400A22F RID: 41519
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> BindAxisList;
}
