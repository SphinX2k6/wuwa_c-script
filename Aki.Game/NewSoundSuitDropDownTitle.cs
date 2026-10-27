using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020016A7 RID: 5799
public class NewSoundSuitDropDownTitle : TitleItemBase<int>
{
	// Token: 0x0600A579 RID: 42361 RVA: 0x0024FC90 File Offset: 0x0024DE90
	[NullableContext(1)]
	public NewSoundSuitDropDownTitle(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600A57A RID: 42362 RVA: 0x0024FC9C File Offset: 0x0024DE9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A57B RID: 42363 RVA: 0x0024FD08 File Offset: 0x0024DF08
	[NullableContext(1)]
	public override void ShowTemp(int data, DropDownItemBase<int> selectedItemObj)
	{
		if (this.VisionFetterSuitItem == null)
		{
			this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(1));
			this.VisionFetterSuitItem.Init().ContinueWith(delegate()
			{
			});
		}
		string newText;
		if (data > 0)
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetFetterGroupById(data).FetterGroupName, null) ?? "");
		}
		else
		{
			newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllVisionFetter_Text", null) ?? "");
		}
		base.GetText(0).SetText(newText, true);
		PhantomFetterGroup? fetterGroupData = (data > 0) ? new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(data)) : null;
		this.VisionFetterSuitItem.Update(fetterGroupData);
		this.VisionFetterSuitItem.SetActive(true);
	}

	// Token: 0x0600A57C RID: 42364 RVA: 0x0024FDEC File Offset: 0x0024DFEC
	protected override void OnBeforeDestroy()
	{
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem == null)
		{
			return;
		}
		visionFetterSuitItem.Destroy(null);
	}

	// Token: 0x04004AD7 RID: 19159
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007C7E RID: 31870
	private enum EComponent
	{
		// Token: 0x04028D8C RID: 167308
		TxtOption,
		// Token: 0x04028D8D RID: 167309
		SuitElementItem
	}
}
