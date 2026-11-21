using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using UnrealEngine;

// Token: 0x0200201D RID: 8221
public class SubPackageDownLoadFreeSpaceTipsView : UiViewBase
{
	// Token: 0x060145D1 RID: 83409 RVA: 0x005F003B File Offset: 0x005EE23B
	[NullableContext(1)]
	public SubPackageDownLoadFreeSpaceTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060145D2 RID: 83410 RVA: 0x005F0044 File Offset: 0x005EE244
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

	// Token: 0x060145D3 RID: 83411 RVA: 0x005F0131 File Offset: 0x005EE331
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackClearData, new Action(this.OnRefreshSubPackClearData));
	}

	// Token: 0x060145D4 RID: 83412 RVA: 0x005F014F File Offset: 0x005EE34F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackClearData, new Action(this.OnRefreshSubPackClearData));
	}

	// Token: 0x060145D5 RID: 83413 RVA: 0x005F0170 File Offset: 0x005EE370
	protected override void OnStart()
	{
		this.TargetSubPackageId = (int)this.OpenParam;
		SubPackageDownLoadModel.Instance.HaveTipsOutOfSpaceList.Add(this.TargetSubPackageId);
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.TargetSubPackageId);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.TargetSubPackageId);
		long requiredSpace = subPackageSpace - subPackageHaveDownLoadSpace;
		SubPackageController.Instance.ReportSubPackageOutOfSpaceLogEvent(this.TargetSubPackageId, requiredSpace, VideoResUpdate.Instance.GetFreeSpace());
	}

	// Token: 0x060145D6 RID: 83414 RVA: 0x005F01E2 File Offset: 0x005EE3E2
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshButton();
	}

	// Token: 0x060145D7 RID: 83415 RVA: 0x005F01F0 File Offset: 0x005EE3F0
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
			base.CloseMe(null);
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			SubPackageDownLoadModel.Instance.OpenMultiBanCleanConfirm();
			base.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadMobileClearPopView, this.TargetSubPackageId, null);
	}

	// Token: 0x060145D8 RID: 83416 RVA: 0x005F0280 File Offset: 0x005EE480
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

	// Token: 0x060145D9 RID: 83417 RVA: 0x005F02F0 File Offset: 0x005EE4F0
	private void RefreshView()
	{
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.TargetSubPackageId);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.TargetSubPackageId);
		long byteValue = subPackageSpace - subPackageHaveDownLoadSpace;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DownLoadText_NeedSpace", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(byteValue)));
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#c25757>" + SubPackageDownLoadModel.Instance.ByteConverter(freeSpace) + "</color>"));
	}

	// Token: 0x060145DA RID: 83418 RVA: 0x005F0388 File Offset: 0x005EE588
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

	// Token: 0x060145DB RID: 83419 RVA: 0x005F0405 File Offset: 0x005EE605
	private void OnRefreshSubPackClearData()
	{
		this.RefreshView();
		this.RefreshButton();
	}

	// Token: 0x0400AC99 RID: 44185
	private int TargetSubPackageId;

	// Token: 0x02008319 RID: 33561
	private class EComponentDefine
	{
		// Token: 0x0402A5D2 RID: 173522
		public const int NeedSpaceText = 0;

		// Token: 0x0402A5D3 RID: 173523
		public const int LeftSpaceText = 1;

		// Token: 0x0402A5D4 RID: 173524
		public const int CancelBtn = 2;

		// Token: 0x0402A5D5 RID: 173525
		public const int ConfirmBtn = 3;

		// Token: 0x0402A5D6 RID: 173526
		public const int TitleText = 4;

		// Token: 0x0402A5D7 RID: 173527
		public const int DesText = 5;

		// Token: 0x0402A5D8 RID: 173528
		public const int CloseBtnText = 6;
	}
}
