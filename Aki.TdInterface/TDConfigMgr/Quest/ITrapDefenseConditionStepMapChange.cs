using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200130E RID: 4878
	public class ITrapDefenseConditionStepMapChange : ITrapDefenseConditionStepBase
	{
		// Token: 0x06006DEF RID: 28143 RVA: 0x00105AA0 File Offset: 0x00103CA0
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

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00105AD8 File Offset: 0x00103CD8
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

		// Token: 0x06006DF1 RID: 28145 RVA: 0x00105AEB File Offset: 0x00103CEB
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

		// Token: 0x06006DF2 RID: 28146 RVA: 0x00105AFE File Offset: 0x00103CFE
		public new ITrapDefenseConditionStepMapChange_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepMapChange_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x00105B11 File Offset: 0x00103D11
		// (set) Token: 0x06006DF4 RID: 28148 RVA: 0x00105B3C File Offset: 0x00103D3C
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

		// Token: 0x040041A2 RID: 16802
		[Nullable(2)]
		protected new ITrapDefenseConditionStepMapChange FbInstance;

		// Token: 0x040041A3 RID: 16803
		[Nullable(2)]
		protected new ITrapDefenseConditionStepMapChange_SetValue PocoInterface;
	}
}
