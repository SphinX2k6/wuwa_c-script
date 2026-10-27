using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757B RID: 30075
	public class IVisualNovelDisplayItemBaseT
	{
		// Token: 0x1700E41B RID: 58395
		// (get) Token: 0x06036B72 RID: 224114 RVA: 0x0076DD8E File Offset: 0x0076BF8E
		// (set) Token: 0x06036B73 RID: 224115 RVA: 0x0076DD96 File Offset: 0x0076BF96
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x06036B74 RID: 224116 RVA: 0x0076DD9F File Offset: 0x0076BF9F
		public IVisualNovelDisplayItemBaseT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
		}
	}
}
