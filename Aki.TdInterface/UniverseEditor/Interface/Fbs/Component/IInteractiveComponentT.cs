using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005459 RID: 21593
	public class IInteractiveComponentT
	{
		// Token: 0x17009EFF RID: 40703
		// (get) Token: 0x0602385F RID: 145503 RVA: 0x004EA22A File Offset: 0x004E842A
		// (set) Token: 0x06023860 RID: 145504 RVA: 0x004EA232 File Offset: 0x004E8432
		public bool Disabled { get; set; }

		// Token: 0x17009F00 RID: 40704
		// (get) Token: 0x06023861 RID: 145505 RVA: 0x004EA23B File Offset: 0x004E843B
		// (set) Token: 0x06023862 RID: 145506 RVA: 0x004EA243 File Offset: 0x004E8443
		public string Content { get; set; }

		// Token: 0x17009F01 RID: 40705
		// (get) Token: 0x06023863 RID: 145507 RVA: 0x004EA24C File Offset: 0x004E844C
		// (set) Token: 0x06023864 RID: 145508 RVA: 0x004EA254 File Offset: 0x004E8454
		public string Icon { get; set; }

		// Token: 0x17009F02 RID: 40706
		// (get) Token: 0x06023865 RID: 145509 RVA: 0x004EA25D File Offset: 0x004E845D
		// (set) Token: 0x06023866 RID: 145510 RVA: 0x004EA265 File Offset: 0x004E8465
		public byte NullMask { get; set; }

		// Token: 0x06023867 RID: 145511 RVA: 0x004EA26E File Offset: 0x004E846E
		public IInteractiveComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.NullMask = 0;
		}
	}
}
