using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C16 RID: 11286
	public class IEnableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600F869 RID: 63593 RVA: 0x00241D44 File Offset: 0x0023FF44
		public static IEnableAllMotorRadioOperation Create(IEnableAllMotorRadioOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllMotorRadioOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x0600F86A RID: 63594 RVA: 0x00241D63 File Offset: 0x0023FF63
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040087EC RID: 34796
		private IEnableAllMotorRadioOperation Instance;
	}
}
