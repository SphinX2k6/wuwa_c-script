using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x02004835 RID: 18485
	[NullableContext(1)]
	public interface IWorldMapSecondaryTipItemParam
	{
		// Token: 0x170078EE RID: 30958
		// (get) Token: 0x06030615 RID: 198165
		// (set) Token: 0x06030616 RID: 198166
		string Name { get; set; }

		// Token: 0x170078EF RID: 30959
		// (get) Token: 0x06030617 RID: 198167
		// (set) Token: 0x06030618 RID: 198168
		string Desc { get; set; }
	}
}
