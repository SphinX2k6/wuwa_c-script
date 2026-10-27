using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D4 RID: 4564
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepPreview : ITrapDefenseConditionStepBase
	{
		// Token: 0x060067B6 RID: 26550 RVA: 0x000F8250 File Offset: 0x000F6450
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

		// Token: 0x060067B7 RID: 26551 RVA: 0x000F8288 File Offset: 0x000F6488
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

		// Token: 0x060067B8 RID: 26552 RVA: 0x000F829B File Offset: 0x000F649B
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

		// Token: 0x060067B9 RID: 26553 RVA: 0x000F82AE File Offset: 0x000F64AE
		public new ITrapDefenseConditionStepPreview_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepPreview_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x000F82C1 File Offset: 0x000F64C1
		// (set) Token: 0x060067BB RID: 26555 RVA: 0x000F82EC File Offset: 0x000F64EC
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

		// Token: 0x04003E37 RID: 15927
		[Nullable(2)]
		protected new ITrapDefenseConditionStepPreview FbInstance;

		// Token: 0x04003E38 RID: 15928
		[Nullable(2)]
		protected new ITrapDefenseConditionStepPreview_SetValue PocoInterface;
	}
}
