using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C60 RID: 23648
	[NullableContext(1)]
	[Nullable(0)]
	public class PassiveSkillCdData
	{
		// Token: 0x0603BC7A RID: 244858 RVA: 0x00E4706F File Offset: 0x00E4526F
		public void Clear()
		{
			this.SkillCdInfoMap.Clear();
		}

		// Token: 0x0401F20F RID: 127503
		public readonly Dictionary<long, PassiveSkillCdInfo> SkillCdInfoMap = new Dictionary<long, PassiveSkillCdInfo>();

		// Token: 0x0401F210 RID: 127504
		public readonly Dictionary<long, long> ServerSkillCd = new Dictionary<long, long>();
	}
}
