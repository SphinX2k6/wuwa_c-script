using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6E RID: 8046
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600B116 RID: 45334 RVA: 0x0019D830 File Offset: 0x0019BA30
		private ITalkOptionConditionSystemConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionConditionSystemConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionConditionSystemConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionConditionSystemConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x0019D868 File Offset: 0x0019BA68
		public static ITalkOptionConditionSystemConfigBase Create([Nullable(2)] ITalkOptionConditionSystemConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x0019D87B File Offset: 0x0019BA7B
		public static ITalkOptionConditionSystemConfigBase CreateFromSetValue([Nullable(2)] ITalkOptionConditionSystemConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x0019D88E File Offset: 0x0019BA8E
		public ITalkOptionConditionSystemConfigBase_SetValue ToSetValue()
		{
			return new ITalkOptionConditionSystemConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600B11A RID: 45338 RVA: 0x0019D8A1 File Offset: 0x0019BAA1
		// (set) Token: 0x0600B11B RID: 45339 RVA: 0x0019D8CC File Offset: 0x0019BACC
		public virtual ETalkOptionConditionSystem Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionConditionSystem.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B29 RID: 27433
		[Nullable(2)]
		protected ITalkOptionConditionSystemConfigBase FbInstance;

		// Token: 0x04006B2A RID: 27434
		[Nullable(2)]
		protected ITalkOptionConditionSystemConfigBase_SetValue PocoInterface;
	}
}
