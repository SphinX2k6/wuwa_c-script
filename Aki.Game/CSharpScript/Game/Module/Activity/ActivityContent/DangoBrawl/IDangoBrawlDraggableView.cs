using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056EE RID: 22254
	[NullableContext(2)]
	public interface IDangoBrawlDraggableView
	{
		// Token: 0x170069DE RID: 27102
		// (get) Token: 0x06036D54 RID: 224596
		int MyUid { get; }

		// Token: 0x170069DF RID: 27103
		// (get) Token: 0x06036D55 RID: 224597
		int MyConfigId { get; }

		// Token: 0x170069E0 RID: 27104
		// (get) Token: 0x06036D56 RID: 224598
		EDangoBrawlTemplateType MyType { get; }

		// Token: 0x170069E1 RID: 27105
		// (get) Token: 0x06036D57 RID: 224599
		DangoBrawlItemBase MyItemData { get; }

		// Token: 0x06036D58 RID: 224600
		[NullableContext(1)]
		UUIItem GetDraggableRootItem();

		// Token: 0x06036D59 RID: 224601
		void SetDraggableRotation(EDangoBrawlRotate rotate);

		// Token: 0x06036D5A RID: 224602
		void SetDraggableActive(bool enabled);

		// Token: 0x06036D5B RID: 224603 RVA: 0x00F4B6A9 File Offset: 0x00F498A9
		void OnMoving()
		{
		}

		// Token: 0x06036D5C RID: 224604 RVA: 0x00F4B6AB File Offset: 0x00F498AB
		void OnDragSourceBegin()
		{
		}

		// Token: 0x06036D5D RID: 224605 RVA: 0x00F4B6AD File Offset: 0x00F498AD
		void OnDragSourceEnd()
		{
		}
	}
}
