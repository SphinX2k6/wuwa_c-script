using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECE RID: 28366
	public class IRideFlyingCarT
	{
		// Token: 0x1700D317 RID: 54039
		// (get) Token: 0x06032219 RID: 205337 RVA: 0x006C6E14 File Offset: 0x006C5014
		// (set) Token: 0x0603221A RID: 205338 RVA: 0x006C6E1C File Offset: 0x006C501C
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D318 RID: 54040
		// (get) Token: 0x0603221B RID: 205339 RVA: 0x006C6E25 File Offset: 0x006C5025
		// (set) Token: 0x0603221C RID: 205340 RVA: 0x006C6E2D File Offset: 0x006C502D
		public int FirstPersonCameraTag { get; set; }

		// Token: 0x1700D319 RID: 54041
		// (get) Token: 0x0603221D RID: 205341 RVA: 0x006C6E36 File Offset: 0x006C5036
		// (set) Token: 0x0603221E RID: 205342 RVA: 0x006C6E3E File Offset: 0x006C503E
		public int ThirdPersonCameraTag { get; set; }

		// Token: 0x1700D31A RID: 54042
		// (get) Token: 0x0603221F RID: 205343 RVA: 0x006C6E47 File Offset: 0x006C5047
		// (set) Token: 0x06032220 RID: 205344 RVA: 0x006C6E4F File Offset: 0x006C504F
		public byte NullMask { get; set; }

		// Token: 0x06032221 RID: 205345 RVA: 0x006C6E58 File Offset: 0x006C5058
		public IRideFlyingCarT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.FirstPersonCameraTag = 0;
			this.ThirdPersonCameraTag = 0;
			this.NullMask = 0;
		}
	}
}
