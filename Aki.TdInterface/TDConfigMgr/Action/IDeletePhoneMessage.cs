using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001980 RID: 6528
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeletePhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x06008BC9 RID: 35785 RVA: 0x00148658 File Offset: 0x00146858
		private IDeletePhoneMessage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeletePhoneMessage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeletePhoneMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeletePhoneMessage_SetValue());
			}
			return result;
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x00148690 File Offset: 0x00146890
		public static IDeletePhoneMessage Create([Nullable(2)] IDeletePhoneMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeletePhoneMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x001486A3 File Offset: 0x001468A3
		public static IDeletePhoneMessage CreateFromSetValue([Nullable(2)] IDeletePhoneMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeletePhoneMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x001486B6 File Offset: 0x001468B6
		public new IDeletePhoneMessage_SetValue ToSetValue()
		{
			return new IDeletePhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneMessageId = this.PhoneMessageId
			};
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x06008BCD RID: 35789 RVA: 0x001486D5 File Offset: 0x001468D5
		// (set) Token: 0x06008BCE RID: 35790 RVA: 0x00148700 File Offset: 0x00146900
		public override EPhoneSystemInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x06008BCF RID: 35791 RVA: 0x00148710 File Offset: 0x00146910
		// (set) Token: 0x06008BD0 RID: 35792 RVA: 0x0014874A File Offset: 0x0014694A
		public virtual int? PhoneMessageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhoneMessageId;
				}
				IDeletePhoneMessage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005720 RID: 22304
		[Nullable(2)]
		protected new IDeletePhoneMessage FbInstance;

		// Token: 0x04005721 RID: 22305
		[Nullable(2)]
		protected new IDeletePhoneMessage_SetValue PocoInterface;
	}
}
