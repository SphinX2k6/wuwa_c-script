using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2B RID: 7467
	public class ILifePointMaxStepRewardRuleItem
	{
		// Token: 0x06009E9D RID: 40605 RVA: 0x0016CCB8 File Offset: 0x0016AEB8
		private ILifePointMaxStepRewardRuleItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILifePointMaxStepRewardRuleItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILifePointMaxStepRewardRuleItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILifePointMaxStepRewardRuleItem_SetValue());
			}
			return result;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x0016CCF0 File Offset: 0x0016AEF0
		public static ILifePointMaxStepRewardRuleItem Create([Nullable(2)] ILifePointMaxStepRewardRuleItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePointMaxStepRewardRuleItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x0016CD03 File Offset: 0x0016AF03
		public static ILifePointMaxStepRewardRuleItem CreateFromSetValue([Nullable(2)] ILifePointMaxStepRewardRuleItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILifePointMaxStepRewardRuleItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x0016CD16 File Offset: 0x0016AF16
		public ILifePointMaxStepRewardRuleItem_SetValue ToSetValue()
		{
			return new ILifePointMaxStepRewardRuleItem_SetValue
			{
				PaintCount = this.PaintCount,
				AddStep = this.AddStep
			};
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x0016CD35 File Offset: 0x0016AF35
		// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x0016CD60 File Offset: 0x0016AF60
		public virtual int PaintCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PaintCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PaintCount;
			}
			set
			{
				this.GetOrCreatePoco().PaintCount = value;
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x0016CD6E File Offset: 0x0016AF6E
		// (set) Token: 0x06009EA4 RID: 40612 RVA: 0x0016CD99 File Offset: 0x0016AF99
		public virtual int AddStep
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddStep;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddStep;
			}
			set
			{
				this.GetOrCreatePoco().AddStep = value;
			}
		}

		// Token: 0x040060B9 RID: 24761
		[Nullable(2)]
		protected ILifePointMaxStepRewardRuleItem FbInstance;

		// Token: 0x040060BA RID: 24762
		[Nullable(2)]
		protected ILifePointMaxStepRewardRuleItem_SetValue PocoInterface;
	}
}
