using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D2 RID: 4562
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepMapChange : ITrapDefenseConditionStepBase
	{
		// Token: 0x060067AE RID: 26542 RVA: 0x000F8194 File Offset: 0x000F6394
		private ITrapDefenseConditionStepMapChange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepMapChange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepMapChange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepMapChange_SetValue());
			}
			return result;
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x000F81CC File Offset: 0x000F63CC
		public static ITrapDefenseConditionStepMapChange Create([Nullable(2)] ITrapDefenseConditionStepMapChange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepMapChange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x000F81DF File Offset: 0x000F63DF
		public static ITrapDefenseConditionStepMapChange CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepMapChange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepMapChange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x000F81F2 File Offset: 0x000F63F2
		public new ITrapDefenseConditionStepMapChange_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepMapChange_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x000F8205 File Offset: 0x000F6405
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x000F8230 File Offset: 0x000F6430
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E34 RID: 15924
		[Nullable(2)]
		protected new ITrapDefenseConditionStepMapChange FbInstance;

		// Token: 0x04003E35 RID: 15925
		[Nullable(2)]
		protected new ITrapDefenseConditionStepMapChange_SetValue PocoInterface;
	}
}
