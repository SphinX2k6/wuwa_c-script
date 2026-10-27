using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F7D RID: 20349
	public class ICharacterConnectorComponentT
	{
		// Token: 0x17009312 RID: 37650
		// (get) Token: 0x060204E1 RID: 132321 RVA: 0x0047E9AD File Offset: 0x0047CBAD
		// (set) Token: 0x060204E2 RID: 132322 RVA: 0x0047E9B5 File Offset: 0x0047CBB5
		public bool Disabled { get; set; }

		// Token: 0x17009313 RID: 37651
		// (get) Token: 0x060204E3 RID: 132323 RVA: 0x0047E9BE File Offset: 0x0047CBBE
		// (set) Token: 0x060204E4 RID: 132324 RVA: 0x0047E9C6 File Offset: 0x0047CBC6
		public ICharacterConnectorRangeT LogicType { get; set; }

		// Token: 0x17009314 RID: 37652
		// (get) Token: 0x060204E5 RID: 132325 RVA: 0x0047E9CF File Offset: 0x0047CBCF
		// (set) Token: 0x060204E6 RID: 132326 RVA: 0x0047E9D7 File Offset: 0x0047CBD7
		public byte NullMask { get; set; }

		// Token: 0x060204E7 RID: 132327 RVA: 0x0047E9E0 File Offset: 0x0047CBE0
		public ICharacterConnectorComponentT()
		{
			this.Disabled = false;
			this.LogicType = null;
			this.NullMask = 0;
		}
	}
}
