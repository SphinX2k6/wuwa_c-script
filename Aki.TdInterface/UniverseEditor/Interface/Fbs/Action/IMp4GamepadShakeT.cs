using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C6 RID: 29382
	public class IMp4GamepadShakeT
	{
		// Token: 0x1700D776 RID: 55158
		// (get) Token: 0x060333A1 RID: 209825 RVA: 0x006E9719 File Offset: 0x006E7919
		// (set) Token: 0x060333A2 RID: 209826 RVA: 0x006E9721 File Offset: 0x006E7921
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700D777 RID: 55159
		// (get) Token: 0x060333A3 RID: 209827 RVA: 0x006E972A File Offset: 0x006E792A
		// (set) Token: 0x060333A4 RID: 209828 RVA: 0x006E9732 File Offset: 0x006E7932
		public IMp4GamepadShakeFadeInConfigT FadeInConfig { get; set; }

		// Token: 0x1700D778 RID: 55160
		// (get) Token: 0x060333A5 RID: 209829 RVA: 0x006E973B File Offset: 0x006E793B
		// (set) Token: 0x060333A6 RID: 209830 RVA: 0x006E9743 File Offset: 0x006E7943
		public IMp4GamepadShakeFadeOutConfigT FadeOutConfig { get; set; }

		// Token: 0x1700D779 RID: 55161
		// (get) Token: 0x060333A7 RID: 209831 RVA: 0x006E974C File Offset: 0x006E794C
		// (set) Token: 0x060333A8 RID: 209832 RVA: 0x006E9754 File Offset: 0x006E7954
		public float ShakeScale { get; set; }

		// Token: 0x1700D77A RID: 55162
		// (get) Token: 0x060333A9 RID: 209833 RVA: 0x006E975D File Offset: 0x006E795D
		// (set) Token: 0x060333AA RID: 209834 RVA: 0x006E9765 File Offset: 0x006E7965
		public byte NullMask { get; set; }

		// Token: 0x060333AB RID: 209835 RVA: 0x006E976E File Offset: 0x006E796E
		public IMp4GamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.FadeInConfig = null;
			this.FadeOutConfig = null;
			this.ShakeScale = 0f;
			this.NullMask = 0;
		}
	}
}
