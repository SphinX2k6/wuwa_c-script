using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001240 RID: 4672
	public class IRoleTowerConditionStepTeamUpgrade : IRoleTowerConditionStepBase
	{
		// Token: 0x060068AD RID: 26797 RVA: 0x000FA900 File Offset: 0x000F8B00
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

		// Token: 0x060068AE RID: 26798 RVA: 0x000FA938 File Offset: 0x000F8B38
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

		// Token: 0x060068AF RID: 26799 RVA: 0x000FA94B File Offset: 0x000F8B4B
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

		// Token: 0x060068B0 RID: 26800 RVA: 0x000FA95E File Offset: 0x000F8B5E
		public new IRoleTowerConditionStepTeamUpgrade_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepTeamUpgrade_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x000FA971 File Offset: 0x000F8B71
		// (set) Token: 0x060068B2 RID: 26802 RVA: 0x000FA99C File Offset: 0x000F8B9C
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

		// Token: 0x04003E85 RID: 16005
		[Nullable(2)]
		protected new IRoleTowerConditionStepTeamUpgrade FbInstance;

		// Token: 0x04003E86 RID: 16006
		[Nullable(2)]
		protected new IRoleTowerConditionStepTeamUpgrade_SetValue PocoInterface;
	}
}
