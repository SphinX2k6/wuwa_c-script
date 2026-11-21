using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000B53 RID: 2899
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectTabItemTitleData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectTabItemTitleItem>
{
	// Token: 0x06007928 RID: 31016 RVA: 0x00258F91 File Offset: 0x00257191
	public NewSoundDetectTabItemTitleData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x06007929 RID: 31017 RVA: 0x00258FA0 File Offset: 0x002571A0
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x00258FA3 File Offset: 0x002571A3
	public override NewSoundDetectTabItemTitleItem CreateProxy()
	{
		return new NewSoundDetectTabItemTitleItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x04004B72 RID: 19314
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;
}
