using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001003 RID: 4099
public class GolemHackingActivitySubView : ActivitySubViewBase
{
	// Token: 0x06006921 RID: 26913 RVA: 0x0014EBB4 File Offset: 0x0014CDB4
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

	// Token: 0x06006922 RID: 26914 RVA: 0x0014EC60 File Offset: 0x0014CE60
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006923 RID: 26915 RVA: 0x0014ECA4 File Offset: 0x0014CEA4
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

	// Token: 0x06006924 RID: 26916 RVA: 0x0014ED67 File Offset: 0x0014CF67
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

	// Token: 0x0400305F RID: 12383
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x020075FA RID: 30202
	private enum EDefine
	{
		// Token: 0x04026FAD RID: 159661
		CommonActivityInfoItem,
		// Token: 0x04026FAE RID: 159662
		ArtTxtCur,
		// Token: 0x04026FAF RID: 159663
		TxtTarget,
		// Token: 0x04026FB0 RID: 159664
		TexFill
	}
}
