using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC9 RID: 3529
	public class IPasserbyNpcExitIntervalBase
	{
		// Token: 0x06005018 RID: 20504 RVA: 0x000C6F9A File Offset: 0x000C519A
		public static IPasserbyNpcExitIntervalBase Create(IPasserbyNpcExitIntervalBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitIntervalBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x000C6FB9 File Offset: 0x000C51B9
		public virtual EPasserbyNpcExitIntervalType Type
		{
			get
			{
				return (EPasserbyNpcExitIntervalType)this.Instance.Type;
			}
		}

		// Token: 0x04002DA0 RID: 11680
		private IPasserbyNpcExitIntervalBase Instance;
	}
}
