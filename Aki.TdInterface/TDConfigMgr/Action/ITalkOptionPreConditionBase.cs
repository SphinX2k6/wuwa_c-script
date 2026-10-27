using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F76 RID: 8054
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionPreConditionBase
	{
		// Token: 0x0600B138 RID: 45368 RVA: 0x0019DB74 File Offset: 0x0019BD74
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

		// Token: 0x0600B139 RID: 45369 RVA: 0x0019DBAC File Offset: 0x0019BDAC
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

		// Token: 0x0600B13A RID: 45370 RVA: 0x0019DBBF File Offset: 0x0019BDBF
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

		// Token: 0x0600B13B RID: 45371 RVA: 0x0019DBD2 File Offset: 0x0019BDD2
		public ITalkOptionPreConditionBase_SetValue ToSetValue()
		{
			return new ITalkOptionPreConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600B13C RID: 45372 RVA: 0x0019DBE5 File Offset: 0x0019BDE5
		// (set) Token: 0x0600B13D RID: 45373 RVA: 0x0019DC10 File Offset: 0x0019BE10
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

		// Token: 0x04006B36 RID: 27446
		[Nullable(2)]
		protected ITalkOptionPreConditionBase FbInstance;

		// Token: 0x04006B37 RID: 27447
		[Nullable(2)]
		protected ITalkOptionPreConditionBase_SetValue PocoInterface;
	}
}
