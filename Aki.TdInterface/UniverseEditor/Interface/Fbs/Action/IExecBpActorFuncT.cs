using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D83 RID: 28035
	public class IExecBpActorFuncT
	{
		// Token: 0x1700CDA8 RID: 52648
		// (get) Token: 0x0603061E RID: 198174 RVA: 0x006930DD File Offset: 0x006912DD
		// (set) Token: 0x0603061F RID: 198175 RVA: 0x006930E5 File Offset: 0x006912E5
		public TBpActorFuncTypeUnion ExecFuncType { get; set; }

		// Token: 0x06030620 RID: 198176 RVA: 0x006930EE File Offset: 0x006912EE
		public IExecBpActorFuncT()
		{
			this.ExecFuncType = null;
		}
	}
}
