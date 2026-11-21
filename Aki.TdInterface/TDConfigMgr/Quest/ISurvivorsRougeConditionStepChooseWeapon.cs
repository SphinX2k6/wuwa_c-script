using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128A RID: 4746
	public class ISurvivorsRougeConditionStepChooseWeapon : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AE9 RID: 27369 RVA: 0x000FF76C File Offset: 0x000FD96C
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

		// Token: 0x06006AEA RID: 27370 RVA: 0x000FF7A4 File Offset: 0x000FD9A4
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

		// Token: 0x06006AEB RID: 27371 RVA: 0x000FF7B7 File Offset: 0x000FD9B7
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

		// Token: 0x06006AEC RID: 27372 RVA: 0x000FF7CA File Offset: 0x000FD9CA
		public new ISurvivorsRougeConditionStepChooseWeapon_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepChooseWeapon_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x000FF7DD File Offset: 0x000FD9DD
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x000FF808 File Offset: 0x000FDA08
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

		// Token: 0x04003FE1 RID: 16353
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseWeapon FbInstance;

		// Token: 0x04003FE2 RID: 16354
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepChooseWeapon_SetValue PocoInterface;
	}
}
