using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007353 RID: 29523
	public class IOnetimeGamepadShakeT
	{
		// Token: 0x1700D871 RID: 55409
		// (get) Token: 0x06033802 RID: 210946 RVA: 0x006F0E53 File Offset: 0x006EF053
		// (set) Token: 0x06033803 RID: 210947 RVA: 0x006F0E5B File Offset: 0x006EF05B
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700D872 RID: 55410
		// (get) Token: 0x06033804 RID: 210948 RVA: 0x006F0E64 File Offset: 0x006EF064
		// (set) Token: 0x06033805 RID: 210949 RVA: 0x006F0E6C File Offset: 0x006EF06C
		public bool IsIgnoreTimeDilation { get; set; }

		// Token: 0x1700D873 RID: 55411
		// (get) Token: 0x06033806 RID: 210950 RVA: 0x006F0E75 File Offset: 0x006EF075
		// (set) Token: 0x06033807 RID: 210951 RVA: 0x006F0E7D File Offset: 0x006EF07D
		public string GamepadShakeTag { get; set; }

		// Token: 0x1700D874 RID: 55412
		// (get) Token: 0x06033808 RID: 210952 RVA: 0x006F0E86 File Offset: 0x006EF086
		// (set) Token: 0x06033809 RID: 210953 RVA: 0x006F0E8E File Offset: 0x006EF08E
		public byte NullMask { get; set; }

		// Token: 0x0603380A RID: 210954 RVA: 0x006F0E97 File Offset: 0x006EF097
		public IOnetimeGamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.IsIgnoreTimeDilation = false;
			this.GamepadShakeTag = null;
			this.NullMask = 0;
		}
	}
}
