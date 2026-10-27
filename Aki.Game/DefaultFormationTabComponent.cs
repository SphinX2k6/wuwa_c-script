using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001C07 RID: 7175
[NullableContext(1)]
[Nullable(0)]
internal sealed class DefaultFormationTabComponent : IFormationTabComponent
{
	// Token: 0x0600D692 RID: 54930 RVA: 0x0031A158 File Offset: 0x00318358
	public DefaultFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		this.Component = new TabComponentWithTitle<EditFormationTabItem>(uiItem, data);
	}

	// Token: 0x0600D693 RID: 54931 RVA: 0x0031A16D File Offset: 0x0031836D
	public void Destroy()
	{
		this.Component.Destroy(null);
	}

	// Token: 0x0600D694 RID: 54932 RVA: 0x0031A17B File Offset: 0x0031837B
	public UniTask RefreshTabItemAsync(int length)
	{
		return this.Component.RefreshTabItemAsync(length);
	}

	// Token: 0x0600D695 RID: 54933 RVA: 0x0031A189 File Offset: 0x00318389
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.Component.SelectToggleByIndex(index, bIgnored);
	}

	// Token: 0x0600D696 RID: 54934 RVA: 0x0031A198 File Offset: 0x00318398
	public int GetSelectedIndex()
	{
		return this.Component.GetSelectedIndex();
	}

	// Token: 0x0600D697 RID: 54935 RVA: 0x0031A1A5 File Offset: 0x003183A5
	public void ScrollToToggleByIndex(int index)
	{
		this.Component.ScrollToToggleByIndex(index);
	}

	// Token: 0x0600D698 RID: 54936 RVA: 0x0031A1B3 File Offset: 0x003183B3
	[NullableContext(2)]
	public EditFormationTabItem GetTabItemByIndex(int index)
	{
		return this.Component.GetTabItemByIndex(index);
	}

	// Token: 0x0600D699 RID: 54937 RVA: 0x0031A1C1 File Offset: 0x003183C1
	public void RefreshTitleByIndex(int index)
	{
		this.Component.RefreshTitleByIndex(index);
	}

	// Token: 0x0600D69A RID: 54938 RVA: 0x0031A1CF File Offset: 0x003183CF
	public void SetCanChange(Func<int, bool> callback)
	{
		this.Component.SetCanChange(callback);
	}

	// Token: 0x04006223 RID: 25123
	private readonly TabComponentWithTitle<EditFormationTabItem> Component;
}
