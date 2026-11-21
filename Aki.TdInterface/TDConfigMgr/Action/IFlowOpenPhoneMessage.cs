using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2C RID: 7212
	public class IFlowOpenPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600996C RID: 39276 RVA: 0x00163A54 File Offset: 0x00161C54
		private IFlowOpenPhoneMessage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowOpenPhoneMessage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowOpenPhoneMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowOpenPhoneMessage_SetValue());
			}
			return result;
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x00163A8C File Offset: 0x00161C8C
		public static IFlowOpenPhoneMessage Create([Nullable(2)] IFlowOpenPhoneMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowOpenPhoneMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00163A9F File Offset: 0x00161C9F
		public static IFlowOpenPhoneMessage CreateFromSetValue([Nullable(2)] IFlowOpenPhoneMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowOpenPhoneMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x00163AB2 File Offset: 0x00161CB2
		public new IFlowOpenPhoneMessage_SetValue ToSetValue()
		{
			return new IFlowOpenPhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneBoardType = this.PhoneBoardType
			};
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x00163AD1 File Offset: 0x00161CD1
		// (set) Token: 0x06009971 RID: 39281 RVA: 0x00163AFC File Offset: 0x00161CFC
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

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x00163B0C File Offset: 0x00161D0C
		// (set) Token: 0x06009973 RID: 39283 RVA: 0x00163B6D File Offset: 0x00161D6D
		public virtual IMessageBoard PhoneBoardType
		{
			get
			{
				if (this._PhoneBoardTypeInited)
				{
					return this._PhoneBoardTypeCache;
				}
				this._PhoneBoardTypeInited = true;
				if (this.FbInstance != null)
				{
					this._PhoneBoardTypeCache = IMessageBoard.Create(this.FbInstance.PhoneBoardType);
				}
				else
				{
					IFlowOpenPhoneMessage_SetValue pocoInterface = this.PocoInterface;
					this._PhoneBoardTypeCache = ((pocoInterface != null) ? pocoInterface.PhoneBoardType : null);
				}
				return this._PhoneBoardTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().PhoneBoardType = value;
				this._PhoneBoardTypeInited = false;
			}
		}

		// Token: 0x04005E5E RID: 24158
		[Nullable(2)]
		protected new IFlowOpenPhoneMessage FbInstance;

		// Token: 0x04005E5F RID: 24159
		[Nullable(2)]
		protected new IFlowOpenPhoneMessage_SetValue PocoInterface;

		// Token: 0x04005E60 RID: 24160
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x04005E61 RID: 24161
		private bool _PhoneBoardTypeInited;
	}
}
