using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025B6 RID: 9654
public class FightPhotoFilterPanel : FightPhotoTabPanelBase
{
	// Token: 0x0601392C RID: 80172 RVA: 0x004E4A18 File Offset: 0x004E2C18
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

	// Token: 0x0601392D RID: 80173 RVA: 0x004E4A88 File Offset: 0x004E2C88
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoFilterPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoFilterPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601392E RID: 80174 RVA: 0x004E4ACB File Offset: 0x004E2CCB
	[NullableContext(1)]
	private FightPhotoOptionItem CreateFilterItem()
	{
		return new FightPhotoOptionItem
		{
			OnToggleClick = new Action<FightPhotoOption>(this.OnToggleClick)
		};
	}

	// Token: 0x0601392F RID: 80175 RVA: 0x004E4AE4 File Offset: 0x004E2CE4
	private void OnToggleClick(FightPhotoOption data)
	{
		this.FilterLayout.GetGenericLayout().SelectGridProxyByKey(data.Id, false);
		PhotographController.SetFightPhotographExtraOption(EFightPhotoExtraOptionType.Filter, data.Id, false);
	}

	// Token: 0x06013930 RID: 80176 RVA: 0x004E4B14 File Offset: 0x004E2D14
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

	// Token: 0x040093BF RID: 37823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FightPhotoOptionItem, FightPhotoOption> FilterLayout;

	// Token: 0x02008BBC RID: 35772
	private enum EComponents
	{
		// Token: 0x0402D5AF RID: 185775
		SvFilter,
		// Token: 0x0402D5B0 RID: 185776
		TogBattlePhotoFilter,
		// Token: 0x0402D5B1 RID: 185777
		SpriteArrowUp,
		// Token: 0x0402D5B2 RID: 185778
		SpriteArrowDown
	}
}
