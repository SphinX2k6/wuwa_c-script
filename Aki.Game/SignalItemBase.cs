using System;
using UnrealEngine;

// Token: 0x02002A12 RID: 10770
public class SignalItemBase : UiComponentAction
{
	// Token: 0x060165AF RID: 91567 RVA: 0x005A8995 File Offset: 0x005A6B95
	public SignalItemBase(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize)
	{
		this.Type = type;
		this.RootHalfWidth = rootHalfWidth;
		this.StartDecisionSize = startDecisionSize;
		this.EndDecisionSize = endDecisionSize;
	}

	// Token: 0x060165B0 RID: 91568 RVA: 0x005A89C9 File Offset: 0x005A6BC9
	public void Reset()
	{
		this.CurrentRelativeX = 0f;
		this.OnReset();
	}

	// Token: 0x060165B1 RID: 91569 RVA: 0x005A89DC File Offset: 0x005A6BDC
	public virtual void InitByGameplayType(ESignalGameplayType type)
	{
		this.GameplayType = type;
	}

	// Token: 0x060165B2 RID: 91570 RVA: 0x005A89E5 File Offset: 0x005A6BE5
	public void Update(float relativeX)
	{
		this.CurrentRelativeX = relativeX;
		this.OnUpdate();
	}

	// Token: 0x060165B3 RID: 91571 RVA: 0x005A89F5 File Offset: 0x005A6BF5
	public virtual float GetProgress()
	{
		return 0f;
	}

	// Token: 0x060165B4 RID: 91572 RVA: 0x005A89FC File Offset: 0x005A6BFC
	public virtual void OnCatchBtnDown()
	{
		this.IsCatchBtnDown = true;
		this.RelativeXWhenCatchDown = this.CurrentRelativeX;
	}

	// Token: 0x060165B5 RID: 91573 RVA: 0x005A8A11 File Offset: 0x005A6C11
	public virtual void OnCatchBtnUp()
	{
		this.IsCatchBtnDown = false;
		this.RelativeXWhenCatchUp = this.CurrentRelativeX;
	}

	// Token: 0x060165B6 RID: 91574 RVA: 0x005A8A26 File Offset: 0x005A6C26
	protected virtual void OnReset()
	{
	}

	// Token: 0x060165B7 RID: 91575 RVA: 0x005A8A28 File Offset: 0x005A6C28
	protected virtual bool OnUpdate()
	{
		if (this.RootHalfWidth == 0f)
		{
			return false;
		}
		float num = this.CurrentRelativeX - this.Width;
		bool flag = this.CurrentRelativeX >= -this.RootHalfWidth && num <= this.RootHalfWidth;
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(flag);
		}
		return flag;
	}

	// Token: 0x060165B8 RID: 91576 RVA: 0x005A8A84 File Offset: 0x005A6C84
	public virtual bool TestCanBtnDown()
	{
		return false;
	}

	// Token: 0x060165B9 RID: 91577 RVA: 0x005A8A87 File Offset: 0x005A6C87
	public virtual bool TestCanBtnUp()
	{
		return false;
	}

	// Token: 0x0400A662 RID: 42594
	public ESignalType Type;

	// Token: 0x0400A663 RID: 42595
	protected ESignalGameplayType GameplayType = ESignalGameplayType.Send;

	// Token: 0x0400A664 RID: 42596
	public float Width;

	// Token: 0x0400A665 RID: 42597
	protected int DecisionShowSize = 36;

	// Token: 0x0400A666 RID: 42598
	protected float CurrentRelativeX;

	// Token: 0x0400A667 RID: 42599
	protected int StartDecisionSize;

	// Token: 0x0400A668 RID: 42600
	protected int EndDecisionSize;

	// Token: 0x0400A669 RID: 42601
	protected bool IsCatchBtnDown;

	// Token: 0x0400A66A RID: 42602
	protected float RelativeXWhenCatchDown;

	// Token: 0x0400A66B RID: 42603
	protected float RelativeXWhenCatchUp;

	// Token: 0x0400A66C RID: 42604
	protected float RootHalfWidth;
}
