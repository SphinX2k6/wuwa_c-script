using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020019D4 RID: 6612
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ConfirmBoxController : ControllerBase
{
	// Token: 0x0600C116 RID: 49430 RVA: 0x002B9280 File Offset: 0x002B7480
	public bool ShowConfirmBoxNew(ConfirmBoxDataNew confirmBoxDataNew)
	{
		ConfirmBox? confirmBoxConfig = ConfirmBoxConfig.Instance.GetConfirmBoxConfig((int)confirmBoxDataNew.ConfigId);
		if (confirmBoxConfig != null && confirmBoxConfig.GetValueOrDefault().ToggleType == 1)
		{
			ConfirmBoxModel instance = ConfirmBoxModel.Instance;
			if (instance != null && instance.NotShowAgainSet.Contains(confirmBoxDataNew.ConfigId))
			{
				Action action;
				if (confirmBoxDataNew.FunctionMap.TryGetValue(2, out action) && action != null)
				{
					action();
				}
				return false;
			}
		}
		EUiViewName? uiViewName = this.GetUiViewName((int)confirmBoxDataNew.ConfigId);
		if (confirmBoxDataNew.FunctionMap.Count > 0)
		{
			confirmBoxDataNew.IsMultipleView = true;
		}
		if (uiViewName != null)
		{
			UiManager.Instance.OpenView(uiViewName.Value, confirmBoxDataNew, confirmBoxDataNew.FinishOpenFunction);
			return true;
		}
		return false;
	}

	// Token: 0x0600C117 RID: 49431 RVA: 0x002B9338 File Offset: 0x002B7538
	public bool CheckIsConfirmBoxOpen()
	{
		foreach (EUiViewName viewName in this.ConfirmBoxMapNameMap.Values)
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600C118 RID: 49432 RVA: 0x002B93A0 File Offset: 0x002B75A0
	public void CloseConfirmBoxView()
	{
		foreach (EUiViewName name in this.ConfirmBoxMapNameMap.Values)
		{
			UiManager.Instance.CloseView(name, null);
		}
	}

	// Token: 0x0600C119 RID: 49433 RVA: 0x002B9400 File Offset: 0x002B7600
	public void ShowNetWorkConfirmBoxView(ConfirmBoxDataNew confirmBoxDataNew, [Nullable(2)] TOpenViewCallBack finishCallback = null)
	{
		confirmBoxDataNew.NotAddChildToTopStackView = true;
		UiManager.Instance.OpenView(EUiViewName.NetWorkConfirmBoxView, confirmBoxDataNew, finishCallback);
	}

	// Token: 0x0600C11A RID: 49434 RVA: 0x002B941A File Offset: 0x002B761A
	[NullableContext(2)]
	public void CloseNetWorkConfirmBoxView(int viewId, Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseViewById(viewId, finishCallback);
	}

	// Token: 0x0600C11B RID: 49435 RVA: 0x002B9428 File Offset: 0x002B7628
	public void ShowFirstCurrencyConfirm()
	{
		int? num = GachaConfig.Instance.PrimaryCurrency();
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FirstCurrency);
		if (num == null)
		{
			return;
		}
		string itemName = ItemConfig.Instance.GetItemName(num.Value);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			itemName
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			PayShopController.Instance.OpenPayShopViewToRecharge();
		};
		this.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600C11C RID: 49436 RVA: 0x002B94A8 File Offset: 0x002B76A8
	public void ShowExitGameConfirmBox()
	{
		if (KuroSdkController.Instance.CanUseSdk())
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROSDKEXIT);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExitGame);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			if (GlobalData.IsPlayInEditor)
			{
				UKismetSystemLibrary.QuitGame(GlobalData.World, null, EQuitPreference.Quit, false);
				return;
			}
			KuroApplication.ExitWithReason(false, "ExitGameConfirmBox");
		};
		this.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600C11D RID: 49437 RVA: 0x002B9508 File Offset: 0x002B7708
	public void ShowReturnLoginConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExitGameOrReturnLogin);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			ReConnectController.Instance.Logout(ELogoutReason.ExitGameConfirmBox);
		};
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KUROSDKEXIT);
		};
		this.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600C11E RID: 49438 RVA: 0x002B9588 File Offset: 0x002B7788
	public EUiViewName? GetUiViewName(int configId)
	{
		EConfirmBoxType valueOrDefault = (EConfirmBoxType)ConfirmBoxConfig.Instance.GetUiShowType(configId).GetValueOrDefault();
		EUiViewName value;
		if (!this.ConfirmBoxMapNameMap.TryGetValue(valueOrDefault, out value))
		{
			return null;
		}
		return new EUiViewName?(value);
	}

	// Token: 0x1700102B RID: 4139
	// (get) Token: 0x0600C11F RID: 49439 RVA: 0x002B95C9 File Offset: 0x002B77C9
	public static ConfirmBoxController Instance
	{
		get
		{
			return ConfirmBoxController._Instance;
		}
	}

	// Token: 0x0600C120 RID: 49440 RVA: 0x002B95D0 File Offset: 0x002B77D0
	public static ConfirmBoxController GetOrCreateInstance()
	{
		if (ConfirmBoxController._Instance == null)
		{
			ConfirmBoxController.CreateInstance();
		}
		return ConfirmBoxController._Instance;
	}

	// Token: 0x0600C121 RID: 49441 RVA: 0x002B95E4 File Offset: 0x002B77E4
	public static bool CreateInstance()
	{
		if (ConfirmBoxController._Instance != null)
		{
			return true;
		}
		ConfirmBoxController._Instance = new ConfirmBoxController();
		return true;
	}

	// Token: 0x0600C122 RID: 49442 RVA: 0x002B95FA File Offset: 0x002B77FA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C123 RID: 49443 RVA: 0x002B95FC File Offset: 0x002B77FC
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxController._Instance = null;
	}

	// Token: 0x0600C124 RID: 49444 RVA: 0x002B9604 File Offset: 0x002B7804
	static ConfirmBoxController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxController.CreateStaticDefaultValue), new Action(ConfirmBoxController.ResetStaticDefaultValue));
	}

	// Token: 0x040056D6 RID: 22230
	private readonly Dictionary<EConfirmBoxType, EUiViewName> ConfirmBoxMapNameMap = new Dictionary<EConfirmBoxType, EUiViewName>
	{
		{
			EConfirmBoxType.Small,
			EUiViewName.ConfirmBoxView
		},
		{
			EConfirmBoxType.Middle,
			EUiViewName.ConfirmBoxMiddleView
		},
		{
			EConfirmBoxType.MiddleWithoutItem,
			EUiViewName.ConfirmBoxMiddleWithoutItemView
		},
		{
			EConfirmBoxType.RacingBets,
			EUiViewName.RacingBetsConfirmBoxView
		},
		{
			EConfirmBoxType.FloroRanch,
			EUiViewName.FloroRanchConfirmBoxView
		},
		{
			EConfirmBoxType.MatchThree,
			EUiViewName.MatchThreeConfirmBoxView
		},
		{
			EConfirmBoxType.Cyberpunk,
			EUiViewName.CyberpunkConfirmBoxView
		},
		{
			EConfirmBoxType.KurotatoSave,
			EUiViewName.KurotatoPopupSaveView
		},
		{
			EConfirmBoxType.DangoBrawl,
			EUiViewName.DangoBrawlConfirmBoxView
		}
	};

	// Token: 0x040056D7 RID: 22231
	[Nullable(2)]
	private static ConfirmBoxController _Instance;
}
