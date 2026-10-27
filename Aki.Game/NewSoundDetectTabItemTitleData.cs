using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200169B RID: 5787
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectTabItemTitleData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectTabItemTitleItem>
{
	// Token: 0x0600A548 RID: 42312 RVA: 0x0024EB74 File Offset: 0x0024CD74
	public NewSoundDetectTabItemTitleData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x0600A549 RID: 42313 RVA: 0x0024EB83 File Offset: 0x0024CD83
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0600A54A RID: 42314 RVA: 0x0024EB86 File Offset: 0x0024CD86
	public override NewSoundDetectTabItemTitleItem CreateProxy()
	{
		return new NewSoundDetectTabItemTitleItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x04004ACB RID: 19147
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;
}
