using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB7 RID: 3255
	public class IMechascoutDragInstant : IMechascoutDragTypeBase
	{
		// Token: 0x06004A74 RID: 19060 RVA: 0x000BA525 File Offset: 0x000B8725
		[NullableContext(1)]
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

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x000BA544 File Offset: 0x000B8744
		public override EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x04002A7C RID: 10876
		private IMechascoutDragInstant Instance;
	}
}
