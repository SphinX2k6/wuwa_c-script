using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FD4 RID: 8148
public class ItemViewDefine
{
	// Token: 0x0400762D RID: 30253
	public const int REFRESH_CD_INTERVAL = 500;

	// Token: 0x0400762E RID: 30254
	public const int MAX_DESTROY_MODE_COUNT = 100;

	// Token: 0x020085E8 RID: 34280
	[NullableContext(1)]
	public interface IDestroyPreviewData
	{
		// Token: 0x1700A073 RID: 41075
		// (get) Token: 0x0604A844 RID: 305220
		// (set) Token: 0x0604A845 RID: 305221
		List<TItem> OriginList { get; set; }

		// Token: 0x1700A074 RID: 41076
		// (get) Token: 0x0604A846 RID: 305222
		// (set) Token: 0x0604A847 RID: 305223
		List<TItem> ResultList { get; set; }
	}

	// Token: 0x020085E9 RID: 34281
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyPreviewData : ItemViewDefine.IDestroyPreviewData
	{
		// Token: 0x1700A075 RID: 41077
		// (get) Token: 0x0604A848 RID: 305224 RVA: 0x01371BA2 File Offset: 0x0136FDA2
		// (set) Token: 0x0604A849 RID: 305225 RVA: 0x01371BAA File Offset: 0x0136FDAA
		public List<TItem> OriginList { get; set; }

		// Token: 0x1700A076 RID: 41078
		// (get) Token: 0x0604A84A RID: 305226 RVA: 0x01371BB3 File Offset: 0x0136FDB3
		// (set) Token: 0x0604A84B RID: 305227 RVA: 0x01371BBB File Offset: 0x0136FDBB
		public List<TItem> ResultList { get; set; }
	}

	// Token: 0x020085EA RID: 34282
	public enum EItemOperationMode
	{
		// Token: 0x0402B965 RID: 178533
		Normal,
		// Token: 0x0402B966 RID: 178534
		Destruction
	}

	// Token: 0x020085EB RID: 34283
	public enum EDestroyViewMode
	{
		// Token: 0x0402B968 RID: 178536
		Default,
		// Token: 0x0402B969 RID: 178537
		Disabled,
		// Token: 0x0402B96A RID: 178538
		Multiple
	}

	// Token: 0x020085EC RID: 34284
	public enum ETipsButtonType
	{
		// Token: 0x0402B96C RID: 178540
		Use,
		// Token: 0x0402B96D RID: 178541
		RouletteEquip,
		// Token: 0x0402B96E RID: 178542
		WeaponCultivate,
		// Token: 0x0402B96F RID: 178543
		VisionCultivate,
		// Token: 0x0402B970 RID: 178544
		FragmentMemory,
		// Token: 0x0402B971 RID: 178545
		EquipBuffItem,
		// Token: 0x0402B972 RID: 178546
		QuestReview,
		// Token: 0x0402B973 RID: 178547
		ChineseZither
	}
}
