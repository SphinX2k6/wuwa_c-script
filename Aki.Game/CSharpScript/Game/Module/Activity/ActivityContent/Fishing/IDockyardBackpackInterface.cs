using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006593 RID: 26003
	public interface IDockyardBackpackInterface
	{
		// Token: 0x06041325 RID: 267045
		void CloseClick();

		// Token: 0x06041326 RID: 267046
		bool CheckCurrencyItemClick(int itemId);

		// Token: 0x06041327 RID: 267047
		void ItemBlockClick(int id);

		// Token: 0x06041328 RID: 267048
		void HandleDragBegin();

		// Token: 0x06041329 RID: 267049
		void HandleDragResult();

		// Token: 0x0604132A RID: 267050
		void DeleteClick();

		// Token: 0x0604132B RID: 267051
		void RotateClick();

		// Token: 0x0604132C RID: 267052
		void ConfirmClick();

		// Token: 0x0604132D RID: 267053
		void TrawlClick(bool isSelected);

		// Token: 0x0604132E RID: 267054
		void AllSellClick();

		// Token: 0x0604132F RID: 267055
		void BackpackTick(float deltaTime);

		// Token: 0x06041330 RID: 267056
		bool IsTrawlInteractive();

		// Token: 0x06041331 RID: 267057
		void SetInSelectState(bool inSelectState);

		// Token: 0x06041332 RID: 267058
		[NullableContext(1)]
		void NotifyItemBlockToWareHouse(DockyardItemBlockOriginalData data);

		// Token: 0x06041333 RID: 267059
		[NullableContext(2)]
		UUIItem GetQuicklySellPanelParentItem();

		// Token: 0x06041334 RID: 267060
		void NotifyQuicklySellActive(bool isActive);

		// Token: 0x06041335 RID: 267061
		UniTask<bool> TrySetSelectedItemBlockToWareHouse();

		// Token: 0x06041336 RID: 267062
		UniTask<bool> TrySetSelectedItemBlockToBackpack();
	}
}
