using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001917 RID: 6423
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigSharePopItem : UiViewBase
{
	// Token: 0x0600FE05 RID: 65029 RVA: 0x004A24E7 File Offset: 0x004A06E7
	public PhantomManagerConfigSharePopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE06 RID: 65030 RVA: 0x004A24F0 File Offset: 0x004A06F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedSelfUpdate));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedShare));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedPaste));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedImport));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FE07 RID: 65031 RVA: 0x004A26E8 File Offset: 0x004A08E8
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(PhantomBattleModel.Instance.GetSelfPhantomConfigCode(), true);
		}
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(PhantomBattleModel.Instance.GetPhantomConfigData().PhantomSelfConfigNeedUpdate);
		}
		bool flag = Info.Instance.IsHomeConsolePlatform();
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!flag);
		}
		UUIButtonComponent button2 = base.GetButton(5);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(!flag);
		}
		this.LevelSequence = new LevelSequencePlayer(base.GetItem(8));
		this.LevelSequence.PlayLevelSequenceByName("Progressing", false, null, false);
	}

	// Token: 0x0600FE08 RID: 65032 RVA: 0x004A27B4 File Offset: 0x004A09B4
	protected bool GetTimeValid()
	{
		long lastSharedCheckTime = PhantomBattleModel.Instance.GetPhantomConfigData().LastSharedCheckTime;
		double now = Time.Instance.Now;
		int phantomSharedCodeCd = PhantomBattleConfig.Instance.GetPhantomSharedCodeCd();
		return now - (double)lastSharedCheckTime >= (double)(phantomSharedCodeCd * 1000);
	}

	// Token: 0x0600FE09 RID: 65033 RVA: 0x004A27F6 File Offset: 0x004A09F6
	private void OnClickedSelfUpdate()
	{
		PhantomBattleController.Instance.RequestPhBaPlanUpdatePlan().ContinueWith(delegate(bool value)
		{
			if (!value)
			{
				return;
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_7", Array.Empty<object>());
			PhantomDiscardPlanShareReport logData = new PhantomDiscardPlanShareReport
			{
				i_type = 1,
				s_my_code = PhantomBattleModel.Instance.GetPhantomConfigData().SelfPhantomConfigCode
			};
			LogReportController.Instance.LogReport(logData);
		}).Forget();
	}

	// Token: 0x0600FE0A RID: 65034 RVA: 0x004A2818 File Offset: 0x004A0A18
	private void OnClickedShare()
	{
		PhantomManagerConfigData configData = PhantomBattleModel.Instance.GetPhantomConfigData();
		string txtContext = StringUtils.Format(PublicUtil.Instance.GetConfigTextByKey("PhantomProject_ShareContent"), new string[]
		{
			FunctionModel.Instance.GetPlayerName() ?? string.Empty,
			configData.SelfPhantomConfigCode
		});
		LogReportController.Instance.LogReport(new PhantomDiscardPlanShareReport
		{
			i_type = 2,
			s_my_code = configData.SelfPhantomConfigCode
		});
		if (!configData.PhantomSelfConfigNeedUpdate)
		{
			this.CopySuccess(txtContext);
			return;
		}
		if (!configData.ConfirmBoxLoginSet.Contains(EConfirmBoxConfigId.PhantomConfigCanUpdateSelf))
		{
			this.NeedUpdateLoginShowTmp = false;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomConfigCanUpdateSelf);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = PublicUtil.Instance.GetConfigTextByKey("PhantomProject_CommonText");
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.SetToggleFunction(delegate(bool value)
			{
				this.NeedUpdateLoginShowTmp = value;
			});
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				this.CopySuccess(txtContext);
				if (this.NeedUpdateLoginShowTmp)
				{
					configData.ConfirmBoxLoginSet.Add(EConfirmBoxConfigId.PhantomConfigCanUpdateSelf);
					configData.ConfigViewShareUpdateSelect = EPhantomManagerEditCloseState.Left;
				}
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.UpdateSelfAndReset();
				if (this.NeedUpdateLoginShowTmp)
				{
					configData.ConfirmBoxLoginSet.Add(EConfirmBoxConfigId.PhantomConfigCanUpdateSelf);
					configData.ConfigViewShareUpdateSelect = EPhantomManagerEditCloseState.Right;
				}
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (configData.ConfigViewShareUpdateSelect == EPhantomManagerEditCloseState.Right)
		{
			this.UpdateSelfAndReset();
			return;
		}
		this.CopySuccess(txtContext);
	}

	// Token: 0x0600FE0B RID: 65035 RVA: 0x004A2983 File Offset: 0x004A0B83
	private void CopySuccess(string txt)
	{
		ULGUIBPLibrary.ClipBoardCopy(txt);
		ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_8", Array.Empty<object>());
	}

	// Token: 0x0600FE0C RID: 65036 RVA: 0x004A299F File Offset: 0x004A0B9F
	private void UpdateSelfAndReset()
	{
		PhantomBattleController.Instance.RequestPhBaPlanUpdatePlan().ContinueWith(delegate(bool _)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			PhantomManagerConfigData phantomConfigData = PhantomBattleModel.Instance.GetPhantomConfigData();
			string txt = StringUtils.Format(PublicUtil.Instance.GetConfigTextByKey("PhantomProject_ShareContent"), new string[]
			{
				FunctionModel.Instance.GetPlayerName() ?? string.Empty,
				phantomConfigData.SelfPhantomConfigCode
			});
			this.CopySuccess(txt);
		}).Forget();
	}

	// Token: 0x0600FE0D RID: 65037 RVA: 0x004A29C4 File Offset: 0x004A0BC4
	private void OnClickedPaste()
	{
		if (Platform.Instance.IsCloudGame())
		{
			string pasteTarget = string.Empty;
			UKuroCloudGameWrapper.ClipBoardPaste();
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				ULGUIBPLibrary.ClipBoardPaste(ref pasteTarget);
				if (!StringUtils.IsEmpty(pasteTarget))
				{
					UUITextInputComponent inputText2 = this.GetInputText(4);
					if (inputText2 == null)
					{
						return;
					}
					inputText2.SetText(pasteTarget, true);
				}
			}, 200f, null, null, true, 1f);
			return;
		}
		string empty = string.Empty;
		ULGUIBPLibrary.ClipBoardPaste(ref empty);
		if (!StringUtils.IsEmpty(empty))
		{
			UUITextInputComponent inputText = base.GetInputText(4);
			if (inputText == null)
			{
				return;
			}
			inputText.SetText(empty, true);
		}
	}

	// Token: 0x0600FE0E RID: 65038 RVA: 0x004A2A48 File Offset: 0x004A0C48
	private void OnClickedImport()
	{
		if (!this.GetTimeValid())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_14", Array.Empty<object>());
			return;
		}
		string code = base.GetInputText(4).GetText();
		if (!this.IsCodeValid(code))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_13", Array.Empty<object>());
			return;
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		PhantomBattleController.Instance.RequestPhBaPlanFindPlan(code).ContinueWith(delegate(PhBaPlanFindPlanResponse response)
		{
			PhantomManagerConfigData configData = PhantomBattleModel.Instance.GetPhantomConfigData();
			UUIButtonComponent button2 = this.GetButton(6);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(true);
			}
			UUIItem item2 = this.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			configData.LastSharedCheckTime = (long)Time.Instance.Now;
			if (response == null)
			{
				this.GetInputText(4).SetText(string.Empty, false);
				return;
			}
			LogReportController.Instance.LogReport(new PhantomDiscardPlanShareReport
			{
				i_type = 3,
				s_others_code = code
			});
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomConfigUsePlayerPlant);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				response.Plan.Name
			});
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				configData.PhantomSelfConfigNeedUpdate = !response.TowPlanSame;
				List<int> fetterIdList = new List<int>();
				HashSet<int> hashSet = new HashSet<int>();
				foreach (PhantomFetterGroup phantomFetterGroup in PhantomBattleConfig.Instance.GetPhantomFetterGroupList())
				{
					fetterIdList.Add(phantomFetterGroup.Id);
					hashSet.Add(phantomFetterGroup.Id);
				}
				PhantomBattleModel.Instance.CacheShareConfigData(response.Plan);
				PhantomBattleController.Instance.RequestPhBaPlanSaveUsePlan(false, hashSet).ContinueWith(delegate(bool value)
				{
					if (!value)
					{
						configData.DoCacheDataUpdate(false);
						return;
					}
					configData.DoLogReport(fetterIdList, false);
					ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_12", Array.Empty<object>());
					this.CloseMe(null);
					EventSystem.Instance.Emit<bool>(EEventName.OnPhantomConfigManagerDataUpdate, true);
				}).Forget();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}).Forget();
	}

	// Token: 0x0600FE0F RID: 65039 RVA: 0x004A2B10 File Offset: 0x004A0D10
	private bool IsCodeValid(string code)
	{
		int phantomManagerShareCodeMax = PhantomBattleConfig.Instance.GetPhantomManagerShareCodeMax();
		int phantomManagerShareCodeMin = PhantomBattleConfig.Instance.GetPhantomManagerShareCodeMin();
		return code.Length >= phantomManagerShareCodeMin && code.Length <= phantomManagerShareCodeMax && StringUtils.CheckIsOnlyLettersAndNumbers(code);
	}

	// Token: 0x04008D4C RID: 36172
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008D4D RID: 36173
	private bool NeedUpdateLoginShowTmp;

	// Token: 0x02007B3B RID: 31547
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027F03 RID: 163587
		TxtCodeNum,
		// Token: 0x04027F04 RID: 163588
		BtnUpdate,
		// Token: 0x04027F05 RID: 163589
		BtnShare,
		// Token: 0x04027F06 RID: 163590
		PanelNeedUpdate,
		// Token: 0x04027F07 RID: 163591
		InputBox,
		// Token: 0x04027F08 RID: 163592
		BtnInputPaste,
		// Token: 0x04027F09 RID: 163593
		BtnImport,
		// Token: 0x04027F0A RID: 163594
		PanelInProgress,
		// Token: 0x04027F0B RID: 163595
		PanelInProgressAnim
	}
}
