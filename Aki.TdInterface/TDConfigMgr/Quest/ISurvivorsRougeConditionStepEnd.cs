using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128C RID: 4748
	public class ISurvivorsRougeConditionStepEnd : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AF1 RID: 27377 RVA: 0x000FF828 File Offset: 0x000FDA28
		private ISurvivorsRougeConditionStepEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepEnd_SetValue());
			}
			return result;
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x000FF860 File Offset: 0x000FDA60
		public static ISurvivorsRougeConditionStepEnd Create([Nullable(2)] ISurvivorsRougeConditionStepEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x000FF873 File Offset: 0x000FDA73
		public static ISurvivorsRougeConditionStepEnd CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x000FF886 File Offset: 0x000FDA86
		public new ISurvivorsRougeConditionStepEnd_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x000FF899 File Offset: 0x000FDA99
		// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x000FF8C4 File Offset: 0x000FDAC4
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

		// Token: 0x04003FE4 RID: 16356
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepEnd FbInstance;

		// Token: 0x04003FE5 RID: 16357
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepEnd_SetValue PocoInterface;
	}
}
