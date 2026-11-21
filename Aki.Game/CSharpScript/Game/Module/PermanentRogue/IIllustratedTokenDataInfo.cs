using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042C3 RID: 17091
	public interface IIllustratedTokenDataInfo
	{
		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x0602B49D RID: 177309
		// (set) Token: 0x0602B49E RID: 177310
		int ConfigId { get; set; }

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x0602B49F RID: 177311
		// (set) Token: 0x0602B4A0 RID: 177312
		int CollectionIndex { get; set; }

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x0602B4A1 RID: 177313
		// (set) Token: 0x0602B4A2 RID: 177314
		bool IsLock { get; set; }

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x0602B4A3 RID: 177315
		// (set) Token: 0x0602B4A4 RID: 177316
		bool HasRedDot { get; set; }

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x0602B4A5 RID: 177317
		// (set) Token: 0x0602B4A6 RID: 177318
		bool IsSelectOn { get; set; }
	}
}
