using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000B55 RID: 2901
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NewSoundDetectPreOpenTitleData : MultiTemplateGridDataBase<NewSoundDetectTabItemData, NewSoundDetectPreOpenTitleItem>
{
	// Token: 0x0600792F RID: 31023 RVA: 0x002591C0 File Offset: 0x002573C0
	public NewSoundDetectPreOpenTitleData(NewSoundDetectTabItemData data)
	{
		base.Data = data;
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x002591CF File Offset: 0x002573CF
	public override int GetTemplateIndex()
	{
		return 2;
	}

	// Token: 0x06007931 RID: 31025 RVA: 0x002591D2 File Offset: 0x002573D2
	public override NewSoundDetectPreOpenTitleItem CreateProxy()
	{
		return new NewSoundDetectPreOpenTitleItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x04004B76 RID: 19318
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;
}
