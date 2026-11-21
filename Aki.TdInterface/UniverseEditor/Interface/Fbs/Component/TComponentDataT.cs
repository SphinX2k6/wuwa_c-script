using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006214 RID: 25108
	public class TComponentDataT
	{
		// Token: 0x1700BB1E RID: 47902
		// (get) Token: 0x0602AC27 RID: 175143 RVA: 0x005D756B File Offset: 0x005D576B
		// (set) Token: 0x0602AC28 RID: 175144 RVA: 0x005D7573 File Offset: 0x005D5773
		public string Key { get; set; }

		// Token: 0x1700BB1F RID: 47903
		// (get) Token: 0x0602AC29 RID: 175145 RVA: 0x005D757C File Offset: 0x005D577C
		// (set) Token: 0x0602AC2A RID: 175146 RVA: 0x005D7584 File Offset: 0x005D5784
		public IComponentBase_UnionUnion Value { get; set; }

		// Token: 0x0602AC2B RID: 175147 RVA: 0x005D758D File Offset: 0x005D578D
		public TComponentDataT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
