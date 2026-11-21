using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020010C6 RID: 4294
[NullableContext(1)]
[Nullable(0)]
internal sealed class DefaultFormationTabComponent : IFormationTabComponent
{
	// Token: 0x0600AAA5 RID: 43685 RVA: 0x00325448 File Offset: 0x00323648
	public DefaultFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		this.Component = new TabComponentWithTitle<EditFormationTabItem>(uiItem, data);
	}

	// Token: 0x0600AAA6 RID: 43686 RVA: 0x0032545D File Offset: 0x0032365D
	public void Destroy()
	{
		this.Component.Destroy(null);
	}

	// Token: 0x0600AAA7 RID: 43687 RVA: 0x0032546B File Offset: 0x0032366B
	public UniTask RefreshTabItemAsync(int length)
	{
		return this.Component.RefreshTabItemAsync(length);
	}

	// Token: 0x0600AAA8 RID: 43688 RVA: 0x00325479 File Offset: 0x00323679
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.Component.SelectToggleByIndex(index, bIgnored);
	}

	// Token: 0x0600AAA9 RID: 43689 RVA: 0x00325488 File Offset: 0x00323688
	public int GetSelectedIndex()
	{
		return this.Component.GetSelectedIndex();
	}

	// Token: 0x0600AAAA RID: 43690 RVA: 0x00325495 File Offset: 0x00323695
	public void ScrollToToggleByIndex(int index)
	{
		this.Component.ScrollToToggleByIndex(index);
	}

	// Token: 0x0600AAAB RID: 43691 RVA: 0x003254A3 File Offset: 0x003236A3
	[NullableContext(2)]
	public EditFormationTabItem GetTabItemByIndex(int index)
	{
		return this.Component.GetTabItemByIndex(index);
	}

	// Token: 0x0600AAAC RID: 43692 RVA: 0x003254B1 File Offset: 0x003236B1
	public void RefreshTitleByIndex(int index)
	{
		this.Component.RefreshTitleByIndex(index);
	}

	// Token: 0x0600AAAD RID: 43693 RVA: 0x003254BF File Offset: 0x003236BF
	public void SetCanChange(Func<int, bool> callback)
	{
		this.Component.SetCanChange(callback);
	}

	// Token: 0x040062F5 RID: 25333
	private readonly TabComponentWithTitle<EditFormationTabItem> Component;
}
