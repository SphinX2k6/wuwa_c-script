using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;

// Token: 0x02000F02 RID: 3842
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssItemSmallItemGrid : SmallItemGrid, IGridProxy<AbyssPluginItemInfo>
{
	// Token: 0x060099CF RID: 39375 RVA: 0x002D9A88 File Offset: 0x002D7C88
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

	// Token: 0x17001079 RID: 4217
	// (get) Token: 0x060099D0 RID: 39376 RVA: 0x002D9B0D File Offset: 0x002D7D0D
	// (set) Token: 0x060099D1 RID: 39377 RVA: 0x002D9B15 File Offset: 0x002D7D15
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

	// Token: 0x1700107A RID: 4218
	// (get) Token: 0x060099D2 RID: 39378 RVA: 0x002D9B1E File Offset: 0x002D7D1E
	// (set) Token: 0x060099D3 RID: 39379 RVA: 0x002D9B26 File Offset: 0x002D7D26
	public int GridIndex { get; set; }

	// Token: 0x1700107B RID: 4219
	// (get) Token: 0x060099D4 RID: 39380 RVA: 0x002D9B2F File Offset: 0x002D7D2F
	// (set) Token: 0x060099D5 RID: 39381 RVA: 0x002D9B37 File Offset: 0x002D7D37
	public int DisplayIndex { get; set; }

	// Token: 0x060099D6 RID: 39382 RVA: 0x002D9B40 File Offset: 0x002D7D40
	public void Clear()
	{
	}

	// Token: 0x060099D7 RID: 39383 RVA: 0x002D9B42 File Offset: 0x002D7D42
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060099D8 RID: 39384 RVA: 0x002D9B44 File Offset: 0x002D7D44
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060099D9 RID: 39385 RVA: 0x002D9B46 File Offset: 0x002D7D46
	public object GetKey(AbyssPluginItemInfo data, int gridIndex)
	{
		return this.GridIndex;
	}
}
