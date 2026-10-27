using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B03 RID: 23299
	public class IUnUseComponentT
	{
		// Token: 0x1700AFC8 RID: 45000
		// (get) Token: 0x06027C86 RID: 162950 RVA: 0x00578C2C File Offset: 0x00576E2C
		// (set) Token: 0x06027C87 RID: 162951 RVA: 0x00578C34 File Offset: 0x00576E34
		public bool Disabled { get; set; }

		// Token: 0x1700AFC9 RID: 45001
		// (get) Token: 0x06027C88 RID: 162952 RVA: 0x00578C3D File Offset: 0x00576E3D
		// (set) Token: 0x06027C89 RID: 162953 RVA: 0x00578C45 File Offset: 0x00576E45
		public byte NullMask { get; set; }

		// Token: 0x06027C8A RID: 162954 RVA: 0x00578C4E File Offset: 0x00576E4E
		public IUnUseComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
