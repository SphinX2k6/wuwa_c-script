using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D98 RID: 3480
	public class IMechascoutDragTypeBase
	{
		// Token: 0x06004F1F RID: 20255 RVA: 0x000C4F01 File Offset: 0x000C3101
		public static IMechascoutDragTypeBase Create(IMechascoutDragTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutDragTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x000C4F20 File Offset: 0x000C3120
		public virtual EMechascoutDragType Type
		{
			get
			{
				return (EMechascoutDragType)this.Instance.Type;
			}
		}

		// Token: 0x04002CF5 RID: 11509
		private IMechascoutDragTypeBase Instance;
	}
}
