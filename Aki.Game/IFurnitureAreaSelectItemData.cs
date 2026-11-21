using System;
using System.Runtime.CompilerServices;

// Token: 0x02000476 RID: 1142
[NullableContext(1)]
public interface IFurnitureAreaSelectItemData
{
	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x06003ACB RID: 15051
	// (set) Token: 0x06003ACC RID: 15052
	int AreaId { get; set; }

	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x06003ACD RID: 15053
	// (set) Token: 0x06003ACE RID: 15054
	int FloorId { get; set; }

	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x06003ACF RID: 15055
	// (set) Token: 0x06003AD0 RID: 15056
	string AreaName { get; set; }

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x06003AD1 RID: 15057
	// (set) Token: 0x06003AD2 RID: 15058
	string LockAreaIcon { get; set; }

	// Token: 0x1700086B RID: 2155
	// (get) Token: 0x06003AD3 RID: 15059
	// (set) Token: 0x06003AD4 RID: 15060
	string UnlockAreaIcon { get; set; }

	// Token: 0x1700086C RID: 2156
	// (get) Token: 0x06003AD5 RID: 15061
	// (set) Token: 0x06003AD6 RID: 15062
	bool IsSelected { get; set; }

	// Token: 0x1700086D RID: 2157
	// (get) Token: 0x06003AD7 RID: 15063
	// (set) Token: 0x06003AD8 RID: 15064
	bool IsUnlock { get; set; }

	// Token: 0x1700086E RID: 2158
	// (get) Token: 0x06003AD9 RID: 15065
	// (set) Token: 0x06003ADA RID: 15066
	int PlacedSlotCount { get; set; }

	// Token: 0x1700086F RID: 2159
	// (get) Token: 0x06003ADB RID: 15067
	// (set) Token: 0x06003ADC RID: 15068
	int MaxSlotCount { get; set; }

	// Token: 0x17000870 RID: 2160
	// (get) Token: 0x06003ADD RID: 15069
	// (set) Token: 0x06003ADE RID: 15070
	bool RedDotShowState { get; set; }

	// Token: 0x17000871 RID: 2161
	// (get) Token: 0x06003ADF RID: 15071
	// (set) Token: 0x06003AE0 RID: 15072
	Action<int> OnSelected { get; set; }
}
