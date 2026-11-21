using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D6 RID: 27094
	public class ICheckFlowLookAtPlayerT
	{
		// Token: 0x1700C760 RID: 51040
		// (get) Token: 0x0602E7C5 RID: 190405 RVA: 0x00657A6E File Offset: 0x00655C6E
		// (set) Token: 0x0602E7C6 RID: 190406 RVA: 0x00657A76 File Offset: 0x00655C76
		public ECheckFlowLookAtTargetType Type { get; set; }

		// Token: 0x0602E7C7 RID: 190407 RVA: 0x00657A7F File Offset: 0x00655C7F
		public ICheckFlowLookAtPlayerT()
		{
			this.Type = ECheckFlowLookAtTargetType.Entity;
		}
	}
}
