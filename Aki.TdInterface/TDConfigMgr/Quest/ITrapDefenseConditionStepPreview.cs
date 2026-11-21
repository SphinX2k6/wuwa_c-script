using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001310 RID: 4880
	public class ITrapDefenseConditionStepPreview : ITrapDefenseConditionStepBase
	{
		// Token: 0x06006DF7 RID: 28151 RVA: 0x00105B5C File Offset: 0x00103D5C
		private ITrapDefenseConditionStepPreview_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepPreview 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepPreview_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepPreview_SetValue());
			}
			return result;
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x00105B94 File Offset: 0x00103D94
		public static ITrapDefenseConditionStepPreview Create([Nullable(2)] ITrapDefenseConditionStepPreview instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepPreview
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x00105BA7 File Offset: 0x00103DA7
		public static ITrapDefenseConditionStepPreview CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepPreview_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepPreview
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00105BBA File Offset: 0x00103DBA
		public new ITrapDefenseConditionStepPreview_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepPreview_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x00105BCD File Offset: 0x00103DCD
		// (set) Token: 0x06006DFC RID: 28156 RVA: 0x00105BF8 File Offset: 0x00103DF8
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

		// Token: 0x040041A5 RID: 16805
		[Nullable(2)]
		protected new ITrapDefenseConditionStepPreview FbInstance;

		// Token: 0x040041A6 RID: 16806
		[Nullable(2)]
		protected new ITrapDefenseConditionStepPreview_SetValue PocoInterface;
	}
}
