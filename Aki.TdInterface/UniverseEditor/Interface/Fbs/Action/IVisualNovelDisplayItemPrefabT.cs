using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007587 RID: 30087
	public class IVisualNovelDisplayItemPrefabT
	{
		// Token: 0x1700E429 RID: 58409
		// (get) Token: 0x06036BBE RID: 224190 RVA: 0x0076E46C File Offset: 0x0076C66C
		// (set) Token: 0x06036BBF RID: 224191 RVA: 0x0076E474 File Offset: 0x0076C674
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x1700E42A RID: 58410
		// (get) Token: 0x06036BC0 RID: 224192 RVA: 0x0076E47D File Offset: 0x0076C67D
		// (set) Token: 0x06036BC1 RID: 224193 RVA: 0x0076E485 File Offset: 0x0076C685
		public int PrefabId { get; set; }

		// Token: 0x06036BC2 RID: 224194 RVA: 0x0076E48E File Offset: 0x0076C68E
		public IVisualNovelDisplayItemPrefabT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
			this.PrefabId = 0;
		}
	}
}
