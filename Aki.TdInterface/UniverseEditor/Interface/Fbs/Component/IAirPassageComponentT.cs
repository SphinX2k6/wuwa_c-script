using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E87 RID: 20103
	public class IAirPassageComponentT
	{
		// Token: 0x17009010 RID: 36880
		// (get) Token: 0x0601F9CC RID: 129484 RVA: 0x004672AC File Offset: 0x004654AC
		// (set) Token: 0x0601F9CD RID: 129485 RVA: 0x004672B4 File Offset: 0x004654B4
		public bool Disabled { get; set; }

		// Token: 0x17009011 RID: 36881
		// (get) Token: 0x0601F9CE RID: 129486 RVA: 0x004672BD File Offset: 0x004654BD
		// (set) Token: 0x0601F9CF RID: 129487 RVA: 0x004672C5 File Offset: 0x004654C5
		public byte NullMask { get; set; }

		// Token: 0x0601F9D0 RID: 129488 RVA: 0x004672CE File Offset: 0x004654CE
		public IAirPassageComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
