using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006279 RID: 25209
	public class ICameraDepthOfFieldT
	{
		// Token: 0x1700BBE0 RID: 48096
		// (get) Token: 0x0602B839 RID: 178233 RVA: 0x005FDCBA File Offset: 0x005FBEBA
		// (set) Token: 0x0602B83A RID: 178234 RVA: 0x005FDCC2 File Offset: 0x005FBEC2
		public float Fstop { get; set; }

		// Token: 0x1700BBE1 RID: 48097
		// (get) Token: 0x0602B83B RID: 178235 RVA: 0x005FDCCB File Offset: 0x005FBECB
		// (set) Token: 0x0602B83C RID: 178236 RVA: 0x005FDCD3 File Offset: 0x005FBED3
		public float Distance { get; set; }

		// Token: 0x1700BBE2 RID: 48098
		// (get) Token: 0x0602B83D RID: 178237 RVA: 0x005FDCDC File Offset: 0x005FBEDC
		// (set) Token: 0x0602B83E RID: 178238 RVA: 0x005FDCE4 File Offset: 0x005FBEE4
		public float BlurAmount { get; set; }

		// Token: 0x1700BBE3 RID: 48099
		// (get) Token: 0x0602B83F RID: 178239 RVA: 0x005FDCED File Offset: 0x005FBEED
		// (set) Token: 0x0602B840 RID: 178240 RVA: 0x005FDCF5 File Offset: 0x005FBEF5
		public float BlurRadius { get; set; }

		// Token: 0x1700BBE4 RID: 48100
		// (get) Token: 0x0602B841 RID: 178241 RVA: 0x005FDCFE File Offset: 0x005FBEFE
		// (set) Token: 0x0602B842 RID: 178242 RVA: 0x005FDD06 File Offset: 0x005FBF06
		public byte NullMask { get; set; }

		// Token: 0x0602B843 RID: 178243 RVA: 0x005FDD0F File Offset: 0x005FBF0F
		public ICameraDepthOfFieldT()
		{
			this.Fstop = 0f;
			this.Distance = 0f;
			this.BlurAmount = 0f;
			this.BlurRadius = 0f;
			this.NullMask = 0;
		}
	}
}
