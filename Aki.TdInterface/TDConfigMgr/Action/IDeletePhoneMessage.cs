using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0B RID: 6923
	public class IDeletePhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x06009301 RID: 37633 RVA: 0x001580E8 File Offset: 0x001562E8
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

		// Token: 0x06009302 RID: 37634 RVA: 0x00158120 File Offset: 0x00156320
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

		// Token: 0x06009303 RID: 37635 RVA: 0x00158133 File Offset: 0x00156333
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

		// Token: 0x06009304 RID: 37636 RVA: 0x00158146 File Offset: 0x00156346
		public new IDeletePhoneMessage_SetValue ToSetValue()
		{
			return new IDeletePhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneMessageId = this.PhoneMessageId
			};
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x06009305 RID: 37637 RVA: 0x00158165 File Offset: 0x00156365
		// (set) Token: 0x06009306 RID: 37638 RVA: 0x00158190 File Offset: 0x00156390
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

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x06009307 RID: 37639 RVA: 0x001581A0 File Offset: 0x001563A0
		// (set) Token: 0x06009308 RID: 37640 RVA: 0x001581DA File Offset: 0x001563DA
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

		// Token: 0x04005B75 RID: 23413
		[Nullable(2)]
		protected new IDeletePhoneMessage FbInstance;

		// Token: 0x04005B76 RID: 23414
		[Nullable(2)]
		protected new IDeletePhoneMessage_SetValue PocoInterface;
	}
}
