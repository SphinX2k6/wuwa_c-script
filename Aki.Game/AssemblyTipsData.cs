using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002916 RID: 10518
[NullableContext(1)]
[Nullable(0)]
public class AssemblyTipsData
{
	// Token: 0x06015AF4 RID: 88820 RVA: 0x00578694 File Offset: 0x00576894
	public AssemblyTipsData()
	{
		this.GridType = ERouletteGridType.Explore;
		this.GridId = 0;
		this.Title = "";
		this.BgQuality = InventoryDefine.EQuality.White;
		this.IsIconTexture = false;
		this.IconPath = "";
		this.HelpId = 0;
		this.TextMain = "";
		this.TextSub = "";
		this.GetWayData = new List<IGetWayItemData>();
		this.CanSetItemNum = new ValueTuple<int, int>(0, 0);
		this.NeedItemMap = new Dictionary<int, int>();
		this.Authorization = new List<int>();
		this.ShowPhantomInteractEquipment = false;
	}

	// Token: 0x0400A191 RID: 41361
	public ERouletteGridType GridType;

	// Token: 0x0400A192 RID: 41362
	public int GridId;

	// Token: 0x0400A193 RID: 41363
	public string Title;

	// Token: 0x0400A194 RID: 41364
	public InventoryDefine.EQuality BgQuality;

	// Token: 0x0400A195 RID: 41365
	public bool IsIconTexture;

	// Token: 0x0400A196 RID: 41366
	public string IconPath;

	// Token: 0x0400A197 RID: 41367
	public int HelpId;

	// Token: 0x0400A198 RID: 41368
	public string TextMain;

	// Token: 0x0400A199 RID: 41369
	public string TextSub;

	// Token: 0x0400A19A RID: 41370
	public List<IGetWayItemData> GetWayData;

	// Token: 0x0400A19B RID: 41371
	[Nullable(0)]
	public ValueTuple<int, int> CanSetItemNum;

	// Token: 0x0400A19C RID: 41372
	public Dictionary<int, int> NeedItemMap;

	// Token: 0x0400A19D RID: 41373
	public List<int> Authorization;

	// Token: 0x0400A19E RID: 41374
	public bool ShowPhantomInteractEquipment;
}
