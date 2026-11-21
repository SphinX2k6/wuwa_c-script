using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D99 RID: 3481
	public class IMechascoutDragInstant : IMechascoutDragTypeBase
	{
		// Token: 0x06004F22 RID: 20258 RVA: 0x000C4F35 File Offset: 0x000C3135
		public static IMechascoutDragInstant Create(IMechascoutDragInstant? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragInstant
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004F23 RID: 20259 RVA: 0x000C4F54 File Offset: 0x000C3154
		public override EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x04002CF6 RID: 11510
		private IMechascoutDragInstant Instance;
	}
}
