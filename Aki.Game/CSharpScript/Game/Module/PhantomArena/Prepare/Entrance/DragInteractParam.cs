using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005157 RID: 20823
	[NullableContext(1)]
	[Nullable(0)]
	public class DragInteractParam : IDragInteractParam
	{
		// Token: 0x1700810E RID: 33038
		// (get) Token: 0x060353B6 RID: 218038 RVA: 0x00C9A68E File Offset: 0x00C9888E
		// (set) Token: 0x060353B5 RID: 218037 RVA: 0x00C9A685 File Offset: 0x00C98885
		public UUIDraggableComponent Draggable { get; set; }

		// Token: 0x1700810F RID: 33039
		// (get) Token: 0x060353B8 RID: 218040 RVA: 0x00C9A69F File Offset: 0x00C9889F
		// (set) Token: 0x060353B7 RID: 218039 RVA: 0x00C9A696 File Offset: 0x00C98896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Vector2D> CallbackOnDrag { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008110 RID: 33040
		// (get) Token: 0x060353BA RID: 218042 RVA: 0x00C9A6B0 File Offset: 0x00C988B0
		// (set) Token: 0x060353B9 RID: 218041 RVA: 0x00C9A6A7 File Offset: 0x00C988A7
		[Nullable(2)]
		public Action CallbackOnDown { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008111 RID: 33041
		// (get) Token: 0x060353BC RID: 218044 RVA: 0x00C9A6C1 File Offset: 0x00C988C1
		// (set) Token: 0x060353BB RID: 218043 RVA: 0x00C9A6B8 File Offset: 0x00C988B8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Vector2D> CallbackOnInertia { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
