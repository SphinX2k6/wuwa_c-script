using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025B8 RID: 9656
public class FightPhotoFramePanel : FightPhotoTabPanelBase
{
	// Token: 0x0601393A RID: 80186 RVA: 0x004E4D14 File Offset: 0x004E2F14
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

	// Token: 0x0601393B RID: 80187 RVA: 0x004E4D84 File Offset: 0x004E2F84
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoFramePanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoFramePanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601393C RID: 80188 RVA: 0x004E4DC8 File Offset: 0x004E2FC8
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

	// Token: 0x0601393D RID: 80189 RVA: 0x004E4E49 File Offset: 0x004E3049
	[NullableContext(1)]
	private FightPhotoFrameItem CreateFrameItem()
	{
		return new FightPhotoFrameItem
		{
			OnToggleClick = new Action<FightPhotoFrameStyle>(this.OnToggleClick)
		};
	}

	// Token: 0x0601393E RID: 80190 RVA: 0x004E4E62 File Offset: 0x004E3062
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

	// Token: 0x0601393F RID: 80191 RVA: 0x004E4EA0 File Offset: 0x004E30A0
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

	// Token: 0x040093C2 RID: 37826
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FightPhotoFrameItem, FightPhotoFrameStyle> FrameLayout;

	// Token: 0x040093C3 RID: 37827
	[Nullable(2)]
	public Action OnFrameSwitched;

	// Token: 0x02008BC0 RID: 35776
	private enum EComponents
	{
		// Token: 0x0402D5C0 RID: 185792
		SvFrame,
		// Token: 0x0402D5C1 RID: 185793
		TogBattlePhotoFilter,
		// Token: 0x0402D5C2 RID: 185794
		SpriteArrowUp,
		// Token: 0x0402D5C3 RID: 185795
		SpriteArrowDown
	}
}
