using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020004B7 RID: 1207
public class GolemHackingActivitySubView : ActivitySubViewBase
{
	// Token: 0x06003CB6 RID: 15542 RVA: 0x001574DC File Offset: 0x001556DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003CB7 RID: 15543 RVA: 0x00157588 File Offset: 0x00155788
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003CB8 RID: 15544 RVA: 0x001575CC File Offset: 0x001557CC
	protected override void OnRefreshView()
	{
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		this.CommonInfoPanel.SetFunctionRedDotVisible(activityData.RedPointShowState);
		ValueTuple<int, int> groupProgressState = activityData.GetGroupProgressState();
		int item = groupProgressState.Item1;
		int item2 = groupProgressState.Item2;
		UUIArtText artText = base.GetArtText(1);
		if (artText != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetFillAmount((float)item / (float)item2);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
	}

	// Token: 0x06003CB9 RID: 15545 RVA: 0x0015768F File Offset: 0x0015588F
	[NullableContext(2)]
	private void OnClickedConfirm(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("IntrusionProtocolActivity_CoopBlockTips", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.GolemHackingLevelMainView, null, null);
		});
	}

	// Token: 0x040030F8 RID: 12536
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0200678E RID: 26510
	private enum EDefine
	{
		// Token: 0x040222F8 RID: 140024
		CommonActivityInfoItem,
		// Token: 0x040222F9 RID: 140025
		ArtTxtCur,
		// Token: 0x040222FA RID: 140026
		TxtTarget,
		// Token: 0x040222FB RID: 140027
		TexFill
	}
}
