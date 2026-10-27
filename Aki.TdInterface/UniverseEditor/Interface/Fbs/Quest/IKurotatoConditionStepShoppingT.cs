using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE8 RID: 16104
	public class IKurotatoConditionStepShoppingT
	{
		// Token: 0x17006FBD RID: 28605
		// (get) Token: 0x06016C83 RID: 93315 RVA: 0x003496E6 File Offset: 0x003478E6
		// (set) Token: 0x06016C84 RID: 93316 RVA: 0x003496EE File Offset: 0x003478EE
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016C85 RID: 93317 RVA: 0x003496F7 File Offset: 0x003478F7
		public IKurotatoConditionStepShoppingT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
