using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002150 RID: 8528
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveNpcGroupPerform : ActionParams
	{
		// Token: 0x0600BBB2 RID: 48050 RVA: 0x001B1380 File Offset: 0x001AF580
		private RemoveNpcGroupPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveNpcGroupPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveNpcGroupPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveNpcGroupPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBB3 RID: 48051 RVA: 0x001B13B8 File Offset: 0x001AF5B8
		public static RemoveNpcGroupPerform Create([Nullable(2)] RemoveNpcGroupPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x001B13CB File Offset: 0x001AF5CB
		public static RemoveNpcGroupPerform CreateFromSetValue([Nullable(2)] RemoveNpcGroupPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x001B13DE File Offset: 0x001AF5DE
		public RemoveNpcGroupPerform_SetValue ToSetValue()
		{
			return new RemoveNpcGroupPerform_SetValue
			{
				Key = this.Key
			};
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x001B13F1 File Offset: 0x001AF5F1
		// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x001B141C File Offset: 0x001AF61C
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x04007034 RID: 28724
		[Nullable(2)]
		protected new RemoveNpcGroupPerform FbInstance;

		// Token: 0x04007035 RID: 28725
		[Nullable(2)]
		protected RemoveNpcGroupPerform_SetValue PocoInterface;
	}
}
