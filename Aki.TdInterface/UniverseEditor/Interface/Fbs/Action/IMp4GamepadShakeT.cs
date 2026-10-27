using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B80 RID: 27520
	public class IMp4GamepadShakeT
	{
		// Token: 0x1700CC91 RID: 52369
		// (get) Token: 0x06030549 RID: 197961 RVA: 0x006910F9 File Offset: 0x0068F2F9
		// (set) Token: 0x0603054A RID: 197962 RVA: 0x00691101 File Offset: 0x0068F301
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700CC92 RID: 52370
		// (get) Token: 0x0603054B RID: 197963 RVA: 0x0069110A File Offset: 0x0068F30A
		// (set) Token: 0x0603054C RID: 197964 RVA: 0x00691112 File Offset: 0x0068F312
		public IMp4GamepadShakeFadeInConfigT FadeInConfig { get; set; }

		// Token: 0x1700CC93 RID: 52371
		// (get) Token: 0x0603054D RID: 197965 RVA: 0x0069111B File Offset: 0x0068F31B
		// (set) Token: 0x0603054E RID: 197966 RVA: 0x00691123 File Offset: 0x0068F323
		public IMp4GamepadShakeFadeOutConfigT FadeOutConfig { get; set; }

		// Token: 0x1700CC94 RID: 52372
		// (get) Token: 0x0603054F RID: 197967 RVA: 0x0069112C File Offset: 0x0068F32C
		// (set) Token: 0x06030550 RID: 197968 RVA: 0x00691134 File Offset: 0x0068F334
		public float ShakeScale { get; set; }

		// Token: 0x1700CC95 RID: 52373
		// (get) Token: 0x06030551 RID: 197969 RVA: 0x0069113D File Offset: 0x0068F33D
		// (set) Token: 0x06030552 RID: 197970 RVA: 0x00691145 File Offset: 0x0068F345
		public byte NullMask { get; set; }

		// Token: 0x06030553 RID: 197971 RVA: 0x0069114E File Offset: 0x0068F34E
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
