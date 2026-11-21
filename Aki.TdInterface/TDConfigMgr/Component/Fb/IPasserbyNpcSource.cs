using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCD RID: 3533
	public class IPasserbyNpcSource
	{
		// Token: 0x06005028 RID: 20520 RVA: 0x000C7113 File Offset: 0x000C5313
		public static IPasserbyNpcSource Create(IPasserbyNpcSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06005029 RID: 20521 RVA: 0x000C7132 File Offset: 0x000C5332
		public virtual EPasserbyNpcSource Type
		{
			get
			{
				return (EPasserbyNpcSource)this.Instance.Type;
			}
		}

		// Token: 0x04002DAA RID: 11690
		private IPasserbyNpcSource Instance;
	}
}
