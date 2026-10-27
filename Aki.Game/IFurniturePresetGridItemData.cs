using System;
using Aki.Config;

// Token: 0x02000FDE RID: 4062
public interface IFurniturePresetGridItemData
{
	// Token: 0x17000873 RID: 2163
	// (get) Token: 0x06006854 RID: 26708
	// (set) Token: 0x06006855 RID: 26709
	Furniture FurnitureConfig { get; set; }

	// Token: 0x17000874 RID: 2164
	// (get) Token: 0x06006856 RID: 26710
	// (set) Token: 0x06006857 RID: 26711
	bool IsLock { get; set; }

	// Token: 0x17000875 RID: 2165
	// (get) Token: 0x06006858 RID: 26712
	// (set) Token: 0x06006859 RID: 26713
	bool IsFinished { get; set; }
}
