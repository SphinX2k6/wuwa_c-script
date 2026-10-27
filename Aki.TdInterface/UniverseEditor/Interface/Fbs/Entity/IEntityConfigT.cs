using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479A RID: 18330
	public class IEntityConfigT
	{
		// Token: 0x17008388 RID: 33672
		// (get) Token: 0x0601C409 RID: 115721 RVA: 0x003FFF85 File Offset: 0x003FE185
		// (set) Token: 0x0601C40A RID: 115722 RVA: 0x003FFF8D File Offset: 0x003FE18D
		public string ComponentsByEntity { get; set; }

		// Token: 0x0601C40B RID: 115723 RVA: 0x003FFF96 File Offset: 0x003FE196
		public IEntityConfigT()
		{
			this.ComponentsByEntity = null;
		}
	}
}
