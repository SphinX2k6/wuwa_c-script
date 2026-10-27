using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ECF RID: 7887
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskProItem : UiPanelBase
{
	// Token: 0x0600F27C RID: 62076 RVA: 0x003A73F0 File Offset: 0x003A55F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F27D RID: 62077 RVA: 0x003A749B File Offset: 0x003A569B
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<HonamiStoryLimitTaskScoreItem, HonamiStoryScoreRewardData>(base.GetHorizontalLayout(2), new Func<HonamiStoryLimitTaskScoreItem>(this.InitScoreItem), (AUIBaseActor)base.GetItem(3).GetOwner(), false, true);
	}

	// Token: 0x0600F27E RID: 62078 RVA: 0x003A74CE File Offset: 0x003A56CE
	private HonamiStoryLimitTaskScoreItem InitScoreItem()
	{
		return new HonamiStoryLimitTaskScoreItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x0600F27F RID: 62079 RVA: 0x003A74E4 File Offset: 0x003A56E4
	public UniTask RefreshAsync(int currentProgress, List<HonamiStoryScoreRewardData> dataList)
	{
		HonamiStoryLimitTaskProItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.currentProgress = currentProgress;
		<RefreshAsync>d__.dataList = dataList;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<HonamiStoryLimitTaskProItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04007054 RID: 28756
	private const float FIRST_OFFSET = 410f;

	// Token: 0x04007055 RID: 28757
	private GenericLayout<HonamiStoryLimitTaskScoreItem, HonamiStoryScoreRewardData> ProgressLayout;

	// Token: 0x04007056 RID: 28758
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x020084AE RID: 33966
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B2F9 RID: 176889
		TxtScore,
		// Token: 0x0402B2FA RID: 176890
		SprBarFill,
		// Token: 0x0402B2FB RID: 176891
		PnlPointRewardLayout,
		// Token: 0x0402B2FC RID: 176892
		PnlPointReward
	}
}
