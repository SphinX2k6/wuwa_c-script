using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002935 RID: 10549
	public class IMotorRadioOperationRestriction
	{
		// Token: 0x0600EA04 RID: 59908 RVA: 0x002247E1 File Offset: 0x002229E1
		[NullableContext(1)]
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

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x00224800 File Offset: 0x00222A00
		public virtual EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008113 RID: 33043
		private IMotorRadioOperationRestriction Instance;
	}
}
