using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200106A RID: 4202
[NullableContext(1)]
[Nullable(0)]
public abstract class GuessJokerSettleViewBase : UiViewBase, IUiCameraBehavior
{
	// Token: 0x06006C4D RID: 27725 RVA: 0x0015DD37 File Offset: 0x0015BF37
	protected GuessJokerSettleViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006C4E RID: 27726 RVA: 0x0015DD40 File Offset: 0x0015BF40
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

	// Token: 0x06006C4F RID: 27727 RVA: 0x0015DE5C File Offset: 0x0015C05C
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

	// Token: 0x06006C50 RID: 27728 RVA: 0x0015DEC0 File Offset: 0x0015C0C0
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

	// Token: 0x06006C51 RID: 27729 RVA: 0x0015DF99 File Offset: 0x0015C199
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

	// Token: 0x06006C52 RID: 27730 RVA: 0x0015DFC7 File Offset: 0x0015C1C7
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

	// Token: 0x06006C53 RID: 27731 RVA: 0x0015DFF1 File Offset: 0x0015C1F1
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerSettleViewBase");
	}

	// Token: 0x06006C54 RID: 27732 RVA: 0x0015E002 File Offset: 0x0015C202
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerSettleViewBase");
	}

	// Token: 0x06006C55 RID: 27733 RVA: 0x0015E014 File Offset: 0x0015C214
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
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
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)cameraNameByCameraId, new int?(viewId), isBlend);
		}
	}

	// Token: 0x06006C56 RID: 27734 RVA: 0x0015E078 File Offset: 0x0015C278
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		if (this.CameraName != null)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.CameraName, stackTopInfo, closeViewId, popOrDelete);
			this.CameraName = null;
		}
	}

	// Token: 0x06006C57 RID: 27735 RVA: 0x0015E0A4 File Offset: 0x0015C2A4
	private void OnClickRematchButton()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		GuessJokerController.Instance.RequestJokerGuessRematch(levelId, delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06006C58 RID: 27736 RVA: 0x0015E0D4 File Offset: 0x0015C2D4
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

	// Token: 0x06006C59 RID: 27737
	protected abstract string GetWinnerName();

	// Token: 0x06006C5A RID: 27738
	protected abstract EPokerStateType GetNpcPokerState();

	// Token: 0x06006C5B RID: 27739
	protected abstract string GetEmojiTexturePath();

	// Token: 0x06006C5C RID: 27740
	protected abstract EUiViewName GetViewName();

	// Token: 0x06006C5D RID: 27741
	protected abstract string GetDescText();

	// Token: 0x0400322C RID: 12844
	[Nullable(2)]
	protected string CameraName;

	// Token: 0x0400322D RID: 12845
	[Nullable(2)]
	private GuessJokerDialogLogic DialogLogic;
}
