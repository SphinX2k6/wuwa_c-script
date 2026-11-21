using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C18 RID: 11288
	public class IEnableInRangeMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600F86F RID: 63599 RVA: 0x00241DAC File Offset: 0x0023FFAC
		public static IEnableInRangeMotorRadioOperation Create(IEnableInRangeMotorRadioOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableInRangeMotorRadioOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x0600F870 RID: 63600 RVA: 0x00241DCB File Offset: 0x0023FFCB
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x0600F871 RID: 63601 RVA: 0x00241DD8 File Offset: 0x0023FFD8
		public virtual string RangeKey
		{
			get
			{
				return this.Instance.RangeKey;
			}
		}

		// Token: 0x040087EE RID: 34798
		private IEnableInRangeMotorRadioOperation Instance;
	}
}
