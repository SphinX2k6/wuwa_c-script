using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF0 RID: 23280
	public class IModelConfigT
	{
		// Token: 0x1700A9EA RID: 43498
		// (get) Token: 0x06026402 RID: 156674 RVA: 0x0053DD42 File Offset: 0x0053BF42
		// (set) Token: 0x06026403 RID: 156675 RVA: 0x0053DD4A File Offset: 0x0053BF4A
		public EModelType Type { get; set; }

		// Token: 0x06026404 RID: 156676 RVA: 0x0053DD53 File Offset: 0x0053BF53
		public IModelConfigT()
		{
			this.Type = EModelType.LevelPrefab;
		}
	}
}
