using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9E RID: 10910
	public class ILimitPlayerAction : ILimitPlayerOption
	{
		// Token: 0x0600F0A4 RID: 61604 RVA: 0x002340C2 File Offset: 0x002322C2
		public static ILimitPlayerAction Create(ILimitPlayerAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x0600F0A5 RID: 61605 RVA: 0x002340E1 File Offset: 0x002322E1
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008454 RID: 33876
		private ILimitPlayerAction Instance;
	}
}
