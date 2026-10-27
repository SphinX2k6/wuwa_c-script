using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007584 RID: 30084
	public class IVisualNovelDisplayItemImageT
	{
		// Token: 0x1700E424 RID: 58404
		// (get) Token: 0x06036BA8 RID: 224168 RVA: 0x0076E26C File Offset: 0x0076C46C
		// (set) Token: 0x06036BA9 RID: 224169 RVA: 0x0076E274 File Offset: 0x0076C474
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x1700E425 RID: 58405
		// (get) Token: 0x06036BAA RID: 224170 RVA: 0x0076E27D File Offset: 0x0076C47D
		// (set) Token: 0x06036BAB RID: 224171 RVA: 0x0076E285 File Offset: 0x0076C485
		public int DisplayImageId { get; set; }

		// Token: 0x06036BAC RID: 224172 RVA: 0x0076E28E File Offset: 0x0076C48E
		public IVisualNovelDisplayItemImageT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
			this.DisplayImageId = 0;
		}
	}
}
