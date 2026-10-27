using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007018 RID: 28696
	[NullableContext(2)]
	public interface ITouchUiEditItem
	{
		// Token: 0x17009BB6 RID: 39862
		// (get) Token: 0x06045D74 RID: 286068
		ITouchUiEditData Data { get; }

		// Token: 0x17009BB7 RID: 39863
		// (get) Token: 0x06045D75 RID: 286069
		[Nullable(1)]
		UUIItem RootItem { [NullableContext(1)] get; }

		// Token: 0x06045D76 RID: 286070
		void SetData(ITouchUiEditData data);

		// Token: 0x06045D77 RID: 286071
		void SetOffset(float offsetX, float offsetY);

		// Token: 0x06045D78 RID: 286072
		void SetScale(float scale);

		// Token: 0x06045D79 RID: 286073
		void SetAlpha(float alpha);

		// Token: 0x06045D7A RID: 286074
		void SetHierarchyIndex(int index);

		// Token: 0x06045D7B RID: 286075
		void OnViewDestroy();

		// Token: 0x06045D7C RID: 286076
		void OnDrag(ULGUIPointerEventData eventData);

		// Token: 0x06045D7D RID: 286077
		void OnDragBegin(ULGUIPointerEventData eventData);

		// Token: 0x06045D7E RID: 286078
		void OnDragEnd(ULGUIPointerEventData eventData);

		// Token: 0x06045D7F RID: 286079
		void OnButtonPress(ULGUIPointerEventData eventData);

		// Token: 0x06045D80 RID: 286080
		void OnButtonRelease(ULGUIPointerEventData eventData);

		// Token: 0x06045D81 RID: 286081
		void OnExtendToggleStateChanged(EToggleState state);

		// Token: 0x06045D82 RID: 286082
		bool OnCheckCanExecuteChange();

		// Token: 0x06045D83 RID: 286083
		bool IsEdited();
	}
}
