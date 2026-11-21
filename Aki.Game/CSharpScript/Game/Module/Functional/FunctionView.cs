using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049FD RID: 18941
	[NullableContext(2)]
	[Nullable(0)]
	public class FunctionView : UiViewBase
	{
		// Token: 0x0602F793 RID: 194451 RVA: 0x00D3D0BC File Offset: 0x00D3B2BC
		[NullableContext(1)]
		public FunctionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F794 RID: 194452 RVA: 0x00D3D0DC File Offset: 0x00D3B2DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 40;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 17;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.BackClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.EndClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.MailClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.HelpClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.TimeClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.SetUpClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.CopyUidClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.NoticeBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.PhotoBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(21, new Action(this.HeadIconButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.MoreButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.SignButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.NameButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.MoveToLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.MoveToRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(32, new Action(this.OnClickOnlineButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(37, new Action(this.OnClickPreDownload));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F795 RID: 194453 RVA: 0x00D3D8C8 File Offset: 0x00D3BAC8
		protected override UniTask OnBeforeStartAsync()
		{
			FunctionView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FunctionView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F796 RID: 194454 RVA: 0x00D3D90B File Offset: 0x00D3BB0B
		private void RefreshPlayerTitle()
		{
			PlayerTitleItem titleItem = this.TitleItem;
			if (titleItem == null)
			{
				return;
			}
			titleItem.Refresh(new int?(PersonalModel.Instance.GetDressedPlayerTitleId()), new int?(PersonalModel.Instance.GetDressedPlayerTitleLevel()), new int?(PersonalModel.Instance.GetSex()));
		}

		// Token: 0x0602F797 RID: 194455 RVA: 0x00D3D94A File Offset: 0x00D3BB4A
		private void BackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602F798 RID: 194456 RVA: 0x00D3D953 File Offset: 0x00D3BB53
		private void EndClick()
		{
			ConfirmBoxController.Instance.ShowReturnLoginConfirmBox();
		}

		// Token: 0x0602F799 RID: 194457 RVA: 0x00D3D960 File Offset: 0x00D3BB60
		private void ReportBottomButtonClick(EFunctionBottomButtonType buttonType)
		{
			OnClickFunctionItemLogEvent onClickFunctionItemLogEvent = new OnClickFunctionItemLogEvent();
			onClickFunctionItemLogEvent.i_id = (int)buttonType;
			onClickFunctionItemLogEvent.i_type = 2;
			LogReportController.Instance.LogReport(onClickFunctionItemLogEvent);
		}

		// Token: 0x0602F79A RID: 194458 RVA: 0x00D3D98C File Offset: 0x00D3BB8C
		private void NoticeBtnClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Notice);
			KuroSdkController.Instance.OpenNotice(EOpenNoticeStage.Normal);
		}

		// Token: 0x0602F79B RID: 194459 RVA: 0x00D3D9A0 File Offset: 0x00D3BBA0
		private void MailClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Mail);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Mail);
		}

		// Token: 0x0602F79C RID: 194460 RVA: 0x00D3D9B8 File Offset: 0x00D3BBB8
		private void HelpClick()
		{
			WorldLevelController.Instance.OpenWorldLevelInfoView();
		}

		// Token: 0x0602F79D RID: 194461 RVA: 0x00D3D9C4 File Offset: 0x00D3BBC4
		private void TimeClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Time);
			UiManager.Instance.OpenView(EUiViewName.TimeOfDaySecondView, null, null);
		}

		// Token: 0x0602F79E RID: 194462 RVA: 0x00D3D9DE File Offset: 0x00D3BBDE
		private void SetUpClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Setting);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Menu);
		}

		// Token: 0x0602F79F RID: 194463 RVA: 0x00D3D9F8 File Offset: 0x00D3BBF8
		private void CopyUidClick()
		{
			GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
			ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
		}

		// Token: 0x0602F7A0 RID: 194464 RVA: 0x00D3DA36 File Offset: 0x00D3BC36
		private void PhotoBtnClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Photograph);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Photograph);
		}

		// Token: 0x0602F7A1 RID: 194465 RVA: 0x00D3DA4E File Offset: 0x00D3BC4E
		private void HeadIconButtonClick()
		{
			if (FunctionModel.Instance.IsOpen(10060))
			{
				UiManager.Instance.OpenView(EUiViewName.PersonalRootView, PersonalModel.Instance.GetPersonalInfoData(), null);
			}
		}

		// Token: 0x0602F7A2 RID: 194466 RVA: 0x00D3DA7B File Offset: 0x00D3BC7B
		private void MoreButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PersonalOptionView, null, null);
		}

		// Token: 0x0602F7A3 RID: 194467 RVA: 0x00D3DA8E File Offset: 0x00D3BC8E
		private void SignButtonClick()
		{
			CommonInputViewController.Instance.OpenPersonalSignInputView();
		}

		// Token: 0x0602F7A4 RID: 194468 RVA: 0x00D3DA9A File Offset: 0x00D3BC9A
		private void NameButtonClick()
		{
			CommonInputViewController.Instance.OpenSetRoleNameInputView();
		}

		// Token: 0x0602F7A5 RID: 194469 RVA: 0x00D3DAA6 File Offset: 0x00D3BCA6
		private void OpenPlayerTitleEditView()
		{
			UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.PlayerTitle, null);
		}

		// Token: 0x0602F7A6 RID: 194470 RVA: 0x00D3DAC0 File Offset: 0x00D3BCC0
		private void MoveToLeft()
		{
			if (this.NoCircleExhibitionView.MovingState())
			{
				return;
			}
			if (this.NoCircleExhibitionView.GetCurrentSelectIndex() <= 0)
			{
				return;
			}
			int showItemIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex() - 1;
			this.NoCircleExhibitionView.AttachToIndex(showItemIndex, false);
		}

		// Token: 0x0602F7A7 RID: 194471 RVA: 0x00D3DB08 File Offset: 0x00D3BD08
		private void MoveToRight()
		{
			if (this.NoCircleExhibitionView.MovingState())
			{
				return;
			}
			if (this.NoCircleExhibitionView.GetCurrentSelectIndex() >= this.NoCircleExhibitionView.GetDataLength())
			{
				return;
			}
			int showItemIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex() + 1;
			this.NoCircleExhibitionView.AttachToIndex(showItemIndex, false);
		}

		// Token: 0x0602F7A8 RID: 194472 RVA: 0x00D3DB58 File Offset: 0x00D3BD58
		private void OnClickOnlineButton()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew;
			if (OnlineModel.Instance.GetIsMyTeam())
			{
				confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuitOnlineWorldAndReduceTeam);
			}
			else
			{
				confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuitOnlineWorld);
			}
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				OnlineController.Instance.LeaveWorldTeamRequest(FunctionModel.Instance.PlayerId, null);
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602F7A9 RID: 194473 RVA: 0x00D3DBB6 File Offset: 0x00D3BDB6
		private void OnClickPreDownload()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.PreDownload);
			PreDownloadController.Instance.OnPreDownloadBtnClick(false);
		}

		// Token: 0x0602F7AA RID: 194474 RVA: 0x00D3DBCC File Offset: 0x00D3BDCC
		protected override void OnStart()
		{
			this.RedTipsLeftBtn = base.GetButton(17).RootUIComp;
			this.RedTipsRightBtn = base.GetButton(16).RootUIComp;
			this.RedTipsLeft = base.GetItem(19);
			this.RedTipsRight = base.GetItem(18);
			this.TabLayout = new FunctionTabLayout(base.GetItem(28));
			this.NoCircleExhibitionView = new NoCircleAttachView<int[], FunctionAttachItemGrid>(base.GetItem(10).GetOwner(), false);
			UUIItem item = base.GetItem(29);
			item.SetUIActive(false);
			this.ReSizeDragContentSize();
			this.NoCircleExhibitionView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, FunctionAttachItemGrid>(this.InitFunctionGrid), EAttachDirection.Horizontal);
			this.NoCircleExhibitionView.SetDragBeginCallback(new Action(this.HideRedTipsBtn));
			this.NoCircleExhibitionView.SetMoveMultiFactor(50f);
			this.NoCircleExhibitionView.SetPageLimitState(true);
			this.BottomMailBtn = new FunctionBottomButtonItem(base.GetButton(8).RootUIComp.Get(), ERedDotName.FunctionMail);
			this.BottomNoticeBtn = new FunctionBottomButtonItem(base.GetButton(15).RootUIComp.Get(), ERedDotName.FunctionNotice);
			this.BottomPhotoBtn = new FunctionBottomButtonItem(base.GetButton(20).RootUIComp.Get(), ERedDotName.FunctionPhotograph);
			this.BottomSettingBtn = new FunctionBottomButtonItem(base.GetButton(13).RootUIComp.Get(), ERedDotName.FunctionSetting);
			this.BottomPreDownloadBtn = new PreDownloadButtonItemB(base.GetButton(37).RootUIComp.Get());
			bool raycastTarget = FunctionModel.Instance.IsOpen(10060);
			UUIButtonComponent button = base.GetButton(21);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetRaycastTarget(raycastTarget);
				}
			}
			this.RefreshEndButtonShowState();
			this.RefreshFunctionGrid();
			int currentSelectIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex();
			this.RefreshRedDot(currentSelectIndex);
			this.TabLayout.SetToggleSelectByIndex(currentSelectIndex);
			if (Info.Instance.IsHomeConsolePlatform())
			{
				UUIButtonComponent button2 = base.GetButton(14);
				if (button2 != null)
				{
					button2.SetSelfInteractive(false);
				}
				UUISprite sprite = base.GetSprite(36);
				if (sprite == null)
				{
					return;
				}
				sprite.SetUIActive(false);
			}
		}

		// Token: 0x0602F7AB RID: 194475 RVA: 0x00D3DDFC File Offset: 0x00D3BFFC
		private void ReSizeDragContentSize()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(30);
			FVector2D fvector2D = (gridLayout != null) ? gridLayout.GetCellSize() : FVector2D.ZeroVector;
			FVector2D fvector2D2 = (gridLayout != null) ? gridLayout.GetSpacing() : FVector2D.ZeroVector;
			float num = fvector2D.X + fvector2D2.X;
			float num2 = (float)this.CalculateGridNum().HorizontalGridNum * num;
			if (num2 <= 0f)
			{
				return;
			}
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetWidth(num2);
		}

		// Token: 0x0602F7AC RID: 194476 RVA: 0x00D3DE6D File Offset: 0x00D3C06D
		private void HideRedTipsBtn()
		{
			this.RedTipsRightBtn.SetUIActive(false);
			this.RedTipsLeftBtn.SetUIActive(false);
		}

		// Token: 0x0602F7AD RID: 194477 RVA: 0x00D3DE88 File Offset: 0x00D3C088
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(this.OnCurWorldLevelChange));
			EventSystem.Instance.Add(EEventName.OnSignChange, new Action(this.OnSignChange));
			EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Add(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
			EventSystem.Instance.Add(EEventName.OnCardChange, new Action(this.OnCardChange));
			EventSystem.Instance.Add(EEventName.OnBirthChange, new Action(this.OnBirthChange));
			EventSystem.Instance.Add(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
			EventSystem.Instance.Add(EEventName.OnPlayerTitleChange, new Action(this.RefreshPlayerTitle));
			EventSystem.Instance.Add<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Add(EEventName.OnPreDownloadAvailableUpdate, new Action(this.OnPreDownloadUpdate));
			EventSystem.Instance.Emit(EEventName.OnFunctionViewShow);
		}

		// Token: 0x0602F7AE RID: 194478 RVA: 0x00D3DFC0 File Offset: 0x00D3C1C0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(this.OnCurWorldLevelChange));
			EventSystem.Instance.Remove(EEventName.OnSignChange, new Action(this.OnSignChange));
			EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.OnNameChange));
			EventSystem.Instance.Remove(EEventName.OnHeadIconChange, new Action<int>(this.OnHeadIconChange));
			EventSystem.Instance.Remove(EEventName.OnCardChange, new Action(this.OnCardChange));
			EventSystem.Instance.Remove(EEventName.OnBirthChange, new Action(this.OnBirthChange));
			EventSystem.Instance.Remove(EEventName.OnPlayerTitleChange, new Action(this.RefreshPlayerTitle));
			EventSystem.Instance.Remove(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
			EventSystem.Instance.Remove<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
			EventSystem.Instance.Remove(EEventName.OnPreDownloadAvailableUpdate, new Action(this.OnPreDownloadUpdate));
		}

		// Token: 0x0602F7AF RID: 194479 RVA: 0x00D3E0E5 File Offset: 0x00D3C2E5
		private void OnCurWorldLevelChange()
		{
			this.RefreshWorldLevel();
		}

		// Token: 0x0602F7B0 RID: 194480 RVA: 0x00D3E0ED File Offset: 0x00D3C2ED
		private void OnSignChange()
		{
			this.RefreshSign();
		}

		// Token: 0x0602F7B1 RID: 194481 RVA: 0x00D3E0F8 File Offset: 0x00D3C2F8
		private void OnNameChange()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			if (playerName != null)
			{
				base.GetText(0).SetText(playerName, true);
			}
		}

		// Token: 0x0602F7B2 RID: 194482 RVA: 0x00D3E121 File Offset: 0x00D3C321
		private void OnHeadIconChange(int headPhotoId)
		{
			this.RefreshHeadIcon();
		}

		// Token: 0x0602F7B3 RID: 194483 RVA: 0x00D3E129 File Offset: 0x00D3C329
		private void OnCardChange()
		{
			this.RefreshCard();
		}

		// Token: 0x0602F7B4 RID: 194484 RVA: 0x00D3E131 File Offset: 0x00D3C331
		private void OnBirthChange()
		{
			this.RefreshBirthDay();
		}

		// Token: 0x0602F7B5 RID: 194485 RVA: 0x00D3E139 File Offset: 0x00D3C339
		private void OnFunctionGridSelected(int index)
		{
			this.RefreshRedDot(index);
			this.TabLayout.SetToggleSelectByIndex(index);
		}

		// Token: 0x0602F7B6 RID: 194486 RVA: 0x00D3E150 File Offset: 0x00D3C350
		private void RefreshRedDot(int index)
		{
			this.RedTipsLeftBtn.SetUIActive(index > 0);
			this.RedTipsRightBtn.SetUIActive(index < this.NoCircleExhibitionView.GetDataLength() - 1);
			this.RedTipsLeft.SetUIActive(this.IsRedLeftBtnActive(index));
			this.RedTipsRight.SetUIActive(this.IsRedRightBtnActive(index));
		}

		// Token: 0x0602F7B7 RID: 194487 RVA: 0x00D3E1AC File Offset: 0x00D3C3AC
		private void RefreshEndButtonShowState()
		{
			bool uiactive = !CloudGameManager.Instance.IsCloudGame && !Info.Instance.IsPs5Platform() && (!Info.Instance.IsXboxPlatform() || Info.Instance.IsWinGDKPlatform());
			UUIButtonComponent button = base.GetButton(7);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x0602F7B8 RID: 194488 RVA: 0x00D3E214 File Offset: 0x00D3C414
		private bool IsRedLeftBtnActive(int index)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < index; i++)
			{
				list.AddRange(this.DataList[i]);
			}
			foreach (int functionId in list)
			{
				ERedDotName? functionItemRedDotName = FunctionModel.Instance.GetFunctionItemRedDotName(functionId);
				if (functionItemRedDotName != null)
				{
					RedDotBase redDot = RedDotModel.Instance.GetRedDot(functionItemRedDotName.Value);
					if (redDot != null && redDot.IsRedDotActive())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602F7B9 RID: 194489 RVA: 0x00D3E2C4 File Offset: 0x00D3C4C4
		private bool IsRedRightBtnActive(int index)
		{
			List<int> list = new List<int>();
			int i = index + 1;
			int count = this.DataList.Count;
			while (i < count)
			{
				list.AddRange(this.DataList[i]);
				i++;
			}
			foreach (int functionId in list)
			{
				ERedDotName? functionItemRedDotName = FunctionModel.Instance.GetFunctionItemRedDotName(functionId);
				if (functionItemRedDotName != null)
				{
					RedDotBase redDot = RedDotModel.Instance.GetRedDot(functionItemRedDotName.Value);
					if (redDot != null && redDot.IsRedDotActive())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602F7BA RID: 194490 RVA: 0x00D3E380 File Offset: 0x00D3C580
		protected override void OnBeforeShow()
		{
			this.SetPlayerInfo();
			this.RefreshOtherButton();
			this.BindRedDot();
			this.RefreshOnlineButton();
			this.RefreshResDownLoadTopPanelState();
			GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("FunctionView");
		}

		// Token: 0x0602F7BB RID: 194491 RVA: 0x00D3E3AF File Offset: 0x00D3C5AF
		protected override void OnAfterShow()
		{
			this.PrintCalculateData();
			this.TryShowParallelPackageUpdateBoxView();
		}

		// Token: 0x0602F7BC RID: 194492 RVA: 0x00D3E3BD File Offset: 0x00D3C5BD
		protected override void OnAfterHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602F7BD RID: 194493 RVA: 0x00D3E3C8 File Offset: 0x00D3C5C8
		protected override void OnBeforeDestroy()
		{
			foreach (FunctionAttachItemGrid child in this.NoCircleExhibitionView.GetItems())
			{
				base.AddChild(child);
			}
			this.TabLayout.Destroy(null);
			this.BottomMailBtn.Destroy(null);
			this.BottomNoticeBtn.Destroy(null);
			this.BottomPhotoBtn.Destroy(null);
			this.BottomSettingBtn.Destroy(null);
			this.TitleItem.Destroy(null);
			this.BottomPreDownloadBtn.Destroy(null);
			this.BottomDownloadPanel.EndShow();
			GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("FunctionView");
		}

		// Token: 0x0602F7BE RID: 194494 RVA: 0x00D3E490 File Offset: 0x00D3C690
		private void BindRedDot()
		{
			this.BottomMailBtn.BindRedDot();
			this.BottomNoticeBtn.BindRedDot();
			this.BottomPhotoBtn.BindRedDot();
			this.BottomSettingBtn.BindRedDot();
			this.BottomPreDownloadBtn.BindRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.PersonalizedInfo, base.GetItem(34), null, 0);
		}

		// Token: 0x0602F7BF RID: 194495 RVA: 0x00D3E4F0 File Offset: 0x00D3C6F0
		private void UnBindRedDot()
		{
			this.BottomMailBtn.UnBindRedDot();
			this.BottomNoticeBtn.UnBindRedDot();
			this.BottomPhotoBtn.UnBindRedDot();
			this.BottomSettingBtn.UnBindRedDot();
			this.BottomPreDownloadBtn.UnBindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.PersonalizedInfo, base.GetItem(34), 0);
		}

		// Token: 0x0602F7C0 RID: 194496 RVA: 0x00D3E54C File Offset: 0x00D3C74C
		private void SetPlayerInfo()
		{
			this.RefreshPlayerName();
			this.RefreshPlayerLevelAndExp();
			this.RefreshWorldLevel();
			this.RefreshHeadIcon();
			this.RefreshCard();
			this.RefreshSign();
			this.RefreshBirthDay();
			this.RefreshPlayerTitle();
		}

		// Token: 0x0602F7C1 RID: 194497 RVA: 0x00D3E580 File Offset: 0x00D3C780
		private void RefreshPlayerName()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			base.GetText(0).SetText(playerName, true);
		}

		// Token: 0x0602F7C2 RID: 194498 RVA: 0x00D3E5A8 File Offset: 0x00D3C7A8
		private void RefreshPlayerLevelAndExp()
		{
			int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
			if (playerLevel == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(4), "PlayerLevelNum", new <>z__ReadOnlySingleElementList<object>(playerLevel));
			LguiUtil.Instance.SetLocalText(base.GetText(1), "UserId", new <>z__ReadOnlySingleElementList<object>(FunctionModel.Instance.PlayerId));
			PlayerExp? config = ConfigPlayerExpByPlayerLevel.GetConfig(playerLevel.Value, true);
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				int levelExp = config.GetValueOrDefault().LevelExp;
				flag = true;
			}
			if (flag)
			{
				int? playerExp = FunctionModel.Instance.GetPlayerExp();
				LguiUtil.Instance.SetLocalText(base.GetText(5), "ExpText", new <>z__ReadOnlyArray<object>(new object[]
				{
					playerExp,
					config.Value.LevelExp
				}));
				base.GetSprite(9).SetFillAmount((float)playerExp.Value / (float)config.Value.LevelExp);
			}
		}

		// Token: 0x0602F7C3 RID: 194499 RVA: 0x00D3E6B4 File Offset: 0x00D3C8B4
		private void RefreshWorldLevel()
		{
			LguiUtil.Instance.SetLocalText(base.GetText(2), "WorldLevelNum", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.CurWorldLevel));
		}

		// Token: 0x0602F7C4 RID: 194500 RVA: 0x00D3E6E0 File Offset: 0x00D3C8E0
		private void RefreshHeadIcon()
		{
			int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
			if (numberPropById == null)
			{
				return;
			}
			UUITexture playerTexture = base.GetTexture(11);
			PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(numberPropById.Value, true);
			if (playerHeadData == null)
			{
				return;
			}
			playerTexture.SetUIActive(false);
			base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), playerTexture, delegate(bool _)
			{
				playerTexture.SetUIActive(true);
			});
			bool uiactive = PersonalModel.Instance.CheckCanShowPersonalTip();
			base.GetItem(35).SetUIActive(uiactive);
		}

		// Token: 0x0602F7C5 RID: 194501 RVA: 0x00D3E774 File Offset: 0x00D3C974
		private void RefreshCard()
		{
			int curCardId = PersonalModel.Instance.GetCurCardId();
			BackgroundCard? config = ConfigBackgroundCardById.GetConfig(curCardId, true);
			if (config != null)
			{
				base.SetTextureByPath(config.Value.FunctionViewCardPath, base.GetTexture(23), null, null);
			}
		}

		// Token: 0x0602F7C6 RID: 194502 RVA: 0x00D3E7C4 File Offset: 0x00D3C9C4
		private void RefreshSign()
		{
			string signature = PersonalModel.Instance.GetSignature();
			UUIText text = base.GetText(25);
			if (string.IsNullOrEmpty(signature))
			{
				LguiUtil.Instance.SetLocalText(text, "ClickToSetSign", Array.Empty<object>());
				return;
			}
			text.SetText(signature, true);
		}

		// Token: 0x0602F7C7 RID: 194503 RVA: 0x00D3E80C File Offset: 0x00D3CA0C
		private void RefreshBirthDay()
		{
			int birthday = PersonalModel.Instance.GetBirthday();
			UUIText text = base.GetText(26);
			if (birthday == 0)
			{
				LguiUtil.Instance.SetLocalText(text, "BirthDay", new <>z__ReadOnlyArray<object>(new object[]
				{
					"--",
					"--"
				}));
				return;
			}
			int date = (int)Math.Floor((double)birthday / 100.0);
			int date2 = birthday % 100;
			string birthLocalText = PersonalConfig.Instance.GetBirthLocalText(date, EBirthDateType.MONTH);
			string birthLocalText2 = PersonalConfig.Instance.GetBirthLocalText(date2, EBirthDateType.DAY);
			LguiUtil.Instance.SetLocalText(text, "BirthDay", new <>z__ReadOnlyArray<object>(new object[]
			{
				birthLocalText,
				birthLocalText2
			}));
		}

		// Token: 0x0602F7C8 RID: 194504 RVA: 0x00D3E8B8 File Offset: 0x00D3CAB8
		private void SetPanelTabItemStretchRight(float offsetValue)
		{
			UUIItem item = base.GetItem(31);
			float stretchRight = item.GetStretchRight();
			item.SetStretchRight(stretchRight + offsetValue);
		}

		// Token: 0x0602F7C9 RID: 194505 RVA: 0x00D3E8DC File Offset: 0x00D3CADC
		private void RefreshFunctionGrid()
		{
			this.CalculateData = this.CalculateGridNum();
			this.SetPanelTabItemStretchRight(this.CalculateData.OffsetWidth);
			int[] showFunctionIdList = FunctionModel.Instance.GetShowFunctionIdList();
			int num = showFunctionIdList.Length;
			int num2 = Math.Max(1, this.CalculateData.TotalGridNumber);
			this.DataList = new List<int[]>();
			if (num == 0)
			{
				this.DataList.Add(Array.Empty<int>());
			}
			else
			{
				int num3 = 0;
				while (num3 + num2 < num)
				{
					int[] array = new int[num2];
					Array.Copy(showFunctionIdList, num3, array, 0, num2);
					this.DataList.Add(array);
					num3 += num2;
				}
				int[] array2 = new int[num - num3];
				Array.Copy(showFunctionIdList, num3, array2, 0, num - num3);
				this.DataList.Add(array2);
			}
			int count = this.DataList.Count;
			this.TabLayout.RefreshTab(count);
			this.NoCircleExhibitionView.SetBoundDistance(0f);
			this.NoCircleExhibitionView.ReloadView(count, this.DataList.ToArray(), 0);
		}

		// Token: 0x0602F7CA RID: 194506 RVA: 0x00D3E9E4 File Offset: 0x00D3CBE4
		[NullableContext(1)]
		private FunctionAttachItemGrid InitFunctionGrid(AActor actor, int index, int showNum)
		{
			FunctionAttachItemGrid functionAttachItemGrid = new FunctionAttachItemGrid(actor);
			functionAttachItemGrid.SetNeedAnim(index == 0);
			this.FunctionGridMap[index] = functionAttachItemGrid;
			return functionAttachItemGrid;
		}

		// Token: 0x0602F7CB RID: 194507 RVA: 0x00D3EA10 File Offset: 0x00D3CC10
		private int GetTargetIndex(int functionId)
		{
			List<int[]> dataList = this.DataList;
			int result = -1;
			int i = 0;
			int count = dataList.Count;
			Predicate<int> <>9__0;
			while (i < count)
			{
				int[] array = dataList[i];
				Predicate<int> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((int id) => id == functionId));
				}
				if (Array.Exists<int>(array, match))
				{
					result = i;
				}
				i++;
			}
			return result;
		}

		// Token: 0x0602F7CC RID: 194508 RVA: 0x00D3EA7C File Offset: 0x00D3CC7C
		private void RefreshOnlineButton()
		{
			UUIButtonComponent button = base.GetButton(32);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (!GameModeModel.Instance.IsMulti)
			{
				if (tweakObjectPtr != null)
				{
					UUIItem uuiitem = tweakObjectPtr.GetValueOrDefault().Get();
					if (uuiitem == null)
					{
						return;
					}
					uuiitem.SetUIActive(false);
				}
				return;
			}
			if (tweakObjectPtr != null)
			{
				UUIItem uuiitem2 = tweakObjectPtr.GetValueOrDefault().Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(true);
				}
			}
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(FunctionModel.Instance.PlayerId);
			ENetPingState? ping = (currentTeamListById != null) ? new ENetPingState?(currentTeamListById.PingState) : null;
			this.RefreshPlayerPingItem(ping);
		}

		// Token: 0x0602F7CD RID: 194509 RVA: 0x00D3EB38 File Offset: 0x00D3CD38
		private void RefreshPlayerPingItem(ENetPingState? ping)
		{
			UUISprite sprite = base.GetSprite(33);
			sprite.SetUIActive(true);
			ENetPingState? enetPingState = ping;
			ENetPingState enetPingState2 = ENetPingState.Unknown;
			if (enetPingState.GetValueOrDefault() == enetPingState2 & enetPingState != null)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_SignalUnknown");
				this.SetSpriteByPath(resourcePath, sprite, false, null, null);
				return;
			}
			if (ping.GetValueOrDefault() == ENetPingState.Great)
			{
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_SignalGreat");
				this.SetSpriteByPath(resourcePath2, sprite, false, null, null);
				return;
			}
			if (ping.GetValueOrDefault() == ENetPingState.Good)
			{
				string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("SP_SignalGood");
				this.SetSpriteByPath(resourcePath3, sprite, false, null, null);
				return;
			}
			if (ping.GetValueOrDefault() == ENetPingState.Poor)
			{
				string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("SP_SignalPoor");
				this.SetSpriteByPath(resourcePath4, sprite, false, null, null);
			}
		}

		// Token: 0x0602F7CE RID: 194510 RVA: 0x00D3EC24 File Offset: 0x00D3CE24
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length > 1 || !int.TryParse(configParams[0], out num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "功能菜单聚焦引导的ExtraParam配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int num2 = int.Parse(configParams[0]);
			int targetIndex = this.GetTargetIndex(num2);
			if (targetIndex == -1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Guide;
				ELogAuthor author2 = ELogAuthor.TL;
				string message2 = "功能菜单聚焦引导的ExtraParam配置错误, 检查functionId";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", num2);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			this.NoCircleExhibitionView.AttachToIndex(targetIndex, true);
			FunctionAttachItemGrid functionAttachItemGrid;
			if (!this.FunctionGridMap.TryGetValue(targetIndex, out functionAttachItemGrid))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Guide;
				ELogAuthor author3 = ELogAuthor.TL;
				string message3 = "功能菜单聚焦引导的ExtraParam配置错误, 检查functionId";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("functionId", num2);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return null;
			}
			FunctionItem functionItem = functionAttachItemGrid.GetFunctionItem(num2);
			if (!functionItem.GetActive())
			{
				return null;
			}
			UUIItem buttonItem = functionItem.GetButtonItem();
			if (buttonItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				buttonItem,
				buttonItem
			};
		}

		// Token: 0x0602F7CF RID: 194511 RVA: 0x00D3ED2C File Offset: 0x00D3CF2C
		private void RefreshOtherButton()
		{
			base.GetButton(8).SetSelfInteractive(FunctionModel.Instance.IsOpen(10020));
			base.GetButton(12).SetSelfInteractive(FunctionModel.Instance.IsOpen(10018));
			base.GetButton(13).SetSelfInteractive(FunctionModel.Instance.IsOpen(10019));
			base.GetButton(15).SetSelfInteractive(KuroSdkController.Instance.CanUseSdk() || PlatformSdkManagerNew.Instance.IsSdkOn);
			base.GetButton(20).SetSelfInteractive(FunctionModel.Instance.IsOpen(10049));
			bool uiactive = PreDownloadModel.Instance.IsPreDownloadAvailable() || PreDownloadModel.Instance.IsComplete();
			UUIButtonComponent button = base.GetButton(37);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x0602F7D0 RID: 194512 RVA: 0x00D3EE0D File Offset: 0x00D3D00D
		private void TryShowParallelPackageUpdateBoxView()
		{
			ParallelPackageController.Instance.TryShowParallelPackageUpdateConfirmBox(ParallelPackageDownloadBoxShowReason.Auto);
		}

		// Token: 0x0602F7D1 RID: 194513 RVA: 0x00D3EE1C File Offset: 0x00D3D01C
		private unsafe void PrintCalculateData()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "功能开启界面Start阶段计算数据输出";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("剩余宽度", this.CalculateData.OffsetWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("显示数量", this.CalculateData.TotalGridNumber);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			ICalculateData calculateData = this.CalculateGridNum();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Functional;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "功能开启界面AfterShow阶段计算数据输出";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("剩余宽度", calculateData.OffsetWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("显示数量", calculateData.TotalGridNumber);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}

		// Token: 0x0602F7D2 RID: 194514 RVA: 0x00D3EF08 File Offset: 0x00D3D108
		[NullableContext(1)]
		private ICalculateData CalculateGridNum()
		{
			UUIItem item = base.GetItem(29);
			UUIGridLayout gridLayout = base.GetGridLayout(30);
			FVector2D cellSize = gridLayout.GetCellSize();
			FVector2D spacing = gridLayout.GetSpacing();
			FMargin padding = gridLayout.GetPadding();
			float width = item.GetWidth();
			float height = item.GetHeight();
			float num = (width - padding.Left - padding.Right) % (cellSize.X + spacing.X);
			int num2 = (num >= cellSize.X) ? 1 : 0;
			int num3 = (int)Math.Floor((double)((width - padding.Left - padding.Right) / (cellSize.X + spacing.X))) + num2;
			int num4 = ((height - padding.Top - padding.Bottom) % (cellSize.Y + spacing.Y) > cellSize.Y) ? 1 : 0;
			int val = (int)Math.Floor((double)((height - padding.Top - padding.Bottom) / (cellSize.Y + spacing.Y))) + num4;
			float offsetWidth = (num3 > 0) ? ((num >= cellSize.X) ? (num - cellSize.X) : (num + spacing.X)) : 0f;
			int num5 = Math.Max(1, num3);
			int num6 = Math.Max(1, val);
			return new CalculateData
			{
				TotalGridNumber = num5 * num6,
				OffsetWidth = offsetWidth,
				HorizontalGridNum = num5,
				VerticalGridNum = num6
			};
		}

		// Token: 0x0602F7D3 RID: 194515 RVA: 0x00D3F053 File Offset: 0x00D3D253
		private void ResDownLoadStateRefresh(EVideoDownloadStatus state)
		{
			this.RefreshResDownLoadTopPanelState();
		}

		// Token: 0x0602F7D4 RID: 194516 RVA: 0x00D3F05C File Offset: 0x00D3D25C
		private void RefreshResDownLoadTopPanelState()
		{
			if (SubPackageDownLoadModel.Instance.NeedShowBattleViewButton())
			{
				FunctionResDownLoadItem bottomDownloadPanel = this.BottomDownloadPanel;
				if (bottomDownloadPanel != null)
				{
					bottomDownloadPanel.SetUiActive(true);
				}
				FunctionResDownLoadItem bottomDownloadPanel2 = this.BottomDownloadPanel;
				if (bottomDownloadPanel2 == null)
				{
					return;
				}
				bottomDownloadPanel2.StartShow();
				return;
			}
			else
			{
				FunctionResDownLoadItem bottomDownloadPanel3 = this.BottomDownloadPanel;
				if (bottomDownloadPanel3 != null)
				{
					bottomDownloadPanel3.SetUiActive(false);
				}
				FunctionResDownLoadItem bottomDownloadPanel4 = this.BottomDownloadPanel;
				if (bottomDownloadPanel4 == null)
				{
					return;
				}
				bottomDownloadPanel4.EndShow();
				return;
			}
		}

		// Token: 0x0602F7D5 RID: 194517 RVA: 0x00D3F0BC File Offset: 0x00D3D2BC
		private void OnPreDownloadUpdate()
		{
			bool uiactive = PreDownloadModel.Instance.IsPreDownloadAvailable() || PreDownloadModel.Instance.IsComplete();
			UUIButtonComponent button = base.GetButton(37);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x0401924E RID: 102990
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<int[], FunctionAttachItemGrid> NoCircleExhibitionView;

		// Token: 0x0401924F RID: 102991
		private FunctionTabLayout TabLayout;

		// Token: 0x04019250 RID: 102992
		private UUIItem RedTipsLeftBtn;

		// Token: 0x04019251 RID: 102993
		private UUIItem RedTipsRightBtn;

		// Token: 0x04019252 RID: 102994
		private UUIItem RedTipsLeft;

		// Token: 0x04019253 RID: 102995
		private UUIItem RedTipsRight;

		// Token: 0x04019254 RID: 102996
		private FunctionBottomButtonItem BottomMailBtn;

		// Token: 0x04019255 RID: 102997
		private FunctionBottomButtonItem BottomNoticeBtn;

		// Token: 0x04019256 RID: 102998
		private FunctionBottomButtonItem BottomPhotoBtn;

		// Token: 0x04019257 RID: 102999
		private FunctionBottomButtonItem BottomSettingBtn;

		// Token: 0x04019258 RID: 103000
		private PlayerTitleItem TitleItem;

		// Token: 0x04019259 RID: 103001
		private PreDownloadButtonItemB BottomPreDownloadBtn;

		// Token: 0x0401925A RID: 103002
		private FunctionResDownLoadItem BottomDownloadPanel;

		// Token: 0x0401925B RID: 103003
		[Nullable(1)]
		private readonly Dictionary<int, FunctionAttachItemGrid> FunctionGridMap = new Dictionary<int, FunctionAttachItemGrid>();

		// Token: 0x0401925C RID: 103004
		[Nullable(1)]
		private List<int[]> DataList = new List<int[]>();

		// Token: 0x0401925D RID: 103005
		[Nullable(1)]
		private ICalculateData CalculateData;

		// Token: 0x0200A69D RID: 42653
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04033809 RID: 210953
			public const int PlayerName = 0;

			// Token: 0x0403380A RID: 210954
			public const int PlayerId = 1;

			// Token: 0x0403380B RID: 210955
			public const int WorldLevel = 2;

			// Token: 0x0403380C RID: 210956
			public const int HelpBtn = 3;

			// Token: 0x0403380D RID: 210957
			public const int PlayerLevel = 4;

			// Token: 0x0403380E RID: 210958
			public const int PlayerExp = 5;

			// Token: 0x0403380F RID: 210959
			public const int BackBtn = 6;

			// Token: 0x04033810 RID: 210960
			public const int EndBtn = 7;

			// Token: 0x04033811 RID: 210961
			public const int MailBtn = 8;

			// Token: 0x04033812 RID: 210962
			public const int ExpProgressBar = 9;

			// Token: 0x04033813 RID: 210963
			public const int FuncDraggable = 10;

			// Token: 0x04033814 RID: 210964
			public const int PlayerTexture = 11;

			// Token: 0x04033815 RID: 210965
			public const int TimeButton = 12;

			// Token: 0x04033816 RID: 210966
			public const int SetUpButton = 13;

			// Token: 0x04033817 RID: 210967
			public const int CopyUidButton = 14;

			// Token: 0x04033818 RID: 210968
			public const int NoticeBtn = 15;

			// Token: 0x04033819 RID: 210969
			public const int RedTipsRightBtn = 16;

			// Token: 0x0403381A RID: 210970
			public const int RedTipsLeftBtn = 17;

			// Token: 0x0403381B RID: 210971
			public const int RedTipsRight = 18;

			// Token: 0x0403381C RID: 210972
			public const int RedTipsLeft = 19;

			// Token: 0x0403381D RID: 210973
			public const int PhotoBtn = 20;

			// Token: 0x0403381E RID: 210974
			public const int HeadIconButton = 21;

			// Token: 0x0403381F RID: 210975
			public const int MoreButton = 22;

			// Token: 0x04033820 RID: 210976
			public const int Card = 23;

			// Token: 0x04033821 RID: 210977
			public const int SignButton = 24;

			// Token: 0x04033822 RID: 210978
			public const int SignText = 25;

			// Token: 0x04033823 RID: 210979
			public const int BirthText = 26;

			// Token: 0x04033824 RID: 210980
			public const int NameButton = 27;

			// Token: 0x04033825 RID: 210981
			public const int TabRoot = 28;

			// Token: 0x04033826 RID: 210982
			public const int GridItem = 29;

			// Token: 0x04033827 RID: 210983
			public const int GridInsideLayout = 30;

			// Token: 0x04033828 RID: 210984
			public const int PanelTabItem = 31;

			// Token: 0x04033829 RID: 210985
			public const int OnlineButton = 32;

			// Token: 0x0403382A RID: 210986
			public const int NetStateSprite = 33;

			// Token: 0x0403382B RID: 210987
			public const int PersonalRedDot = 34;

			// Token: 0x0403382C RID: 210988
			public const int PersonalTipItem = 35;

			// Token: 0x0403382D RID: 210989
			public const int CopyUidButtonSprite = 36;

			// Token: 0x0403382E RID: 210990
			public const int MobilePreDownloadBtn = 37;

			// Token: 0x0403382F RID: 210991
			public const int PlayerTitleItem = 38;

			// Token: 0x04033830 RID: 210992
			public const int DownLoadPanel = 39;
		}
	}
}
