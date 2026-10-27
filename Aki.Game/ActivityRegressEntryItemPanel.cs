using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200148F RID: 5263
public class ActivityRegressEntryItemPanel : UiPanelBase
{
	// Token: 0x06009513 RID: 38163 RVA: 0x00202734 File Offset: 0x00200934
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

	// Token: 0x06009514 RID: 38164 RVA: 0x002027C8 File Offset: 0x002009C8
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

	// Token: 0x06009515 RID: 38165 RVA: 0x002028A0 File Offset: 0x00200AA0
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

	// Token: 0x06009516 RID: 38166 RVA: 0x002028D8 File Offset: 0x00200AD8
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

	// Token: 0x06009517 RID: 38167 RVA: 0x002029BC File Offset: 0x00200BBC
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

	// Token: 0x040041F8 RID: 16888
	private EActivityRegressEntranceType? EntryType;

	// Token: 0x040041F9 RID: 16889
	private RegressEntry? Config;

	// Token: 0x02007ABD RID: 31421
	private class EComponents
	{
		// Token: 0x04028624 RID: 165412
		public const int TxtNum = 0;

		// Token: 0x04028625 RID: 165413
		public const int TxtContent = 1;

		// Token: 0x04028626 RID: 165414
		public const int BtnItem = 2;

		// Token: 0x04028627 RID: 165415
		public const int TxtIcon = 3;
	}
}
