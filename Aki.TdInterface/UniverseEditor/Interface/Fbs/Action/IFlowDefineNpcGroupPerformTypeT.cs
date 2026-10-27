using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006802 RID: 26626
	public class IFlowDefineNpcGroupPerformTypeT
	{
		// Token: 0x1700C5A0 RID: 50592
		// (get) Token: 0x0602E5DA RID: 189914 RVA: 0x006541BA File Offset: 0x006523BA
		// (set) Token: 0x0602E5DB RID: 189915 RVA: 0x006541C2 File Offset: 0x006523C2
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x0602E5DC RID: 189916 RVA: 0x006541CB File Offset: 0x006523CB
		public IFlowDefineNpcGroupPerformTypeT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
		}
	}
}
