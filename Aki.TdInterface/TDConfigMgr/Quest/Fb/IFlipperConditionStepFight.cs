using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001553 RID: 5459
	public class IFlipperConditionStepFight : IFlipperConditionStepBase
	{
		// Token: 0x06007B25 RID: 31525 RVA: 0x00125148 File Offset: 0x00123348
		public static IFlipperConditionStepFight Create(IFlipperConditionStepFight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepFight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x00125167 File Offset: 0x00123367
		public override EFlipperConditionStep Type
		{
			get
			{
				return (EFlipperConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046EB RID: 18155
		private IFlipperConditionStepFight Instance;
	}
}
