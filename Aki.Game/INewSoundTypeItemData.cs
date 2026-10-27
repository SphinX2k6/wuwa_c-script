using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x020016AB RID: 5803
public interface INewSoundTypeItemData
{
	// Token: 0x17000DD4 RID: 3540
	// (get) Token: 0x0600A58B RID: 42379
	// (set) Token: 0x0600A58C RID: 42380
	EUiTabViewName? FromTabViewName { get; set; }

	// Token: 0x17000DD5 RID: 3541
	// (get) Token: 0x0600A58D RID: 42381
	// (set) Token: 0x0600A58E RID: 42382
	EDungeonType TypeId { get; set; }
}
