using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EAE RID: 7854
[NullableContext(2)]
[Nullable(0)]
public abstract class RouletteInputBase
{
	// Token: 0x0601362D RID: 79405 RVA: 0x005A81E8 File Offset: 0x005A63E8
	public RouletteInputBase(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null)
	{
		this.BeginPos = pos;
		this.RouletteViewType = rouletteViewType.GetValueOrDefault(ERouletteViewType.Main);
	}

	// Token: 0x0601362E RID: 79406 RVA: 0x005A824B File Offset: 0x005A644B
	public void ActivateInput(bool isOn)
	{
		this.ActivateOn = isOn;
	}

	// Token: 0x0601362F RID: 79407 RVA: 0x005A8254 File Offset: 0x005A6454
	public void Destroy()
	{
		this.ActivateInput(false);
		this.UnBindEvent();
		this.OnDestroy();
	}

	// Token: 0x06013630 RID: 79408 RVA: 0x005A8269 File Offset: 0x005A6469
	protected void Reset()
	{
		this.AreaIndex = 0;
		this.Angle = -1;
	}

	// Token: 0x06013631 RID: 79409 RVA: 0x005A8279 File Offset: 0x005A6479
	protected void EndInput()
	{
		this.ActivateOn = false;
		Action onEndInputEvent = this.OnEndInputEvent;
		if (onEndInputEvent == null)
		{
			return;
		}
		onEndInputEvent();
	}

	// Token: 0x06013632 RID: 79410 RVA: 0x005A8292 File Offset: 0x005A6492
	[NullableContext(1)]
	public void SetEndInputEvent(Action eventHandler)
	{
		this.OnEndInputEvent = eventHandler;
	}

	// Token: 0x06013633 RID: 79411 RVA: 0x005A829B File Offset: 0x005A649B
	public void SetIsNeedEmpty(bool canEmpty)
	{
		this.NeedEmptyChoose = canEmpty;
	}

	// Token: 0x06013634 RID: 79412 RVA: 0x005A82A4 File Offset: 0x005A64A4
	public virtual void OnInit()
	{
	}

	// Token: 0x06013635 RID: 79413 RVA: 0x005A82A6 File Offset: 0x005A64A6
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06013636 RID: 79414 RVA: 0x005A82A8 File Offset: 0x005A64A8
	public virtual void BindEvent()
	{
	}

	// Token: 0x06013637 RID: 79415 RVA: 0x005A82AA File Offset: 0x005A64AA
	protected virtual void UnBindEvent()
	{
	}

	// Token: 0x06013638 RID: 79416 RVA: 0x005A82AC File Offset: 0x005A64AC
	protected virtual void InputTick(float delta)
	{
	}

	// Token: 0x06013639 RID: 79417 RVA: 0x005A82B0 File Offset: 0x005A64B0
	[NullableContext(0)]
	public ValueTuple<int?, int?> Tick(float delta)
	{
		if (!this.ActivateOn)
		{
			return new ValueTuple<int?, int?>(null, null);
		}
		int areaIndex = this.AreaIndex;
		int angle = this.Angle;
		this.InputTick(delta);
		int? item = (areaIndex != this.AreaIndex) ? new int?(this.AreaIndex) : null;
		int? item2 = (angle != this.Angle) ? new int?(this.Angle) : null;
		return new ValueTuple<int?, int?>(item, item2);
	}

	// Token: 0x0400A606 RID: 42502
	protected bool ActivateOn;

	// Token: 0x0400A607 RID: 42503
	protected int AreaIndex;

	// Token: 0x0400A608 RID: 42504
	protected int Angle = -1;

	// Token: 0x0400A609 RID: 42505
	protected bool NeedEmptyChoose = true;

	// Token: 0x0400A60A RID: 42506
	public ERouletteViewType RouletteViewType = ERouletteViewType.Main;

	// Token: 0x0400A60B RID: 42507
	public Vector2D BeginPos;

	// Token: 0x0400A60C RID: 42508
	[Nullable(1)]
	protected readonly Vector ForwardVector = Vector.Create(0.0, -1.0, 0.0);

	// Token: 0x0400A60D RID: 42509
	private Action OnEndInputEvent;
}
