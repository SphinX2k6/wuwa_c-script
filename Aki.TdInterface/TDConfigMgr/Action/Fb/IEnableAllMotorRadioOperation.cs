using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002936 RID: 10550
	public class IEnableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600EA07 RID: 59911 RVA: 0x00224815 File Offset: 0x00222A15
		[NullableContext(1)]
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

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x0600EA08 RID: 59912 RVA: 0x00224834 File Offset: 0x00222A34
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008114 RID: 33044
		private IEnableAllMotorRadioOperation Instance;
	}
}
