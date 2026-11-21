using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056F1 RID: 22257
	[NullableContext(1)]
	public interface IDangobrawlInputAdapter
	{
		// Token: 0x170069E6 RID: 27110
		// (get) Token: 0x06036D74 RID: 224628
		EInputPlatform Platform { get; }

		// Token: 0x06036D75 RID: 224629 RVA: 0x00F4B89B File Offset: 0x00F49A9B
		void Start()
		{
		}

		// Token: 0x06036D76 RID: 224630 RVA: 0x00F4B89D File Offset: 0x00F49A9D
		void Stop()
		{
		}

		// Token: 0x06036D77 RID: 224631
		void OnTick(float delta);

		// Token: 0x06036D78 RID: 224632
		UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos);

		// Token: 0x06036D79 RID: 224633
		UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos);

		// Token: 0x06036D7A RID: 224634
		void OnPointerDrag(FVector pointerPos);

		// Token: 0x06036D7B RID: 224635
		UniTask OnPointerEndDrag(FVector pointerPos);
	}
}
