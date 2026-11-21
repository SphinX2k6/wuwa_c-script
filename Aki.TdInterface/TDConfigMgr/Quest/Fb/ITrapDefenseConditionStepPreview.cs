using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152D RID: 5421
	public class ITrapDefenseConditionStepPreview : ITrapDefenseConditionStepBase
	{
		// Token: 0x06007AA1 RID: 31393 RVA: 0x00124638 File Offset: 0x00122838
		public static ITrapDefenseConditionStepPreview Create(ITrapDefenseConditionStepPreview? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepPreview
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x06007AA2 RID: 31394 RVA: 0x00124657 File Offset: 0x00122857
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A5 RID: 18085
		private ITrapDefenseConditionStepPreview Instance;
	}
}
