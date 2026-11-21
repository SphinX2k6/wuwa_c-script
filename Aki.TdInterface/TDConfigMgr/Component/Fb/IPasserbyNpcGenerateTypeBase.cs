using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC3 RID: 3523
	public class IPasserbyNpcGenerateTypeBase
	{
		// Token: 0x06005001 RID: 20481 RVA: 0x000C6D49 File Offset: 0x000C4F49
		public static IPasserbyNpcGenerateTypeBase Create(IPasserbyNpcGenerateTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcGenerateTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x000C6D68 File Offset: 0x000C4F68
		public virtual EPasserbyNpcGenerateType Type
		{
			get
			{
				return (EPasserbyNpcGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x04002D94 RID: 11668
		private IPasserbyNpcGenerateTypeBase Instance;
	}
}
