using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AD RID: 6573
	public class IDisableExploreSkill_SetValue
	{
		// Token: 0x0400578A RID: 22410
		public bool? PlaceTemporaryTeleport;

		// Token: 0x0400578B RID: 22411
		public bool? IsComplementary;

		// Token: 0x0400578C RID: 22412
		[Nullable(2)]
		public List<EExploreSkillType> ExploreSkillList;
	}
}
