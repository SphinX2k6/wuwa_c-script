using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001288 RID: 4744
	public class ISurvivorsRougeConditionStepChooseItem : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AE1 RID: 27361 RVA: 0x000FF6B0 File Offset: 0x000FD8B0
		private ISurvivorsRougeConditionStepChooseItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepChooseItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepChooseItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepChooseItem_SetValue());
			}
			return result;
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x000FF6E8 File Offset: 0x000FD8E8
		public static ISurvivorsRougeConditionStepChooseItem Create([Nullable(2)] ISurvivorsRougeConditionStepChooseItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x000FF6FB File Offset: 0x000FD8FB
		public static ISurvivorsRougeConditionStepChooseItem CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepChooseItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x000FF70E File Offset: 0x000FD90E
		public new ISurvivorsRougeConditionStepChooseItem_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChooseItem_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x000FF721 File Offset: 0x000FD921
		// (set) Token: 0x06006AE6 RID: 27366 RVA: 0x000FF74C File Offset: 0x000FD94C
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

		// Token: 0x04003FDE RID: 16350
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseItem FbInstance;

		// Token: 0x04003FDF RID: 16351
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseItem_SetValue PocoInterface;
	}
}
