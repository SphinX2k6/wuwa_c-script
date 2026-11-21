using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002362 RID: 9058
	public class PhoneSystemInteract : ActionParams
	{
		// Token: 0x0600C56A RID: 50538 RVA: 0x001C4BB8 File Offset: 0x001C2DB8
		private PhoneSystemInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PhoneSystemInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PhoneSystemInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PhoneSystemInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x001C4BF0 File Offset: 0x001C2DF0
		public static PhoneSystemInteract Create([Nullable(2)] PhoneSystemInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PhoneSystemInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x001C4C03 File Offset: 0x001C2E03
		public static PhoneSystemInteract CreateFromSetValue([Nullable(2)] PhoneSystemInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PhoneSystemInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x001C4C16 File Offset: 0x001C2E16
		public PhoneSystemInteract_SetValue ToSetValue()
		{
			return new PhoneSystemInteract_SetValue
			{
				InteractType = this.InteractType
			};
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600C56E RID: 50542 RVA: 0x001C4C29 File Offset: 0x001C2E29
		// (set) Token: 0x0600C56F RID: 50543 RVA: 0x001C4C50 File Offset: 0x001C2E50
		public virtual IPhoneSystemInteractBase InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				PhoneSystemInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x04007580 RID: 30080
		[Nullable(2)]
		protected new PhoneSystemInteract FbInstance;

		// Token: 0x04007581 RID: 30081
		[Nullable(2)]
		protected PhoneSystemInteract_SetValue PocoInterface;
	}
}
