using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004126 RID: 16678
	[NullableContext(1)]
	public interface IDragInteractParam
	{
		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x0602A2AA RID: 172714
		// (set) Token: 0x0602A2A9 RID: 172713
		UUIDraggableComponent Draggable { get; set; }

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x0602A2AC RID: 172716
		// (set) Token: 0x0602A2AB RID: 172715
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

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x0602A2AE RID: 172718
		// (set) Token: 0x0602A2AD RID: 172717
		[Nullable(2)]
		Action CallbackOnDown { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x0602A2B0 RID: 172720
		// (set) Token: 0x0602A2AF RID: 172719
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
