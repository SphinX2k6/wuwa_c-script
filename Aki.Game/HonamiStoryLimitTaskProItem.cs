using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001391 RID: 5009
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskProItem : UiPanelBase
{
	// Token: 0x0600C69B RID: 50843 RVA: 0x003B2EF0 File Offset: 0x003B10F0
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

	// Token: 0x0600C69C RID: 50844 RVA: 0x003B2F9B File Offset: 0x003B119B
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<HonamiStoryLimitTaskScoreItem, HonamiStoryScoreRewardData>(base.GetHorizontalLayout(2), new Func<HonamiStoryLimitTaskScoreItem>(this.InitScoreItem), (AUIBaseActor)base.GetItem(3).GetOwner(), false, true);
	}

	// Token: 0x0600C69D RID: 50845 RVA: 0x003B2FCE File Offset: 0x003B11CE
	private HonamiStoryLimitTaskScoreItem InitScoreItem()
	{
		return new HonamiStoryLimitTaskScoreItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x0600C69E RID: 50846 RVA: 0x003B2FE4 File Offset: 0x003B11E4
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

	// Token: 0x04007135 RID: 28981
	private const float FIRST_OFFSET = 410f;

	// Token: 0x04007136 RID: 28982
	private GenericLayout<HonamiStoryLimitTaskScoreItem, HonamiStoryScoreRewardData> ProgressLayout;

	// Token: 0x04007137 RID: 28983
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x02007633 RID: 30259
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402661D RID: 157213
		TxtScore,
		// Token: 0x0402661E RID: 157214
		SprBarFill,
		// Token: 0x0402661F RID: 157215
		PnlPointRewardLayout,
		// Token: 0x04026620 RID: 157216
		PnlPointReward
	}
}
