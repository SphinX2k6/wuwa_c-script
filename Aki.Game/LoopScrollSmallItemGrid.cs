using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001965 RID: 6501
[NullableContext(1)]
[Nullable(0)]
public abstract class LoopScrollSmallItemGrid<[Nullable(2)] TData> : SmallItemGrid, IGridProxy<TData>
{
	// Token: 0x17000FE7 RID: 4071
	// (get) Token: 0x0600BE2E RID: 48686 RVA: 0x002B03CF File Offset: 0x002AE5CF
	// (set) Token: 0x0600BE2F RID: 48687 RVA: 0x002B03D7 File Offset: 0x002AE5D7
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

	// Token: 0x17000FE8 RID: 4072
	// (get) Token: 0x0600BE30 RID: 48688 RVA: 0x002B03E0 File Offset: 0x002AE5E0
	// (set) Token: 0x0600BE31 RID: 48689 RVA: 0x002B03E8 File Offset: 0x002AE5E8
	public int GridIndex { get; set; }

	// Token: 0x17000FE9 RID: 4073
	// (get) Token: 0x0600BE32 RID: 48690 RVA: 0x002B03F1 File Offset: 0x002AE5F1
	// (set) Token: 0x0600BE33 RID: 48691 RVA: 0x002B03F9 File Offset: 0x002AE5F9
	public int DisplayIndex { get; set; }

	// Token: 0x0600BE34 RID: 48692 RVA: 0x002B0402 File Offset: 0x002AE602
	public virtual void Refresh(TData data, bool isSelected, int gridIndex)
	{
		this.OnRefresh(data, isSelected, gridIndex);
	}

	// Token: 0x0600BE35 RID: 48693
	protected abstract void OnRefresh(TData data, bool isSelected, int gridIndex);

	// Token: 0x0600BE36 RID: 48694 RVA: 0x002B040D File Offset: 0x002AE60D
	public void Clear()
	{
	}

	// Token: 0x0600BE37 RID: 48695 RVA: 0x002B040F File Offset: 0x002AE60F
	public virtual void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600BE38 RID: 48696 RVA: 0x002B0411 File Offset: 0x002AE611
	public virtual void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600BE39 RID: 48697 RVA: 0x002B0413 File Offset: 0x002AE613
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x0600BE3A RID: 48698 RVA: 0x002B041D File Offset: 0x002AE61D
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		return base.CreateThenShowByActorAsync(actor, null, false);
	}

	// Token: 0x0600BE3B RID: 48699 RVA: 0x002B0428 File Offset: 0x002AE628
	public UniTask CreateByActorAsync(AActor actor)
	{
		return base.CreateByActorAsync(actor, null, false);
	}

	// Token: 0x0600BE3C RID: 48700 RVA: 0x002B0433 File Offset: 0x002AE633
	protected override void OnAddEvents()
	{
		this.OnShowGridAnimationCallback = new Action<int, UUIItem>(this.OnShowGridAnimation);
		EventSystem.Instance.Add<int, UUIItem>(EEventName.OnShowGridAnimation, this.OnShowGridAnimationCallback);
	}

	// Token: 0x0600BE3D RID: 48701 RVA: 0x002B045D File Offset: 0x002AE65D
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, UUIItem>(EEventName.OnShowGridAnimation, this.OnShowGridAnimationCallback);
		this.OnShowGridAnimationCallback = null;
	}

	// Token: 0x0600BE3E RID: 48702 RVA: 0x002B047C File Offset: 0x002AE67C
	protected void OnShowGridAnimation(int gridIndex, UUIItem gridItem)
	{
		if (gridIndex != this.GridIndex)
		{
			return;
		}
		if (this.IsSelected)
		{
			this.SetSelected(false, false);
			this.SetSelected(true, false);
		}
	}

	// Token: 0x0600BE3F RID: 48703 RVA: 0x002B04A0 File Offset: 0x002AE6A0
	[return: Nullable(2)]
	public virtual object GetKey(TData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x040055BE RID: 21950
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIItem> OnShowGridAnimationCallback;
}
