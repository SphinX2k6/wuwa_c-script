using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B55 RID: 6997
	public class IDurationInteract
	{
		// Token: 0x060094A3 RID: 38051 RVA: 0x0015AFAC File Offset: 0x001591AC
		private IDurationInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurationInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurationInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurationInteract_SetValue());
			}
			return result;
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x0015AFE4 File Offset: 0x001591E4
		public static IDurationInteract Create([Nullable(2)] IDurationInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x0015AFF7 File Offset: 0x001591F7
		public static IDurationInteract CreateFromSetValue([Nullable(2)] IDurationInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x0015B00A File Offset: 0x0015920A
		public IDurationInteract_SetValue ToSetValue()
		{
			return new IDurationInteract_SetValue
			{
				Duration = this.Duration
			};
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x060094A7 RID: 38055 RVA: 0x0015B01D File Offset: 0x0015921D
		// (set) Token: 0x060094A8 RID: 38056 RVA: 0x0015B04C File Offset: 0x0015924C
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04005C2B RID: 23595
		[Nullable(2)]
		protected IDurationInteract FbInstance;

		// Token: 0x04005C2C RID: 23596
		[Nullable(2)]
		protected IDurationInteract_SetValue PocoInterface;
	}
}
