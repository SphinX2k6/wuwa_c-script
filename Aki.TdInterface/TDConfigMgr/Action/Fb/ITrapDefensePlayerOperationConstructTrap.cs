using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8C RID: 10892
	public class ITrapDefensePlayerOperationConstructTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600EF51 RID: 61265 RVA: 0x0022CBF8 File Offset: 0x0022ADF8
		[NullableContext(1)]
		public static ITrapDefensePlayerOperationConstructTrap Create(ITrapDefensePlayerOperationConstructTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationConstructTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x0600EF52 RID: 61266 RVA: 0x0022CC17 File Offset: 0x0022AE17
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040083AC RID: 33708
		private ITrapDefensePlayerOperationConstructTrap Instance;
	}
}
