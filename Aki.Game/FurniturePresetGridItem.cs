using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000FE0 RID: 4064
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurniturePresetGridItem : GridProxyAbstract<IFurniturePresetGridItemData>
{
	// Token: 0x06006861 RID: 26721 RVA: 0x0014B7DC File Offset: 0x001499DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06006862 RID: 26722 RVA: 0x0014B836 File Offset: 0x00149A36
	public override void Refresh(IFurniturePresetGridItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdateItemsVisible();
		this.RefreshDetail();
	}

	// Token: 0x06006863 RID: 26723 RVA: 0x0014B84C File Offset: 0x00149A4C
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

	// Token: 0x06006864 RID: 26724 RVA: 0x0014B8A4 File Offset: 0x00149AA4
	public void RefreshDetail()
	{
		IFurniturePresetGridItemData data = this.Data;
		string textStringId = ((data != null) ? data.FurnitureConfig.Name : null) ?? "";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
	}

	// Token: 0x04002FA4 RID: 12196
	[Nullable(2)]
	private IFurniturePresetGridItemData Data;
}
