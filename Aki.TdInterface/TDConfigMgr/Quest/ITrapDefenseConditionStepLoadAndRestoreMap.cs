using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200130C RID: 4876
	public class ITrapDefenseConditionStepLoadAndRestoreMap : ITrapDefenseConditionStepBase
	{
		// Token: 0x06006DE7 RID: 28135 RVA: 0x001059E4 File Offset: 0x00103BE4
		private ITrapDefenseConditionStepLoadAndRestoreMap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepLoadAndRestoreMap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepLoadAndRestoreMap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue());
			}
			return result;
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00105A1C File Offset: 0x00103C1C
		public static ITrapDefenseConditionStepLoadAndRestoreMap Create([Nullable(2)] ITrapDefenseConditionStepLoadAndRestoreMap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00105A2F File Offset: 0x00103C2F
		public static ITrapDefenseConditionStepLoadAndRestoreMap CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepLoadAndRestoreMap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00105A42 File Offset: 0x00103C42
		public new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x06006DEB RID: 28139 RVA: 0x00105A55 File Offset: 0x00103C55
		// (set) Token: 0x06006DEC RID: 28140 RVA: 0x00105A80 File Offset: 0x00103C80
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

		// Token: 0x0400419F RID: 16799
		[Nullable(2)]
		protected new ITrapDefenseConditionStepLoadAndRestoreMap FbInstance;

		// Token: 0x040041A0 RID: 16800
		[Nullable(2)]
		protected new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue PocoInterface;
	}
}
