using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C40 RID: 19520
	[NullableContext(1)]
	[Nullable(0)]
	public class PassiveSkillCdData
	{
		// Token: 0x06030BC5 RID: 199621 RVA: 0x00D9744F File Offset: 0x00D9564F
		public void Clear()
		{
			this.SkillCdInfoMap.Clear();
		}

		// Token: 0x04019CC0 RID: 105664
		public readonly Dictionary<long, PassiveSkillCdInfo> SkillCdInfoMap = new Dictionary<long, PassiveSkillCdInfo>();

		// Token: 0x04019CC1 RID: 105665
		public readonly Dictionary<long, long> ServerSkillCd = new Dictionary<long, long>();
	}
}
