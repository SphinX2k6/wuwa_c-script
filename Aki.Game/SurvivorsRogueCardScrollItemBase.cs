using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;

// Token: 0x02002050 RID: 8272
[NullableContext(1)]
[Nullable(0)]
public abstract class SurvivorsRogueCardScrollItemBase<[Nullable(2)] TData> : SurvivorsRogueCardBase, IGridProxy<TData>
{
	// Token: 0x17001EA7 RID: 7847
	// (get) Token: 0x06014740 RID: 83776 RVA: 0x005F7FEF File Offset: 0x005F61EF
	// (set) Token: 0x06014741 RID: 83777 RVA: 0x005F7FF7 File Offset: 0x005F61F7
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

	// Token: 0x17001EA8 RID: 7848
	// (get) Token: 0x06014742 RID: 83778 RVA: 0x005F8000 File Offset: 0x005F6200
	// (set) Token: 0x06014743 RID: 83779 RVA: 0x005F8008 File Offset: 0x005F6208
	public int GridIndex { get; set; }

	// Token: 0x17001EA9 RID: 7849
	// (get) Token: 0x06014744 RID: 83780 RVA: 0x005F8011 File Offset: 0x005F6211
	// (set) Token: 0x06014745 RID: 83781 RVA: 0x005F8019 File Offset: 0x005F6219
	public int DisplayIndex { get; set; }

	// Token: 0x06014746 RID: 83782 RVA: 0x005F8022 File Offset: 0x005F6222
	public void Clear()
	{
	}

	// Token: 0x06014747 RID: 83783
	public abstract UniTask RefreshAsync(TData data, bool isSelected, int gridIndex);

	// Token: 0x06014748 RID: 83784 RVA: 0x005F8024 File Offset: 0x005F6224
	public virtual void OnSelected(bool fireEvent)
	{
		base.SetSelected(true, fireEvent, false);
	}

	// Token: 0x06014749 RID: 83785 RVA: 0x005F802F File Offset: 0x005F622F
	public virtual void OnDeselected(bool fireEvent)
	{
		base.SetSelected(false, fireEvent, false);
	}

	// Token: 0x0601474A RID: 83786 RVA: 0x005F803A File Offset: 0x005F623A
	public virtual void OnForceSelected(bool bSelected, bool fireEvent)
	{
		base.SetSelected(bSelected, fireEvent, true);
	}

	// Token: 0x0601474B RID: 83787 RVA: 0x005F8045 File Offset: 0x005F6245
	public virtual object GetKey(TData data, int gridIndex)
	{
		return this.GridIndex;
	}
}
