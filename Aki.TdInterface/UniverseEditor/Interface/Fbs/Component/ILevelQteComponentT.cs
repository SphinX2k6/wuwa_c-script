using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EC RID: 21740
	public class ILevelQteComponentT
	{
		// Token: 0x1700A05F RID: 41055
		// (get) Token: 0x06023DF1 RID: 146929 RVA: 0x004F5B15 File Offset: 0x004F3D15
		// (set) Token: 0x06023DF2 RID: 146930 RVA: 0x004F5B1D File Offset: 0x004F3D1D
		public bool Disabled { get; set; }

		// Token: 0x1700A060 RID: 41056
		// (get) Token: 0x06023DF3 RID: 146931 RVA: 0x004F5B26 File Offset: 0x004F3D26
		// (set) Token: 0x06023DF4 RID: 146932 RVA: 0x004F5B2E File Offset: 0x004F3D2E
		public ISingleBtnQteT QteConfig { get; set; }

		// Token: 0x1700A061 RID: 41057
		// (get) Token: 0x06023DF5 RID: 146933 RVA: 0x004F5B37 File Offset: 0x004F3D37
		// (set) Token: 0x06023DF6 RID: 146934 RVA: 0x004F5B3F File Offset: 0x004F3D3F
		public byte NullMask { get; set; }

		// Token: 0x06023DF7 RID: 146935 RVA: 0x004F5B48 File Offset: 0x004F3D48
		public ILevelQteComponentT()
		{
			this.Disabled = false;
			this.QteConfig = null;
			this.NullMask = 0;
		}
	}
}
