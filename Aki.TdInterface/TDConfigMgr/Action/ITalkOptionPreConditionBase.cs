using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B1 RID: 8625
	public class ITalkOptionPreConditionBase
	{
		// Token: 0x0600BC12 RID: 48146 RVA: 0x001B3AC8 File Offset: 0x001B1CC8
		private ITalkOptionPreConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionPreConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionPreConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionPreConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x001B3B00 File Offset: 0x001B1D00
		public static ITalkOptionPreConditionBase Create([Nullable(2)] ITalkOptionPreConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPreConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x001B3B13 File Offset: 0x001B1D13
		public static ITalkOptionPreConditionBase CreateFromSetValue([Nullable(2)] ITalkOptionPreConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionPreConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x001B3B26 File Offset: 0x001B1D26
		public ITalkOptionPreConditionBase_SetValue ToSetValue()
		{
			return new ITalkOptionPreConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x001B3B39 File Offset: 0x001B1D39
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x001B3B64 File Offset: 0x001B1D64
		public virtual ETalkOptionPreConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400711E RID: 28958
		[Nullable(2)]
		protected ITalkOptionPreConditionBase FbInstance;

		// Token: 0x0400711F RID: 28959
		[Nullable(2)]
		protected ITalkOptionPreConditionBase_SetValue PocoInterface;
	}
}
