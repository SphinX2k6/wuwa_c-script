using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide.Views;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA5 RID: 20133
	[NullableContext(1)]
	[Nullable(0)]
	public class NewSoundDetectTabItemData
	{
		// Token: 0x0401ADED RID: 110061
		public int Area;

		// Token: 0x0401ADEE RID: 110062
		public string TabTextId = "";

		// Token: 0x0401ADEF RID: 110063
		public string IconPath = "";

		// Token: 0x0401ADF0 RID: 110064
		[Nullable(2)]
		public NewSoundDetectItemData Dungeon;

		// Token: 0x0401ADF1 RID: 110065
		public int Sort;

		// Token: 0x0401ADF2 RID: 110066
		public bool IsVisible = true;
	}
}
