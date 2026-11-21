using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E93 RID: 3731
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ConfirmBoxController : ControllerBase
{
	// Token: 0x06009523 RID: 38179 RVA: 0x002C424C File Offset: 0x002C244C
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

	// Token: 0x06009524 RID: 38180 RVA: 0x002C4304 File Offset: 0x002C2504
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

	// Token: 0x06009525 RID: 38181 RVA: 0x002C436C File Offset: 0x002C256C
	public void CloseConfirmBoxView()
	{
		foreach (EUiViewName name in this.ConfirmBoxMapNameMap.Values)
		{
			UiManager.Instance.CloseView(name, null);
		}
	}

	// Token: 0x06009526 RID: 38182 RVA: 0x002C43CC File Offset: 0x002C25CC
	public void ShowNetWorkConfirmBoxView(ConfirmBoxDataNew confirmBoxDataNew, [Nullable(2)] TOpenViewCallBack finishCallback = null)
	{
		confirmBoxDataNew.NotAddChildToTopStackView = true;
		UiManager.Instance.OpenView(EUiViewName.NetWorkConfirmBoxView, confirmBoxDataNew, finishCallback);
	}

	// Token: 0x06009527 RID: 38183 RVA: 0x002C43E6 File Offset: 0x002C25E6
	[NullableContext(2)]
	public void CloseNetWorkConfirmBoxView(int viewId, Action<bool> finishCallback = null)
	{
		UiManager.Instance.CloseViewById(viewId, finishCallback);
	}

	// Token: 0x06009528 RID: 38184 RVA: 0x002C43F4 File Offset: 0x002C25F4
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

	// Token: 0x06009529 RID: 38185 RVA: 0x002C4474 File Offset: 0x002C2674
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

	// Token: 0x0600952A RID: 38186 RVA: 0x002C44D4 File Offset: 0x002C26D4
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

	// Token: 0x0600952B RID: 38187 RVA: 0x002C4554 File Offset: 0x002C2754
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

	// Token: 0x17001050 RID: 4176
	// (get) Token: 0x0600952C RID: 38188 RVA: 0x002C4595 File Offset: 0x002C2795
	public static ConfirmBoxController Instance
	{
		get
		{
			return ConfirmBoxController._Instance;
		}
	}

	// Token: 0x0600952D RID: 38189 RVA: 0x002C459C File Offset: 0x002C279C
	public static ConfirmBoxController GetOrCreateInstance()
	{
		if (ConfirmBoxController._Instance == null)
		{
			ConfirmBoxController.CreateInstance();
		}
		return ConfirmBoxController._Instance;
	}

	// Token: 0x0600952E RID: 38190 RVA: 0x002C45B0 File Offset: 0x002C27B0
	public static bool CreateInstance()
	{
		if (ConfirmBoxController._Instance != null)
		{
			return true;
		}
		ConfirmBoxController._Instance = new ConfirmBoxController();
		return true;
	}

	// Token: 0x0600952F RID: 38191 RVA: 0x002C45C6 File Offset: 0x002C27C6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009530 RID: 38192 RVA: 0x002C45C8 File Offset: 0x002C27C8
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxController._Instance = null;
	}

	// Token: 0x06009531 RID: 38193 RVA: 0x002C45D0 File Offset: 0x002C27D0
	static ConfirmBoxController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxController.CreateStaticDefaultValue), new Action(ConfirmBoxController.ResetStaticDefaultValue));
	}

	// Token: 0x04005788 RID: 22408
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
		},
		{
			EConfirmBoxType.SolarSchool,
			EUiViewName.SolarSchoolConfirmPopupView
		}
	};

	// Token: 0x04005789 RID: 22409
	[Nullable(2)]
	private static ConfirmBoxController _Instance;
}
