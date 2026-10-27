using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A97 RID: 6807
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowOpenPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x060091FE RID: 37374 RVA: 0x00153A34 File Offset: 0x00151C34
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

		// Token: 0x060091FF RID: 37375 RVA: 0x00153A6C File Offset: 0x00151C6C
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

		// Token: 0x06009200 RID: 37376 RVA: 0x00153A7F File Offset: 0x00151C7F
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

		// Token: 0x06009201 RID: 37377 RVA: 0x00153A92 File Offset: 0x00151C92
		public new IFlowOpenPhoneMessage_SetValue ToSetValue()
		{
			return new IFlowOpenPhoneMessage_SetValue
			{
				Type = this.Type,
				PhoneBoardType = this.PhoneBoardType
			};
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x00153AB1 File Offset: 0x00151CB1
		// (set) Token: 0x06009203 RID: 37379 RVA: 0x00153ADC File Offset: 0x00151CDC
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

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x06009204 RID: 37380 RVA: 0x00153AEC File Offset: 0x00151CEC
		// (set) Token: 0x06009205 RID: 37381 RVA: 0x00153B4D File Offset: 0x00151D4D
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

		// Token: 0x040059F5 RID: 23029
		[Nullable(2)]
		protected new IFlowOpenPhoneMessage FbInstance;

		// Token: 0x040059F6 RID: 23030
		[Nullable(2)]
		protected new IFlowOpenPhoneMessage_SetValue PocoInterface;

		// Token: 0x040059F7 RID: 23031
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x040059F8 RID: 23032
		private bool _PhoneBoardTypeInited;
	}
}
