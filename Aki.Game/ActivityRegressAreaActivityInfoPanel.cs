using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200146F RID: 5231
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressAreaActivityInfoPanel : UiPanelBase
{
	// Token: 0x06009407 RID: 37895 RVA: 0x001FE6DC File Offset: 0x001FC8DC
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

	// Token: 0x06009408 RID: 37896 RVA: 0x001FE788 File Offset: 0x001FC988
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressAreaActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressAreaActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009409 RID: 37897 RVA: 0x001FE7CC File Offset: 0x001FC9CC
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoAreaBtnClick));
		this.ActivityBottom.FunctionButton.SetLocalTextNew("RecallActivity_Go", Array.Empty<object>());
		this.ActivityRewardListPanel.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.ActivityRewardListPanel.InitCommonGridItem));
		this.ActivityTitlePanel.SetTimeTextVisible(false);
	}

	// Token: 0x0600940A RID: 37898 RVA: 0x001FE837 File Offset: 0x001FCA37
	public void RefreshByData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshReward();
	}

	// Token: 0x0600940B RID: 37899 RVA: 0x001FE858 File Offset: 0x001FCA58
	private void RefreshTitle()
	{
		this.ActivityTitlePanel.SetTitleByTextId(this.Config.Value.Title, Array.Empty<string>());
	}

	// Token: 0x0600940C RID: 37900 RVA: 0x001FE888 File Offset: 0x001FCA88
	private void RefreshDesc()
	{
		string subTitle = this.Config.Value.SubTitle;
		string description = this.Config.Value.Description;
		bool flag = !StringUtils.IsEmpty(subTitle);
		this.ActivityTitlePanel.SetSubTitleVisible(flag);
		if (flag)
		{
			this.ActivityTitlePanel.SetSubTitleByTextId(subTitle, Array.Empty<string>());
		}
		this.ActivityDescPanel.SetContentByTextId(description, Array.Empty<string>());
	}

	// Token: 0x0600940D RID: 37901 RVA: 0x001FE8F8 File Offset: 0x001FCAF8
	private void RefreshReward()
	{
	}

	// Token: 0x0600940E RID: 37902 RVA: 0x001FE8FC File Offset: 0x001FCAFC
	private void OnGotoAreaBtnClick()
	{
		ActivityRegressHelper.ReportRecallLog1024(EReportLogEventType.NewArea, 0);
		int markId = this.Config.Value.GetArgIdArray()[0];
		MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
		if (configMark == null)
		{
			return;
		}
		MapMark value = configMark.Value;
		MapController.Instance.OpenMapViewAndFocusMark((EMarkType)value.ObjectType, markId, null, false, 1f);
	}

	// Token: 0x040041A9 RID: 16809
	private RegressBase? Config;

	// Token: 0x040041AA RID: 16810
	private ActivityTitleTypeA ActivityTitlePanel;

	// Token: 0x040041AB RID: 16811
	private ActivityDescriptionTypeB ActivityDescPanel;

	// Token: 0x040041AC RID: 16812
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> ActivityRewardListPanel;

	// Token: 0x040041AD RID: 16813
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02007A9C RID: 31388
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028573 RID: 165235
		ComActivityTitle,
		// Token: 0x04028574 RID: 165236
		ComActivityDesc,
		// Token: 0x04028575 RID: 165237
		ComActivityReward,
		// Token: 0x04028576 RID: 165238
		ComActivityBottom
	}
}
