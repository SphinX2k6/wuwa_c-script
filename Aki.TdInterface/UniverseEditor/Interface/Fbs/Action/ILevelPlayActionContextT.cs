using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EB RID: 27115
	public class ILevelPlayActionContextT
	{
		// Token: 0x1700C92B RID: 51499
		// (get) Token: 0x0602F705 RID: 194309 RVA: 0x006762B5 File Offset: 0x006744B5
		// (set) Token: 0x0602F706 RID: 194310 RVA: 0x006762BD File Offset: 0x006744BD
		public string Type { get; set; }

		// Token: 0x1700C92C RID: 51500
		// (get) Token: 0x0602F707 RID: 194311 RVA: 0x006762C6 File Offset: 0x006744C6
		// (set) Token: 0x0602F708 RID: 194312 RVA: 0x006762CE File Offset: 0x006744CE
		public EDecisionBtType DecisionBtType { get; set; }

		// Token: 0x1700C92D RID: 51501
		// (get) Token: 0x0602F709 RID: 194313 RVA: 0x006762D7 File Offset: 0x006744D7
		// (set) Token: 0x0602F70A RID: 194314 RVA: 0x006762DF File Offset: 0x006744DF
		public byte NullMask { get; set; }

		// Token: 0x0602F70B RID: 194315 RVA: 0x006762E8 File Offset: 0x006744E8
		public ILevelPlayActionContextT()
		{
			this.Type = null;
			this.DecisionBtType = EDecisionBtType.Bvb;
			this.NullMask = 0;
		}
	}
}
