using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056F2 RID: 22258
	[NullableContext(1)]
	public interface IDangoBrawlItemZone
	{
		// Token: 0x06036D7C RID: 224636
		[NullableContext(2)]
		DangoBrawlViewItemBase DetachPanel(int uid);

		// Token: 0x06036D7D RID: 224637
		void AcceptPanel(DangoBrawlViewItemBase panel, DangoBrawlItemBase itemData, bool playEnterSeq = true);

		// Token: 0x06036D7E RID: 224638
		bool TryRefreshPanel(int uid);

		// Token: 0x06036D7F RID: 224639
		void FallbackAddItemPanel(int uid, bool playEnterSeq = true);

		// Token: 0x06036D80 RID: 224640
		void RemoveItemPanel(int uid);

		// Token: 0x06036D81 RID: 224641
		void CollectPanelUids(List<int> result);
	}
}
