using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014A7 RID: 5287
public class ItemViewDefine
{
	// Token: 0x04007716 RID: 30486
	public const int REFRESH_CD_INTERVAL = 500;

	// Token: 0x04007717 RID: 30487
	public const int MAX_DESTROY_MODE_COUNT = 100;

	// Token: 0x0200776F RID: 30575
	[NullableContext(1)]
	public interface IDestroyPreviewData
	{
		// Token: 0x17007811 RID: 30737
		// (get) Token: 0x06040C3E RID: 265278
		// (set) Token: 0x06040C3F RID: 265279
		List<TItem> OriginList { get; set; }

		// Token: 0x17007812 RID: 30738
		// (get) Token: 0x06040C40 RID: 265280
		// (set) Token: 0x06040C41 RID: 265281
		List<TItem> ResultList { get; set; }
	}

	// Token: 0x02007770 RID: 30576
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyPreviewData : ItemViewDefine.IDestroyPreviewData
	{
		// Token: 0x17007813 RID: 30739
		// (get) Token: 0x06040C42 RID: 265282 RVA: 0x01314F66 File Offset: 0x01313166
		// (set) Token: 0x06040C43 RID: 265283 RVA: 0x01314F6E File Offset: 0x0131316E
		public List<TItem> OriginList { get; set; }

		// Token: 0x17007814 RID: 30740
		// (get) Token: 0x06040C44 RID: 265284 RVA: 0x01314F77 File Offset: 0x01313177
		// (set) Token: 0x06040C45 RID: 265285 RVA: 0x01314F7F File Offset: 0x0131317F
		public List<TItem> ResultList { get; set; }
	}

	// Token: 0x02007771 RID: 30577
	public enum EItemOperationMode
	{
		// Token: 0x04026C74 RID: 158836
		Normal,
		// Token: 0x04026C75 RID: 158837
		Destruction
	}

	// Token: 0x02007772 RID: 30578
	public enum EDestroyViewMode
	{
		// Token: 0x04026C77 RID: 158839
		Default,
		// Token: 0x04026C78 RID: 158840
		Disabled,
		// Token: 0x04026C79 RID: 158841
		Multiple
	}

	// Token: 0x02007773 RID: 30579
	public enum ETipsButtonType
	{
		// Token: 0x04026C7B RID: 158843
		Use,
		// Token: 0x04026C7C RID: 158844
		RouletteEquip,
		// Token: 0x04026C7D RID: 158845
		WeaponCultivate,
		// Token: 0x04026C7E RID: 158846
		VisionCultivate,
		// Token: 0x04026C7F RID: 158847
		FragmentMemory,
		// Token: 0x04026C80 RID: 158848
		EquipBuffItem,
		// Token: 0x04026C81 RID: 158849
		QuestReview,
		// Token: 0x04026C82 RID: 158850
		ChineseZither
	}
}
