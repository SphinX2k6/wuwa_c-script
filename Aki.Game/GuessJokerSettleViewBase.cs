using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200051E RID: 1310
[NullableContext(1)]
[Nullable(0)]
public abstract class GuessJokerSettleViewBase : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06003FE2 RID: 16354 RVA: 0x0016666F File Offset: 0x0016486F
	protected GuessJokerSettleViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x00166678 File Offset: 0x00164878
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRematchButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmButton))
		};
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x00166794 File Offset: 0x00164994
	protected override void OnStart()
	{
		bool uiactive = true;
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		bool firstPass = SpringManorModel.Instance.ActivityData.GetGuessJokerGameData(levelId).FirstPass;
		if (!GuessJokerGamePlayModel.Instance.IsFinish && firstPass)
		{
			uiactive = false;
		}
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x001667F8 File Offset: 0x001649F8
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		if (this.DialogLogic == null)
		{
			this.DialogLogic = new GuessJokerDialogLogic();
		}
		this.DialogLogic.InitData(new GuessJokerDialogData
		{
			GetDialogItem = ((EGuessJokerPlayerType playerType) => base.GetItem(6)),
			GetDialogText = ((EGuessJokerPlayerType playerType) => base.GetText(8))
		});
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, "GuessJoker_WinText", new <>z__ReadOnlySingleElementList<object>(this.GetWinnerName()));
		base.SetTextureByPath(this.GetEmojiTexturePath(), base.GetTexture(2), null, null);
		base.GetText(3).ShowTextNew(this.GetDescText());
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Ai);
		base.GetText(7).SetText(playerNameByType, true);
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x001668D1 File Offset: 0x00164AD1
	protected override void OnAfterShow()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance != null)
		{
			instance.SetActiveDialogLogic(this.DialogLogic);
		}
		GuessJokerGamePlayModel instance2 = GuessJokerGamePlayModel.Instance;
		if (instance2 == null)
		{
			return;
		}
		instance2.SetNpcPokerState(this.GetNpcPokerState());
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x001668FF File Offset: 0x00164AFF
	protected override void OnBeforeHide()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance != null)
		{
			instance.SetActiveDialogLogic(null);
		}
		GuessJokerDialogLogic dialogLogic = this.DialogLogic;
		if (dialogLogic != null)
		{
			dialogLogic.Clear();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x00166929 File Offset: 0x00164B29
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerSettleViewBase");
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x0016693A File Offset: 0x00164B3A
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerSettleViewBase");
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x0016694C File Offset: 0x00164B4C
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		int roleId = GuessJokerGamePlayModel.Instance.GetRoleId();
		GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(roleId);
		if (jokerAiConfigByRoleId == null)
		{
			return;
		}
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(jokerAiConfigByRoleId.Value.SettleCameraId);
		if (cameraNameByCameraId != null)
		{
			this.CameraName = cameraNameByCameraId;
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)cameraNameByCameraId, viewId, operationType);
		}
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x001669AB File Offset: 0x00164BAB
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CameraName != null)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.CameraName, nextViewName, closeViewId, operationType);
			this.CameraName = null;
		}
	}

	// Token: 0x06003FEC RID: 16364 RVA: 0x001669D8 File Offset: 0x00164BD8
	private void OnClickRematchButton()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerController.Instance.RequestJokerGuessRematch(levelId, delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x00166A08 File Offset: 0x00164C08
	private void OnClickConfirmButton()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerGamePlayModel.Instance.ExitGame();
		bool flag = false;
		bool firstPass = SpringManorModel.Instance.ActivityData.GetGuessJokerGameData(levelId).FirstPass;
		if (!GuessJokerGamePlayModel.Instance.IsFinish && firstPass)
		{
			flag = true;
		}
		if (flag && levelId == 1010)
		{
			GuessJokerGamePlayModel.Instance.HideAllGuessJokerNpc();
			base.CloseMe(null);
			return;
		}
		GuessJokerGamePlayModel.Instance.OpenSelectRoleView(0).ContinueWith(delegate()
		{
			base.CloseMe(null);
		}).Forget();
	}

	// Token: 0x06003FEE RID: 16366
	protected abstract string GetWinnerName();

	// Token: 0x06003FEF RID: 16367
	protected abstract EPokerStateType GetNpcPokerState();

	// Token: 0x06003FF0 RID: 16368
	protected abstract string GetEmojiTexturePath();

	// Token: 0x06003FF1 RID: 16369
	protected abstract EUiViewName GetViewName();

	// Token: 0x06003FF2 RID: 16370
	protected abstract string GetDescText();

	// Token: 0x040032C5 RID: 12997
	[Nullable(2)]
	protected string CameraName;

	// Token: 0x040032C6 RID: 12998
	[Nullable(2)]
	private GuessJokerDialogLogic DialogLogic;
}
