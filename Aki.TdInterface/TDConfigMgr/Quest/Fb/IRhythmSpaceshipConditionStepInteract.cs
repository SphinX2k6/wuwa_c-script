using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001550 RID: 5456
	public class IRhythmSpaceshipConditionStepInteract : IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06007B1A RID: 31514 RVA: 0x00125044 File Offset: 0x00123244
		public static IRhythmSpaceshipConditionStepInteract Create(IRhythmSpaceshipConditionStepInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x00125063 File Offset: 0x00123263
		public override ERhythmSpaceshipConditionStep Type
		{
			get
			{
				return (ERhythmSpaceshipConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046E4 RID: 18148
		private IRhythmSpaceshipConditionStepInteract Instance;
	}
}
