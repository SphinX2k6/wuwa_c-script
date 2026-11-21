using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA3 RID: 6819
public class FightPhotoFramePanel : FightPhotoTabPanelBase
{
	// Token: 0x06010E1A RID: 69146 RVA: 0x004F3914 File Offset: 0x004F1B14
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

	// Token: 0x06010E1B RID: 69147 RVA: 0x004F3984 File Offset: 0x004F1B84
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoFramePanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoFramePanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E1C RID: 69148 RVA: 0x004F39C8 File Offset: 0x004F1BC8
	private void RefreshArrows(FVector2D? progress)
	{
		GenericScrollViewNew<FightPhotoFrameItem, FightPhotoFrameStyle> frameLayout = this.FrameLayout;
		if (frameLayout == null || !frameLayout.IsExpand)
		{
			base.GetSprite(2).SetUIActive(false);
			base.GetSprite(3).SetUIActive(false);
			return;
		}
		float num = (progress != null) ? progress.GetValueOrDefault().Y : 0f;
		base.GetSprite(2).SetUIActive(num > 0f);
		base.GetSprite(3).SetUIActive(num < 1f);
	}

	// Token: 0x06010E1D RID: 69149 RVA: 0x004F3A49 File Offset: 0x004F1C49
	[NullableContext(1)]
	private FightPhotoFrameItem CreateFrameItem()
	{
		return new FightPhotoFrameItem
		{
			OnToggleClick = new Action<FightPhotoFrameStyle>(this.OnToggleClick)
		};
	}

	// Token: 0x06010E1E RID: 69150 RVA: 0x004F3A62 File Offset: 0x004F1C62
	private void OnToggleClick(FightPhotoFrameStyle data)
	{
		this.FrameLayout.GetGenericLayout().SelectGridProxyByKey(data.Id, false);
		PhotographController.SetFightPhotographExtraOption(EFightPhotoExtraOptionType.Frame, data.Id, false);
		Action onFrameSwitched = this.OnFrameSwitched;
		if (onFrameSwitched == null)
		{
			return;
		}
		onFrameSwitched();
	}

	// Token: 0x06010E1F RID: 69151 RVA: 0x004F3AA0 File Offset: 0x004F1CA0
	[NullableContext(1)]
	private void ScrollToSelectedItem(object key)
	{
		GenericScrollViewNew<FightPhotoFrameItem, FightPhotoFrameStyle> frameLayout = this.FrameLayout;
		UUIItem uuiitem = (frameLayout != null) ? frameLayout.GetItemByKey(key) : null;
		if (uuiitem == null)
		{
			return;
		}
		this.FrameLayout.LateScrollTo(uuiitem, null, false);
	}

	// Token: 0x04009518 RID: 38168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FightPhotoFrameItem, FightPhotoFrameStyle> FrameLayout;

	// Token: 0x04009519 RID: 38169
	[Nullable(2)]
	public Action OnFrameSwitched;

	// Token: 0x02007D48 RID: 32072
	private enum EComponents
	{
		// Token: 0x040288D5 RID: 166101
		SvFrame,
		// Token: 0x040288D6 RID: 166102
		TogBattlePhotoFilter,
		// Token: 0x040288D7 RID: 166103
		SpriteArrowUp,
		// Token: 0x040288D8 RID: 166104
		SpriteArrowDown
	}
}
