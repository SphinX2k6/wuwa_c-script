using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002185 RID: 8581
	public class ITalkItemPhoneMessageBase
	{
		// Token: 0x0600B920 RID: 47392 RVA: 0x001A7828 File Offset: 0x001A5A28
		private ITalkItemPhoneMessageBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x001A7860 File Offset: 0x001A5A60
		public static ITalkItemPhoneMessageBase Create([Nullable(2)] ITalkItemPhoneMessageBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x001A7873 File Offset: 0x001A5A73
		public static ITalkItemPhoneMessageBase CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x001A7886 File Offset: 0x001A5A86
		public ITalkItemPhoneMessageBase_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B924 RID: 47396 RVA: 0x001A7899 File Offset: 0x001A5A99
		// (set) Token: 0x0600B925 RID: 47397 RVA: 0x001A78C4 File Offset: 0x001A5AC4
		public virtual EPhoneMessageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageType.Voice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006EBA RID: 28346
		[Nullable(2)]
		protected ITalkItemPhoneMessageBase FbInstance;

		// Token: 0x04006EBB RID: 28347
		[Nullable(2)]
		protected ITalkItemPhoneMessageBase_SetValue PocoInterface;
	}
}
