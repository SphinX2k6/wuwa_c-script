using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005163 RID: 20835
	public class IEntityBatchTypeT
	{
		// Token: 0x170097FC RID: 38908
		// (get) Token: 0x06021A4A RID: 137802 RVA: 0x004AB45E File Offset: 0x004A965E
		// (set) Token: 0x06021A4B RID: 137803 RVA: 0x004AB466 File Offset: 0x004A9666
		public EEntityBatchType Type { get; set; }

		// Token: 0x06021A4C RID: 137804 RVA: 0x004AB46F File Offset: 0x004A966F
		public IEntityBatchTypeT()
		{
			this.Type = EEntityBatchType.EntityList;
		}
	}
}
