using System;
using System.Runtime.CompilerServices;

// Token: 0x02002933 RID: 10547
[NullableContext(2)]
[Nullable(0)]
public abstract class RouletteInputBase
{
	// Token: 0x06015C28 RID: 89128 RVA: 0x0057D1A8 File Offset: 0x0057B3A8
	public RouletteInputBase(Vector2D pos = null, ERouletteViewType? rouletteViewType = null, int? touchId = null, float? limit = null)
	{
		this.BeginPos = pos;
		this.RouletteViewType = rouletteViewType.GetValueOrDefault(ERouletteViewType.Main);
	}

	// Token: 0x06015C29 RID: 89129 RVA: 0x0057D20B File Offset: 0x0057B40B
	public void ActivateInput(bool isOn)
	{
		this.ActivateOn = isOn;
	}

	// Token: 0x06015C2A RID: 89130 RVA: 0x0057D214 File Offset: 0x0057B414
	public void Destroy()
	{
		this.ActivateInput(false);
		this.UnBindEvent();
		this.OnDestroy();
	}

	// Token: 0x06015C2B RID: 89131 RVA: 0x0057D229 File Offset: 0x0057B429
	protected void Reset()
	{
		this.AreaIndex = 0;
		this.Angle = -1;
	}

	// Token: 0x06015C2C RID: 89132 RVA: 0x0057D239 File Offset: 0x0057B439
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

	// Token: 0x06015C2D RID: 89133 RVA: 0x0057D252 File Offset: 0x0057B452
	[NullableContext(1)]
	public void SetEndInputEvent(Action eventHandler)
	{
		this.OnEndInputEvent = eventHandler;
	}

	// Token: 0x06015C2E RID: 89134 RVA: 0x0057D25B File Offset: 0x0057B45B
	public void SetIsNeedEmpty(bool canEmpty)
	{
		this.NeedEmptyChoose = canEmpty;
	}

	// Token: 0x06015C2F RID: 89135 RVA: 0x0057D264 File Offset: 0x0057B464
	public virtual void OnInit()
	{
	}

	// Token: 0x06015C30 RID: 89136 RVA: 0x0057D266 File Offset: 0x0057B466
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06015C31 RID: 89137 RVA: 0x0057D268 File Offset: 0x0057B468
	public virtual void BindEvent()
	{
	}

	// Token: 0x06015C32 RID: 89138 RVA: 0x0057D26A File Offset: 0x0057B46A
	protected virtual void UnBindEvent()
	{
	}

	// Token: 0x06015C33 RID: 89139 RVA: 0x0057D26C File Offset: 0x0057B46C
	protected virtual void InputTick(float delta)
	{
	}

	// Token: 0x06015C34 RID: 89140 RVA: 0x0057D270 File Offset: 0x0057B470
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

	// Token: 0x0400A21B RID: 41499
	protected bool ActivateOn;

	// Token: 0x0400A21C RID: 41500
	protected int AreaIndex;

	// Token: 0x0400A21D RID: 41501
	protected int Angle = -1;

	// Token: 0x0400A21E RID: 41502
	protected bool NeedEmptyChoose = true;

	// Token: 0x0400A21F RID: 41503
	public ERouletteViewType RouletteViewType = ERouletteViewType.Main;

	// Token: 0x0400A220 RID: 41504
	public Vector2D BeginPos;

	// Token: 0x0400A221 RID: 41505
	[Nullable(1)]
	protected readonly Vector ForwardVector = Vector.Create(0.0, -1.0, 0.0);

	// Token: 0x0400A222 RID: 41506
	private Action OnEndInputEvent;
}
