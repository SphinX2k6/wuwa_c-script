using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE6 RID: 11494
	public class ICustomAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x0600FBC2 RID: 64450 RVA: 0x002471DF File Offset: 0x002453DF
		public static ICustomAlertValueChangeSpeed Create(ICustomAlertValueChangeSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x0600FBC3 RID: 64451 RVA: 0x002471FE File Offset: 0x002453FE
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x0600FBC4 RID: 64452 RVA: 0x0024720B File Offset: 0x0024540B
		public virtual float CustomValue
		{
			get
			{
				return this.Instance.CustomValue;
			}
		}

		// Token: 0x04008984 RID: 35204
		private ICustomAlertValueChangeSpeed Instance;
	}
}
