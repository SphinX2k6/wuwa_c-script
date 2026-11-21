using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C11 RID: 11281
	public class IMotorRadioDisableRange
	{
		// Token: 0x0600F856 RID: 63574 RVA: 0x00241B39 File Offset: 0x0023FD39
		public static IMotorRadioDisableRange Create(IMotorRadioDisableRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x0600F857 RID: 63575 RVA: 0x00241B58 File Offset: 0x0023FD58
		public virtual EMotorRadioDisableRangeType Type
		{
			get
			{
				return (EMotorRadioDisableRangeType)this.Instance.Type;
			}
		}

		// Token: 0x040087E1 RID: 34785
		private IMotorRadioDisableRange Instance;
	}
}
