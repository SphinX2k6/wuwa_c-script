using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128E RID: 4750
	public class ISurvivorsRougeConditionStepPrepare : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AF9 RID: 27385 RVA: 0x000FF8E4 File Offset: 0x000FDAE4
		private ISurvivorsRougeConditionStepPrepare_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepPrepare 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepPrepare_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepPrepare_SetValue());
			}
			return result;
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x000FF91C File Offset: 0x000FDB1C
		public static ISurvivorsRougeConditionStepPrepare Create([Nullable(2)] ISurvivorsRougeConditionStepPrepare instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepPrepare
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x000FF92F File Offset: 0x000FDB2F
		public static ISurvivorsRougeConditionStepPrepare CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepPrepare_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepPrepare
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x000FF942 File Offset: 0x000FDB42
		public new ISurvivorsRougeConditionStepPrepare_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x000FF955 File Offset: 0x000FDB55
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x000FF980 File Offset: 0x000FDB80
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003FE7 RID: 16359
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepPrepare FbInstance;

		// Token: 0x04003FE8 RID: 16360
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepPrepare_SetValue PocoInterface;
	}
}
