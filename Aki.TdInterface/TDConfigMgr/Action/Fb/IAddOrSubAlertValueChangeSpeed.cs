using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE5 RID: 11493
	public class IAddOrSubAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x0600FBBE RID: 64446 RVA: 0x0024719E File Offset: 0x0024539E
		public static IAddOrSubAlertValueChangeSpeed Create(IAddOrSubAlertValueChangeSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x0600FBBF RID: 64447 RVA: 0x002471BD File Offset: 0x002453BD
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x0600FBC0 RID: 64448 RVA: 0x002471CA File Offset: 0x002453CA
		public virtual float DeltaValue
		{
			get
			{
				return this.Instance.DeltaValue;
			}
		}

		// Token: 0x04008983 RID: 35203
		private IAddOrSubAlertValueChangeSpeed Instance;
	}
}
