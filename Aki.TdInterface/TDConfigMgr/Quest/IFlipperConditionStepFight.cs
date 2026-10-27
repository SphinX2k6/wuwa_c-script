using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F93 RID: 3987
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperConditionStepFight : IFlipperConditionStepBase
	{
		// Token: 0x060058D6 RID: 22742 RVA: 0x000D8B1C File Offset: 0x000D6D1C
		private IFlipperConditionStepFight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlipperConditionStepFight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlipperConditionStepFight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlipperConditionStepFight_SetValue());
			}
			return result;
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x000D8B54 File Offset: 0x000D6D54
		public static IFlipperConditionStepFight Create([Nullable(2)] IFlipperConditionStepFight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepFight
			{
				FbInstance = instance
			};
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x000D8B67 File Offset: 0x000D6D67
		public static IFlipperConditionStepFight CreateFromSetValue([Nullable(2)] IFlipperConditionStepFight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlipperConditionStepFight
			{
				PocoInterface = value
			};
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x000D8B7A File Offset: 0x000D6D7A
		public new IFlipperConditionStepFight_SetValue ToSetValue()
		{
			return new IFlipperConditionStepFight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x000D8B8D File Offset: 0x000D6D8D
		// (set) Token: 0x060058DB RID: 22747 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
		public override EFlipperConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFlipperConditionStep.Fight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035A9 RID: 13737
		[Nullable(2)]
		protected new IFlipperConditionStepFight FbInstance;

		// Token: 0x040035AA RID: 13738
		[Nullable(2)]
		protected new IFlipperConditionStepFight_SetValue PocoInterface;
	}
}
