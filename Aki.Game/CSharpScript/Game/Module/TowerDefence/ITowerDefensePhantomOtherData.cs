using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADB RID: 15067
	[NullableContext(1)]
	public interface ITowerDefensePhantomOtherData
	{
		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x06026B3F RID: 158527
		// (set) Token: 0x06026B40 RID: 158528
		string NameTextId { get; set; }

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x06026B41 RID: 158529
		// (set) Token: 0x06026B42 RID: 158530
		string TypeTextId { get; set; }

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x06026B43 RID: 158531
		// (set) Token: 0x06026B44 RID: 158532
		string TypeIconPath { get; set; }

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x06026B45 RID: 158533
		// (set) Token: 0x06026B46 RID: 158534
		bool IsLocked { get; set; }
	}
}
