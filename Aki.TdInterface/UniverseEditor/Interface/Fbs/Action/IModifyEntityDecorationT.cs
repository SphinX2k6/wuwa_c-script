using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F0 RID: 29168
	public class IModifyEntityDecorationT
	{
		// Token: 0x1700D58A RID: 54666
		// (get) Token: 0x06032BF0 RID: 207856 RVA: 0x006DAE8F File Offset: 0x006D908F
		// (set) Token: 0x06032BF1 RID: 207857 RVA: 0x006DAE97 File Offset: 0x006D9097
		public int EntityId { get; set; }

		// Token: 0x1700D58B RID: 54667
		// (get) Token: 0x06032BF2 RID: 207858 RVA: 0x006DAEA0 File Offset: 0x006D90A0
		// (set) Token: 0x06032BF3 RID: 207859 RVA: 0x006DAEA8 File Offset: 0x006D90A8
		public TEntityDecorationConfigUnion Config { get; set; }

		// Token: 0x06032BF4 RID: 207860 RVA: 0x006DAEB1 File Offset: 0x006D90B1
		public IModifyEntityDecorationT()
		{
			this.EntityId = 0;
			this.Config = null;
		}
	}
}
