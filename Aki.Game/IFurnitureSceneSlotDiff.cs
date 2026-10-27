using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F93 RID: 3987
[NullableContext(1)]
public interface IFurnitureSceneSlotDiff
{
	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06006628 RID: 26152
	int RootFurnitureToPlace { get; }

	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x06006629 RID: 26153
	int RootFurnitureToUnPlace { get; }

	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x0600662A RID: 26154
	int[] SubFurnitureListToPlace { get; }

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x0600662B RID: 26155
	int[] SubFurnitureListToUnPlace { get; }
}
