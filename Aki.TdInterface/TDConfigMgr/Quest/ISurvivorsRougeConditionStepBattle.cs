using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001154 RID: 4436
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepBattle : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064CA RID: 25802 RVA: 0x000F2274 File Offset: 0x000F0474
		private ISurvivorsRougeConditionStepBattle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepBattle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepBattle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepBattle_SetValue());
			}
			return result;
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x000F22AC File Offset: 0x000F04AC
		public static ISurvivorsRougeConditionStepBattle Create([Nullable(2)] ISurvivorsRougeConditionStepBattle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x000F22BF File Offset: 0x000F04BF
		public static ISurvivorsRougeConditionStepBattle CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepBattle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x000F22D2 File Offset: 0x000F04D2
		public new ISurvivorsRougeConditionStepBattle_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x000F22E5 File Offset: 0x000F04E5
		// (set) Token: 0x060064CF RID: 25807 RVA: 0x000F2310 File Offset: 0x000F0510
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

		// Token: 0x04003C85 RID: 15493
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepBattle FbInstance;

		// Token: 0x04003C86 RID: 15494
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepBattle_SetValue PocoInterface;
	}
}
