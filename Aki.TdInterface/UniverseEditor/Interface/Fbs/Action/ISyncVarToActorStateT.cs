using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A50 RID: 31312
	public class ISyncVarToActorStateT
	{
		// Token: 0x1700E56B RID: 58731
		// (get) Token: 0x06037303 RID: 226051 RVA: 0x0075F4DE File Offset: 0x0075D6DE
		// (set) Token: 0x06037304 RID: 226052 RVA: 0x0075F4E6 File Offset: 0x0075D6E6
		public string VarName { get; set; }

		// Token: 0x1700E56C RID: 58732
		// (get) Token: 0x06037305 RID: 226053 RVA: 0x0075F4EF File Offset: 0x0075D6EF
		// (set) Token: 0x06037306 RID: 226054 RVA: 0x0075F4F7 File Offset: 0x0075D6F7
		public string StateKey { get; set; }

		// Token: 0x06037307 RID: 226055 RVA: 0x0075F500 File Offset: 0x0075D700
		public ISyncVarToActorStateT()
		{
			this.VarName = null;
			this.StateKey = null;
		}
	}
}
