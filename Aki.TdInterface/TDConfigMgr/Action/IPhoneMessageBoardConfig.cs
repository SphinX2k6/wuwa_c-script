using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EED RID: 7917
	public class IPhoneMessageBoardConfig
	{
		// Token: 0x0600A885 RID: 43141 RVA: 0x0017EE5C File Offset: 0x0017D05C
		private IPhoneMessageBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneMessageBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneMessageBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneMessageBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x0017EE94 File Offset: 0x0017D094
		public static IPhoneMessageBoardConfig Create([Nullable(2)] IPhoneMessageBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x0017EEA7 File Offset: 0x0017D0A7
		public static IPhoneMessageBoardConfig CreateFromSetValue([Nullable(2)] IPhoneMessageBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneMessageBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x0017EEBA File Offset: 0x0017D0BA
		public IPhoneMessageBoardConfig_SetValue ToSetValue()
		{
			return new IPhoneMessageBoardConfig_SetValue
			{
				PhoneMessageId = this.PhoneMessageId
			};
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x0017EED0 File Offset: 0x0017D0D0
		// (set) Token: 0x0600A88A RID: 43146 RVA: 0x0017EF0A File Offset: 0x0017D10A
		public virtual int? PhoneMessageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhoneMessageId;
				}
				IPhoneMessageBoardConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PhoneMessageId;
			}
			set
			{
				this.GetOrCreatePoco().PhoneMessageId = value;
			}
		}

		// Token: 0x0400654C RID: 25932
		[Nullable(2)]
		protected IPhoneMessageBoardConfig FbInstance;

		// Token: 0x0400654D RID: 25933
		[Nullable(2)]
		protected IPhoneMessageBoardConfig_SetValue PocoInterface;
	}
}
