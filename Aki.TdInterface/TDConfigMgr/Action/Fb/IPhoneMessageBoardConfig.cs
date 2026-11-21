using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBA RID: 11706
	public class IPhoneMessageBoardConfig
	{
		// Token: 0x0600FEF7 RID: 65271 RVA: 0x0024C156 File Offset: 0x0024A356
		public static IPhoneMessageBoardConfig Create(IPhoneMessageBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x0600FEF8 RID: 65272 RVA: 0x0024C178 File Offset: 0x0024A378
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

		// Token: 0x04008B28 RID: 35624
		private IPhoneMessageBoardConfig Instance;
	}
}
