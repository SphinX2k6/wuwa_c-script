using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x020016AD RID: 5805
public class NewSoundTypeItemData : INewSoundTypeItemData
{
	// Token: 0x17000DD6 RID: 3542
	// (get) Token: 0x0600A592 RID: 42386 RVA: 0x002503F1 File Offset: 0x0024E5F1
	// (set) Token: 0x0600A593 RID: 42387 RVA: 0x002503F9 File Offset: 0x0024E5F9
	public EUiTabViewName? FromTabViewName { get; set; }

	// Token: 0x17000DD7 RID: 3543
	// (get) Token: 0x0600A594 RID: 42388 RVA: 0x00250402 File Offset: 0x0024E602
	// (set) Token: 0x0600A595 RID: 42389 RVA: 0x0025040A File Offset: 0x0024E60A
	public EDungeonType TypeId { get; set; }
}
