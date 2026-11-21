using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.InputDevice;
using CSharpScript.Launcher.PlayerInput;
using CSharpScript.Launcher.Ui;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000031 RID: 49
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixDownSubPackageDownLoadMobileClearPopView : LaunchComponentsAction
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00009984 File Offset: 0x00007B84
		public UniTask OnInitTipsView()
		{
			HotFixDownSubPackageDownLoadMobileClearPopView.<OnInitTipsView>d__13 <OnInitTipsView>d__;
			<OnInitTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitTipsView>d__.<>4__this = this;
			<OnInitTipsView>d__.<>1__state = -1;
			<OnInitTipsView>d__.<>t__builder.Start<HotFixDownSubPackageDownLoadMobileClearPopView.<OnInitTipsView>d__13>(ref <OnInitTipsView>d__);
			return <OnInitTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000099C8 File Offset: 0x00007BC8
		protected override void OnStart()
		{
			base.AttachElement<HotFixBtnUiItem>(0).BindClickCallback(new Action(this.OnClickConfirmBtn));
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				button.OnClickCallBack.Bind(delegate()
				{
					LauncherLog.Instance.Info("HotFixDownSubPackageDownLoadMobileClearPopView CancelBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetActive(false);
					if (this.OnCloseCallBack != null)
					{
						this.OnCloseCallBack();
					}
					this.OnCloseCallBack = null;
				});
			}
			base.GetExtendToggle(1).RootUIComp.Get().SetUIActive(false);
			base.GetExtendToggle(1).OnStateChange.Add(delegate(EToggleState state)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "HotFixDownSubPackageDownLoadMobileClearPopView AutoClearToggle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state:", state);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				HotFixManager.HandleAutoClear = (state == EToggleState.ETT_Checked);
			});
			UUILayoutBase layout = base.GetLayout(2);
			AUIBaseActor gridActor = base.GetItem(3).GetOwner() as AUIBaseActor;
			this.HotFixPackageLayout = new HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData>(layout, () => new SubPackageDownLoadMobileClearItem
			{
				OnClickToggleCallBack = new Action<int?, bool, EToggleState, string>(this.OnSelectSubItem),
				OnClickHelpBtnCallBack = new Action<int, UUIItem>(this.OnClickHelpBtn)
			}, gridActor);
			HotFixManager.SetLocalText(base.GetText(6), "HotFixSubPackageClearTipsTitle", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(7), "HotFixSubPackageClearTipsTitle_AutoClear", Array.Empty<string>());
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009ABC File Offset: 0x00007CBC
		protected override void OnHide()
		{
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.UnRegisterInputAction("手柄右边下键", new TInputAction(this.OnGamePadClick));
			InputDevice.Instance.UnRegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.OnInputChange));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009B68 File Offset: 0x00007D68
		protected override void OnShow()
		{
			this.RefreshView();
			this.RefreshButton();
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆上", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左摇杆下", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边上键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄左边下键", new TInputAction(this.InputAction));
			HotPatchInputManager.Instance.RegisterInputAction("手柄右边下键", new TInputAction(this.OnGamePadClick));
			InputDevice.Instance.RegisterInputChangeDelegate(new Action<EInputControllerType, EInputControllerType>(this.OnInputChange));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009C20 File Offset: 0x00007E20
		private void OnClickConfirmBtn()
		{
			LauncherLog.Instance.Info("HotFixDownSubPackageDownLoadMobileClearPopView ConfirmBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.CurrentSelectInfoIdSet.Count > 0)
			{
				if (this.ShowConfirmBox != null)
				{
					this.ShowConfirmBox(delegate
					{
						HotFixManager.ClearSubPackage(new List<int>(this.CurrentSelectInfoIdSet), this.HaveSelectVideo);
						ResourceDiffUpdaterManager.Instance.UpdateDecision();
						if (this.SelectVoiceCodeSet.Count > 0)
						{
							foreach (string audioCode2 in this.SelectVoiceCodeSet)
							{
								ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(audioCode2);
							}
						}
						if (this.OnCloseCallBack != null)
						{
							this.OnCloseCallBack();
						}
					});
				}
			}
			else
			{
				if (this.HaveSelectVideo)
				{
					HotFixManager.ClearSubPackage(new List<int>(), this.HaveSelectVideo);
				}
				ResourceDiffUpdaterManager.Instance.UpdateDecision();
				if (this.SelectVoiceCodeSet.Count > 0)
				{
					foreach (string audioCode in this.SelectVoiceCodeSet)
					{
						ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(audioCode);
					}
				}
				if (this.OnCloseCallBack != null)
				{
					this.OnCloseCallBack();
				}
			}
			base.SetActive(false);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009D14 File Offset: 0x00007F14
		private List<ISubPackageDownLoadMobileClearData> GetScrollViewDataList()
		{
			this.AllCanClearSpace = 0L;
			this.AllCanSelectItemCount = 0;
			this.SelectIndex = 0;
			this.CurrentSelectInfoIdSet.Clear();
			this.HaveSelectVideo = false;
			this.SelectVoiceCodeSet.Clear();
			List<ISubPackageDownLoadMobileClearData> list = new List<ISubPackageDownLoadMobileClearData>();
			ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData = new SubPackageDownLoadMobileClearData
			{
				TitleId = 3
			};
			subPackageDownLoadMobileClearData.HaveVideoCanClear = new bool?(this.GetPlotData());
			list.Add(subPackageDownLoadMobileClearData);
			this.AllCanSelectItemCount++;
			this.PlotAndSceneSplitIndex = this.AllCanSelectItemCount - 1;
			ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData2 = new SubPackageDownLoadMobileClearData
			{
				TitleId = 2
			};
			subPackageDownLoadMobileClearData2.SceneIdList = this.GetSceneData();
			list.Add(subPackageDownLoadMobileClearData2);
			this.AllCanSelectItemCount++;
			this.SceneAndVoiceSplitIndex = this.AllCanSelectItemCount - 1;
			ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData3 = new SubPackageDownLoadMobileClearData
			{
				TitleId = 5
			};
			subPackageDownLoadMobileClearData3.VoiceLanguageCodeList = this.GetVoiceData();
			list.Add(subPackageDownLoadMobileClearData3);
			this.AllCanSelectItemCount++;
			return list;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009E04 File Offset: 0x00008004
		private List<int> GetSceneData()
		{
			List<int> list = new List<int>();
			foreach (int num in HotFixManager.GetCanCleanSceneIdList())
			{
				long subPackageSpace = HotFixManager.GetSubPackageSpace(num);
				if (subPackageSpace != 0L)
				{
					list.Add(num);
					this.CurrentSelectInfoIdSet.Add(num);
					this.AllCanSelectItemCount++;
					this.AllCanClearSpace += subPackageSpace;
				}
			}
			if (list.Count <= 0)
			{
				list.Add(-1);
			}
			return list;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009EA0 File Offset: 0x000080A0
		private bool GetPlotData()
		{
			long canCleanVideoSpace = HotFixManager.GetCanCleanVideoSpace();
			this.HaveSelectVideo = (canCleanVideoSpace > 0L);
			this.AllCanClearSpace += canCleanVideoSpace;
			if (canCleanVideoSpace > 0L)
			{
				this.AllCanSelectItemCount++;
			}
			return canCleanVideoSpace > 0L;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009EE4 File Offset: 0x000080E4
		private List<string> GetVoiceData()
		{
			List<string> list = new List<string>();
			string packageAudioLanguage = LauncherLanguageLib.Instance.GetPackageAudioLanguage();
			IEnumerable<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
			HashSet<string> hashSet = new HashSet<string>();
			foreach (LaunchLangDefine launchLangDefine in allLanguageDefines)
			{
				string audioCode = launchLangDefine.AudioCode;
				if (!hashSet.Contains(audioCode))
				{
					hashSet.Add(audioCode);
					if (!(audioCode == packageAudioLanguage))
					{
						LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCode);
						if (updater != null && updater.Status == ELanguageDownloadStatus.Done && ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode) > 0L)
						{
							list.Add(audioCode);
							this.SelectVoiceCodeSet.Add(audioCode);
							this.AllCanSelectItemCount++;
							this.AllCanClearSpace += updater.TotalDiskSize;
						}
					}
				}
			}
			if (list.Count <= 0)
			{
				list.Add("");
			}
			return list;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009FEC File Offset: 0x000081EC
		private void RefreshView()
		{
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout = this.HotFixPackageLayout;
			if (hotFixPackageLayout != null)
			{
				hotFixPackageLayout.RefreshByData(this.GetScrollViewDataList());
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout2 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem = ((hotFixPackageLayout2 != null) ? hotFixPackageLayout2.GetLayoutItemByIndex(0) : null) as SubPackageDownLoadMobileClearItem;
			if (InputDevice.Instance.IsInGamepad())
			{
				if (subPackageDownLoadMobileClearItem != null)
				{
					subPackageDownLoadMobileClearItem.SelectItem(0);
				}
			}
			else if (subPackageDownLoadMobileClearItem != null)
			{
				subPackageDownLoadMobileClearItem.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout3 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem2 = ((hotFixPackageLayout3 != null) ? hotFixPackageLayout3.GetLayoutItemByIndex(1) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem2 != null)
			{
				subPackageDownLoadMobileClearItem2.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout4 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem3 = ((hotFixPackageLayout4 != null) ? hotFixPackageLayout4.GetLayoutItemByIndex(2) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem3 == null)
			{
				return;
			}
			subPackageDownLoadMobileClearItem3.UnSelectItem();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000A090 File Offset: 0x00008290
		[NullableContext(2)]
		private void OnSelectSubItem(int? sceneId, bool isVideo, EToggleState state, string voiceCode = null)
		{
			if (state == EToggleState.ETT_Checked)
			{
				if (sceneId != null)
				{
					this.CurrentSelectInfoIdSet.Add(sceneId.Value);
				}
				else if (isVideo)
				{
					this.HaveSelectVideo = true;
				}
				else if (voiceCode != null)
				{
					this.SelectVoiceCodeSet.Add(voiceCode);
				}
			}
			else if (sceneId != null)
			{
				this.CurrentSelectInfoIdSet.Remove(sceneId.Value);
			}
			else if (isVideo)
			{
				this.HaveSelectVideo = false;
			}
			else if (voiceCode != null)
			{
				this.SelectVoiceCodeSet.Remove(voiceCode);
			}
			this.RefreshButton();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000A124 File Offset: 0x00008324
		private void RefreshButton()
		{
			base.GetButton(0).SetSelfInteractive(this.CurrentSelectInfoIdSet.Count > 0 || this.HaveSelectVideo || this.SelectVoiceCodeSet.Count > 0);
			long num = this.HaveSelectVideo ? HotFixManager.GetCanCleanVideoSpace() : 0L;
			foreach (int packId in this.CurrentSelectInfoIdSet)
			{
				num += HotFixManager.GetSubPackageSpace(packId);
			}
			foreach (string audioCode in this.SelectVoiceCodeSet)
			{
				long localSizeByAudioCode = ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode);
				num += localSizeByAudioCode;
			}
			HotFixManager.SetLocalText(base.GetText(5), "HotFixSubPackageClearButton", new string[]
			{
				HotFixManager.ByteConverter(num),
				HotFixManager.ByteConverter(this.AllCanClearSpace)
			});
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000A240 File Offset: 0x00008440
		private void OnClickHelpBtn(int type, UUIItem item)
		{
			HotFixSubPackageDownLoadVersionTipsView versionTipsView = this.VersionTipsView;
			bool flag;
			if (versionTipsView == null)
			{
				flag = false;
			}
			else
			{
				UUIItem rootItem = versionTipsView.GetRootItem();
				flag = ((rootItem != null) ? new bool?(rootItem.IsUIActiveSelf()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			HotFixSubPackageDownLoadVersionTipsView versionTipsView2 = this.VersionTipsView;
			if (versionTipsView2 != null)
			{
				FVectorDouble fvectorDouble = item.D_K2_GetComponentLocation();
				versionTipsView2.RefreshItemByClearType(type, fvectorDouble);
			}
			HotFixSubPackageDownLoadVersionTipsView versionTipsView3 = this.VersionTipsView;
			if (versionTipsView3 == null)
			{
				return;
			}
			versionTipsView3.SetActive(true);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A2B4 File Offset: 0x000084B4
		private void InputAction(bool bPress, string actionName)
		{
			if (!bPress)
			{
				return;
			}
			if ("手柄左边上键" == actionName || "手柄左摇杆上" == actionName)
			{
				this.FocusPrev();
			}
			if ("手柄左边下键" == actionName || "手柄左摇杆下" == actionName)
			{
				this.FocusNext();
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000A305 File Offset: 0x00008505
		private void FocusPrev()
		{
			this.SelectCanSelectIndex(Math.Max(0, this.SelectIndex - 1));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A31B File Offset: 0x0000851B
		private void FocusNext()
		{
			this.SelectCanSelectIndex(Math.Min(this.AllCanSelectItemCount - 1, this.SelectIndex + 1));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A338 File Offset: 0x00008538
		private int GetLayoutIndex(int selectIndex)
		{
			if (selectIndex <= this.PlotAndSceneSplitIndex)
			{
				return 0;
			}
			if (selectIndex <= this.SceneAndVoiceSplitIndex)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A351 File Offset: 0x00008551
		private int GetSubIndex(int selectIndex)
		{
			if (selectIndex <= this.PlotAndSceneSplitIndex)
			{
				return selectIndex;
			}
			if (selectIndex <= this.SceneAndVoiceSplitIndex)
			{
				return selectIndex - (this.PlotAndSceneSplitIndex + 1);
			}
			return selectIndex - (this.SceneAndVoiceSplitIndex + 1);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A37C File Offset: 0x0000857C
		private unsafe void SelectCanSelectIndex(int index)
		{
			if (this.SelectIndex == index)
			{
				return;
			}
			if (this.SelectIndex >= 0)
			{
				HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout = this.HotFixPackageLayout;
				SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem = ((hotFixPackageLayout != null) ? hotFixPackageLayout.GetLayoutItemByIndex(this.GetLayoutIndex(this.SelectIndex)) : null) as SubPackageDownLoadMobileClearItem;
				if (subPackageDownLoadMobileClearItem != null)
				{
					subPackageDownLoadMobileClearItem.UnSelectItem();
				}
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "HotFixDownSubPackageDownLoadMobileClearPopView SelectCanSelectIndex";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.SelectIndex", this.SelectIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newIndex", index);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.SelectIndex = index;
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout2 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem2 = ((hotFixPackageLayout2 != null) ? hotFixPackageLayout2.GetLayoutItemByIndex(this.GetLayoutIndex(this.SelectIndex)) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem2 != null)
			{
				subPackageDownLoadMobileClearItem2.SelectItem(this.GetSubIndex(this.SelectIndex));
			}
			float inValue = (this.AllCanSelectItemCount > 0) ? ((float)this.SelectIndex / (float)(this.AllCanSelectItemCount - 1)) : 0f;
			UUIScrollbarComponent uiScrollbarComponent = base.GetUiScrollbarComponent(10);
			if (uiScrollbarComponent == null)
			{
				return;
			}
			uiScrollbarComponent.SetValue(inValue, true);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A4A0 File Offset: 0x000086A0
		private void OnGamePadClick(bool bPress, string actionName)
		{
			if (bPress)
			{
				HotFixSubPackageDownLoadVersionTipsView versionTipsView = this.VersionTipsView;
				bool flag;
				if (versionTipsView == null)
				{
					flag = false;
				}
				else
				{
					UUIItem rootItem = versionTipsView.GetRootItem();
					flag = ((rootItem != null) ? new bool?(rootItem.IsUIActiveSelf()) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout = this.HotFixPackageLayout;
					SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem = ((hotFixPackageLayout != null) ? hotFixPackageLayout.GetLayoutItemByIndex(this.GetLayoutIndex(this.SelectIndex)) : null) as SubPackageDownLoadMobileClearItem;
					if (subPackageDownLoadMobileClearItem == null)
					{
						return;
					}
					subPackageDownLoadMobileClearItem.OnClickItem(this.GetSubIndex(this.SelectIndex));
					return;
				}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A520 File Offset: 0x00008720
		private void OnInputChange(EInputControllerType oldControllerType, EInputControllerType newControllerType)
		{
			if (InputDevice.Instance.IsInGamepad())
			{
				HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout = this.HotFixPackageLayout;
				SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem = ((hotFixPackageLayout != null) ? hotFixPackageLayout.GetLayoutItemByIndex(0) : null) as SubPackageDownLoadMobileClearItem;
				if (subPackageDownLoadMobileClearItem != null)
				{
					subPackageDownLoadMobileClearItem.SelectItem(0);
				}
				HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout2 = this.HotFixPackageLayout;
				SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem2 = ((hotFixPackageLayout2 != null) ? hotFixPackageLayout2.GetLayoutItemByIndex(1) : null) as SubPackageDownLoadMobileClearItem;
				if (subPackageDownLoadMobileClearItem2 != null)
				{
					subPackageDownLoadMobileClearItem2.UnSelectItem();
				}
				HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout3 = this.HotFixPackageLayout;
				SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem3 = ((hotFixPackageLayout3 != null) ? hotFixPackageLayout3.GetLayoutItemByIndex(2) : null) as SubPackageDownLoadMobileClearItem;
				if (subPackageDownLoadMobileClearItem3 != null)
				{
					subPackageDownLoadMobileClearItem3.UnSelectItem();
				}
				this.SelectIndex = 0;
				return;
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout4 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem4 = ((hotFixPackageLayout4 != null) ? hotFixPackageLayout4.GetLayoutItemByIndex(0) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem4 != null)
			{
				subPackageDownLoadMobileClearItem4.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout5 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem5 = ((hotFixPackageLayout5 != null) ? hotFixPackageLayout5.GetLayoutItemByIndex(1) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem5 != null)
			{
				subPackageDownLoadMobileClearItem5.UnSelectItem();
			}
			HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> hotFixPackageLayout6 = this.HotFixPackageLayout;
			SubPackageDownLoadMobileClearItem subPackageDownLoadMobileClearItem6 = ((hotFixPackageLayout6 != null) ? hotFixPackageLayout6.GetLayoutItemByIndex(2) : null) as SubPackageDownLoadMobileClearItem;
			if (subPackageDownLoadMobileClearItem6 == null)
			{
				return;
			}
			subPackageDownLoadMobileClearItem6.UnSelectItem();
		}

		// Token: 0x040000D2 RID: 210
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private HotFixLayout<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> HotFixPackageLayout;

		// Token: 0x040000D3 RID: 211
		private readonly HashSet<int> CurrentSelectInfoIdSet = new HashSet<int>();

		// Token: 0x040000D4 RID: 212
		private bool HaveSelectVideo;

		// Token: 0x040000D5 RID: 213
		private readonly HashSet<string> SelectVoiceCodeSet = new HashSet<string>();

		// Token: 0x040000D6 RID: 214
		[Nullable(2)]
		private HotFixSubPackageDownLoadVersionTipsView VersionTipsView;

		// Token: 0x040000D7 RID: 215
		private long AllCanClearSpace;

		// Token: 0x040000D8 RID: 216
		[Nullable(2)]
		public Action OnCloseCallBack;

		// Token: 0x040000D9 RID: 217
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Action> ShowConfirmBox;

		// Token: 0x040000DA RID: 218
		private int SelectIndex;

		// Token: 0x040000DB RID: 219
		private int AllCanSelectItemCount;

		// Token: 0x040000DC RID: 220
		private int PlotAndSceneSplitIndex;

		// Token: 0x040000DD RID: 221
		private int SceneAndVoiceSplitIndex;

		// Token: 0x020002B3 RID: 691
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04000AC6 RID: 2758
			public const int ConfirmBtn = 0;

			// Token: 0x04000AC7 RID: 2759
			public const int AutoClearToggle = 1;

			// Token: 0x04000AC8 RID: 2760
			public const int ScrollLayout = 2;

			// Token: 0x04000AC9 RID: 2761
			public const int ScrollItem = 3;

			// Token: 0x04000ACA RID: 2762
			public const int ConfirmBoxText = 5;

			// Token: 0x04000ACB RID: 2763
			public const int TitleText = 6;

			// Token: 0x04000ACC RID: 2764
			public const int AutoClearText = 7;

			// Token: 0x04000ACD RID: 2765
			public const int CloseBtn = 9;

			// Token: 0x04000ACE RID: 2766
			public const int ScrollBar = 10;

			// Token: 0x04000ACF RID: 2767
			public const int ClearSubPackageTipsPop = 100;
		}
	}
}
