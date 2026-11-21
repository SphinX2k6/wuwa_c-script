using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006199 RID: 24985
	[NullableContext(2)]
	public interface ITouchUiEditItem
	{
		// Token: 0x170070F6 RID: 28918
		// (get) Token: 0x0603BF2A RID: 245546
		ITouchUiEditData Data { get; }

		// Token: 0x170070F7 RID: 28919
		// (get) Token: 0x0603BF2B RID: 245547
		[Nullable(1)]
		UUIItem RootItem { [NullableContext(1)] get; }

		// Token: 0x0603BF2C RID: 245548
		void SetData(ITouchUiEditData data);

		// Token: 0x0603BF2D RID: 245549
		void SetOffset(float offsetX, float offsetY);

		// Token: 0x0603BF2E RID: 245550
		void SetScale(float scale);

		// Token: 0x0603BF2F RID: 245551
		void SetAlpha(float alpha);

		// Token: 0x0603BF30 RID: 245552
		void SetHierarchyIndex(int index);

		// Token: 0x0603BF31 RID: 245553
		void OnViewDestroy();

		// Token: 0x0603BF32 RID: 245554
		void OnDrag(ULGUIPointerEventData eventData);

		// Token: 0x0603BF33 RID: 245555
		void OnDragBegin(ULGUIPointerEventData eventData);

		// Token: 0x0603BF34 RID: 245556
		void OnDragEnd(ULGUIPointerEventData eventData);

		// Token: 0x0603BF35 RID: 245557
		void OnButtonPress(ULGUIPointerEventData eventData);

		// Token: 0x0603BF36 RID: 245558
		void OnButtonRelease(ULGUIPointerEventData eventData);

		// Token: 0x0603BF37 RID: 245559
		void OnExtendToggleStateChanged(EToggleState state);

		// Token: 0x0603BF38 RID: 245560
		bool OnCheckCanExecuteChange();

		// Token: 0x0603BF39 RID: 245561
		bool IsEdited();
	}
}
