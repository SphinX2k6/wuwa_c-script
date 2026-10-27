using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEF RID: 27631
	public class IOnetimeGamepadShakeT
	{
		// Token: 0x1700CD65 RID: 52581
		// (get) Token: 0x060308E6 RID: 198886 RVA: 0x00697553 File Offset: 0x00695753
		// (set) Token: 0x060308E7 RID: 198887 RVA: 0x0069755B File Offset: 0x0069575B
		public EGamepadShakeType Type { get; set; }

		// Token: 0x1700CD66 RID: 52582
		// (get) Token: 0x060308E8 RID: 198888 RVA: 0x00697564 File Offset: 0x00695764
		// (set) Token: 0x060308E9 RID: 198889 RVA: 0x0069756C File Offset: 0x0069576C
		public bool IsIgnoreTimeDilation { get; set; }

		// Token: 0x1700CD67 RID: 52583
		// (get) Token: 0x060308EA RID: 198890 RVA: 0x00697575 File Offset: 0x00695775
		// (set) Token: 0x060308EB RID: 198891 RVA: 0x0069757D File Offset: 0x0069577D
		public string GamepadShakeTag { get; set; }

		// Token: 0x1700CD68 RID: 52584
		// (get) Token: 0x060308EC RID: 198892 RVA: 0x00697586 File Offset: 0x00695786
		// (set) Token: 0x060308ED RID: 198893 RVA: 0x0069758E File Offset: 0x0069578E
		public byte NullMask { get; set; }

		// Token: 0x060308EE RID: 198894 RVA: 0x00697597 File Offset: 0x00695797
		public IOnetimeGamepadShakeT()
		{
			this.Type = EGamepadShakeType.Onetime;
			this.IsIgnoreTimeDilation = false;
			this.GamepadShakeTag = null;
			this.NullMask = 0;
		}
	}
}
