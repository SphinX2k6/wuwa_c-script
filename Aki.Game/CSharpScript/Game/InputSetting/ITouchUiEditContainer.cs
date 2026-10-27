using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007019 RID: 28697
	[NullableContext(1)]
	public interface ITouchUiEditContainer
	{
		// Token: 0x06045D84 RID: 286084
		UniTask LoadPanel(UUIItem parent, string[] resIdList, CommonTouchUiEditGroup groupConfig);

		// Token: 0x06045D85 RID: 286085
		[return: Nullable(2)]
		UUIItem GetItem(string resId, int index, int subPanelIndex);

		// Token: 0x06045D86 RID: 286086
		UUIItem[] GetRegistryItemList(string resId);

		// Token: 0x06045D87 RID: 286087
		UUIItem GetRootItem();

		// Token: 0x06045D88 RID: 286088
		void OnViewDestroy();
	}
}
