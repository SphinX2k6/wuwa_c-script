using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002466 RID: 9318
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditGridViewModel : IPhantomInteractGridViewModel, IPhantomInteractGridData
{
	// Token: 0x06012B1F RID: 76575 RVA: 0x0049D65B File Offset: 0x0049B85B
	public PhantomInteractEditGridViewModel(IPhantomInteractGridData data)
	{
	}

	// Token: 0x1700185E RID: 6238
	// (get) Token: 0x06012B20 RID: 76576 RVA: 0x0049D671 File Offset: 0x0049B871
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

	// Token: 0x1700185F RID: 6239
	// (get) Token: 0x06012B21 RID: 76577 RVA: 0x0049D684 File Offset: 0x0049B884
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

	// Token: 0x17001860 RID: 6240
	// (get) Token: 0x06012B22 RID: 76578 RVA: 0x0049D697 File Offset: 0x0049B897
	public List<int> SkinIds
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.SkinIds : null) ?? new List<int>();
		}
	}

	// Token: 0x17001861 RID: 6241
	// (get) Token: 0x06012B23 RID: 76579 RVA: 0x0049D6B4 File Offset: 0x0049B8B4
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

	// Token: 0x17001862 RID: 6242
	// (get) Token: 0x06012B24 RID: 76580 RVA: 0x0049D6C7 File Offset: 0x0049B8C7
	public bool IsSpecial
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.IsSpecial;
		}
	}

	// Token: 0x17001863 RID: 6243
	// (get) Token: 0x06012B25 RID: 76581 RVA: 0x0049D6DA File Offset: 0x0049B8DA
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

	// Token: 0x17001864 RID: 6244
	// (get) Token: 0x06012B26 RID: 76582 RVA: 0x0049D6F3 File Offset: 0x0049B8F3
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

	// Token: 0x17001865 RID: 6245
	// (get) Token: 0x06012B27 RID: 76583 RVA: 0x0049D706 File Offset: 0x0049B906
	public bool IsUnlocked
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.IsUnlocked;
		}
	}

	// Token: 0x17001866 RID: 6246
	// (get) Token: 0x06012B28 RID: 76584 RVA: 0x0049D719 File Offset: 0x0049B919
	public List<int> InteractAreaList
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return ((data != null) ? data.InteractAreaList : null) ?? new List<int>();
		}
	}

	// Token: 0x17001867 RID: 6247
	// (get) Token: 0x06012B29 RID: 76585 RVA: 0x0049D736 File Offset: 0x0049B936
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

	// Token: 0x17001868 RID: 6248
	// (get) Token: 0x06012B2A RID: 76586 RVA: 0x0049D749 File Offset: 0x0049B949
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

	// Token: 0x17001869 RID: 6249
	// (get) Token: 0x06012B2B RID: 76587 RVA: 0x0049D762 File Offset: 0x0049B962
	public bool HasSkin
	{
		get
		{
			IPhantomInteractGridData data = this.Data;
			return data != null && data.HasSkin;
		}
	}

	// Token: 0x1700186A RID: 6250
	// (get) Token: 0x06012B2C RID: 76588 RVA: 0x0049D775 File Offset: 0x0049B975
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

	// Token: 0x1700186B RID: 6251
	// (get) Token: 0x06012B2D RID: 76589 RVA: 0x0049D788 File Offset: 0x0049B988
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

	// Token: 0x1700186C RID: 6252
	// (get) Token: 0x06012B2E RID: 76590 RVA: 0x0049D79B File Offset: 0x0049B99B
	// (set) Token: 0x06012B2F RID: 76591 RVA: 0x0049D7A3 File Offset: 0x0049B9A3
	public bool IsSelected { get; set; }

	// Token: 0x1700186D RID: 6253
	// (get) Token: 0x06012B30 RID: 76592 RVA: 0x0049D7AC File Offset: 0x0049B9AC
	// (set) Token: 0x06012B31 RID: 76593 RVA: 0x0049D7B4 File Offset: 0x0049B9B4
	public int GridIndex { get; set; } = -1;

	// Token: 0x1700186E RID: 6254
	// (get) Token: 0x06012B32 RID: 76594 RVA: 0x0049D7BD File Offset: 0x0049B9BD
	// (set) Token: 0x06012B33 RID: 76595 RVA: 0x0049D7C5 File Offset: 0x0049B9C5
	public bool IsInArea { get; set; }

	// Token: 0x04008CD4 RID: 36052
	[Nullable(2)]
	private readonly IPhantomInteractGridData Data = data;
}
