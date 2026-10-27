using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002485 RID: 9349
[NullableContext(1)]
[Nullable(0)]
public class LongPressContext
{
	// Token: 0x1700189A RID: 6298
	// (get) Token: 0x06012C23 RID: 76835 RVA: 0x004A0368 File Offset: 0x0049E568
	// (set) Token: 0x06012C24 RID: 76836 RVA: 0x004A0370 File Offset: 0x0049E570
	public ILongPressParam Param { get; set; }

	// Token: 0x06012C25 RID: 76837 RVA: 0x004A0379 File Offset: 0x0049E579
	public LongPressContext(ILongPressParam param)
	{
		this.Param = param;
	}

	// Token: 0x06012C26 RID: 76838 RVA: 0x004A0388 File Offset: 0x0049E588
	public void Reset()
	{
		this.PressedTime = 0f;
		this.TriggeredLongPress = false;
		this.TriggeredStartLongPress = false;
	}

	// Token: 0x06012C27 RID: 76839 RVA: 0x004A03A4 File Offset: 0x0049E5A4
	public void Start()
	{
		FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
		this.OnPressPositionX = worldPointInPlane.X;
		this.OnPressPositionY = worldPointInPlane.Z;
	}

	// Token: 0x06012C28 RID: 76840 RVA: 0x004A03DC File Offset: 0x0049E5DC
	public bool CheckIsMoved()
	{
		FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
		float value = this.OnPressPositionX - worldPointInPlane.X;
		float value2 = this.OnPressPositionY - worldPointInPlane.Z;
		return Math.Abs(value) + Math.Abs(value2) > this.Param.InvalidMoveDistance;
	}

	// Token: 0x06012C29 RID: 76841 RVA: 0x004A0434 File Offset: 0x0049E634
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

	// Token: 0x06012C2A RID: 76842 RVA: 0x004A049C File Offset: 0x0049E69C
	public bool IsBeforeLongPressThreshold()
	{
		return this.PressedTime < this.Param.BeforeLongPressThreshold;
	}

	// Token: 0x06012C2B RID: 76843 RVA: 0x004A04B1 File Offset: 0x0049E6B1
	public bool IsLongPressing()
	{
		return this.PressedTime >= this.Param.BeforeLongPressThreshold;
	}

	// Token: 0x1700189B RID: 6299
	// (get) Token: 0x06012C2C RID: 76844 RVA: 0x004A04CC File Offset: 0x0049E6CC
	public float LongPressProgress
	{
		get
		{
			float num = this.PressedTime - this.Param.BeforeLongPressThreshold;
			float num2 = Math.Max(this.Param.LongPressThreshold, 0.01f);
			return Math.Max(Math.Min(num / num2, 1f), 0f);
		}
	}

	// Token: 0x04008D45 RID: 36165
	private float PressedTime;

	// Token: 0x04008D46 RID: 36166
	private bool TriggeredStartLongPress;

	// Token: 0x04008D47 RID: 36167
	private bool TriggeredLongPress;

	// Token: 0x04008D48 RID: 36168
	private float OnPressPositionX;

	// Token: 0x04008D49 RID: 36169
	private float OnPressPositionY;
}
