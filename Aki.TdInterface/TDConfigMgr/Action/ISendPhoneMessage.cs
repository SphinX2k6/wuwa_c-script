using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFE RID: 7678
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600A445 RID: 42053 RVA: 0x00174974 File Offset: 0x00172B74
		private ISendPhoneMessage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendPhoneMessage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendPhoneMessage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendPhoneMessage_SetValue());
			}
			return result;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x001749AC File Offset: 0x00172BAC
		public static ISendPhoneMessage Create([Nullable(2)] ISendPhoneMessage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendPhoneMessage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x001749BF File Offset: 0x00172BBF
		public static ISendPhoneMessage CreateFromSetValue([Nullable(2)] ISendPhoneMessage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendPhoneMessage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x001749D2 File Offset: 0x00172BD2
		public new ISendPhoneMessage_SetValue ToSetValue()
		{
			return new ISendPhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneRecordActionConfig = this.PhoneRecordActionConfig
			};
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x001749F1 File Offset: 0x00172BF1
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00174A1C File Offset: 0x00172C1C
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

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x00174A2C File Offset: 0x00172C2C
		// (set) Token: 0x0600A44C RID: 42060 RVA: 0x00174A8D File Offset: 0x00172C8D
		public virtual IPhoneRecordActionConfig PhoneRecordActionConfig
		{
			get
			{
				if (this._PhoneRecordActionConfigInited)
				{
					return this._PhoneRecordActionConfigCache;
				}
				this._PhoneRecordActionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PhoneRecordActionConfigCache = IPhoneRecordActionConfig.Create(this.FbInstance.PhoneRecordActionConfig);
				}
				else
				{
					ISendPhoneMessage_SetValue pocoInterface = this.PocoInterface;
					this._PhoneRecordActionConfigCache = ((pocoInterface != null) ? pocoInterface.PhoneRecordActionConfig : null);
				}
				return this._PhoneRecordActionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PhoneRecordActionConfig = value;
				this._PhoneRecordActionConfigInited = false;
			}
		}

		// Token: 0x0400625F RID: 25183
		[Nullable(2)]
		protected new ISendPhoneMessage FbInstance;

		// Token: 0x04006260 RID: 25184
		[Nullable(2)]
		protected new ISendPhoneMessage_SetValue PocoInterface;

		// Token: 0x04006261 RID: 25185
		private IPhoneRecordActionConfig _PhoneRecordActionConfigCache;

		// Token: 0x04006262 RID: 25186
		private bool _PhoneRecordActionConfigInited;
	}
}
