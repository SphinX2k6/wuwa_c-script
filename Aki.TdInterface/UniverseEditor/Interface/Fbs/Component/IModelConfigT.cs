using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555E RID: 21854
	public class IModelConfigT
	{
		// Token: 0x1700A174 RID: 41332
		// (get) Token: 0x0602425D RID: 148061 RVA: 0x004FE47E File Offset: 0x004FC67E
		// (set) Token: 0x0602425E RID: 148062 RVA: 0x004FE486 File Offset: 0x004FC686
		public EModelType Type { get; set; }

		// Token: 0x0602425F RID: 148063 RVA: 0x004FE48F File Offset: 0x004FC68F
		public IModelConfigT()
		{
			this.Type = EModelType.LevelPrefab;
		}
	}
}
