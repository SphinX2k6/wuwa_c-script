using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F9 RID: 5113
	public class IRhythmSpaceshipConditionStepInteract : IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06007459 RID: 29785 RVA: 0x00116660 File Offset: 0x00114860
		[NullableContext(1)]
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

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x0011667F File Offset: 0x0011487F
		public override ERhythmSpaceshipConditionStep Type
		{
			get
			{
				return (ERhythmSpaceshipConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004353 RID: 17235
		private IRhythmSpaceshipConditionStepInteract Instance;
	}
}
