using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

// Token: 0x02000232 RID: 562
[NullableContext(1)]
public interface ICapabilityDebugRecord
{
	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x060022B1 RID: 8881
	// (set) Token: 0x060022B2 RID: 8882
	int Seq { get; set; }

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x060022B3 RID: 8883
	// (set) Token: 0x060022B4 RID: 8884
	double Time { get; set; }

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x060022B5 RID: 8885
	// (set) Token: 0x060022B6 RID: 8886
	CapabilityCommonDefine.ECapabilityDebugEvent Event { get; set; }

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x060022B7 RID: 8887
	// (set) Token: 0x060022B8 RID: 8888
	string CapabilityId { get; set; }

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x060022B9 RID: 8889
	// (set) Token: 0x060022BA RID: 8890
	string GameObjectId { get; set; }

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x060022BB RID: 8891
	// (set) Token: 0x060022BC RID: 8892
	string ClassName { get; set; }

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x060022BD RID: 8893
	// (set) Token: 0x060022BE RID: 8894
	[Nullable(2)]
	string Detail { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x060022BF RID: 8895
	// (set) Token: 0x060022C0 RID: 8896
	double? DurationMs { get; set; }
}
