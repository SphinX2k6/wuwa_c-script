using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CFB RID: 23803
	public class CodeNBase
	{
		// Token: 0x0603C4B0 RID: 246960 RVA: 0x00E6FE01 File Offset: 0x00E6E001
		[NullableContext(1)]
		public virtual Dictionary<string, int[]> GetCodeTable()
		{
			return new Dictionary<string, int[]>();
		}

		// Token: 0x0603C4B1 RID: 246961 RVA: 0x00E6FE08 File Offset: 0x00E6E008
		public virtual int SingleCodeLength()
		{
			return 0;
		}

		// Token: 0x0603C4B2 RID: 246962 RVA: 0x00E6FE0B File Offset: 0x00E6E00B
		public virtual int SupportCharCount()
		{
			return this.GetCodeTable().Count;
		}
	}
}
