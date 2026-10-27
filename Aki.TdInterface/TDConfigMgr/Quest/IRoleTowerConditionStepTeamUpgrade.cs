using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001112 RID: 4370
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepTeamUpgrade : IRoleTowerConditionStepBase
	{
		// Token: 0x060062B2 RID: 25266 RVA: 0x000ED78C File Offset: 0x000EB98C
		private IRoleTowerConditionStepTeamUpgrade_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepTeamUpgrade 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepTeamUpgrade_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepTeamUpgrade_SetValue());
			}
			return result;
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x000ED7C4 File Offset: 0x000EB9C4
		public static IRoleTowerConditionStepTeamUpgrade Create([Nullable(2)] IRoleTowerConditionStepTeamUpgrade instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepTeamUpgrade
			{
				FbInstance = instance
			};
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x000ED7D7 File Offset: 0x000EB9D7
		public static IRoleTowerConditionStepTeamUpgrade CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepTeamUpgrade_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepTeamUpgrade
			{
				PocoInterface = value
			};
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x000ED7EA File Offset: 0x000EB9EA
		public new IRoleTowerConditionStepTeamUpgrade_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepTeamUpgrade_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x060062B6 RID: 25270 RVA: 0x000ED7FD File Offset: 0x000EB9FD
		// (set) Token: 0x060062B7 RID: 25271 RVA: 0x000ED828 File Offset: 0x000EBA28
		public override ERoleTowerConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B37 RID: 15159
		[Nullable(2)]
		protected new IRoleTowerConditionStepTeamUpgrade FbInstance;

		// Token: 0x04003B38 RID: 15160
		[Nullable(2)]
		protected new IRoleTowerConditionStepTeamUpgrade_SetValue PocoInterface;
	}
}
