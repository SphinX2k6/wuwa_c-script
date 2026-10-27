using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0C RID: 11020
	public class IChangeElementalBoxStatePlayerTarget : IChangeElementalBoxStateTarget
	{
		// Token: 0x0600F148 RID: 61768 RVA: 0x0022FDC2 File Offset: 0x0022DFC2
		[NullableContext(1)]
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

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x0600F149 RID: 61769 RVA: 0x0022FDE1 File Offset: 0x0022DFE1
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040084B2 RID: 33970
		private IChangeElementalBoxStatePlayerTarget Instance;
	}
}
