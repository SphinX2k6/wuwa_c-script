using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E22 RID: 3618
[NullableContext(1)]
[Nullable(0)]
public abstract class LoopScrollSmallItemGrid<[Nullable(2)] TData> : SmallItemGrid, IGridProxy<TData>
{
	// Token: 0x1700100B RID: 4107
	// (get) Token: 0x06009231 RID: 37425 RVA: 0x002BB213 File Offset: 0x002B9413
	// (set) Token: 0x06009232 RID: 37426 RVA: 0x002BB21B File Offset: 0x002B941B
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

	// Token: 0x1700100C RID: 4108
	// (get) Token: 0x06009233 RID: 37427 RVA: 0x002BB224 File Offset: 0x002B9424
	// (set) Token: 0x06009234 RID: 37428 RVA: 0x002BB22C File Offset: 0x002B942C
	public int GridIndex { get; set; }

	// Token: 0x1700100D RID: 4109
	// (get) Token: 0x06009235 RID: 37429 RVA: 0x002BB235 File Offset: 0x002B9435
	// (set) Token: 0x06009236 RID: 37430 RVA: 0x002BB23D File Offset: 0x002B943D
	public int DisplayIndex { get; set; }

	// Token: 0x06009237 RID: 37431 RVA: 0x002BB246 File Offset: 0x002B9446
	public virtual void Refresh(TData data, bool isSelected, int gridIndex)
	{
		this.OnRefresh(data, isSelected, gridIndex);
	}

	// Token: 0x06009238 RID: 37432
	protected abstract void OnRefresh(TData data, bool isSelected, int gridIndex);

	// Token: 0x06009239 RID: 37433 RVA: 0x002BB251 File Offset: 0x002B9451
	public void Clear()
	{
	}

	// Token: 0x0600923A RID: 37434 RVA: 0x002BB253 File Offset: 0x002B9453
	public virtual void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600923B RID: 37435 RVA: 0x002BB255 File Offset: 0x002B9455
	public virtual void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600923C RID: 37436 RVA: 0x002BB257 File Offset: 0x002B9457
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x0600923D RID: 37437 RVA: 0x002BB261 File Offset: 0x002B9461
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		return base.CreateThenShowByActorAsync(actor, null, false);
	}

	// Token: 0x0600923E RID: 37438 RVA: 0x002BB26C File Offset: 0x002B946C
	public UniTask CreateByActorAsync(AActor actor)
	{
		return base.CreateByActorAsync(actor, null, false);
	}

	// Token: 0x0600923F RID: 37439 RVA: 0x002BB277 File Offset: 0x002B9477
	protected override void OnAddEvents()
	{
		this.OnShowGridAnimationCallback = new Action<int, UUIItem>(this.OnShowGridAnimation);
		EventSystem.Instance.Add<int, UUIItem>(EEventName.OnShowGridAnimation, this.OnShowGridAnimationCallback);
	}

	// Token: 0x06009240 RID: 37440 RVA: 0x002BB2A1 File Offset: 0x002B94A1
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, UUIItem>(EEventName.OnShowGridAnimation, this.OnShowGridAnimationCallback);
		this.OnShowGridAnimationCallback = null;
	}

	// Token: 0x06009241 RID: 37441 RVA: 0x002BB2C0 File Offset: 0x002B94C0
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

	// Token: 0x06009242 RID: 37442 RVA: 0x002BB2E4 File Offset: 0x002B94E4
	[return: Nullable(2)]
	public virtual object GetKey(TData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0400566B RID: 22123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIItem> OnShowGridAnimationCallback;
}
