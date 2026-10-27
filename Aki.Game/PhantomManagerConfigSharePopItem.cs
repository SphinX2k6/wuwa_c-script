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

// Token: 0x02002432 RID: 9266
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigSharePopItem : UiViewBase
{
	// Token: 0x0601294F RID: 76111 RVA: 0x00494F1B File Offset: 0x0049311B
	public PhantomManagerConfigSharePopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012950 RID: 76112 RVA: 0x00494F24 File Offset: 0x00493124
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

	// Token: 0x06012951 RID: 76113 RVA: 0x0049511C File Offset: 0x0049331C
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

	// Token: 0x06012952 RID: 76114 RVA: 0x004951E8 File Offset: 0x004933E8
	protected bool GetTimeValid()
	{
		long lastSharedCheckTime = PhantomBattleModel.Instance.GetPhantomConfigData().LastSharedCheckTime;
		double now = Time.Instance.Now;
		int phantomSharedCodeCd = PhantomBattleConfig.Instance.GetPhantomSharedCodeCd();
		return now - (double)lastSharedCheckTime >= (double)(phantomSharedCodeCd * 1000);
	}

	// Token: 0x06012953 RID: 76115 RVA: 0x0049522A File Offset: 0x0049342A
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

	// Token: 0x06012954 RID: 76116 RVA: 0x0049524C File Offset: 0x0049344C
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

	// Token: 0x06012955 RID: 76117 RVA: 0x004953B7 File Offset: 0x004935B7
	private void CopySuccess(string txt)
	{
		ULGUIBPLibrary.ClipBoardCopy(txt);
		ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_ShareImport_Des_8", Array.Empty<object>());
	}

	// Token: 0x06012956 RID: 76118 RVA: 0x004953D3 File Offset: 0x004935D3
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

	// Token: 0x06012957 RID: 76119 RVA: 0x004953F8 File Offset: 0x004935F8
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

	// Token: 0x06012958 RID: 76120 RVA: 0x0049547C File Offset: 0x0049367C
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

	// Token: 0x06012959 RID: 76121 RVA: 0x00495544 File Offset: 0x00493744
	private bool IsCodeValid(string code)
	{
		int phantomManagerShareCodeMax = PhantomBattleConfig.Instance.GetPhantomManagerShareCodeMax();
		int phantomManagerShareCodeMin = PhantomBattleConfig.Instance.GetPhantomManagerShareCodeMin();
		return code.Length >= phantomManagerShareCodeMin && code.Length <= phantomManagerShareCodeMax && StringUtils.CheckIsOnlyLettersAndNumbers(code);
	}

	// Token: 0x04008C05 RID: 35845
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008C06 RID: 35846
	private bool NeedUpdateLoginShowTmp;

	// Token: 0x020089B4 RID: 35252
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402CBED RID: 183277
		TxtCodeNum,
		// Token: 0x0402CBEE RID: 183278
		BtnUpdate,
		// Token: 0x0402CBEF RID: 183279
		BtnShare,
		// Token: 0x0402CBF0 RID: 183280
		PanelNeedUpdate,
		// Token: 0x0402CBF1 RID: 183281
		InputBox,
		// Token: 0x0402CBF2 RID: 183282
		BtnInputPaste,
		// Token: 0x0402CBF3 RID: 183283
		BtnImport,
		// Token: 0x0402CBF4 RID: 183284
		PanelInProgress,
		// Token: 0x0402CBF5 RID: 183285
		PanelInProgressAnim
	}
}
