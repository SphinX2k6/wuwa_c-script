using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB8 RID: 3256
	public class IMechascoutDragLongPress : IMechascoutDragTypeBase
	{
		// Token: 0x06004A77 RID: 19063 RVA: 0x000BA559 File Offset: 0x000B8759
		[NullableContext(1)]
		public static IMechascoutDragLongPress Create(IMechascoutDragLongPress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragLongPress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x000BA578 File Offset: 0x000B8778
		public override EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x000BA585 File Offset: 0x000B8785
		public virtual float LongPressDuration
		{
			get
			{
				return this.Instance.LongPressDuration;
			}
		}

		// Token: 0x04002A7D RID: 10877
		private IMechascoutDragLongPress Instance;
	}
}
