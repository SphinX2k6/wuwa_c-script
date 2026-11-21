using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010BD RID: 4285
	public class IFlipperConditionStepFight : IFlipperConditionStepBase
	{
		// Token: 0x06005EA8 RID: 24232 RVA: 0x000E5544 File Offset: 0x000E3744
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

		// Token: 0x06005EA9 RID: 24233 RVA: 0x000E557C File Offset: 0x000E377C
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

		// Token: 0x06005EAA RID: 24234 RVA: 0x000E558F File Offset: 0x000E378F
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

		// Token: 0x06005EAB RID: 24235 RVA: 0x000E55A2 File Offset: 0x000E37A2
		public new IFlipperConditionStepFight_SetValue ToSetValue()
		{
			return new IFlipperConditionStepFight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06005EAC RID: 24236 RVA: 0x000E55B5 File Offset: 0x000E37B5
		// (set) Token: 0x06005EAD RID: 24237 RVA: 0x000E55E0 File Offset: 0x000E37E0
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

		// Token: 0x040038D9 RID: 14553
		[Nullable(2)]
		protected new IFlipperConditionStepFight FbInstance;

		// Token: 0x040038DA RID: 14554
		[Nullable(2)]
		protected new IFlipperConditionStepFight_SetValue PocoInterface;
	}
}
