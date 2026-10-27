using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7E RID: 7038
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePointMaxStepRewardRuleItem
	{
		// Token: 0x060096BB RID: 38587 RVA: 0x0015C10C File Offset: 0x0015A30C
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

		// Token: 0x060096BC RID: 38588 RVA: 0x0015C144 File Offset: 0x0015A344
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

		// Token: 0x060096BD RID: 38589 RVA: 0x0015C157 File Offset: 0x0015A357
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

		// Token: 0x060096BE RID: 38590 RVA: 0x0015C16A File Offset: 0x0015A36A
		public ILifePointMaxStepRewardRuleItem_SetValue ToSetValue()
		{
			return new ILifePointMaxStepRewardRuleItem_SetValue
			{
				PaintCount = this.PaintCount,
				AddStep = this.AddStep
			};
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x060096BF RID: 38591 RVA: 0x0015C189 File Offset: 0x0015A389
		// (set) Token: 0x060096C0 RID: 38592 RVA: 0x0015C1B4 File Offset: 0x0015A3B4
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

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x060096C1 RID: 38593 RVA: 0x0015C1C2 File Offset: 0x0015A3C2
		// (set) Token: 0x060096C2 RID: 38594 RVA: 0x0015C1ED File Offset: 0x0015A3ED
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

		// Token: 0x04005C20 RID: 23584
		[Nullable(2)]
		protected ILifePointMaxStepRewardRuleItem FbInstance;

		// Token: 0x04005C21 RID: 23585
		[Nullable(2)]
		protected ILifePointMaxStepRewardRuleItem_SetValue PocoInterface;
	}
}
