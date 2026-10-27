using System;

// Token: 0x02000F82 RID: 3970
public interface IFurnitureSlotScrollItemData
{
	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x060065C7 RID: 26055
	int SceneSlotEntityId { get; }

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x060065C8 RID: 26056
	int PlacedFurnitureId { get; }

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x060065C9 RID: 26057
	int SubSlotIndex { get; }

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x060065CA RID: 26058
	EFurnitureSlotType SlotType { get; }

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x060065CB RID: 26059
	int TagId { get; }

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x060065CC RID: 26060
	int TagIndex { get; }

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x060065CD RID: 26061
	bool ShowTagIndex { get; }

	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x060065CE RID: 26062
	bool IsSelected { get; }

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x060065CF RID: 26063
	bool LineShowState { get; }

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x060065D0 RID: 26064
	bool RedDotShowState { get; }
}
