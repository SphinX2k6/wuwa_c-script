using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F5F RID: 20319
	public class ICategoryMatchingAnimationBaseT
	{
		// Token: 0x170092B2 RID: 37554
		// (get) Token: 0x06020391 RID: 131985 RVA: 0x0047BD36 File Offset: 0x00479F36
		// (set) Token: 0x06020392 RID: 131986 RVA: 0x0047BD3E File Offset: 0x00479F3E
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x170092B3 RID: 37555
		// (get) Token: 0x06020393 RID: 131987 RVA: 0x0047BD47 File Offset: 0x00479F47
		// (set) Token: 0x06020394 RID: 131988 RVA: 0x0047BD4F File Offset: 0x00479F4F
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x170092B4 RID: 37556
		// (get) Token: 0x06020395 RID: 131989 RVA: 0x0047BD58 File Offset: 0x00479F58
		// (set) Token: 0x06020396 RID: 131990 RVA: 0x0047BD60 File Offset: 0x00479F60
		public string MatchReferenceKey { get; set; }

		// Token: 0x06020397 RID: 131991 RVA: 0x0047BD69 File Offset: 0x00479F69
		public ICategoryMatchingAnimationBaseT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
		}
	}
}
