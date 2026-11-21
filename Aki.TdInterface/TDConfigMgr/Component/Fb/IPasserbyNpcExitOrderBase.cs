using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC7 RID: 3527
	public class IPasserbyNpcExitOrderBase
	{
		// Token: 0x06005012 RID: 20498 RVA: 0x000C6F32 File Offset: 0x000C5132
		public static IPasserbyNpcExitOrderBase Create(IPasserbyNpcExitOrderBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitOrderBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x000C6F51 File Offset: 0x000C5151
		public virtual EPasserbyNpcExitOrderType Type
		{
			get
			{
				return (EPasserbyNpcExitOrderType)this.Instance.Type;
			}
		}

		// Token: 0x04002D9E RID: 11678
		private IPasserbyNpcExitOrderBase Instance;
	}
}
