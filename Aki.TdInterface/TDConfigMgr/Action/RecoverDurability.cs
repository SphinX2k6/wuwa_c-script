using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002396 RID: 9110
	public class RecoverDurability : ActionParams
	{
		// Token: 0x0600C6CA RID: 50890 RVA: 0x001C7974 File Offset: 0x001C5B74
		private RecoverDurability_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RecoverDurability 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RecoverDurability_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RecoverDurability_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6CB RID: 50891 RVA: 0x001C79AC File Offset: 0x001C5BAC
		public static RecoverDurability Create([Nullable(2)] RecoverDurability instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6CC RID: 50892 RVA: 0x001C79BF File Offset: 0x001C5BBF
		public static RecoverDurability CreateFromSetValue([Nullable(2)] RecoverDurability_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6CD RID: 50893 RVA: 0x001C79D2 File Offset: 0x001C5BD2
		public RecoverDurability_SetValue ToSetValue()
		{
			return new RecoverDurability_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600C6CE RID: 50894 RVA: 0x001C79E5 File Offset: 0x001C5BE5
		// (set) Token: 0x0600C6CF RID: 50895 RVA: 0x001C7A10 File Offset: 0x001C5C10
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04007637 RID: 30263
		[Nullable(2)]
		protected new RecoverDurability FbInstance;

		// Token: 0x04007638 RID: 30264
		[Nullable(2)]
		protected RecoverDurability_SetValue PocoInterface;
	}
}
