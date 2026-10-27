using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x02001A43 RID: 6723
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssItemSmallItemGrid : SmallItemGrid, IGridProxy<AbyssPluginItemInfo>
{
	// Token: 0x0600C5BF RID: 50623 RVA: 0x002CE974 File Offset: 0x002CCB74
	public void Refresh(AbyssPluginItemInfo data)
	{
		TItemConfig config = data.GetConfig();
		AbyssQuality? abyssQualityByPluginItemId = DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(data.GetConfigId());
		if (config == null || abyssQualityByPluginItemId == null)
		{
			return;
		}
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId()),
			BottomTextId = config.As<AbyssItem>().Value.Name,
			IsLockVisible = new bool?(data.GetIsLock())
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x17001054 RID: 4180
	// (get) Token: 0x0600C5C0 RID: 50624 RVA: 0x002CE9F9 File Offset: 0x002CCBF9
	// (set) Token: 0x0600C5C1 RID: 50625 RVA: 0x002CEA01 File Offset: 0x002CCC01
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<AbyssPluginItemInfo>, AbyssPluginItemInfo> ScrollViewDelegate { [return: Nullable(new byte[]
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

	// Token: 0x17001055 RID: 4181
	// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x002CEA0A File Offset: 0x002CCC0A
	// (set) Token: 0x0600C5C3 RID: 50627 RVA: 0x002CEA12 File Offset: 0x002CCC12
	public int GridIndex { get; set; }

	// Token: 0x17001056 RID: 4182
	// (get) Token: 0x0600C5C4 RID: 50628 RVA: 0x002CEA1B File Offset: 0x002CCC1B
	// (set) Token: 0x0600C5C5 RID: 50629 RVA: 0x002CEA23 File Offset: 0x002CCC23
	public int DisplayIndex { get; set; }

	// Token: 0x0600C5C6 RID: 50630 RVA: 0x002CEA2C File Offset: 0x002CCC2C
	public void Clear()
	{
	}

	// Token: 0x0600C5C7 RID: 50631 RVA: 0x002CEA2E File Offset: 0x002CCC2E
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C5C8 RID: 50632 RVA: 0x002CEA30 File Offset: 0x002CCC30
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C5C9 RID: 50633 RVA: 0x002CEA32 File Offset: 0x002CCC32
	public object GetKey(AbyssPluginItemInfo data, int gridIndex)
	{
		return this.GridIndex;
	}
}
