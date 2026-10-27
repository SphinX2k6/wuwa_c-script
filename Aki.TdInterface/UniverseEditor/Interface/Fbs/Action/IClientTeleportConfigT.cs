using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F8 RID: 25592
	public class IClientTeleportConfigT
	{
		// Token: 0x1700BE95 RID: 48789
		// (get) Token: 0x0602C463 RID: 181347 RVA: 0x0061391A File Offset: 0x00611B1A
		// (set) Token: 0x0602C464 RID: 181348 RVA: 0x00613922 File Offset: 0x00611B22
		public EClientTeleportType Type { get; set; }

		// Token: 0x0602C465 RID: 181349 RVA: 0x0061392B File Offset: 0x00611B2B
		public IClientTeleportConfigT()
		{
			this.Type = EClientTeleportType.RelativeEntityPos;
		}
	}
}
