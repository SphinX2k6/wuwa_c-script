using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D5C RID: 32092
	public class IVisualNovelCgBaseT
	{
		// Token: 0x1700F01F RID: 61471
		// (get) Token: 0x06039EE6 RID: 237286 RVA: 0x007D0026 File Offset: 0x007CE226
		// (set) Token: 0x06039EE7 RID: 237287 RVA: 0x007D002E File Offset: 0x007CE22E
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x06039EE8 RID: 237288 RVA: 0x007D0037 File Offset: 0x007CE237
		public IVisualNovelCgBaseT()
		{
			this.Type = EVisualNovelCgType.LoadPrefab;
		}
	}
}
