using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200154F RID: 5455
	public class IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06007B17 RID: 31511 RVA: 0x00125010 File Offset: 0x00123210
		public static IRhythmSpaceshipConditionStepBase Create(IRhythmSpaceshipConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x0012502F File Offset: 0x0012322F
		public virtual ERhythmSpaceshipConditionStep Type
		{
			get
			{
				return (ERhythmSpaceshipConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046E3 RID: 18147
		private IRhythmSpaceshipConditionStepBase Instance;
	}
}
