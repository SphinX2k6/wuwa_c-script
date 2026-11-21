using System;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02000B65 RID: 2917
public class NewSoundTypeItemData : INewSoundTypeItemData
{
	// Token: 0x17000DF7 RID: 3575
	// (get) Token: 0x06007972 RID: 31090 RVA: 0x0025A805 File Offset: 0x00258A05
	// (set) Token: 0x06007973 RID: 31091 RVA: 0x0025A80D File Offset: 0x00258A0D
	public EUiTabViewName? FromTabViewName { get; set; }

	// Token: 0x17000DF8 RID: 3576
	// (get) Token: 0x06007974 RID: 31092 RVA: 0x0025A816 File Offset: 0x00258A16
	// (set) Token: 0x06007975 RID: 31093 RVA: 0x0025A81E File Offset: 0x00258A1E
	public EDungeonType TypeId { get; set; }
}
