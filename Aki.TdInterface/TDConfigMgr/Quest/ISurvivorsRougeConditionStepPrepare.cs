using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200115E RID: 4446
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepPrepare : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064F2 RID: 25842 RVA: 0x000F2620 File Offset: 0x000F0820
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

		// Token: 0x060064F3 RID: 25843 RVA: 0x000F2658 File Offset: 0x000F0858
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

		// Token: 0x060064F4 RID: 25844 RVA: 0x000F266B File Offset: 0x000F086B
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

		// Token: 0x060064F5 RID: 25845 RVA: 0x000F267E File Offset: 0x000F087E
		public new ISurvivorsRougeConditionStepPrepare_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x000F2691 File Offset: 0x000F0891
		// (set) Token: 0x060064F7 RID: 25847 RVA: 0x000F26BC File Offset: 0x000F08BC
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

		// Token: 0x04003C94 RID: 15508
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepPrepare FbInstance;

		// Token: 0x04003C95 RID: 15509
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepPrepare_SetValue PocoInterface;
	}
}
