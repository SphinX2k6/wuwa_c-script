using System;
using System.Runtime.CompilerServices;

// Token: 0x0200225C RID: 8796
[NullableContext(2)]
public interface IMotorTechLevelPoint
{
	// Token: 0x170015DD RID: 5597
	// (get) Token: 0x06011275 RID: 70261
	// (set) Token: 0x06011276 RID: 70262
	string Title { get; set; }

	// Token: 0x170015DE RID: 5598
	// (get) Token: 0x06011277 RID: 70263
	// (set) Token: 0x06011278 RID: 70264
	string Desc { get; set; }

	// Token: 0x170015DF RID: 5599
	// (get) Token: 0x06011279 RID: 70265
	// (set) Token: 0x0601127A RID: 70266
	int TargetLevel { get; set; }

	// Token: 0x170015E0 RID: 5600
	// (get) Token: 0x0601127B RID: 70267
	// (set) Token: 0x0601127C RID: 70268
	int CurLevel { get; set; }
}
