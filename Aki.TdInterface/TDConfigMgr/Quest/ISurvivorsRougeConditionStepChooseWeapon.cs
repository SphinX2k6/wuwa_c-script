using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200115A RID: 4442
	[NullableContext(1)]
	[Nullable(0)]
	public class ISurvivorsRougeConditionStepChooseWeapon : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060064E2 RID: 25826 RVA: 0x000F24A8 File Offset: 0x000F06A8
		private ISurvivorsRougeConditionStepChooseWeapon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepChooseWeapon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepChooseWeapon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepChooseWeapon_SetValue());
			}
			return result;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x000F24E0 File Offset: 0x000F06E0
		public static ISurvivorsRougeConditionStepChooseWeapon Create([Nullable(2)] ISurvivorsRougeConditionStepChooseWeapon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseWeapon
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x000F24F3 File Offset: 0x000F06F3
		public static ISurvivorsRougeConditionStepChooseWeapon CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepChooseWeapon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseWeapon
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x000F2506 File Offset: 0x000F0706
		public new ISurvivorsRougeConditionStepChooseWeapon_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChooseWeapon_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x060064E6 RID: 25830 RVA: 0x000F2519 File Offset: 0x000F0719
		// (set) Token: 0x060064E7 RID: 25831 RVA: 0x000F2544 File Offset: 0x000F0744
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

		// Token: 0x04003C8E RID: 15502
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseWeapon FbInstance;

		// Token: 0x04003C8F RID: 15503
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseWeapon_SetValue PocoInterface;
	}
}
