using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A41 RID: 23105
	public class ITeleControlDestroyConditionT
	{
		// Token: 0x1700ADD6 RID: 44502
		// (get) Token: 0x060274B0 RID: 160944 RVA: 0x005683D2 File Offset: 0x005665D2
		// (set) Token: 0x060274B1 RID: 160945 RVA: 0x005683DA File Offset: 0x005665DA
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x060274B2 RID: 160946 RVA: 0x005683E3 File Offset: 0x005665E3
		public ITeleControlDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
