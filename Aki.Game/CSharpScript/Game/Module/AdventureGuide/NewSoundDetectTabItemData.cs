using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide.Views;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC0 RID: 24256
	[NullableContext(1)]
	[Nullable(0)]
	public class NewSoundDetectTabItemData
	{
		// Token: 0x04020326 RID: 131878
		public int Area;

		// Token: 0x04020327 RID: 131879
		public string TabTextId = "";

		// Token: 0x04020328 RID: 131880
		public string IconPath = "";

		// Token: 0x04020329 RID: 131881
		[Nullable(2)]
		public NewSoundDetectItemData Dungeon;

		// Token: 0x0402032A RID: 131882
		public int Sort;

		// Token: 0x0402032B RID: 131883
		public bool IsVisible = true;
	}
}
