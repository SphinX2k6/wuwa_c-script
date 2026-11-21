using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AA RID: 29610
	public class IOpenSystemFunctionT
	{
		// Token: 0x1700D982 RID: 55682
		// (get) Token: 0x06033C7F RID: 212095 RVA: 0x006FC1DE File Offset: 0x006FA3DE
		// (set) Token: 0x06033C80 RID: 212096 RVA: 0x006FC1E6 File Offset: 0x006FA3E6
		public int FunctionId { get; set; }

		// Token: 0x06033C81 RID: 212097 RVA: 0x006FC1EF File Offset: 0x006FA3EF
		public IOpenSystemFunctionT()
		{
			this.FunctionId = 0;
		}
	}
}
