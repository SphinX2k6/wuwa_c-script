using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E00 RID: 11776
	public class IChangeElementalBoxStatePlayerTarget : IChangeElementalBoxStateTarget
	{
		// Token: 0x0600FFFE RID: 65534 RVA: 0x0024DACE File Offset: 0x0024BCCE
		public static IChangeElementalBoxStatePlayerTarget Create(IChangeElementalBoxStatePlayerTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStatePlayerTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x0600FFFF RID: 65535 RVA: 0x0024DAED File Offset: 0x0024BCED
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008BB6 RID: 35766
		private IChangeElementalBoxStatePlayerTarget Instance;
	}
}
