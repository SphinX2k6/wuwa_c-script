using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042C4 RID: 17092
	public class IllustratedTokenDataInfo : IIllustratedTokenDataInfo
	{
		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x0602B4A7 RID: 177319 RVA: 0x00C2A0B8 File Offset: 0x00C282B8
		// (set) Token: 0x0602B4A8 RID: 177320 RVA: 0x00C2A0C0 File Offset: 0x00C282C0
		public int ConfigId { get; set; }

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x0602B4A9 RID: 177321 RVA: 0x00C2A0C9 File Offset: 0x00C282C9
		// (set) Token: 0x0602B4AA RID: 177322 RVA: 0x00C2A0D1 File Offset: 0x00C282D1
		public int CollectionIndex { get; set; }

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x0602B4AB RID: 177323 RVA: 0x00C2A0DA File Offset: 0x00C282DA
		// (set) Token: 0x0602B4AC RID: 177324 RVA: 0x00C2A0E2 File Offset: 0x00C282E2
		public bool IsLock { get; set; }

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x0602B4AD RID: 177325 RVA: 0x00C2A0EB File Offset: 0x00C282EB
		// (set) Token: 0x0602B4AE RID: 177326 RVA: 0x00C2A0F3 File Offset: 0x00C282F3
		public bool HasRedDot { get; set; }

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x0602B4AF RID: 177327 RVA: 0x00C2A0FC File Offset: 0x00C282FC
		// (set) Token: 0x0602B4B0 RID: 177328 RVA: 0x00C2A104 File Offset: 0x00C28304
		public bool IsSelectOn { get; set; }
	}
}
