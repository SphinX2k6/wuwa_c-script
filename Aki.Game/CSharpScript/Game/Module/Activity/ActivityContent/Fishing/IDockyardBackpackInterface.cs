using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005511 RID: 21777
	public interface IDockyardBackpackInterface
	{
		// Token: 0x06035FEA RID: 221162
		void CloseClick();

		// Token: 0x06035FEB RID: 221163
		bool CheckCurrencyItemClick(int itemId);

		// Token: 0x06035FEC RID: 221164
		void ItemBlockClick(int id);

		// Token: 0x06035FED RID: 221165
		void HandleDragBegin();

		// Token: 0x06035FEE RID: 221166
		void HandleDragResult();

		// Token: 0x06035FEF RID: 221167
		void DeleteClick();

		// Token: 0x06035FF0 RID: 221168
		void RotateClick();

		// Token: 0x06035FF1 RID: 221169
		void ConfirmClick();

		// Token: 0x06035FF2 RID: 221170
		void TrawlClick(bool isSelected);

		// Token: 0x06035FF3 RID: 221171
		void AllSellClick();

		// Token: 0x06035FF4 RID: 221172
		void BackpackTick(float deltaTime);

		// Token: 0x06035FF5 RID: 221173
		bool IsTrawlInteractive();

		// Token: 0x06035FF6 RID: 221174
		void SetInSelectState(bool inSelectState);

		// Token: 0x06035FF7 RID: 221175
		[NullableContext(1)]
		void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data);

		// Token: 0x06035FF8 RID: 221176
		[NullableContext(2)]
		UUIItem GetQuicklySellPanelParentItem();

		// Token: 0x06035FF9 RID: 221177
		void NotifyQuicklySellActive(bool isActive);

		// Token: 0x06035FFA RID: 221178
		UniTask<bool> TrySetSelectedItemBlockToWareHouse();

		// Token: 0x06035FFB RID: 221179
		UniTask<bool> TrySetSelectedItemBlockToBackpack();
	}
}
