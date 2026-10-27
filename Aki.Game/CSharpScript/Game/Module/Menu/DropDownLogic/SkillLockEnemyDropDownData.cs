using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02005473 RID: 21619
	public class SkillLockEnemyDropDownData
	{
		// Token: 0x060372CE RID: 225998 RVA: 0x00D15ED9 File Offset: 0x00D140D9
		[NullableContext(1)]
		public SkillLockEnemyDropDownData(int index, string textId)
		{
			this.Index = index;
			this.TextId = textId;
		}

		// Token: 0x0401D1A8 RID: 119208
		public int Index;

		// Token: 0x0401D1A9 RID: 119209
		[Nullable(2)]
		public string TextId;
	}
}
