using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002189 RID: 8585
	public class ITalkItemPhoneMessageSystemTip : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600B932 RID: 47410 RVA: 0x001A79E4 File Offset: 0x001A5BE4
		private ITalkItemPhoneMessageSystemTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageSystemTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageSystemTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageSystemTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x001A7A1C File Offset: 0x001A5C1C
		public static ITalkItemPhoneMessageSystemTip Create([Nullable(2)] ITalkItemPhoneMessageSystemTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageSystemTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x001A7A2F File Offset: 0x001A5C2F
		public static ITalkItemPhoneMessageSystemTip CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageSystemTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageSystemTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x001A7A42 File Offset: 0x001A5C42
		public new ITalkItemPhoneMessageSystemTip_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageSystemTip_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B936 RID: 47414 RVA: 0x001A7A55 File Offset: 0x001A5C55
		// (set) Token: 0x0600B937 RID: 47415 RVA: 0x001A7A80 File Offset: 0x001A5C80
		public override EPhoneMessageType Type
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

		// Token: 0x04006EC1 RID: 28353
		[Nullable(2)]
		protected new ITalkItemPhoneMessageSystemTip FbInstance;

		// Token: 0x04006EC2 RID: 28354
		[Nullable(2)]
		protected new ITalkItemPhoneMessageSystemTip_SetValue PocoInterface;
	}
}
