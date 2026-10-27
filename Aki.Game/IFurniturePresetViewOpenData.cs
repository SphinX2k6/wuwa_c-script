using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F88 RID: 3976
[NullableContext(1)]
public interface IFurniturePresetViewOpenData
{
	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x06006600 RID: 26112
	FurnitureAreaData AreaData { get; }

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x06006601 RID: 26113
	Action<FurnitureAreaData> OnApplyDelegate { get; }
}
