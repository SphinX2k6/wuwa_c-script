using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002101 RID: 8449
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneSystemInteract : ActionParams
	{
		// Token: 0x0600B9DE RID: 47582 RVA: 0x001ADA58 File Offset: 0x001ABC58
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

		// Token: 0x0600B9DF RID: 47583 RVA: 0x001ADA90 File Offset: 0x001ABC90
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

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x001ADAA3 File Offset: 0x001ABCA3
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

		// Token: 0x0600B9E1 RID: 47585 RVA: 0x001ADAB6 File Offset: 0x001ABCB6
		public PhoneSystemInteract_SetValue ToSetValue()
		{
			return new PhoneSystemInteract_SetValue
			{
				InteractType = this.InteractType
			};
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x001ADAC9 File Offset: 0x001ABCC9
		// (set) Token: 0x0600B9E3 RID: 47587 RVA: 0x001ADAF0 File Offset: 0x001ABCF0
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

		// Token: 0x04006F4C RID: 28492
		[Nullable(2)]
		protected new PhoneSystemInteract FbInstance;

		// Token: 0x04006F4D RID: 28493
		[Nullable(2)]
		protected PhoneSystemInteract_SetValue PocoInterface;
	}
}
