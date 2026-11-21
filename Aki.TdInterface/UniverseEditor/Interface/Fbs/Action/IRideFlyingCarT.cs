using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007652 RID: 30290
	public class IRideFlyingCarT
	{
		// Token: 0x1700DE6E RID: 56942
		// (get) Token: 0x06035259 RID: 217689 RVA: 0x00722B48 File Offset: 0x00720D48
		// (set) Token: 0x0603525A RID: 217690 RVA: 0x00722B50 File Offset: 0x00720D50
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DE6F RID: 56943
		// (get) Token: 0x0603525B RID: 217691 RVA: 0x00722B59 File Offset: 0x00720D59
		// (set) Token: 0x0603525C RID: 217692 RVA: 0x00722B61 File Offset: 0x00720D61
		public int FirstPersonCameraTag { get; set; }

		// Token: 0x1700DE70 RID: 56944
		// (get) Token: 0x0603525D RID: 217693 RVA: 0x00722B6A File Offset: 0x00720D6A
		// (set) Token: 0x0603525E RID: 217694 RVA: 0x00722B72 File Offset: 0x00720D72
		public int ThirdPersonCameraTag { get; set; }

		// Token: 0x1700DE71 RID: 56945
		// (get) Token: 0x0603525F RID: 217695 RVA: 0x00722B7B File Offset: 0x00720D7B
		// (set) Token: 0x06035260 RID: 217696 RVA: 0x00722B83 File Offset: 0x00720D83
		public byte NullMask { get; set; }

		// Token: 0x06035261 RID: 217697 RVA: 0x00722B8C File Offset: 0x00720D8C
		public IRideFlyingCarT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.FirstPersonCameraTag = 0;
			this.ThirdPersonCameraTag = 0;
			this.NullMask = 0;
		}
	}
}
