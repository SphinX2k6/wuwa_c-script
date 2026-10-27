using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067A1 RID: 26529
	[NullableContext(1)]
	public interface IDangobrawlInputAdapter
	{
		// Token: 0x170096A5 RID: 38565
		// (get) Token: 0x0604221E RID: 270878
		EInputPlatform Platform { get; }

		// Token: 0x0604221F RID: 270879 RVA: 0x0100A4B7 File Offset: 0x010086B7
		void Start()
		{
		}

		// Token: 0x06042220 RID: 270880 RVA: 0x0100A4B9 File Offset: 0x010086B9
		void Stop()
		{
		}

		// Token: 0x06042221 RID: 270881
		void OnTick(float delta);

		// Token: 0x06042222 RID: 270882
		UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos);

		// Token: 0x06042223 RID: 270883
		UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos);

		// Token: 0x06042224 RID: 270884
		void OnPointerDrag(FVector pointerPos);

		// Token: 0x06042225 RID: 270885
		UniTask OnPointerEndDrag(FVector pointerPos);
	}
}
