using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin.Skip
{
	// Token: 0x02004BF2 RID: 19442
	[NullableContext(1)]
	public interface ISkinSkipData
	{
		// Token: 0x17007C6C RID: 31852
		// (get) Token: 0x06032458 RID: 205912
		// (set) Token: 0x06032459 RID: 205913
		int Id { get; set; }

		// Token: 0x17007C6D RID: 31853
		// (get) Token: 0x0603245A RID: 205914
		// (set) Token: 0x0603245B RID: 205915
		int ConfigId { get; set; }

		// Token: 0x17007C6E RID: 31854
		// (get) Token: 0x0603245C RID: 205916
		// (set) Token: 0x0603245D RID: 205917
		ESkinSkipType Type { get; set; }

		// Token: 0x17007C6F RID: 31855
		// (get) Token: 0x0603245E RID: 205918
		// (set) Token: 0x0603245F RID: 205919
		string Text { get; set; }

		// Token: 0x17007C70 RID: 31856
		// (get) Token: 0x06032460 RID: 205920
		// (set) Token: 0x06032461 RID: 205921
		int SortIndex { get; set; }
	}
}
