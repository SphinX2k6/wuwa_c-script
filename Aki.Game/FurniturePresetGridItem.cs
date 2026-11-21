using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000495 RID: 1173
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurniturePresetGridItem : GridProxyAbstract<IFurniturePresetGridItemData>
{
	// Token: 0x06003BF9 RID: 15353 RVA: 0x001540A0 File Offset: 0x001522A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x001540FA File Offset: 0x001522FA
	public override void Refresh(IFurniturePresetGridItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateItemsVisible();
		this.RefreshDetail();
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x00154110 File Offset: 0x00152310
	private void UpdateItemsVisible()
	{
		IFurniturePresetGridItemData data = this.Data;
		bool uiactive = data != null && data.IsLock;
		IFurniturePresetGridItemData data2 = this.Data;
		bool uiactive2 = data2 != null && data2.IsFinished;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(uiactive2);
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x00154168 File Offset: 0x00152368
	public void RefreshDetail()
	{
		IFurniturePresetGridItemData data = this.Data;
		string textStringId = ((data != null) ? data.FurnitureConfig.Name : null) ?? "";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
	}

	// Token: 0x0400303D RID: 12349
	[Nullable(2)]
	private IFurniturePresetGridItemData Data;
}
