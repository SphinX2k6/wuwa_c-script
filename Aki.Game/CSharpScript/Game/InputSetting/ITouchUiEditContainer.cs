using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200619A RID: 24986
	[NullableContext(1)]
	public interface ITouchUiEditContainer
	{
		// Token: 0x0603BF3A RID: 245562
		UniTask LoadPanel(UUIItem parent, string[] resIdList, CommonTouchUiEditGroup groupConfig);

		// Token: 0x0603BF3B RID: 245563
		[return: Nullable(2)]
		UUIItem GetItem(string resId, int index, int subPanelIndex);

		// Token: 0x0603BF3C RID: 245564
		UUIItem[] GetRegistryItemList(string resId);

		// Token: 0x0603BF3D RID: 245565
		UUIItem GetRootItem();

		// Token: 0x0603BF3E RID: 245566
		void OnViewDestroy();
	}
}
