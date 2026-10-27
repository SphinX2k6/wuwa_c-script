using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC6 RID: 10950
	public class IPhoneMessageBoardConfig
	{
		// Token: 0x0600F041 RID: 61505 RVA: 0x0022E44A File Offset: 0x0022C64A
		[NullableContext(1)]
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

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x0600F042 RID: 61506 RVA: 0x0022E46C File Offset: 0x0022C66C
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

		// Token: 0x04008424 RID: 33828
		private IPhoneMessageBoardConfig Instance;
	}
}
