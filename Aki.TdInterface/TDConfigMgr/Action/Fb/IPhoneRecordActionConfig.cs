using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB5 RID: 11701
	public class IPhoneRecordActionConfig
	{
		// Token: 0x0600FEE5 RID: 65253 RVA: 0x0024BF85 File Offset: 0x0024A185
		public static IPhoneRecordActionConfig Create(IPhoneRecordActionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneRecordActionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x0600FEE6 RID: 65254 RVA: 0x0024BFA4 File Offset: 0x0024A1A4
		public virtual int? PhoneMessageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PhoneMessageId);
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x0600FEE7 RID: 65255 RVA: 0x0024BFDC File Offset: 0x0024A1DC
		public virtual int? DialogProgress
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DialogProgress);
			}
		}

		// Token: 0x04008B21 RID: 35617
		private IPhoneRecordActionConfig Instance;
	}
}
