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

// Token: 0x02000923 RID: 2339
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressAreaActivityInfoPanel : UiPanelBase
{
	// Token: 0x0600679C RID: 26524 RVA: 0x00207640 File Offset: 0x00205840
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

	// Token: 0x0600679D RID: 26525 RVA: 0x002076EC File Offset: 0x002058EC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressAreaActivityInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressAreaActivityInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600679E RID: 26526 RVA: 0x00207730 File Offset: 0x00205930
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoAreaBtnClick));
		this.ActivityBottom.FunctionButton.SetLocalTextNew("RecallActivity_Go", Array.Empty<object>());
		this.ActivityRewardListPanel.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.ActivityRewardListPanel.InitCommonGridItem));
		this.ActivityTitlePanel.SetTimeTextVisible(false);
	}

	// Token: 0x0600679F RID: 26527 RVA: 0x0020779B File Offset: 0x0020599B
	public void RefreshByData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshReward();
	}

	// Token: 0x060067A0 RID: 26528 RVA: 0x002077BC File Offset: 0x002059BC
	private void RefreshTitle()
	{
		this.ActivityTitlePanel.SetTitleByTextId(this.Config.Value.Title, Array.Empty<string>());
	}

	// Token: 0x060067A1 RID: 26529 RVA: 0x002077EC File Offset: 0x002059EC
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

	// Token: 0x060067A2 RID: 26530 RVA: 0x0020785C File Offset: 0x00205A5C
	private void RefreshReward()
	{
	}

	// Token: 0x060067A3 RID: 26531 RVA: 0x00207860 File Offset: 0x00205A60
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

	// Token: 0x04004241 RID: 16961
	private RegressBase? Config;

	// Token: 0x04004242 RID: 16962
	private ActivityTitleTypeA ActivityTitlePanel;

	// Token: 0x04004243 RID: 16963
	private ActivityDescriptionTypeB ActivityDescPanel;

	// Token: 0x04004244 RID: 16964
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> ActivityRewardListPanel;

	// Token: 0x04004245 RID: 16965
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02006C20 RID: 27680
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402388D RID: 145549
		ComActivityTitle,
		// Token: 0x0402388E RID: 145550
		ComActivityDesc,
		// Token: 0x0402388F RID: 145551
		ComActivityReward,
		// Token: 0x04023890 RID: 145552
		ComActivityBottom
	}
}
