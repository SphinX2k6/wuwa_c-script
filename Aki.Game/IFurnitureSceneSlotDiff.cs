using System;
using System.Runtime.CompilerServices;

// Token: 0x02000448 RID: 1096
[NullableContext(1)]
public interface IFurnitureSceneSlotDiff
{
	// Token: 0x17000820 RID: 2080
	// (get) Token: 0x060039C0 RID: 14784
	int RootFurnitureToPlace { get; }

	// Token: 0x17000821 RID: 2081
	// (get) Token: 0x060039C1 RID: 14785
	int RootFurnitureToUnPlace { get; }

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x060039C2 RID: 14786
	int[] SubFurnitureListToPlace { get; }

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x060039C3 RID: 14787
	int[] SubFurnitureListToUnPlace { get; }
}
