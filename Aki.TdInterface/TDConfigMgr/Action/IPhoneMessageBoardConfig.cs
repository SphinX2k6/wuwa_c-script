using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDE RID: 7390
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhoneMessageBoardConfig
	{
		// Token: 0x06009EA5 RID: 40613 RVA: 0x0016ABFC File Offset: 0x00168DFC
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

		// Token: 0x06009EA6 RID: 40614 RVA: 0x0016AC34 File Offset: 0x00168E34
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

		// Token: 0x06009EA7 RID: 40615 RVA: 0x0016AC47 File Offset: 0x00168E47
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

		// Token: 0x06009EA8 RID: 40616 RVA: 0x0016AC5A File Offset: 0x00168E5A
		public IPhoneMessageBoardConfig_SetValue ToSetValue()
		{
			return new IPhoneMessageBoardConfig_SetValue
			{
				PhoneMessageId = this.PhoneMessageId
			};
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x0016AC70 File Offset: 0x00168E70
		// (set) Token: 0x06009EAA RID: 40618 RVA: 0x0016ACAA File Offset: 0x00168EAA
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

		// Token: 0x04005FD9 RID: 24537
		[Nullable(2)]
		protected IPhoneMessageBoardConfig FbInstance;

		// Token: 0x04005FDA RID: 24538
		[Nullable(2)]
		protected IPhoneMessageBoardConfig_SetValue PocoInterface;
	}
}
