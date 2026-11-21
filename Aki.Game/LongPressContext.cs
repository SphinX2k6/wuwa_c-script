using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200196A RID: 6506
[NullableContext(1)]
[Nullable(0)]
public class LongPressContext
{
	// Token: 0x170018D4 RID: 6356
	// (get) Token: 0x060100DA RID: 65754 RVA: 0x004ADAC0 File Offset: 0x004ABCC0
	// (set) Token: 0x060100DB RID: 65755 RVA: 0x004ADAC8 File Offset: 0x004ABCC8
	public ILongPressParam Param { get; set; }

	// Token: 0x060100DC RID: 65756 RVA: 0x004ADAD1 File Offset: 0x004ABCD1
	public LongPressContext(ILongPressParam param)
	{
		this.Param = param;
	}

	// Token: 0x060100DD RID: 65757 RVA: 0x004ADAE0 File Offset: 0x004ABCE0
	public void Reset()
	{
		this.PressedTime = 0f;
		this.TriggeredLongPress = false;
		this.TriggeredStartLongPress = false;
	}

	// Token: 0x060100DE RID: 65758 RVA: 0x004ADAFC File Offset: 0x004ABCFC
	public void Start()
	{
		FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
		this.OnPressPositionX = worldPointInPlane.X;
		this.OnPressPositionY = worldPointInPlane.Z;
	}

	// Token: 0x060100DF RID: 65759 RVA: 0x004ADB34 File Offset: 0x004ABD34
	public bool CheckIsMoved()
	{
		FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
		float value = this.OnPressPositionX - worldPointInPlane.X;
		float value2 = this.OnPressPositionY - worldPointInPlane.Z;
		return Math.Abs(value) + Math.Abs(value2) > this.Param.InvalidMoveDistance;
	}

	// Token: 0x060100E0 RID: 65760 RVA: 0x004ADB8C File Offset: 0x004ABD8C
	[NullableContext(0)]
	public ValueTuple<bool, bool> Update(float deltaTime)
	{
		this.PressedTime += deltaTime;
		bool item = false;
		bool item2 = false;
		if (!this.TriggeredStartLongPress && this.PressedTime >= this.Param.BeforeLongPressThreshold)
		{
			this.TriggeredStartLongPress = true;
			item = true;
		}
		if (!this.TriggeredLongPress && this.LongPressProgress >= 1f)
		{
			this.TriggeredLongPress = true;
			item2 = true;
		}
		return new ValueTuple<bool, bool>(item, item2);
	}

	// Token: 0x060100E1 RID: 65761 RVA: 0x004ADBF4 File Offset: 0x004ABDF4
	public bool IsBeforeLongPressThreshold()
	{
		return this.PressedTime < this.Param.BeforeLongPressThreshold;
	}

	// Token: 0x060100E2 RID: 65762 RVA: 0x004ADC09 File Offset: 0x004ABE09
	public bool IsLongPressing()
	{
		return this.PressedTime >= this.Param.BeforeLongPressThreshold;
	}

	// Token: 0x170018D5 RID: 6357
	// (get) Token: 0x060100E3 RID: 65763 RVA: 0x004ADC24 File Offset: 0x004ABE24
	public float LongPressProgress
	{
		get
		{
			float num = this.PressedTime - this.Param.BeforeLongPressThreshold;
			float num2 = Math.Max(this.Param.LongPressThreshold, 0.01f);
			return Math.Max(Math.Min(num / num2, 1f), 0f);
		}
	}

	// Token: 0x04008E8C RID: 36492
	private float PressedTime;

	// Token: 0x04008E8D RID: 36493
	private bool TriggeredStartLongPress;

	// Token: 0x04008E8E RID: 36494
	private bool TriggeredLongPress;

	// Token: 0x04008E8F RID: 36495
	private float OnPressPositionX;

	// Token: 0x04008E90 RID: 36496
	private float OnPressPositionY;
}
