using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CDD RID: 19677
	public class CodeNBase
	{
		// Token: 0x06031409 RID: 201737 RVA: 0x00DC0469 File Offset: 0x00DBE669
		[NullableContext(1)]
		public virtual Dictionary<string, int[]> GetCodeTable()
		{
			return new Dictionary<string, int[]>();
		}

		// Token: 0x0603140A RID: 201738 RVA: 0x00DC0470 File Offset: 0x00DBE670
		public virtual int SingleCodeLength()
		{
			return 0;
		}

		// Token: 0x0603140B RID: 201739 RVA: 0x00DC0473 File Offset: 0x00DBE673
		public virtual int SupportCharCount()
		{
			return this.GetCodeTable().Count;
		}
	}
}
