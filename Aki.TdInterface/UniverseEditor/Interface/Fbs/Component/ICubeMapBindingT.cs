using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A8 RID: 21928
	public class ICubeMapBindingT
	{
		// Token: 0x17009D06 RID: 40198
		// (get) Token: 0x06022E23 RID: 142883 RVA: 0x004CDDBA File Offset: 0x004CBFBA
		// (set) Token: 0x06022E24 RID: 142884 RVA: 0x004CDDC2 File Offset: 0x004CBFC2
		public string CubeMapActorKey { get; set; }

		// Token: 0x17009D07 RID: 40199
		// (get) Token: 0x06022E25 RID: 142885 RVA: 0x004CDDCB File Offset: 0x004CBFCB
		// (set) Token: 0x06022E26 RID: 142886 RVA: 0x004CDDD3 File Offset: 0x004CBFD3
		public string CubeMapPath { get; set; }

		// Token: 0x06022E27 RID: 142887 RVA: 0x004CDDDC File Offset: 0x004CBFDC
		public ICubeMapBindingT()
		{
			this.CubeMapActorKey = null;
			this.CubeMapPath = null;
		}
	}
}
