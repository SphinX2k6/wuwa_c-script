using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

// Token: 0x02002AD4 RID: 10964
[NullableContext(1)]
[Nullable(0)]
public abstract class SurvivorsRogueCardScrollItemBase<[Nullable(2)] TData> : SurvivorsRogueCardBase, IGridProxy<TData>
{
	// Token: 0x17001E4F RID: 7759
	// (get) Token: 0x06016D0F RID: 93455 RVA: 0x005CB49B File Offset: 0x005C969B
	// (set) Token: 0x06016D10 RID: 93456 RVA: 0x005CB4A3 File Offset: 0x005C96A3
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<TData>, TData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001E50 RID: 7760
	// (get) Token: 0x06016D11 RID: 93457 RVA: 0x005CB4AC File Offset: 0x005C96AC
	// (set) Token: 0x06016D12 RID: 93458 RVA: 0x005CB4B4 File Offset: 0x005C96B4
	public int GridIndex { get; set; }

	// Token: 0x17001E51 RID: 7761
	// (get) Token: 0x06016D13 RID: 93459 RVA: 0x005CB4BD File Offset: 0x005C96BD
	// (set) Token: 0x06016D14 RID: 93460 RVA: 0x005CB4C5 File Offset: 0x005C96C5
	public int DisplayIndex { get; set; }

	// Token: 0x06016D15 RID: 93461 RVA: 0x005CB4CE File Offset: 0x005C96CE
	public void Clear()
	{
	}

	// Token: 0x06016D16 RID: 93462
	public abstract UniTask RefreshAsync(TData data, bool isSelected, int gridIndex);

	// Token: 0x06016D17 RID: 93463 RVA: 0x005CB4D0 File Offset: 0x005C96D0
	public virtual void OnSelected(bool fireEvent)
	{
		base.SetSelected(true, fireEvent, false);
	}

	// Token: 0x06016D18 RID: 93464 RVA: 0x005CB4DB File Offset: 0x005C96DB
	public virtual void OnDeselected(bool fireEvent)
	{
		base.SetSelected(false, fireEvent, false);
	}

	// Token: 0x06016D19 RID: 93465 RVA: 0x005CB4E6 File Offset: 0x005C96E6
	public virtual void OnForceSelected(bool bSelected, bool fireEvent)
	{
		base.SetSelected(bSelected, fireEvent, true);
	}

	// Token: 0x06016D1A RID: 93466 RVA: 0x005CB4F1 File Offset: 0x005C96F1
	public virtual object GetKey(TData data, int gridIndex)
	{
		return this.GridIndex;
	}
}
