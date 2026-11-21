using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004454 RID: 17492
	public class ResourceStandardDropDownData
	{
		// Token: 0x0602C210 RID: 180752 RVA: 0x00C651E8 File Offset: 0x00C633E8
		[NullableContext(1)]
		public ResourceStandardDropDownData(int index, string textId)
		{
			this.Index = index;
			this.TextId = textId;
		}

		// Token: 0x04017C3F RID: 97343
		public int Index;

		// Token: 0x04017C40 RID: 97344
		[Nullable(2)]
		public string TextId;
	}
}
