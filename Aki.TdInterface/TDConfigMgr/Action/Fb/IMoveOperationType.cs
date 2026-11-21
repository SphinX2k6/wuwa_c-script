using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C21 RID: 11297
	public class IMoveOperationType
	{
		// Token: 0x0600F898 RID: 63640 RVA: 0x002421AD File Offset: 0x002403AD
		public static IMoveOperationType Create(IMoveOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x0600F899 RID: 63641 RVA: 0x002421CC File Offset: 0x002403CC
		public virtual EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008803 RID: 34819
		private IMoveOperationType Instance;
	}
}
