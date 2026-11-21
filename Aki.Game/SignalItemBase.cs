using System;
using UnrealEngine;

// Token: 0x02001F8D RID: 8077
public class SignalItemBase : UiComponentAction
{
	// Token: 0x06013FB6 RID: 81846 RVA: 0x005D396D File Offset: 0x005D1B6D
	public SignalItemBase(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize)
	{
		this.Type = type;
		this.RootHalfWidth = rootHalfWidth;
		this.StartDecisionSize = startDecisionSize;
		this.EndDecisionSize = endDecisionSize;
	}

	// Token: 0x06013FB7 RID: 81847 RVA: 0x005D39A1 File Offset: 0x005D1BA1
	public void Reset()
	{
		this.CurrentRelativeX = 0f;
		this.OnReset();
	}

	// Token: 0x06013FB8 RID: 81848 RVA: 0x005D39B4 File Offset: 0x005D1BB4
	public virtual void InitByGameplayType(ESignalGameplayType type)
	{
		this.GameplayType = type;
	}

	// Token: 0x06013FB9 RID: 81849 RVA: 0x005D39BD File Offset: 0x005D1BBD
	public void Update(float relativeX)
	{
		this.CurrentRelativeX = relativeX;
		this.OnUpdate();
	}

	// Token: 0x06013FBA RID: 81850 RVA: 0x005D39CD File Offset: 0x005D1BCD
	public virtual float GetProgress()
	{
		return 0f;
	}

	// Token: 0x06013FBB RID: 81851 RVA: 0x005D39D4 File Offset: 0x005D1BD4
	public virtual void OnCatchBtnDown()
	{
		this.IsCatchBtnDown = true;
		this.RelativeXWhenCatchDown = this.CurrentRelativeX;
	}

	// Token: 0x06013FBC RID: 81852 RVA: 0x005D39E9 File Offset: 0x005D1BE9
	public virtual void OnCatchBtnUp()
	{
		this.IsCatchBtnDown = false;
		this.RelativeXWhenCatchUp = this.CurrentRelativeX;
	}

	// Token: 0x06013FBD RID: 81853 RVA: 0x005D39FE File Offset: 0x005D1BFE
	protected virtual void OnReset()
	{
	}

	// Token: 0x06013FBE RID: 81854 RVA: 0x005D3A00 File Offset: 0x005D1C00
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

	// Token: 0x06013FBF RID: 81855 RVA: 0x005D3A5C File Offset: 0x005D1C5C
	public virtual bool TestCanBtnDown()
	{
		return false;
	}

	// Token: 0x06013FC0 RID: 81856 RVA: 0x005D3A5F File Offset: 0x005D1C5F
	public virtual bool TestCanBtnUp()
	{
		return false;
	}

	// Token: 0x0400AA4C RID: 43596
	public ESignalType Type;

	// Token: 0x0400AA4D RID: 43597
	protected ESignalGameplayType GameplayType = ESignalGameplayType.Send;

	// Token: 0x0400AA4E RID: 43598
	public float Width;

	// Token: 0x0400AA4F RID: 43599
	protected int DecisionShowSize = 36;

	// Token: 0x0400AA50 RID: 43600
	protected float CurrentRelativeX;

	// Token: 0x0400AA51 RID: 43601
	protected int StartDecisionSize;

	// Token: 0x0400AA52 RID: 43602
	protected int EndDecisionSize;

	// Token: 0x0400AA53 RID: 43603
	protected bool IsCatchBtnDown;

	// Token: 0x0400AA54 RID: 43604
	protected float RelativeXWhenCatchDown;

	// Token: 0x0400AA55 RID: 43605
	protected float RelativeXWhenCatchUp;

	// Token: 0x0400AA56 RID: 43606
	protected float RootHalfWidth;
}
