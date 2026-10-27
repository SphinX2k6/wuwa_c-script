using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110C RID: 4364
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepLoadSubLevel : IRoleTowerConditionStepBase
	{
		// Token: 0x0600629A RID: 25242 RVA: 0x000ED558 File Offset: 0x000EB758
		private IRoleTowerConditionStepLoadSubLevel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepLoadSubLevel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepLoadSubLevel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepLoadSubLevel_SetValue());
			}
			return result;
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x000ED590 File Offset: 0x000EB790
		public static IRoleTowerConditionStepLoadSubLevel Create([Nullable(2)] IRoleTowerConditionStepLoadSubLevel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepLoadSubLevel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x000ED5A3 File Offset: 0x000EB7A3
		public static IRoleTowerConditionStepLoadSubLevel CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepLoadSubLevel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepLoadSubLevel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x000ED5B6 File Offset: 0x000EB7B6
		public new IRoleTowerConditionStepLoadSubLevel_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepLoadSubLevel_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x000ED5C9 File Offset: 0x000EB7C9
		// (set) Token: 0x0600629F RID: 25247 RVA: 0x000ED5F4 File Offset: 0x000EB7F4
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

		// Token: 0x04003B2E RID: 15150
		[Nullable(2)]
		protected new IRoleTowerConditionStepLoadSubLevel FbInstance;

		// Token: 0x04003B2F RID: 15151
		[Nullable(2)]
		protected new IRoleTowerConditionStepLoadSubLevel_SetValue PocoInterface;
	}
}
