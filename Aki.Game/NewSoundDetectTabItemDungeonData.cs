using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200169F RID: 5791
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectTabItemDungeonData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectTabItemDungeonItem>
{
	// Token: 0x0600A556 RID: 42326 RVA: 0x0024EEAC File Offset: 0x0024D0AC
	public NewSoundDetectTabItemDungeonData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x0600A557 RID: 42327 RVA: 0x0024EEBB File Offset: 0x0024D0BB
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x0600A558 RID: 42328 RVA: 0x0024EEBE File Offset: 0x0024D0BE
	public override NewSoundDetectTabItemDungeonItem CreateProxy()
	{
		return new NewSoundDetectTabItemDungeonItem();
	}
}
