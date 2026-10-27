using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED3 RID: 16083
	public class IKurotatoConditionStepBaseT
	{
		// Token: 0x17006FA9 RID: 28585
		// (get) Token: 0x06016BFD RID: 93181 RVA: 0x00348B46 File Offset: 0x00346D46
		// (set) Token: 0x06016BFE RID: 93182 RVA: 0x00348B4E File Offset: 0x00346D4E
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x06016BFF RID: 93183 RVA: 0x00348B57 File Offset: 0x00346D57
		public IKurotatoConditionStepBaseT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
