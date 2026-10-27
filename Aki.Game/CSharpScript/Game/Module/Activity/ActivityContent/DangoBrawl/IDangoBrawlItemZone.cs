using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067A2 RID: 26530
	[NullableContext(1)]
	public interface IDangoBrawlItemZone
	{
		// Token: 0x06042226 RID: 270886
		[NullableContext(2)]
		DangoBrawlViewItemBase DetachPanel(int uid);

		// Token: 0x06042227 RID: 270887
		void AcceptPanel(DangoBrawlViewItemBase panel, DangoBrawlItemBase itemData, bool playEnterSeq = true);

		// Token: 0x06042228 RID: 270888
		bool TryRefreshPanel(int uid);

		// Token: 0x06042229 RID: 270889
		void FallbackAddItemPanel(int uid, bool playEnterSeq = true);

		// Token: 0x0604222A RID: 270890
		void RemoveItemPanel(int uid);

		// Token: 0x0604222B RID: 270891
		void CollectPanelUids(List<int> result);
	}
}
