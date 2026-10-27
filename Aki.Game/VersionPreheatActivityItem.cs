using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001572 RID: 5490
[NullableContext(1)]
[Nullable(0)]
internal class VersionPreheatActivityItem : UiPanelBase
{
	// Token: 0x06009D02 RID: 40194 RVA: 0x0021F848 File Offset: 0x0021DA48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D03 RID: 40195 RVA: 0x0021F8F4 File Offset: 0x0021DAF4
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatActivityItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatActivityItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D04 RID: 40196 RVA: 0x0021F937 File Offset: 0x0021DB37
	protected override void OnStart()
	{
		this.Reward.SetUiActive(false);
		this.Bottom.SetUiActive(false);
	}

	// Token: 0x06009D05 RID: 40197 RVA: 0x0021F951 File Offset: 0x0021DB51
	public void RefreshExternal(VersionPreheatActivityInfoData data)
	{
		this.RefreshTitle(data.TitleData);
		this.RefreshDescription(data.DescriptionData);
	}

	// Token: 0x06009D06 RID: 40198 RVA: 0x0021F96B File Offset: 0x0021DB6B
	public void RefreshSubTitleExternal(bool isShow, string text)
	{
		this.Title.SetTimeTextVisible(isShow);
		if (isShow)
		{
			this.Title.SetTimeTextByText(text);
		}
	}

	// Token: 0x06009D07 RID: 40199 RVA: 0x0021F988 File Offset: 0x0021DB88
	private void RefreshTitle(VersionPreheatActivityTitleData data)
	{
		this.Title.SetTitleByTextId(data.TitleTextId, Array.Empty<string>());
		this.Title.SetSubTitleByTextId(data.SubTitleTextId, Array.Empty<string>());
		this.Title.SetSubTitleVisible(true);
		this.Title.SetTimeTextVisible(false);
	}

	// Token: 0x06009D08 RID: 40200 RVA: 0x0021F9D9 File Offset: 0x0021DBD9
	private void RefreshDescription(VersionPreheatActivityDescriptionData data)
	{
		this.Description.SetContentByTextId(data.ContentTextId, Array.Empty<string>());
	}

	// Token: 0x040044E8 RID: 17640
	private ActivityTitleTypeA Title;

	// Token: 0x040044E9 RID: 17641
	private ActivityDescriptionTypeA Description;

	// Token: 0x040044EA RID: 17642
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> Reward;

	// Token: 0x040044EB RID: 17643
	private VersionPreheatActivityBottom Bottom;

	// Token: 0x02007BA1 RID: 31649
	[NullableContext(0)]
	internal class EActivityComponent
	{
		// Token: 0x04028A39 RID: 166457
		public const int TitleItem = 0;

		// Token: 0x04028A3A RID: 166458
		public const int DescriptionItem = 1;

		// Token: 0x04028A3B RID: 166459
		public const int RewardItem = 2;

		// Token: 0x04028A3C RID: 166460
		public const int BottomItem = 3;
	}
}
