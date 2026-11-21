using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C17 RID: 11287
	public class IDisableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600F86C RID: 63596 RVA: 0x00241D78 File Offset: 0x0023FF78
		public static IDisableAllMotorRadioOperation Create(IDisableAllMotorRadioOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAllMotorRadioOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x00241D97 File Offset: 0x0023FF97
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087ED RID: 34797
		private IDisableAllMotorRadioOperation Instance;
	}
}
