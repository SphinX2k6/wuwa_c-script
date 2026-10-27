using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using UnrealEngine;

// Token: 0x02002AA1 RID: 10913
public class SubPackageDownLoadFreeSpaceTipsView : UiViewBase
{
	// Token: 0x06016BA2 RID: 93090 RVA: 0x005C35BF File Offset: 0x005C17BF
	[NullableContext(1)]
	public SubPackageDownLoadFreeSpaceTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016BA3 RID: 93091 RVA: 0x005C35C8 File Offset: 0x005C17C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06016BA4 RID: 93092 RVA: 0x005C36B5 File Offset: 0x005C18B5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackClearData, new Action(this.OnRefreshSubPackClearData));
	}

	// Token: 0x06016BA5 RID: 93093 RVA: 0x005C36D3 File Offset: 0x005C18D3
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackClearData, new Action(this.OnRefreshSubPackClearData));
	}

	// Token: 0x06016BA6 RID: 93094 RVA: 0x005C36F4 File Offset: 0x005C18F4
	protected override void OnStart()
	{
		this.TargetSubPackageId = (int)this.OpenParam;
		SubPackageDownLoadModel.Instance.HaveTipsOutOfSpaceList.Add(this.TargetSubPackageId);
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.TargetSubPackageId);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.TargetSubPackageId);
		long requiredSpace = subPackageSpace - subPackageHaveDownLoadSpace;
		SubPackageController.Instance.ReportSubPackageOutOfSpaceLogEvent(this.TargetSubPackageId, requiredSpace, VideoResUpdate.Instance.GetFreeSpace());
	}

	// Token: 0x06016BA7 RID: 93095 RVA: 0x005C3766 File Offset: 0x005C1966
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshButton();
	}

	// Token: 0x06016BA8 RID: 93096 RVA: 0x005C3774 File Offset: 0x005C1974
	private void OnClickCancelBtn()
	{
		if (SubPackageDownLoadModel.Instance.GetAllCanClearSpace() <= 0L || !ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			base.CloseMe(null);
			return;
		}
		if (RecallQuestModel.Instance.IsInRecallInstance())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanCleanSystem", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadMobileClearPopView, this.TargetSubPackageId, null);
	}

	// Token: 0x06016BA9 RID: 93097 RVA: 0x005C37E0 File Offset: 0x005C19E0
	private void OnClickConfirmBtn()
	{
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.TargetSubPackageId);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.TargetSubPackageId);
		long num = subPackageSpace - subPackageHaveDownLoadSpace;
		if (freeSpace > num)
		{
			SubPackageController.Instance.PrioritySubPackageDownLoading(new List<int>
			{
				this.TargetSubPackageId
			}, null);
			base.CloseMe(null);
			return;
		}
		this.RefreshView();
		this.RefreshButton();
	}

	// Token: 0x06016BAA RID: 93098 RVA: 0x005C3850 File Offset: 0x005C1A50
	private void RefreshView()
	{
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.TargetSubPackageId);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.TargetSubPackageId);
		long byteValue = subPackageSpace - subPackageHaveDownLoadSpace;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DownLoadText_NeedSpace", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(byteValue)));
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#c25757>" + SubPackageDownLoadModel.Instance.ByteConverter(freeSpace) + "</color>"));
	}

	// Token: 0x06016BAB RID: 93099 RVA: 0x005C38E8 File Offset: 0x005C1AE8
	private void RefreshButton()
	{
		long allCanClearSpace = SubPackageDownLoadModel.Instance.GetAllCanClearSpace();
		if (allCanClearSpace > 0L && ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "SubPackageCanClearButton", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(allCanClearSpace)));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "SubPackageHaveNoSpaceClear", Array.Empty<object>());
		}
		base.GetButton(2).SetSelfInteractive(allCanClearSpace > 0L);
	}

	// Token: 0x06016BAC RID: 93100 RVA: 0x005C3965 File Offset: 0x005C1B65
	private void OnRefreshSubPackClearData()
	{
		this.RefreshView();
		this.RefreshButton();
	}

	// Token: 0x0400A893 RID: 43155
	private int TargetSubPackageId;

	// Token: 0x020090D5 RID: 37077
	private class EComponentDefine
	{
		// Token: 0x0402EECD RID: 192205
		public const int NeedSpaceText = 0;

		// Token: 0x0402EECE RID: 192206
		public const int LeftSpaceText = 1;

		// Token: 0x0402EECF RID: 192207
		public const int CancelBtn = 2;

		// Token: 0x0402EED0 RID: 192208
		public const int ConfirmBtn = 3;

		// Token: 0x0402EED1 RID: 192209
		public const int TitleText = 4;

		// Token: 0x0402EED2 RID: 192210
		public const int DesText = 5;

		// Token: 0x0402EED3 RID: 192211
		public const int CloseBtnText = 6;
	}
}
