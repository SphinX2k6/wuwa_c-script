using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C9 RID: 25801
	public class IContinualGamepadShakeT
	{
		// Token: 0x1700C002 RID: 49154
		// (get) Token: 0x0602CC18 RID: 183320 RVA: 0x00626DB7 File Offset: 0x00624FB7
		// (set) Token: 0x0602CC19 RID: 183321 RVA: 0x00626DBF File Offset: 0x00624FBF
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700C003 RID: 49155
		// (get) Token: 0x0602CC1A RID: 183322 RVA: 0x00626DC8 File Offset: 0x00624FC8
		// (set) Token: 0x0602CC1B RID: 183323 RVA: 0x00626DD0 File Offset: 0x00624FD0
		public bool IsIgnoreTimeDilation { get; set; }

		// Token: 0x1700C004 RID: 49156
		// (get) Token: 0x0602CC1C RID: 183324 RVA: 0x00626DD9 File Offset: 0x00624FD9
		// (set) Token: 0x0602CC1D RID: 183325 RVA: 0x00626DE1 File Offset: 0x00624FE1
		public float Duration { get; set; }

		// Token: 0x1700C005 RID: 49157
		// (get) Token: 0x0602CC1E RID: 183326 RVA: 0x00626DEA File Offset: 0x00624FEA
		// (set) Token: 0x0602CC1F RID: 183327 RVA: 0x00626DF2 File Offset: 0x00624FF2
		public bool IsLoop { get; set; }

		// Token: 0x1700C006 RID: 49158
		// (get) Token: 0x0602CC20 RID: 183328 RVA: 0x00626DFB File Offset: 0x00624FFB
		// (set) Token: 0x0602CC21 RID: 183329 RVA: 0x00626E03 File Offset: 0x00625003
		public string GamepadShakeTag { get; set; }

		// Token: 0x1700C007 RID: 49159
		// (get) Token: 0x0602CC22 RID: 183330 RVA: 0x00626E0C File Offset: 0x0062500C
		// (set) Token: 0x0602CC23 RID: 183331 RVA: 0x00626E14 File Offset: 0x00625014
		public byte NullMask { get; set; }

		// Token: 0x0602CC24 RID: 183332 RVA: 0x00626E1D File Offset: 0x0062501D
		public IContinualGamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.IsIgnoreTimeDilation = false;
			this.Duration = 0f;
			this.IsLoop = false;
			this.GamepadShakeTag = null;
			this.NullMask = 0;
		}
	}
}
