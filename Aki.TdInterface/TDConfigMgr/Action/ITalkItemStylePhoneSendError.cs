using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002193 RID: 8595
	public class ITalkItemStylePhoneSendError : ITalkItemStyle
	{
		// Token: 0x0600B9A0 RID: 47520 RVA: 0x001A93F0 File Offset: 0x001A75F0
		private ITalkItemStylePhoneSendError_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStylePhoneSendError 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStylePhoneSendError_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStylePhoneSendError_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x001A9428 File Offset: 0x001A7628
		public static ITalkItemStylePhoneSendError Create([Nullable(2)] ITalkItemStylePhoneSendError instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStylePhoneSendError
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x001A943B File Offset: 0x001A763B
		public static ITalkItemStylePhoneSendError CreateFromSetValue([Nullable(2)] ITalkItemStylePhoneSendError_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStylePhoneSendError
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x001A944E File Offset: 0x001A764E
		public new ITalkItemStylePhoneSendError_SetValue ToSetValue()
		{
			return new ITalkItemStylePhoneSendError_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B9A4 RID: 47524 RVA: 0x001A9461 File Offset: 0x001A7661
		// (set) Token: 0x0600B9A5 RID: 47525 RVA: 0x001A948C File Offset: 0x001A768C
		public override ETalkItemStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006F16 RID: 28438
		[Nullable(2)]
		protected new ITalkItemStylePhoneSendError FbInstance;

		// Token: 0x04006F17 RID: 28439
		[Nullable(2)]
		protected new ITalkItemStylePhoneSendError_SetValue PocoInterface;
	}
}
