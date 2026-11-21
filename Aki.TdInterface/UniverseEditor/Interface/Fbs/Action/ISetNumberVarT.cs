using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007813 RID: 30739
	public class ISetNumberVarT
	{
		// Token: 0x1700E160 RID: 57696
		// (get) Token: 0x0603606C RID: 221292 RVA: 0x0073CB53 File Offset: 0x0073AD53
		// (set) Token: 0x0603606D RID: 221293 RVA: 0x0073CB5B File Offset: 0x0073AD5B
		public string Name { get; set; }

		// Token: 0x1700E161 RID: 57697
		// (get) Token: 0x0603606E RID: 221294 RVA: 0x0073CB64 File Offset: 0x0073AD64
		// (set) Token: 0x0603606F RID: 221295 RVA: 0x0073CB6C File Offset: 0x0073AD6C
		public TVarValueUnion Value { get; set; }

		// Token: 0x06036070 RID: 221296 RVA: 0x0073CB75 File Offset: 0x0073AD75
		public ISetNumberVarT()
		{
			this.Name = null;
			this.Value = null;
		}
	}
}
