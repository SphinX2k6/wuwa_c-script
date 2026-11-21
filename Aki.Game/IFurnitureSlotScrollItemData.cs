using System;

// Token: 0x02000437 RID: 1079
public interface IFurnitureSlotScrollItemData
{
	// Token: 0x170007E4 RID: 2020
	// (get) Token: 0x0600395F RID: 14687
	int SceneSlotEntityId { get; }

	// Token: 0x170007E5 RID: 2021
	// (get) Token: 0x06003960 RID: 14688
	int PlacedFurnitureId { get; }

	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x06003961 RID: 14689
	int SubSlotIndex { get; }

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x06003962 RID: 14690
	EFurnitureSlotType SlotType { get; }

	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x06003963 RID: 14691
	int TagId { get; }

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x06003964 RID: 14692
	int TagIndex { get; }

	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x06003965 RID: 14693
	bool ShowTagIndex { get; }

	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x06003966 RID: 14694
	bool IsSelected { get; }

	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x06003967 RID: 14695
	bool LineShowState { get; }

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x06003968 RID: 14696
	bool RedDotShowState { get; }
}
