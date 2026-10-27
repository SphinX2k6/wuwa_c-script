using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200679E RID: 26526
	[NullableContext(2)]
	public interface IDangoBrawlDraggableView
	{
		// Token: 0x1700969D RID: 38557
		// (get) Token: 0x060421FE RID: 270846
		int MyUid { get; }

		// Token: 0x1700969E RID: 38558
		// (get) Token: 0x060421FF RID: 270847
		int MyConfigId { get; }

		// Token: 0x1700969F RID: 38559
		// (get) Token: 0x06042200 RID: 270848
		EDangoBrawlTemplateType MyType { get; }

		// Token: 0x170096A0 RID: 38560
		// (get) Token: 0x06042201 RID: 270849
		DangoBrawlItemBase MyItemData { get; }

		// Token: 0x06042202 RID: 270850
		[NullableContext(1)]
		UUIItem GetDraggableRootItem();

		// Token: 0x06042203 RID: 270851
		void SetDraggableRotation(EDangoBrawlRotate rotate);

		// Token: 0x06042204 RID: 270852
		void SetDraggableActive(bool enabled);

		// Token: 0x06042205 RID: 270853 RVA: 0x0100A2C5 File Offset: 0x010084C5
		void OnMoving()
		{
		}

		// Token: 0x06042206 RID: 270854 RVA: 0x0100A2C7 File Offset: 0x010084C7
		void OnDragSourceBegin()
		{
		}

		// Token: 0x06042207 RID: 270855 RVA: 0x0100A2C9 File Offset: 0x010084C9
		void OnDragSourceEnd()
		{
		}
	}
}
