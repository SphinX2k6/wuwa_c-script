using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED5 RID: 16085
	public class ISystemVarBaseT
	{
		// Token: 0x17006CE9 RID: 27881
		// (get) Token: 0x06015C7D RID: 89213 RVA: 0x003222A6 File Offset: 0x003204A6
		// (set) Token: 0x06015C7E RID: 89214 RVA: 0x003222AE File Offset: 0x003204AE
		public ESystemVarName Type { get; set; }

		// Token: 0x06015C7F RID: 89215 RVA: 0x003222B7 File Offset: 0x003204B7
		public ISystemVarBaseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
