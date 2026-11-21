using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004456 RID: 17494
	public class SkillLockEnemyDropDownData
	{
		// Token: 0x0602C217 RID: 180759 RVA: 0x00C65331 File Offset: 0x00C63531
		[NullableContext(1)]
		public SkillLockEnemyDropDownData(int index, string textId)
		{
			this.Index = index;
			this.TextId = textId;
		}

		// Token: 0x04017C41 RID: 97345
		public int Index;

		// Token: 0x04017C42 RID: 97346
		[Nullable(2)]
		public string TextId;
	}
}
