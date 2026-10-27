using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006596 RID: 26006
	[NullableContext(1)]
	public interface IDockyardViewInterface
	{
		// Token: 0x0604133E RID: 267070
		void ShowTipsPanel(int id);

		// Token: 0x0604133F RID: 267071
		void HideTipsPanel();

		// Token: 0x06041340 RID: 267072
		void SetTrawlState(bool state);

		// Token: 0x06041341 RID: 267073
		[NullableContext(2)]
		void CloseMe(Action<bool> callback = null);

		// Token: 0x06041342 RID: 267074
		void NotifyQuicklySellActive(bool isActive);

		// Token: 0x06041343 RID: 267075
		UUIItem GetQuicklySellPanelParentItem();
	}
}
