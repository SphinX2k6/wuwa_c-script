using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200169D RID: 5789
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectPreOpenTitleData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectPreOpenTitleItem>
{
	// Token: 0x0600A54F RID: 42319 RVA: 0x0024EDA4 File Offset: 0x0024CFA4
	public NewSoundDetectPreOpenTitleData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x0600A550 RID: 42320 RVA: 0x0024EDB3 File Offset: 0x0024CFB3
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x0600A551 RID: 42321 RVA: 0x0024EDB6 File Offset: 0x0024CFB6
	public override NewSoundDetectPreOpenTitleItem CreateProxy()
	{
		return new NewSoundDetectPreOpenTitleItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x04004ACF RID: 19151
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;
}
