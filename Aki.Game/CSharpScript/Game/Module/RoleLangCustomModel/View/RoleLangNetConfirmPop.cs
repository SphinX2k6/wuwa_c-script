using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View
{
	// Token: 0x02003D45 RID: 15685
	public class RoleLangNetConfirmPop : UiTickViewBase
	{
		// Token: 0x060282D3 RID: 164563 RVA: 0x00B3F8AD File Offset: 0x00B3DAAD
		[NullableContext(1)]
		public RoleLangNetConfirmPop(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060282D4 RID: 164564 RVA: 0x00B3F8CC File Offset: 0x00B3DACC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedBtnVersionDel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBtnVersionPause));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedBtnVersionStar));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedBtnVersionDownload));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060282D5 RID: 164565 RVA: 0x00B3FB4C File Offset: 0x00B3DD4C
		protected override void OnStart()
		{
			this.FromSettingAll = (bool)this.OpenParam;
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClickedClose));
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PopItem.SetMaskResponsibleState(false);
			}
			this.CancelBtn = new ButtonItem(base.GetItem(10));
			this.CancelBtn.SetFunction(new Action<int>(this.OnClickedBtnCancel));
			this.CancelBtn.SetShowText("VoiceDIY_Button_KeepCurrent");
			this.ConfirmBtn = new ButtonItem(base.GetItem(11));
			this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickedBtnConfirm));
			this.InitData();
			this.InitBtnState();
		}

		// Token: 0x060282D6 RID: 164566 RVA: 0x00B3FC13 File Offset: 0x00B3DE13
		protected override void OnTick(float deltaTime)
		{
			if (!this.NeedTick)
			{
				return;
			}
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.NoSpace)
			{
				this.RefreshState(true);
				return;
			}
			this.RefreshState(true);
			this.RefreshDownloadProgress();
		}

		// Token: 0x060282D7 RID: 164567 RVA: 0x00B3FC3C File Offset: 0x00B3DE3C
		private void InitData()
		{
			this.NoResourceInfo = RoleLangCustomModel.Instance.CheckNoResourceInfo();
			if (this.NoResourceInfo.Count > 0)
			{
				UUIItem item = base.GetItem(12);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.GetPackageSize();
				return;
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x060282D8 RID: 164568 RVA: 0x00B3FCA8 File Offset: 0x00B3DEA8
		private void InitBtnState()
		{
			bool flag = this.NoResourceInfo.Count > 0;
			bool flag2 = this.CheckSpaceEnough();
			if (!flag)
			{
				this.ConfirmBtn.SetShowText("VoiceDIY_Button_ApplySyncPlan");
				this.ConfirmBtn.SetEnableClick(true);
				return;
			}
			if (!flag2)
			{
				this.RefreshState(false);
			}
			this.RefreshButtonState(true);
		}

		// Token: 0x060282D9 RID: 164569 RVA: 0x00B3FCFC File Offset: 0x00B3DEFC
		private void RefreshButtonState(bool isInit = false)
		{
			bool flag = this.DownloadState == RoleLangNetConfirmPop.EDownloadState.None;
			bool uiactive = this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Downloading;
			bool flag2 = this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Pause;
			bool uiactive2 = this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Done;
			bool flag3 = this.DownloadState == RoleLangNetConfirmPop.EDownloadState.NoSpace;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(uiactive2);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(flag3);
			}
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!flag);
			}
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(uiactive);
			}
			UUIButtonComponent button3 = base.GetButton(5);
			if (button3 != null)
			{
				button3.RootUIComp.Get().SetUIActive(flag3 ? (!isInit) : flag2);
			}
			UUIButtonComponent button4 = base.GetButton(6);
			if (button4 != null)
			{
				button4.RootUIComp.Get().SetUIActive(flag3 ? isInit : flag);
			}
			this.RefreshConfirm();
		}

		// Token: 0x060282DA RID: 164570 RVA: 0x00B3FE04 File Offset: 0x00B3E004
		private void RefreshConfirm()
		{
			switch (this.DownloadState)
			{
			case RoleLangNetConfirmPop.EDownloadState.None:
				this.ConfirmBtn.SetEnableClick(true);
				this.ConfirmBtn.SetShowText("VoiceDIY_Button_DownloadResources");
				return;
			case RoleLangNetConfirmPop.EDownloadState.Downloading:
				this.ConfirmBtn.SetEnableClick(false);
				this.ConfirmBtn.SetShowText("VoiceDIY_Button_Downloading");
				return;
			case RoleLangNetConfirmPop.EDownloadState.Pause:
				this.ConfirmBtn.SetEnableClick(false);
				this.ConfirmBtn.SetShowText("VoiceDIY_Button_Downloading");
				return;
			case RoleLangNetConfirmPop.EDownloadState.Done:
				this.ConfirmBtn.SetEnableClick(true);
				this.ConfirmBtn.SetShowText("VoiceDIY_Button_ApplySyncPlan");
				return;
			case RoleLangNetConfirmPop.EDownloadState.NoSpace:
			{
				this.ConfirmBtn.SetEnableClick(true);
				string showText = this.HaveStarted ? "VoiceDIY_Button_Downloading" : "VoiceDIY_Button_DownloadResources";
				this.ConfirmBtn.SetShowText(showText);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060282DB RID: 164571 RVA: 0x00B3FED4 File Offset: 0x00B3E0D4
		private void GetPackageSize()
		{
			long num = 0L;
			RoleLangCustomUpdateManager updateManager = RoleLangCustomModel.Instance.GetUpdateManager();
			foreach (IRoleLangCustomLangPackageInfo info in this.NoResourceInfo)
			{
				ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(updateManager.GetPackageName(info));
				if (roleVoiceInfo != null)
				{
					long item = roleVoiceInfo.CalculateSavedSizeAndTotalSize().Item2;
					num += item;
				}
			}
			this.TotalSize = num;
			this.TotalSizeTxt = ((float)this.TotalSize / 1048576f).ToString("F2");
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(this.TotalSizeTxt + "MB", true);
		}

		// Token: 0x060282DC RID: 164572 RVA: 0x00B3FFA0 File Offset: 0x00B3E1A0
		private void RefreshDownloadProgress()
		{
			long num = 0L;
			RoleLangCustomUpdateManager updateManager = RoleLangCustomModel.Instance.GetUpdateManager();
			foreach (IRoleLangCustomLangPackageInfo info in this.NoResourceInfo)
			{
				ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(updateManager.GetPackageName(info));
				if (roleVoiceInfo != null)
				{
					long item = roleVoiceInfo.CalculateSavedSizeAndTotalSize().Item1;
					num += item;
				}
			}
			string str = ((float)num / 1048576f).ToString("F2");
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Downloading || this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Pause)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(str + "MB/" + this.TotalSizeTxt + "MB", true);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(this.TotalSizeTxt + "MB", true);
				return;
			}
		}

		// Token: 0x060282DD RID: 164573 RVA: 0x00B40098 File Offset: 0x00B3E298
		private void RefreshState(bool needButtonRefresh = true)
		{
			if (this.NoResourceInfo.Count == 0)
			{
				return;
			}
			RoleLangNetConfirmPop.EDownloadState downloadState = this.DownloadState;
			RoleLangCustomUpdateManager updateManager = RoleLangCustomModel.Instance.GetUpdateManager();
			if (!this.CheckSpaceEnough())
			{
				this.DownloadState = RoleLangNetConfirmPop.EDownloadState.NoSpace;
			}
			else if (downloadState == RoleLangNetConfirmPop.EDownloadState.NoSpace)
			{
				this.DownloadState = (this.HaveStarted ? RoleLangNetConfirmPop.EDownloadState.Pause : RoleLangNetConfirmPop.EDownloadState.None);
			}
			else
			{
				bool flag = true;
				foreach (IRoleLangCustomLangPackageInfo info in this.NoResourceInfo)
				{
					if (updateManager.GetDownloadStatus(info) != ELanguageDownloadStatus.Done)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					this.DownloadState = RoleLangNetConfirmPop.EDownloadState.Done;
				}
				else if (RoleLangCustomModel.Instance.IsListDownloading())
				{
					this.DownloadState = RoleLangNetConfirmPop.EDownloadState.Downloading;
				}
				else if (this.HaveStarted)
				{
					this.DownloadState = RoleLangNetConfirmPop.EDownloadState.Pause;
				}
			}
			if (this.DownloadState != downloadState)
			{
				if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.NoSpace)
				{
					if (RoleLangCustomModel.Instance.IsListDownloading())
					{
						RoleLangCustomModel.Instance.PauseDownloadingList();
					}
					this.NeedTick = true;
				}
				else
				{
					this.NeedTick = (this.DownloadState != RoleLangNetConfirmPop.EDownloadState.Done);
				}
				if (needButtonRefresh)
				{
					this.RefreshButtonState(false);
				}
			}
		}

		// Token: 0x060282DE RID: 164574 RVA: 0x00B401C0 File Offset: 0x00B3E3C0
		private bool CheckSpaceEnough()
		{
			long num = 0L;
			RoleLangCustomUpdateManager updateManager = RoleLangCustomModel.Instance.GetUpdateManager();
			foreach (IRoleLangCustomLangPackageInfo info in this.NoResourceInfo)
			{
				ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(updateManager.GetPackageName(info));
				if (roleVoiceInfo != null)
				{
					ValueTuple<long, long> valueTuple = roleVoiceInfo.CalculateSavedSizeAndTotalSize();
					long item = valueTuple.Item1;
					long item2 = valueTuple.Item2;
					num += item2 - item;
				}
			}
			string checkPath = UKuroLauncherLibrary.GameSavedDir();
			long num2 = 0L;
			UKuroLauncherLibrary.GetTotalAndFreeSpace(checkPath, ref num2);
			return num2 >= num + 10485760L;
		}

		// Token: 0x060282DF RID: 164575 RVA: 0x00B4026C File Offset: 0x00B3E46C
		protected void BeforeCloseConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_ExitInterface");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Cancel");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.CloseMe(null);
				if (this.FromSettingAll)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.RoleLangCustomView);
					UiManager.Instance.CloseViewById(viewByName.GetViewId(), null);
				}
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E0 RID: 164576 RVA: 0x00B402F8 File Offset: 0x00B3E4F8
		protected void FinishedCloseConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_ExitInterface");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Cancel");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.CloseMe(null);
				if (this.FromSettingAll)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.RoleLangCustomView);
					UiManager.Instance.CloseViewById(viewByName.GetViewId(), null);
				}
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E1 RID: 164577 RVA: 0x00B40384 File Offset: 0x00B3E584
		protected void DownloadingConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_ExitWhileDownload");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Cancel");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (this.FromSettingAll)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.RoleLangCustomView);
					UiManager.Instance.CloseViewById(viewByName.GetViewId(), null);
				}
				RoleLangCustomModel.Instance.DeletePackageList(this.NoResourceInfo);
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E2 RID: 164578 RVA: 0x00B40410 File Offset: 0x00B3E610
		protected void DeleteConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_DeleteResources");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Cancel");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				RoleLangCustomModel.Instance.DeletePackageList(this.NoResourceInfo);
				this.HaveStarted = false;
				this.NeedTick = false;
				if (this.CheckSpaceEnough())
				{
					this.DownloadState = RoleLangNetConfirmPop.EDownloadState.None;
					this.RefreshButtonState(false);
				}
				else
				{
					this.RefreshState(true);
				}
				this.RefreshDownloadProgress();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E3 RID: 164579 RVA: 0x00B4049C File Offset: 0x00B3E69C
		protected void AfterDownloadKeepLocalConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_KeepCurrentWhileDownloadCompleted");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Cancel");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				RoleLangCustomModel.Instance.OnClickedConfirmClose();
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E4 RID: 164580 RVA: 0x00B40528 File Offset: 0x00B3E728
		protected void ApplyLocalWhileDownloadingConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleLangCustomConfirm);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Tips_KeepCurrentWhileDownload");
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				configTextByKey
			});
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_ContinueDownloading");
			string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("VoiceDIY_Button_Confirm");
			confirmBoxDataNew.SetBtnText(0, configTextByKey2);
			confirmBoxDataNew.SetBtnText(1, configTextByKey3);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				RoleLangCustomModel.Instance.DeletePackageList(this.NoResourceInfo);
				RoleLangCustomModel.Instance.OnClickedConfirmClose();
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060282E5 RID: 164581 RVA: 0x00B405BB File Offset: 0x00B3E7BB
		private void OnClickedClose()
		{
			if (!this.HaveStarted)
			{
				this.BeforeCloseConfirmBox();
				return;
			}
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Done)
			{
				this.FinishedCloseConfirmBox();
				return;
			}
			this.DownloadingConfirmBox();
		}

		// Token: 0x060282E6 RID: 164582 RVA: 0x00B405E2 File Offset: 0x00B3E7E2
		private void OnClickedBtnVersionDel()
		{
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Downloading)
			{
				this.OnClickedBtnVersionPause();
			}
			this.DeleteConfirmBox();
		}

		// Token: 0x060282E7 RID: 164583 RVA: 0x00B405F9 File Offset: 0x00B3E7F9
		private void OnClickedBtnVersionPause()
		{
			RoleLangCustomModel.Instance.PauseDownloadingList();
			this.RefreshState(true);
		}

		// Token: 0x060282E8 RID: 164584 RVA: 0x00B4060C File Offset: 0x00B3E80C
		private void OnClickedBtnVersionStar()
		{
			if (!this.CheckSpaceEnough())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_OutOfMemory", Array.Empty<object>());
				return;
			}
			RoleLangCustomModel.Instance.StartDownloadingList(this.NoResourceInfo);
			this.DownloadState = RoleLangNetConfirmPop.EDownloadState.Downloading;
			this.NeedTick = true;
			this.RefreshButtonState(false);
		}

		// Token: 0x060282E9 RID: 164585 RVA: 0x00B4065C File Offset: 0x00B3E85C
		private void OnClickedBtnVersionDownload()
		{
			if (!this.CheckSpaceEnough())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_OutOfMemory", Array.Empty<object>());
				return;
			}
			RoleLangCustomModel.Instance.StartDownloadingList(this.NoResourceInfo);
			this.DownloadState = RoleLangNetConfirmPop.EDownloadState.Downloading;
			this.NeedTick = true;
			this.HaveStarted = true;
			this.RefreshButtonState(false);
		}

		// Token: 0x060282EA RID: 164586 RVA: 0x00B406B2 File Offset: 0x00B3E8B2
		private void OnClickedBtnCancel(int data)
		{
			if (!this.HaveStarted)
			{
				RoleLangCustomModel.Instance.OnClickedConfirmClose();
				base.CloseMe(null);
				return;
			}
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Done)
			{
				this.AfterDownloadKeepLocalConfirmBox();
				return;
			}
			this.ApplyLocalWhileDownloadingConfirmBox();
		}

		// Token: 0x060282EB RID: 164587 RVA: 0x00B406E4 File Offset: 0x00B3E8E4
		private void OnClickedBtnConfirm(int data)
		{
			if (this.NoResourceInfo.Count == 0)
			{
				RoleLangCustomModel.Instance.OnClickedConfirmConfirm();
				base.CloseMe(null);
				return;
			}
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Done)
			{
				RoleLangCustomModel.Instance.OnClickedConfirmConfirm();
				base.CloseMe(null);
				return;
			}
			if (!this.CheckSpaceEnough())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_OutOfMemory", Array.Empty<object>());
				return;
			}
			this.OnClickedBtnVersionDownload();
		}

		// Token: 0x04015D39 RID: 89401
		[Nullable(2)]
		protected ButtonItem CancelBtn;

		// Token: 0x04015D3A RID: 89402
		[Nullable(2)]
		protected ButtonItem ConfirmBtn;

		// Token: 0x04015D3B RID: 89403
		protected bool FromSettingAll;

		// Token: 0x04015D3C RID: 89404
		[Nullable(1)]
		protected List<IRoleLangCustomLangPackageInfo> NoResourceInfo = new List<IRoleLangCustomLangPackageInfo>();

		// Token: 0x04015D3D RID: 89405
		protected long TotalSize;

		// Token: 0x04015D3E RID: 89406
		[Nullable(1)]
		protected string TotalSizeTxt = "";

		// Token: 0x04015D3F RID: 89407
		protected bool NeedTick;

		// Token: 0x04015D40 RID: 89408
		protected RoleLangNetConfirmPop.EDownloadState DownloadState;

		// Token: 0x04015D41 RID: 89409
		protected bool HaveStarted;

		// Token: 0x02009924 RID: 39204
		private enum EDefine
		{
			// Token: 0x0402FC49 RID: 195657
			SpriteInfoBg,
			// Token: 0x0402FC4A RID: 195658
			TxtDesc,
			// Token: 0x0402FC4B RID: 195659
			TxtValue,
			// Token: 0x0402FC4C RID: 195660
			BtnVersionDel,
			// Token: 0x0402FC4D RID: 195661
			BtnVersionPause,
			// Token: 0x0402FC4E RID: 195662
			BtnVersionStar,
			// Token: 0x0402FC4F RID: 195663
			BtnVersionDownload,
			// Token: 0x0402FC50 RID: 195664
			PanelDone,
			// Token: 0x0402FC51 RID: 195665
			PanelActiveB,
			// Token: 0x0402FC52 RID: 195666
			TxtActivated,
			// Token: 0x0402FC53 RID: 195667
			BtnCancel,
			// Token: 0x0402FC54 RID: 195668
			BtnConfirm,
			// Token: 0x0402FC55 RID: 195669
			PanelAssetInfo
		}

		// Token: 0x02009925 RID: 39205
		protected enum EDownloadState
		{
			// Token: 0x0402FC57 RID: 195671
			None,
			// Token: 0x0402FC58 RID: 195672
			Downloading,
			// Token: 0x0402FC59 RID: 195673
			Pause,
			// Token: 0x0402FC5A RID: 195674
			Done,
			// Token: 0x0402FC5B RID: 195675
			NoSpace
		}
	}
}
