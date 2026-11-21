using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA1 RID: 6817
public class FightPhotoFilterPanel : FightPhotoTabPanelBase
{
	// Token: 0x06010E0C RID: 69132 RVA: 0x004F3618 File Offset: 0x004F1818
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x06010E0D RID: 69133 RVA: 0x004F3688 File Offset: 0x004F1888
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoFilterPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoFilterPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E0E RID: 69134 RVA: 0x004F36CB File Offset: 0x004F18CB
	[NullableContext(1)]
	private FightPhotoOptionItem CreateFilterItem()
	{
		return new FightPhotoOptionItem
		{
			OnToggleClick = new Action<FightPhotoOption>(this.OnToggleClick)
		};
	}

	// Token: 0x06010E0F RID: 69135 RVA: 0x004F36E4 File Offset: 0x004F18E4
	private void OnToggleClick(FightPhotoOption data)
	{
		this.FilterLayout.GetGenericLayout().SelectGridProxyByKey(data.Id, false);
		PhotographController.SetFightPhotographExtraOption(EFightPhotoExtraOptionType.Filter, data.Id, false);
	}

	// Token: 0x06010E10 RID: 69136 RVA: 0x004F3714 File Offset: 0x004F1914
	[NullableContext(1)]
	private void ScrollToSelectedItem(object key)
	{
		GenericScrollViewNew<FightPhotoOptionItem, FightPhotoOption> filterLayout = this.FilterLayout;
		UUIItem uuiitem = (filterLayout != null) ? filterLayout.GetItemByKey(key) : null;
		if (uuiitem == null)
		{
			return;
		}
		this.FilterLayout.LateScrollTo(uuiitem, null, false);
	}

	// Token: 0x04009515 RID: 38165
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FightPhotoOptionItem, FightPhotoOption> FilterLayout;

	// Token: 0x02007D44 RID: 32068
	private enum EComponents
	{
		// Token: 0x040288C4 RID: 166084
		SvFilter,
		// Token: 0x040288C5 RID: 166085
		TogBattlePhotoFilter,
		// Token: 0x040288C6 RID: 166086
		SpriteArrowUp,
		// Token: 0x040288C7 RID: 166087
		SpriteArrowDown
	}
}
