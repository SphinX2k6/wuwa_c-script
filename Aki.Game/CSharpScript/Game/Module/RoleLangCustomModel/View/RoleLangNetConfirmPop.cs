using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View
{
	// Token: 0x02004D7C RID: 19836
	public class RoleLangNetConfirmPop : UiTickViewBase
	{
		// Token: 0x06033466 RID: 210022 RVA: 0x00BF62D4 File Offset: 0x00BF44D4
		[NullableContext(1)]
		public RoleLangNetConfirmPop(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033467 RID: 210023 RVA: 0x00BF62F4 File Offset: 0x00BF44F4
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

		// Token: 0x06033468 RID: 210024 RVA: 0x00BF6574 File Offset: 0x00BF4774
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

		// Token: 0x06033469 RID: 210025 RVA: 0x00BF663B File Offset: 0x00BF483B
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

		// Token: 0x0603346A RID: 210026 RVA: 0x00BF6664 File Offset: 0x00BF4864
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

		// Token: 0x0603346B RID: 210027 RVA: 0x00BF66D0 File Offset: 0x00BF48D0
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

		// Token: 0x0603346C RID: 210028 RVA: 0x00BF6724 File Offset: 0x00BF4924
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

		// Token: 0x0603346D RID: 210029 RVA: 0x00BF682C File Offset: 0x00BF4A2C
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

		// Token: 0x0603346E RID: 210030 RVA: 0x00BF68FC File Offset: 0x00BF4AFC
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

		// Token: 0x0603346F RID: 210031 RVA: 0x00BF69C8 File Offset: 0x00BF4BC8
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

		// Token: 0x06033470 RID: 210032 RVA: 0x00BF6AC0 File Offset: 0x00BF4CC0
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

		// Token: 0x06033471 RID: 210033 RVA: 0x00BF6BE8 File Offset: 0x00BF4DE8
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

		// Token: 0x06033472 RID: 210034 RVA: 0x00BF6C94 File Offset: 0x00BF4E94
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

		// Token: 0x06033473 RID: 210035 RVA: 0x00BF6D20 File Offset: 0x00BF4F20
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

		// Token: 0x06033474 RID: 210036 RVA: 0x00BF6DAC File Offset: 0x00BF4FAC
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

		// Token: 0x06033475 RID: 210037 RVA: 0x00BF6E38 File Offset: 0x00BF5038
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

		// Token: 0x06033476 RID: 210038 RVA: 0x00BF6EC4 File Offset: 0x00BF50C4
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

		// Token: 0x06033477 RID: 210039 RVA: 0x00BF6F50 File Offset: 0x00BF5150
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

		// Token: 0x06033478 RID: 210040 RVA: 0x00BF6FE3 File Offset: 0x00BF51E3
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

		// Token: 0x06033479 RID: 210041 RVA: 0x00BF700A File Offset: 0x00BF520A
		private void OnClickedBtnVersionDel()
		{
			if (this.DownloadState == RoleLangNetConfirmPop.EDownloadState.Downloading)
			{
				this.OnClickedBtnVersionPause();
			}
			this.DeleteConfirmBox();
		}

		// Token: 0x0603347A RID: 210042 RVA: 0x00BF7021 File Offset: 0x00BF5221
		private void OnClickedBtnVersionPause()
		{
			RoleLangCustomModel.Instance.PauseDownloadingList();
			this.RefreshState(true);
		}

		// Token: 0x0603347B RID: 210043 RVA: 0x00BF7034 File Offset: 0x00BF5234
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

		// Token: 0x0603347C RID: 210044 RVA: 0x00BF7084 File Offset: 0x00BF5284
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

		// Token: 0x0603347D RID: 210045 RVA: 0x00BF70DA File Offset: 0x00BF52DA
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

		// Token: 0x0603347E RID: 210046 RVA: 0x00BF710C File Offset: 0x00BF530C
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

		// Token: 0x0401B366 RID: 111462
		[Nullable(2)]
		protected ButtonItem CancelBtn;

		// Token: 0x0401B367 RID: 111463
		[Nullable(2)]
		protected ButtonItem ConfirmBtn;

		// Token: 0x0401B368 RID: 111464
		protected bool FromSettingAll;

		// Token: 0x0401B369 RID: 111465
		[Nullable(1)]
		protected List<IRoleLangCustomLangPackageInfo> NoResourceInfo = new List<IRoleLangCustomLangPackageInfo>();

		// Token: 0x0401B36A RID: 111466
		protected long TotalSize;

		// Token: 0x0401B36B RID: 111467
		[Nullable(1)]
		protected string TotalSizeTxt = "";

		// Token: 0x0401B36C RID: 111468
		protected bool NeedTick;

		// Token: 0x0401B36D RID: 111469
		protected RoleLangNetConfirmPop.EDownloadState DownloadState;

		// Token: 0x0401B36E RID: 111470
		protected bool HaveStarted;

		// Token: 0x0200AEF0 RID: 44784
		private enum EDefine
		{
			// Token: 0x04035215 RID: 217621
			SpriteInfoBg,
			// Token: 0x04035216 RID: 217622
			TxtDesc,
			// Token: 0x04035217 RID: 217623
			TxtValue,
			// Token: 0x04035218 RID: 217624
			BtnVersionDel,
			// Token: 0x04035219 RID: 217625
			BtnVersionPause,
			// Token: 0x0403521A RID: 217626
			BtnVersionStar,
			// Token: 0x0403521B RID: 217627
			BtnVersionDownload,
			// Token: 0x0403521C RID: 217628
			PanelDone,
			// Token: 0x0403521D RID: 217629
			PanelActiveB,
			// Token: 0x0403521E RID: 217630
			TxtActivated,
			// Token: 0x0403521F RID: 217631
			BtnCancel,
			// Token: 0x04035220 RID: 217632
			BtnConfirm,
			// Token: 0x04035221 RID: 217633
			PanelAssetInfo
		}

		// Token: 0x0200AEF1 RID: 44785
		protected enum EDownloadState
		{
			// Token: 0x04035223 RID: 217635
			None,
			// Token: 0x04035224 RID: 217636
			Downloading,
			// Token: 0x04035225 RID: 217637
			Pause,
			// Token: 0x04035226 RID: 217638
			Done,
			// Token: 0x04035227 RID: 217639
			NoSpace
		}
	}
}
