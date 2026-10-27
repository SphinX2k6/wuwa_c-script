using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02005471 RID: 21617
	public class ResourceStandardDropDownData
	{
		// Token: 0x060372C7 RID: 225991 RVA: 0x00D15D90 File Offset: 0x00D13F90
		[NullableContext(1)]
		public ResourceStandardDropDownData(int index, string textId)
		{
			this.Index = index;
			this.TextId = textId;
		}

		// Token: 0x0401D1A6 RID: 119206
		public int Index;

		// Token: 0x0401D1A7 RID: 119207
		[Nullable(2)]
		public string TextId;
	}
}
