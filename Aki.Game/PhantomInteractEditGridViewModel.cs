using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200194B RID: 6475
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditGridViewModel : IPhantomInteractGridViewModel, IPhantomInteractGridData
{
	// Token: 0x0600FFD7 RID: 65495 RVA: 0x004AADC7 File Offset: 0x004A8FC7
	public PhantomInteractEditGridViewModel(IPhantomInteractGridData data)
	{
	}

	// Token: 0x17001898 RID: 6296
	// (get) Token: 0x0600FFD8 RID: 65496 RVA: 0x004AADDD File Offset: 0x004A8FDD
	public int MonsterId
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.MonsterId;
		}
	}

	// Token: 0x17001899 RID: 6297
	// (get) Token: 0x0600FFD9 RID: 65497 RVA: 0x004AADF0 File Offset: 0x004A8FF0
	public int MonsterInfoId
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.MonsterInfoId;
		}
	}

	// Token: 0x1700189A RID: 6298
	// (get) Token: 0x0600FFDA RID: 65498 RVA: 0x004AAE03 File Offset: 0x004A9003
	public List<int> SkinIds
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.SkinIds : null) ?? new List<int>();
		}
	}

	// Token: 0x1700189B RID: 6299
	// (get) Token: 0x0600FFDB RID: 65499 RVA: 0x004AAE20 File Offset: 0x004A9020
	public int EquippedSkin
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.EquippedSkin;
		}
	}

	// Token: 0x1700189C RID: 6300
	// (get) Token: 0x0600FFDC RID: 65500 RVA: 0x004AAE33 File Offset: 0x004A9033
	public bool IsSpecial
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.IsSpecial;
		}
	}

	// Token: 0x1700189D RID: 6301
	// (get) Token: 0x0600FFDD RID: 65501 RVA: 0x004AAE46 File Offset: 0x004A9046
	[Nullable(2)]
	public string Name
	{
		[NullableContext(2)]
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.Name : null) ?? null;
		}
	}

	// Token: 0x1700189E RID: 6302
	// (get) Token: 0x0600FFDE RID: 65502 RVA: 0x004AAE5F File Offset: 0x004A905F
	public int Cost
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.Cost;
		}
	}

	// Token: 0x1700189F RID: 6303
	// (get) Token: 0x0600FFDF RID: 65503 RVA: 0x004AAE72 File Offset: 0x004A9072
	public bool IsUnlocked
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.IsUnlocked;
		}
	}

	// Token: 0x170018A0 RID: 6304
	// (get) Token: 0x0600FFE0 RID: 65504 RVA: 0x004AAE85 File Offset: 0x004A9085
	public List<int> InteractAreaList
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.InteractAreaList : null) ?? new List<int>();
		}
	}

	// Token: 0x170018A1 RID: 6305
	// (get) Token: 0x0600FFE1 RID: 65505 RVA: 0x004AAEA2 File Offset: 0x004A90A2
	public int InSlotIndex
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return -1;
			}
			return data.InSlotIndex;
		}
	}

	// Token: 0x170018A2 RID: 6306
	// (get) Token: 0x0600FFE2 RID: 65506 RVA: 0x004AAEB5 File Offset: 0x004A90B5
	[Nullable(2)]
	public string IconPath
	{
		[NullableContext(2)]
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.IconPath : null) ?? null;
		}
	}

	// Token: 0x170018A3 RID: 6307
	// (get) Token: 0x0600FFE3 RID: 65507 RVA: 0x004AAECE File Offset: 0x004A90CE
	public bool HasSkin
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.HasSkin;
		}
	}

	// Token: 0x170018A4 RID: 6308
	// (get) Token: 0x0600FFE4 RID: 65508 RVA: 0x004AAEE1 File Offset: 0x004A90E1
	public int GetWayConfigId
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.GetWayConfigId;
		}
	}

	// Token: 0x170018A5 RID: 6309
	// (get) Token: 0x0600FFE5 RID: 65509 RVA: 0x004AAEF4 File Offset: 0x004A90F4
	public int SortId
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.SortId;
		}
	}

	// Token: 0x170018A6 RID: 6310
	// (get) Token: 0x0600FFE6 RID: 65510 RVA: 0x004AAF07 File Offset: 0x004A9107
	// (set) Token: 0x0600FFE7 RID: 65511 RVA: 0x004AAF0F File Offset: 0x004A910F
	public bool IsSelected { get; set; }

	// Token: 0x170018A7 RID: 6311
	// (get) Token: 0x0600FFE8 RID: 65512 RVA: 0x004AAF18 File Offset: 0x004A9118
	// (set) Token: 0x0600FFE9 RID: 65513 RVA: 0x004AAF20 File Offset: 0x004A9120
	public int GridIndex { get; set; } = -1;

	// Token: 0x170018A8 RID: 6312
	// (get) Token: 0x0600FFEA RID: 65514 RVA: 0x004AAF29 File Offset: 0x004A9129
	// (set) Token: 0x0600FFEB RID: 65515 RVA: 0x004AAF31 File Offset: 0x004A9131
	public bool IsInArea { get; set; }

	// Token: 0x04008E1B RID: 36379
	[Nullable(2)]
	private readonly IPhantomInteractGridData Data = data;
}
