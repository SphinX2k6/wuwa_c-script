using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001152 RID: 4434
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064C2 RID: 25794 RVA: 0x000F21B8 File Offset: 0x000F03B8
		private ISurvivorsRougeConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x000F21F0 File Offset: 0x000F03F0
		public static ISurvivorsRougeConditionStepBase Create([Nullable(2)] ISurvivorsRougeConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x000F2203 File Offset: 0x000F0403
		public static ISurvivorsRougeConditionStepBase CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x000F2216 File Offset: 0x000F0416
		public ISurvivorsRougeConditionStepBase_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x060064C6 RID: 25798 RVA: 0x000F2229 File Offset: 0x000F0429
		// (set) Token: 0x060064C7 RID: 25799 RVA: 0x000F2254 File Offset: 0x000F0454
		public virtual ESurvivorsRougeConditionStep Type
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

		// Token: 0x04003C82 RID: 15490
		[Nullable(2)]
		protected ISurvivorsRougeConditionStepBase FbInstance;

		// Token: 0x04003C83 RID: 15491
		[Nullable(2)]
		protected ISurvivorsRougeConditionStepBase_SetValue PocoInterface;
	}
}
