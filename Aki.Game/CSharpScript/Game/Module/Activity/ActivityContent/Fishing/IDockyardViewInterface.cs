using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005514 RID: 21780
	[NullableContext(1)]
	public interface IDockyardViewInterface
	{
		// Token: 0x06036003 RID: 221187
		void ShowTipsPanel(int id);

		// Token: 0x06036004 RID: 221188
		void HideTipsPanel();

		// Token: 0x06036005 RID: 221189
		void SetTrawlState(bool state);

		// Token: 0x06036006 RID: 221190
		[NullableContext(2)]
		void CloseMe(Action<bool> callback = null);

		// Token: 0x06036007 RID: 221191
		void NotifyQuicklySellActive(bool isActive);

		// Token: 0x06036008 RID: 221192
		UUIItem GetQuicklySellPanelParentItem();
	}
}
