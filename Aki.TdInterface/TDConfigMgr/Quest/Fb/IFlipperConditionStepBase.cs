using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013FB RID: 5115
	public class IFlipperConditionStepBase
	{
		// Token: 0x06007461 RID: 29793 RVA: 0x00116730 File Offset: 0x00114930
		[NullableContext(1)]
		public static IFlipperConditionStepBase Create(IFlipperConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06007462 RID: 29794 RVA: 0x0011674F File Offset: 0x0011494F
		public virtual EFlipperConditionStep Type
		{
			get
			{
				return (EFlipperConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004359 RID: 17241
		private IFlipperConditionStepBase Instance;
	}
}
