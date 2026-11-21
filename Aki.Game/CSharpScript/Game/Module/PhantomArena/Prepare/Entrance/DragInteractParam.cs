using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004127 RID: 16679
	[NullableContext(1)]
	[Nullable(0)]
	public class DragInteractParam : IDragInteractParam
	{
		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x0602A2B2 RID: 172722 RVA: 0x00BE7B8E File Offset: 0x00BE5D8E
		// (set) Token: 0x0602A2B1 RID: 172721 RVA: 0x00BE7B85 File Offset: 0x00BE5D85
		public UUIDraggableComponent Draggable { get; set; }

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x0602A2B4 RID: 172724 RVA: 0x00BE7B9F File Offset: 0x00BE5D9F
		// (set) Token: 0x0602A2B3 RID: 172723 RVA: 0x00BE7B96 File Offset: 0x00BE5D96
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

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x0602A2B6 RID: 172726 RVA: 0x00BE7BB0 File Offset: 0x00BE5DB0
		// (set) Token: 0x0602A2B5 RID: 172725 RVA: 0x00BE7BA7 File Offset: 0x00BE5DA7
		[Nullable(2)]
		public Action CallbackOnDown { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x0602A2B8 RID: 172728 RVA: 0x00BE7BC1 File Offset: 0x00BE5DC1
		// (set) Token: 0x0602A2B7 RID: 172727 RVA: 0x00BE7BB8 File Offset: 0x00BE5DB8
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
