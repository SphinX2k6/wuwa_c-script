using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9A RID: 3482
	public class IMechascoutDragLongPress : IMechascoutDragTypeBase
	{
		// Token: 0x06004F25 RID: 20261 RVA: 0x000C4F69 File Offset: 0x000C3169
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

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x000C4F88 File Offset: 0x000C3188
		public override EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x000C4F95 File Offset: 0x000C3195
		public virtual float LongPressDuration
		{
			get
			{
				return this.Instance.LongPressDuration;
			}
		}

		// Token: 0x04002CF7 RID: 11511
		private IMechascoutDragLongPress Instance;
	}
}
