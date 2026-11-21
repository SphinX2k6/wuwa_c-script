using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02000B63 RID: 2915
public interface INewSoundTypeItemData
{
	// Token: 0x17000DF5 RID: 3573
	// (get) Token: 0x0600796B RID: 31083
	// (set) Token: 0x0600796C RID: 31084
	EUiTabViewName? FromTabViewName { get; set; }

	// Token: 0x17000DF6 RID: 3574
	// (get) Token: 0x0600796D RID: 31085
	// (set) Token: 0x0600796E RID: 31086
	EDungeonType TypeId { get; set; }
}
