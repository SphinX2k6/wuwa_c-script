using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002876 RID: 10358
	public class IPhoneMessageConfig
	{
		// Token: 0x0600E6E5 RID: 59109 RVA: 0x002229DC File Offset: 0x00220BDC
		public static IPhoneMessageConfig Create(IPhoneMessageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x0600E6E6 RID: 59110 RVA: 0x002229FC File Offset: 0x00220BFC
		public virtual bool? IsJumpToFirstOption
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsJumpToFirstOption);
			}
		}

		// Token: 0x04007F26 RID: 32550
		private IPhoneMessageConfig Instance;
	}
}
