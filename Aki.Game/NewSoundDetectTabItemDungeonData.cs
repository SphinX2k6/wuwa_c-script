using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000B57 RID: 2903
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectTabItemDungeonData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectTabItemDungeonItem>
{
	// Token: 0x06007936 RID: 31030 RVA: 0x002592C8 File Offset: 0x002574C8
	public NewSoundDetectTabItemDungeonData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x06007937 RID: 31031 RVA: 0x002592D7 File Offset: 0x002574D7
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06007938 RID: 31032 RVA: 0x002592DA File Offset: 0x002574DA
	public override NewSoundDetectTabItemDungeonItem CreateProxy()
	{
		return new NewSoundDetectTabItemDungeonItem();
	}
}
