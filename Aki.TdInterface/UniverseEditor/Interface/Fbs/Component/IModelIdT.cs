using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005564 RID: 21860
	public class IModelIdT
	{
		// Token: 0x1700A17A RID: 41338
		// (get) Token: 0x06024283 RID: 148099 RVA: 0x004FE820 File Offset: 0x004FCA20
		// (set) Token: 0x06024284 RID: 148100 RVA: 0x004FE828 File Offset: 0x004FCA28
		public EModelType Type { get; set; }

		// Token: 0x1700A17B RID: 41339
		// (get) Token: 0x06024285 RID: 148101 RVA: 0x004FE831 File Offset: 0x004FCA31
		// (set) Token: 0x06024286 RID: 148102 RVA: 0x004FE839 File Offset: 0x004FCA39
		public int ModelId { get; set; }

		// Token: 0x06024287 RID: 148103 RVA: 0x004FE842 File Offset: 0x004FCA42
		public IModelIdT()
		{
			this.Type = EModelType.LevelPrefab;
			this.ModelId = 0;
		}
	}
}
