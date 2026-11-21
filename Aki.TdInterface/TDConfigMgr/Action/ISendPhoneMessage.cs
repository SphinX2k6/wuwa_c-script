using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002031 RID: 8241
	public class ISendPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600AEED RID: 44781 RVA: 0x0018A37C File Offset: 0x0018857C
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

		// Token: 0x0600AEEE RID: 44782 RVA: 0x0018A3B4 File Offset: 0x001885B4
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

		// Token: 0x0600AEEF RID: 44783 RVA: 0x0018A3C7 File Offset: 0x001885C7
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

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x0018A3DA File Offset: 0x001885DA
		public new ISendPhoneMessage_SetValue ToSetValue()
		{
			return new ISendPhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneRecordActionConfig = this.PhoneRecordActionConfig
			};
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600AEF1 RID: 44785 RVA: 0x0018A3F9 File Offset: 0x001885F9
		// (set) Token: 0x0600AEF2 RID: 44786 RVA: 0x0018A424 File Offset: 0x00188624
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

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600AEF3 RID: 44787 RVA: 0x0018A434 File Offset: 0x00188634
		// (set) Token: 0x0600AEF4 RID: 44788 RVA: 0x0018A495 File Offset: 0x00188695
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

		// Token: 0x04006836 RID: 26678
		[Nullable(2)]
		protected new ISendPhoneMessage FbInstance;

		// Token: 0x04006837 RID: 26679
		[Nullable(2)]
		protected new ISendPhoneMessage_SetValue PocoInterface;

		// Token: 0x04006838 RID: 26680
		private IPhoneRecordActionConfig _PhoneRecordActionConfigCache;

		// Token: 0x04006839 RID: 26681
		private bool _PhoneRecordActionConfigInited;
	}
}
