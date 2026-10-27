using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200528F RID: 21135
	public class IFollowDecorationComponentT
	{
		// Token: 0x17009AFA RID: 39674
		// (get) Token: 0x06022718 RID: 141080 RVA: 0x004C685D File Offset: 0x004C4A5D
		// (set) Token: 0x06022719 RID: 141081 RVA: 0x004C6865 File Offset: 0x004C4A65
		public bool Disabled { get; set; }

		// Token: 0x17009AFB RID: 39675
		// (get) Token: 0x0602271A RID: 141082 RVA: 0x004C686E File Offset: 0x004C4A6E
		// (set) Token: 0x0602271B RID: 141083 RVA: 0x004C6876 File Offset: 0x004C4A76
		public IFollowDecorationChairConfigT DecorationConfig { get; set; }

		// Token: 0x17009AFC RID: 39676
		// (get) Token: 0x0602271C RID: 141084 RVA: 0x004C687F File Offset: 0x004C4A7F
		// (set) Token: 0x0602271D RID: 141085 RVA: 0x004C6887 File Offset: 0x004C4A87
		public byte NullMask { get; set; }

		// Token: 0x0602271E RID: 141086 RVA: 0x004C6890 File Offset: 0x004C4A90
		public IFollowDecorationComponentT()
		{
			this.Disabled = false;
			this.DecorationConfig = null;
			this.NullMask = 0;
		}
	}
}
