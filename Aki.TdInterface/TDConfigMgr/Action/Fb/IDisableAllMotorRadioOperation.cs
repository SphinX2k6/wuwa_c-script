using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002937 RID: 10551
	public class IDisableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600EA0A RID: 59914 RVA: 0x00224849 File Offset: 0x00222A49
		[NullableContext(1)]
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

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x0600EA0B RID: 59915 RVA: 0x00224868 File Offset: 0x00222A68
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008115 RID: 33045
		private IDisableAllMotorRadioOperation Instance;
	}
}
