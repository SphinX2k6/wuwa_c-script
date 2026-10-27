using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001108 RID: 4360
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepBase
	{
		// Token: 0x0600628A RID: 25226 RVA: 0x000ED3E0 File Offset: 0x000EB5E0
		private IRoleTowerConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x000ED418 File Offset: 0x000EB618
		public static IRoleTowerConditionStepBase Create([Nullable(2)] IRoleTowerConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x000ED42B File Offset: 0x000EB62B
		public static IRoleTowerConditionStepBase CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x000ED43E File Offset: 0x000EB63E
		public IRoleTowerConditionStepBase_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x000ED451 File Offset: 0x000EB651
		// (set) Token: 0x0600628F RID: 25231 RVA: 0x000ED47C File Offset: 0x000EB67C
		public virtual ERoleTowerConditionStep Type
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

		// Token: 0x04003B28 RID: 15144
		[Nullable(2)]
		protected IRoleTowerConditionStepBase FbInstance;

		// Token: 0x04003B29 RID: 15145
		[Nullable(2)]
		protected IRoleTowerConditionStepBase_SetValue PocoInterface;
	}
}
