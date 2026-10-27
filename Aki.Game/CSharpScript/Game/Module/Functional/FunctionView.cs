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
	// Token: 0x02005A21 RID: 23073
	[NullableContext(2)]
	[Nullable(0)]
	public class FunctionView : UiViewBase
	{
		// Token: 0x0603A84A RID: 239690 RVA: 0x00DECB2C File Offset: 0x00DEAD2C
		[NullableContext(1)]
		public FunctionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A84B RID: 239691 RVA: 0x00DECB4C File Offset: 0x00DEAD4C
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

		// Token: 0x0603A84C RID: 239692 RVA: 0x00DED338 File Offset: 0x00DEB538
		protected override UniTask OnBeforeStartAsync()
		{
			FunctionView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FunctionView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A84D RID: 239693 RVA: 0x00DED37B File Offset: 0x00DEB57B
		private void RefreshPlayerTitle()
		{
			PlayerTitleItem titleItem = this.TitleItem;
			if (titleItem == null)
			{
				return;
			}
			titleItem.Refresh(new int?(PersonalModel.Instance.GetDressedPlayerTitleId()), new int?(PersonalModel.Instance.GetDressedPlayerTitleLevel()), new int?(PersonalModel.Instance.GetSex()));
		}

		// Token: 0x0603A84E RID: 239694 RVA: 0x00DED3BA File Offset: 0x00DEB5BA
		private void BackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603A84F RID: 239695 RVA: 0x00DED3C3 File Offset: 0x00DEB5C3
		private void EndClick()
		{
			ConfirmBoxController.Instance.ShowReturnLoginConfirmBox();
		}

		// Token: 0x0603A850 RID: 239696 RVA: 0x00DED3D0 File Offset: 0x00DEB5D0
		private void ReportBottomButtonClick(EFunctionBottomButtonType buttonType)
		{
			OnClickFunctionItemLogEvent onClickFunctionItemLogEvent = new OnClickFunctionItemLogEvent();
			onClickFunctionItemLogEvent.i_id = (int)buttonType;
			onClickFunctionItemLogEvent.i_type = 2;
			LogReportController.Instance.LogReport(onClickFunctionItemLogEvent);
		}

		// Token: 0x0603A851 RID: 239697 RVA: 0x00DED3FC File Offset: 0x00DEB5FC
		private void NoticeBtnClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Notice);
			KuroSdkController.Instance.OpenNotice(EOpenNoticeStage.Normal);
		}

		// Token: 0x0603A852 RID: 239698 RVA: 0x00DED410 File Offset: 0x00DEB610
		private void MailClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Mail);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Mail);
		}

		// Token: 0x0603A853 RID: 239699 RVA: 0x00DED428 File Offset: 0x00DEB628
		private void HelpClick()
		{
			WorldLevelController.Instance.OpenWorldLevelInfoView();
		}

		// Token: 0x0603A854 RID: 239700 RVA: 0x00DED434 File Offset: 0x00DEB634
		private void TimeClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Time);
			UiManager.Instance.OpenView(EUiViewName.TimeOfDaySecondView, null, null);
		}

		// Token: 0x0603A855 RID: 239701 RVA: 0x00DED44E File Offset: 0x00DEB64E
		private void SetUpClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Setting);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Menu);
		}

		// Token: 0x0603A856 RID: 239702 RVA: 0x00DED468 File Offset: 0x00DEB668
		private void CopyUidClick()
		{
			GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
			ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
		}

		// Token: 0x0603A857 RID: 239703 RVA: 0x00DED4A6 File Offset: 0x00DEB6A6
		private void PhotoBtnClick()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.Photograph);
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Photograph);
		}

		// Token: 0x0603A858 RID: 239704 RVA: 0x00DED4BE File Offset: 0x00DEB6BE
		private void HeadIconButtonClick()
		{
			if (FunctionModel.Instance.IsOpen(10060))
			{
				UiManager.Instance.OpenView(EUiViewName.PersonalRootView, PersonalModel.Instance.GetPersonalInfoData(), null);
			}
		}

		// Token: 0x0603A859 RID: 239705 RVA: 0x00DED4EB File Offset: 0x00DEB6EB
		private void MoreButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PersonalOptionView, null, null);
		}

		// Token: 0x0603A85A RID: 239706 RVA: 0x00DED4FE File Offset: 0x00DEB6FE
		private void SignButtonClick()
		{
			CommonInputViewController.Instance.OpenPersonalSignInputView();
		}

		// Token: 0x0603A85B RID: 239707 RVA: 0x00DED50A File Offset: 0x00DEB70A
		private void NameButtonClick()
		{
			CommonInputViewController.Instance.OpenSetRoleNameInputView();
		}

		// Token: 0x0603A85C RID: 239708 RVA: 0x00DED516 File Offset: 0x00DEB716
		private void OpenPlayerTitleEditView()
		{
			UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.PlayerTitle, null);
		}

		// Token: 0x0603A85D RID: 239709 RVA: 0x00DED530 File Offset: 0x00DEB730
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

		// Token: 0x0603A85E RID: 239710 RVA: 0x00DED578 File Offset: 0x00DEB778
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

		// Token: 0x0603A85F RID: 239711 RVA: 0x00DED5C8 File Offset: 0x00DEB7C8
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

		// Token: 0x0603A860 RID: 239712 RVA: 0x00DED626 File Offset: 0x00DEB826
		private void OnClickPreDownload()
		{
			this.ReportBottomButtonClick(EFunctionBottomButtonType.PreDownload);
			PreDownloadController.Instance.OnPreDownloadBtnClick(false);
		}

		// Token: 0x0603A861 RID: 239713 RVA: 0x00DED63C File Offset: 0x00DEB83C
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

		// Token: 0x0603A862 RID: 239714 RVA: 0x00DED86C File Offset: 0x00DEBA6C
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

		// Token: 0x0603A863 RID: 239715 RVA: 0x00DED8DD File Offset: 0x00DEBADD
		private void HideRedTipsBtn()
		{
			this.RedTipsRightBtn.SetUIActive(false);
			this.RedTipsLeftBtn.SetUIActive(false);
		}

		// Token: 0x0603A864 RID: 239716 RVA: 0x00DED8F8 File Offset: 0x00DEBAF8
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

		// Token: 0x0603A865 RID: 239717 RVA: 0x00DEDA30 File Offset: 0x00DEBC30
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

		// Token: 0x0603A866 RID: 239718 RVA: 0x00DEDB55 File Offset: 0x00DEBD55
		private void OnCurWorldLevelChange()
		{
			this.RefreshWorldLevel();
		}

		// Token: 0x0603A867 RID: 239719 RVA: 0x00DEDB5D File Offset: 0x00DEBD5D
		private void OnSignChange()
		{
			this.RefreshSign();
		}

		// Token: 0x0603A868 RID: 239720 RVA: 0x00DEDB68 File Offset: 0x00DEBD68
		private void OnNameChange()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			if (playerName != null)
			{
				base.GetText(0).SetText(playerName, true);
			}
		}

		// Token: 0x0603A869 RID: 239721 RVA: 0x00DEDB91 File Offset: 0x00DEBD91
		private void OnHeadIconChange(int headPhotoId)
		{
			this.RefreshHeadIcon();
		}

		// Token: 0x0603A86A RID: 239722 RVA: 0x00DEDB99 File Offset: 0x00DEBD99
		private void OnCardChange()
		{
			this.RefreshCard();
		}

		// Token: 0x0603A86B RID: 239723 RVA: 0x00DEDBA1 File Offset: 0x00DEBDA1
		private void OnBirthChange()
		{
			this.RefreshBirthDay();
		}

		// Token: 0x0603A86C RID: 239724 RVA: 0x00DEDBA9 File Offset: 0x00DEBDA9
		private void OnFunctionGridSelected(int index)
		{
			this.RefreshRedDot(index);
			this.TabLayout.SetToggleSelectByIndex(index);
		}

		// Token: 0x0603A86D RID: 239725 RVA: 0x00DEDBC0 File Offset: 0x00DEBDC0
		private void RefreshRedDot(int index)
		{
			this.RedTipsLeftBtn.SetUIActive(index > 0);
			this.RedTipsRightBtn.SetUIActive(index < this.NoCircleExhibitionView.GetDataLength() - 1);
			this.RedTipsLeft.SetUIActive(this.IsRedLeftBtnActive(index));
			this.RedTipsRight.SetUIActive(this.IsRedRightBtnActive(index));
		}

		// Token: 0x0603A86E RID: 239726 RVA: 0x00DEDC1C File Offset: 0x00DEBE1C
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

		// Token: 0x0603A86F RID: 239727 RVA: 0x00DEDC84 File Offset: 0x00DEBE84
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

		// Token: 0x0603A870 RID: 239728 RVA: 0x00DEDD34 File Offset: 0x00DEBF34
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

		// Token: 0x0603A871 RID: 239729 RVA: 0x00DEDDF0 File Offset: 0x00DEBFF0
		protected override void OnBeforeShow()
		{
			this.SetPlayerInfo();
			this.RefreshOtherButton();
			this.BindRedDot();
			this.RefreshOnlineButton();
			this.RefreshResDownLoadTopPanelState();
			GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("FunctionView");
		}

		// Token: 0x0603A872 RID: 239730 RVA: 0x00DEDE1F File Offset: 0x00DEC01F
		protected override void OnAfterShow()
		{
			this.PrintCalculateData();
			this.TryShowParallelPackageUpdateBoxView();
		}

		// Token: 0x0603A873 RID: 239731 RVA: 0x00DEDE2D File Offset: 0x00DEC02D
		protected override void OnAfterHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0603A874 RID: 239732 RVA: 0x00DEDE38 File Offset: 0x00DEC038
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

		// Token: 0x0603A875 RID: 239733 RVA: 0x00DEDF00 File Offset: 0x00DEC100
		private void BindRedDot()
		{
			this.BottomMailBtn.BindRedDot();
			this.BottomNoticeBtn.BindRedDot();
			this.BottomPhotoBtn.BindRedDot();
			this.BottomSettingBtn.BindRedDot();
			this.BottomPreDownloadBtn.BindRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.PersonalizedInfo, base.GetItem(34), null, 0);
		}

		// Token: 0x0603A876 RID: 239734 RVA: 0x00DEDF60 File Offset: 0x00DEC160
		private void UnBindRedDot()
		{
			this.BottomMailBtn.UnBindRedDot();
			this.BottomNoticeBtn.UnBindRedDot();
			this.BottomPhotoBtn.UnBindRedDot();
			this.BottomSettingBtn.UnBindRedDot();
			this.BottomPreDownloadBtn.UnBindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.PersonalizedInfo, base.GetItem(34), 0);
		}

		// Token: 0x0603A877 RID: 239735 RVA: 0x00DEDFBC File Offset: 0x00DEC1BC
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

		// Token: 0x0603A878 RID: 239736 RVA: 0x00DEDFF0 File Offset: 0x00DEC1F0
		private void RefreshPlayerName()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			base.GetText(0).SetText(playerName, true);
		}

		// Token: 0x0603A879 RID: 239737 RVA: 0x00DEE018 File Offset: 0x00DEC218
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

		// Token: 0x0603A87A RID: 239738 RVA: 0x00DEE124 File Offset: 0x00DEC324
		private void RefreshWorldLevel()
		{
			LguiUtil.Instance.SetLocalText(base.GetText(2), "WorldLevelNum", new <>z__ReadOnlySingleElementList<object>(WorldLevelModel.Instance.CurWorldLevel));
		}

		// Token: 0x0603A87B RID: 239739 RVA: 0x00DEE150 File Offset: 0x00DEC350
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

		// Token: 0x0603A87C RID: 239740 RVA: 0x00DEE1E4 File Offset: 0x00DEC3E4
		private void RefreshCard()
		{
			int curCardId = PersonalModel.Instance.GetCurCardId();
			BackgroundCard? config = ConfigBackgroundCardById.GetConfig(curCardId, true);
			if (config != null)
			{
				base.SetTextureByPath(config.Value.FunctionViewCardPath, base.GetTexture(23), null, null);
			}
		}

		// Token: 0x0603A87D RID: 239741 RVA: 0x00DEE234 File Offset: 0x00DEC434
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

		// Token: 0x0603A87E RID: 239742 RVA: 0x00DEE27C File Offset: 0x00DEC47C
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

		// Token: 0x0603A87F RID: 239743 RVA: 0x00DEE328 File Offset: 0x00DEC528
		private void SetPanelTabItemStretchRight(float offsetValue)
		{
			UUIItem item = base.GetItem(31);
			float stretchRight = item.GetStretchRight();
			item.SetStretchRight(stretchRight + offsetValue);
		}

		// Token: 0x0603A880 RID: 239744 RVA: 0x00DEE34C File Offset: 0x00DEC54C
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

		// Token: 0x0603A881 RID: 239745 RVA: 0x00DEE454 File Offset: 0x00DEC654
		[NullableContext(1)]
		private FunctionAttachItemGrid InitFunctionGrid(AActor actor, int index, int showNum)
		{
			FunctionAttachItemGrid functionAttachItemGrid = new FunctionAttachItemGrid(actor);
			functionAttachItemGrid.SetNeedAnim(index == 0);
			this.FunctionGridMap[index] = functionAttachItemGrid;
			return functionAttachItemGrid;
		}

		// Token: 0x0603A882 RID: 239746 RVA: 0x00DEE480 File Offset: 0x00DEC680
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

		// Token: 0x0603A883 RID: 239747 RVA: 0x00DEE4EC File Offset: 0x00DEC6EC
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

		// Token: 0x0603A884 RID: 239748 RVA: 0x00DEE5A8 File Offset: 0x00DEC7A8
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

		// Token: 0x0603A885 RID: 239749 RVA: 0x00DEE694 File Offset: 0x00DEC894
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

		// Token: 0x0603A886 RID: 239750 RVA: 0x00DEE79C File Offset: 0x00DEC99C
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

		// Token: 0x0603A887 RID: 239751 RVA: 0x00DEE87D File Offset: 0x00DECA7D
		private void TryShowParallelPackageUpdateBoxView()
		{
			ParallelPackageController.Instance.TryShowParallelPackageUpdateConfirmBox(ParallelPackageDownloadBoxShowReason.Auto);
		}

		// Token: 0x0603A888 RID: 239752 RVA: 0x00DEE88C File Offset: 0x00DECA8C
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

		// Token: 0x0603A889 RID: 239753 RVA: 0x00DEE978 File Offset: 0x00DECB78
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

		// Token: 0x0603A88A RID: 239754 RVA: 0x00DEEAC3 File Offset: 0x00DECCC3
		private void ResDownLoadStateRefresh(EVideoDownloadStatus state)
		{
			this.RefreshResDownLoadTopPanelState();
		}

		// Token: 0x0603A88B RID: 239755 RVA: 0x00DEEACC File Offset: 0x00DECCCC
		private void RefreshResDownLoadTopPanelState()
		{
			if (!Info.Instance.IsPcPlatform() && SubPackageDownLoadModel.Instance.NeedShowBattleViewButton())
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

		// Token: 0x0603A88C RID: 239756 RVA: 0x00DEEB38 File Offset: 0x00DECD38
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

		// Token: 0x0401E7A7 RID: 124839
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<int[], FunctionAttachItemGrid> NoCircleExhibitionView;

		// Token: 0x0401E7A8 RID: 124840
		private FunctionTabLayout TabLayout;

		// Token: 0x0401E7A9 RID: 124841
		private UUIItem RedTipsLeftBtn;

		// Token: 0x0401E7AA RID: 124842
		private UUIItem RedTipsRightBtn;

		// Token: 0x0401E7AB RID: 124843
		private UUIItem RedTipsLeft;

		// Token: 0x0401E7AC RID: 124844
		private UUIItem RedTipsRight;

		// Token: 0x0401E7AD RID: 124845
		private FunctionBottomButtonItem BottomMailBtn;

		// Token: 0x0401E7AE RID: 124846
		private FunctionBottomButtonItem BottomNoticeBtn;

		// Token: 0x0401E7AF RID: 124847
		private FunctionBottomButtonItem BottomPhotoBtn;

		// Token: 0x0401E7B0 RID: 124848
		private FunctionBottomButtonItem BottomSettingBtn;

		// Token: 0x0401E7B1 RID: 124849
		private PlayerTitleItem TitleItem;

		// Token: 0x0401E7B2 RID: 124850
		private PreDownloadButtonItemB BottomPreDownloadBtn;

		// Token: 0x0401E7B3 RID: 124851
		private FunctionResDownLoadItem BottomDownloadPanel;

		// Token: 0x0401E7B4 RID: 124852
		[Nullable(1)]
		private readonly Dictionary<int, FunctionAttachItemGrid> FunctionGridMap = new Dictionary<int, FunctionAttachItemGrid>();

		// Token: 0x0401E7B5 RID: 124853
		[Nullable(1)]
		private List<int[]> DataList = new List<int[]>();

		// Token: 0x0401E7B6 RID: 124854
		[Nullable(1)]
		private ICalculateData CalculateData;

		// Token: 0x0200BC94 RID: 48276
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04038E3E RID: 233022
			public const int PlayerName = 0;

			// Token: 0x04038E3F RID: 233023
			public const int PlayerId = 1;

			// Token: 0x04038E40 RID: 233024
			public const int WorldLevel = 2;

			// Token: 0x04038E41 RID: 233025
			public const int HelpBtn = 3;

			// Token: 0x04038E42 RID: 233026
			public const int PlayerLevel = 4;

			// Token: 0x04038E43 RID: 233027
			public const int PlayerExp = 5;

			// Token: 0x04038E44 RID: 233028
			public const int BackBtn = 6;

			// Token: 0x04038E45 RID: 233029
			public const int EndBtn = 7;

			// Token: 0x04038E46 RID: 233030
			public const int MailBtn = 8;

			// Token: 0x04038E47 RID: 233031
			public const int ExpProgressBar = 9;

			// Token: 0x04038E48 RID: 233032
			public const int FuncDraggable = 10;

			// Token: 0x04038E49 RID: 233033
			public const int PlayerTexture = 11;

			// Token: 0x04038E4A RID: 233034
			public const int TimeButton = 12;

			// Token: 0x04038E4B RID: 233035
			public const int SetUpButton = 13;

			// Token: 0x04038E4C RID: 233036
			public const int CopyUidButton = 14;

			// Token: 0x04038E4D RID: 233037
			public const int NoticeBtn = 15;

			// Token: 0x04038E4E RID: 233038
			public const int RedTipsRightBtn = 16;

			// Token: 0x04038E4F RID: 233039
			public const int RedTipsLeftBtn = 17;

			// Token: 0x04038E50 RID: 233040
			public const int RedTipsRight = 18;

			// Token: 0x04038E51 RID: 233041
			public const int RedTipsLeft = 19;

			// Token: 0x04038E52 RID: 233042
			public const int PhotoBtn = 20;

			// Token: 0x04038E53 RID: 233043
			public const int HeadIconButton = 21;

			// Token: 0x04038E54 RID: 233044
			public const int MoreButton = 22;

			// Token: 0x04038E55 RID: 233045
			public const int Card = 23;

			// Token: 0x04038E56 RID: 233046
			public const int SignButton = 24;

			// Token: 0x04038E57 RID: 233047
			public const int SignText = 25;

			// Token: 0x04038E58 RID: 233048
			public const int BirthText = 26;

			// Token: 0x04038E59 RID: 233049
			public const int NameButton = 27;

			// Token: 0x04038E5A RID: 233050
			public const int TabRoot = 28;

			// Token: 0x04038E5B RID: 233051
			public const int GridItem = 29;

			// Token: 0x04038E5C RID: 233052
			public const int GridInsideLayout = 30;

			// Token: 0x04038E5D RID: 233053
			public const int PanelTabItem = 31;

			// Token: 0x04038E5E RID: 233054
			public const int OnlineButton = 32;

			// Token: 0x04038E5F RID: 233055
			public const int NetStateSprite = 33;

			// Token: 0x04038E60 RID: 233056
			public const int PersonalRedDot = 34;

			// Token: 0x04038E61 RID: 233057
			public const int PersonalTipItem = 35;

			// Token: 0x04038E62 RID: 233058
			public const int CopyUidButtonSprite = 36;

			// Token: 0x04038E63 RID: 233059
			public const int MobilePreDownloadBtn = 37;

			// Token: 0x04038E64 RID: 233060
			public const int PlayerTitleItem = 38;

			// Token: 0x04038E65 RID: 233061
			public const int DownLoadPanel = 39;
		}
	}
}
