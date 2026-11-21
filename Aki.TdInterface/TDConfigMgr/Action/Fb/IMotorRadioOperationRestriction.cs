using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C15 RID: 11285
	public class IMotorRadioOperationRestriction
	{
		// Token: 0x0600F866 RID: 63590 RVA: 0x00241D10 File Offset: 0x0023FF10
		public static IMotorRadioOperationRestriction Create(IMotorRadioOperationRestriction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioOperationRestriction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x0600F867 RID: 63591 RVA: 0x00241D2F File Offset: 0x0023FF2F
		public virtual EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087EB RID: 34795
		private IMotorRadioOperationRestriction Instance;
	}
}
