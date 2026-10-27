using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B1 RID: 26545
	public class IFireBulletT
	{
		// Token: 0x1700C500 RID: 50432
		// (get) Token: 0x0602E315 RID: 189205 RVA: 0x0064EEF9 File Offset: 0x0064D0F9
		// (set) Token: 0x0602E316 RID: 189206 RVA: 0x0064EF01 File Offset: 0x0064D101
		public TFireBulletUnion Type { get; set; }

		// Token: 0x1700C501 RID: 50433
		// (get) Token: 0x0602E317 RID: 189207 RVA: 0x0064EF0A File Offset: 0x0064D10A
		// (set) Token: 0x0602E318 RID: 189208 RVA: 0x0064EF12 File Offset: 0x0064D112
		public EBulletLauncher Launcher { get; set; }

		// Token: 0x1700C502 RID: 50434
		// (get) Token: 0x0602E319 RID: 189209 RVA: 0x0064EF1B File Offset: 0x0064D11B
		// (set) Token: 0x0602E31A RID: 189210 RVA: 0x0064EF23 File Offset: 0x0064D123
		public byte NullMask { get; set; }

		// Token: 0x0602E31B RID: 189211 RVA: 0x0064EF2C File Offset: 0x0064D12C
		public IFireBulletT()
		{
			this.Type = null;
			this.Launcher = EBulletLauncher.Player;
			this.NullMask = 0;
		}
	}
}
