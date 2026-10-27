using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F8 RID: 5112
	public class IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06007456 RID: 29782 RVA: 0x0011662C File Offset: 0x0011482C
		[NullableContext(1)]
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

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06007457 RID: 29783 RVA: 0x0011664B File Offset: 0x0011484B
		public virtual ERhythmSpaceshipConditionStep Type
		{
			get
			{
				return (ERhythmSpaceshipConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004352 RID: 17234
		private IRhythmSpaceshipConditionStepBase Instance;
	}
}
