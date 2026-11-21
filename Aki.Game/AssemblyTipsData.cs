using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001E91 RID: 7825
[NullableContext(1)]
[Nullable(0)]
public class AssemblyTipsData
{
	// Token: 0x060134F8 RID: 79096 RVA: 0x005A3588 File Offset: 0x005A1788
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

	// Token: 0x0400A57C RID: 42364
	public ERouletteGridType GridType;

	// Token: 0x0400A57D RID: 42365
	public int GridId;

	// Token: 0x0400A57E RID: 42366
	public string Title;

	// Token: 0x0400A57F RID: 42367
	public InventoryDefine.EQuality BgQuality;

	// Token: 0x0400A580 RID: 42368
	public bool IsIconTexture;

	// Token: 0x0400A581 RID: 42369
	public string IconPath;

	// Token: 0x0400A582 RID: 42370
	public int HelpId;

	// Token: 0x0400A583 RID: 42371
	public string TextMain;

	// Token: 0x0400A584 RID: 42372
	public string TextSub;

	// Token: 0x0400A585 RID: 42373
	public List<IGetWayItemData> GetWayData;

	// Token: 0x0400A586 RID: 42374
	[Nullable(0)]
	public ValueTuple<int, int> CanSetItemNum;

	// Token: 0x0400A587 RID: 42375
	public Dictionary<int, int> NeedItemMap;

	// Token: 0x0400A588 RID: 42376
	public List<int> Authorization;

	// Token: 0x0400A589 RID: 42377
	public bool ShowPhantomInteractEquipment;
}
