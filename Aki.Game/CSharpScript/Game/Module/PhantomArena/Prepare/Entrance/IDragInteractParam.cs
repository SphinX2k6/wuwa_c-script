using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005156 RID: 20822
	[NullableContext(1)]
	public interface IDragInteractParam
	{
		// Token: 0x1700810A RID: 33034
		// (get) Token: 0x060353AE RID: 218030
		// (set) Token: 0x060353AD RID: 218029
		UUIDraggableComponent Draggable { get; set; }

		// Token: 0x1700810B RID: 33035
		// (get) Token: 0x060353B0 RID: 218032
		// (set) Token: 0x060353AF RID: 218031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<Vector2D> CallbackOnDrag { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700810C RID: 33036
		// (get) Token: 0x060353B2 RID: 218034
		// (set) Token: 0x060353B1 RID: 218033
		[Nullable(2)]
		Action CallbackOnDown { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700810D RID: 33037
		// (get) Token: 0x060353B4 RID: 218036
		// (set) Token: 0x060353B3 RID: 218035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<Vector2D> CallbackOnInertia { [return: Nullable(new byte[]
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
