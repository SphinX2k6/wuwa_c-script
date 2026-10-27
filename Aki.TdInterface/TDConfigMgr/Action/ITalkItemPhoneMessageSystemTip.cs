using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F50 RID: 8016
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemPhoneMessageSystemTip : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600AE60 RID: 44640 RVA: 0x001919EC File Offset: 0x0018FBEC
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

		// Token: 0x0600AE61 RID: 44641 RVA: 0x00191A24 File Offset: 0x0018FC24
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

		// Token: 0x0600AE62 RID: 44642 RVA: 0x00191A37 File Offset: 0x0018FC37
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

		// Token: 0x0600AE63 RID: 44643 RVA: 0x00191A4A File Offset: 0x0018FC4A
		public new ITalkItemPhoneMessageSystemTip_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageSystemTip_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600AE64 RID: 44644 RVA: 0x00191A5D File Offset: 0x0018FC5D
		// (set) Token: 0x0600AE65 RID: 44645 RVA: 0x00191A88 File Offset: 0x0018FC88
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

		// Token: 0x040068D2 RID: 26834
		[Nullable(2)]
		protected new ITalkItemPhoneMessageSystemTip FbInstance;

		// Token: 0x040068D3 RID: 26835
		[Nullable(2)]
		protected new ITalkItemPhoneMessageSystemTip_SetValue PocoInterface;
	}
}
