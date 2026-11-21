using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000943 RID: 2371
public class ActivityRegressEntryItemPanel : UiPanelBase
{
	// Token: 0x060068A8 RID: 26792 RVA: 0x0020B69C File Offset: 0x0020989C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnEntryBtnClick))
		};
	}

	// Token: 0x060068A9 RID: 26793 RVA: 0x0020B730 File Offset: 0x00209930
	private void OnEntryBtnClick()
	{
		if (!ActivityRegressModel.Instance.CheckIfEntryOpen(this.Config.Value).Item1)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Role_Lock", Array.Empty<object>());
			return;
		}
		switch (this.EntryType.Value)
		{
		case EActivityRegressEntranceType.NewMainLine:
			ActivityRegressHelper.ReportRecallLog1023(EReportLogEventType.NewMainLine);
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.MainLine, null);
			return;
		case EActivityRegressEntranceType.NewArea:
			ActivityRegressHelper.ReportRecallLog1023(EReportLogEventType.NewArea);
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.Area, null);
			return;
		case EActivityRegressEntranceType.NewRole1:
			ActivityRegressHelper.ReportRecallLog1023(EReportLogEventType.NewRole);
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.Role1, null);
			return;
		case EActivityRegressEntranceType.NewRole2:
			ActivityRegressHelper.ReportRecallLog1023(EReportLogEventType.NewRole);
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.Role2, null);
			return;
		default:
			return;
		}
	}

	// Token: 0x060068AA RID: 26794 RVA: 0x0020B808 File Offset: 0x00209A08
	public void RefreshData(EActivityRegressEntranceType entryType, RegressEntry? config)
	{
		this.EntryType = new EActivityRegressEntranceType?(entryType);
		this.Config = config;
		bool flag = config != null;
		base.SetUiActive(flag);
		if (flag)
		{
			this.RefreshView();
		}
	}

	// Token: 0x060068AB RID: 26795 RVA: 0x0020B840 File Offset: 0x00209A40
	private void RefreshView()
	{
		if (this.Config == null)
		{
			Log.Instance.Warn(ELogModule.ActivityRegress, ELogAuthor.LRX, "ActivityRegressEntryItemPanel.RefreshView->回流活动入口配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		UUIText text = base.GetText(0);
		string title = this.Config.Value.Title;
		LguiUtil.Instance.SetLocalTextNew(text, title ?? "", Array.Empty<object>());
		base.GetText(1).SetText("", true);
		string currentBgResourcePathByGender = this.GetCurrentBgResourcePathByGender(this.Config.Value);
		UUITexture texture = base.GetTexture(3);
		bool item = ActivityRegressModel.Instance.CheckIfEntryOpen(this.Config.Value).Item1;
		texture.SetUIActive(item);
		base.SetTextureByPath(currentBgResourcePathByGender, texture, null, null);
	}

	// Token: 0x060068AC RID: 26796 RVA: 0x0020B924 File Offset: 0x00209B24
	[NullableContext(1)]
	private string GetCurrentBgResourcePathByGender(RegressEntry config)
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (playerGender == EPlayerGender.Male)
		{
			return config.IconPath ?? "";
		}
		if (playerGender == EPlayerGender.Female)
		{
			return config.IconPathF ?? "";
		}
		return "";
	}

	// Token: 0x04004290 RID: 17040
	private EActivityRegressEntranceType? EntryType;

	// Token: 0x04004291 RID: 17041
	private RegressEntry? Config;

	// Token: 0x02006C41 RID: 27713
	private class EComponents
	{
		// Token: 0x0402393E RID: 145726
		public const int TxtNum = 0;

		// Token: 0x0402393F RID: 145727
		public const int TxtContent = 1;

		// Token: 0x04023940 RID: 145728
		public const int BtnItem = 2;

		// Token: 0x04023941 RID: 145729
		public const int TxtIcon = 3;
	}
}
