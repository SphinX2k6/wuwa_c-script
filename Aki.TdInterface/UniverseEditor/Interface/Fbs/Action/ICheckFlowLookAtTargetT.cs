using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D9 RID: 27097
	public class ICheckFlowLookAtTargetT
	{
		// Token: 0x1700C763 RID: 51043
		// (get) Token: 0x0602E7D7 RID: 190423 RVA: 0x00657BE6 File Offset: 0x00655DE6
		// (set) Token: 0x0602E7D8 RID: 190424 RVA: 0x00657BEE File Offset: 0x00655DEE
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x0602E7D9 RID: 190425 RVA: 0x00657BF7 File Offset: 0x00655DF7
		public ICheckFlowLookAtTargetT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
		}
	}
}
