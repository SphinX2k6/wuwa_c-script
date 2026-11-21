using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EA7 RID: 3751
[NullableContext(1)]
[Nullable(0)]
public class CreateCharacterView : UiViewBase
{
	// Token: 0x060095FC RID: 38396 RVA: 0x002C757A File Offset: 0x002C577A
	public CreateCharacterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060095FD RID: 38397 RVA: 0x002C759C File Offset: 0x002C579C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.SelectedMale)),
			new ValueTuple<int, Delegate>(2, new Action(this.SelectedFemale))
		};
	}

	// Token: 0x060095FE RID: 38398 RVA: 0x002C765D File Offset: 0x002C585D
	private void SelectedMale()
	{
		this.HandleGenderSwitch(LoginDefine.ELoginSex.Boy);
	}

	// Token: 0x060095FF RID: 38399 RVA: 0x002C7666 File Offset: 0x002C5866
	private void SelectedFemale()
	{
		this.HandleGenderSwitch(LoginDefine.ELoginSex.Girl);
	}

	// Token: 0x06009600 RID: 38400 RVA: 0x002C7670 File Offset: 0x002C5870
	private void HandleGenderSwitch(LoginDefine.ELoginSex loginSex)
	{
		LoginDefine.ELoginSex? selectedSex = this.SelectedSex;
		if (selectedSex.GetValueOrDefault() == loginSex & selectedSex != null)
		{
			return;
		}
		LoginDefine.ELoginSex? selectedSex2 = this.SelectedSex;
		this.SelectedSex = new LoginDefine.ELoginSex?(loginSex);
		base.GetItem(3).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		if (this.InSelectedState)
		{
			this.HideNameView(true);
			UiLoginSceneManager.Instance.LoadSequenceAsync(this.GetSwitchSequence(), new Action(this.HandleSequenceCallback), false, null);
			this.GenderButtonList[(int)selectedSex2.Value].RemoveRoleChooseRenderingMaterial();
			this.GenderButtonList[(int)loginSex].SetRoleChooseRenderingMaterial();
			return;
		}
		UiLoginSceneManager.Instance.LoadSequenceAsync(this.GetSelectSequence(), new Action(this.HandleSequenceCallback), false, null);
		this.GenderButtonList[(int)loginSex].SetRoleChooseRenderingMaterial();
	}

	// Token: 0x06009601 RID: 38401 RVA: 0x002C774D File Offset: 0x002C594D
	private string GetSwitchSequence()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_SwitchMale";
		}
		return "LevelSequence_SwitchFemale";
	}

	// Token: 0x06009602 RID: 38402 RVA: 0x002C7768 File Offset: 0x002C5968
	private string GetSelectSequence()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_SelectMale";
		}
		return "LevelSequence_SelectFemale";
	}

	// Token: 0x06009603 RID: 38403 RVA: 0x002C7784 File Offset: 0x002C5984
	private void HandleSequenceCallback()
	{
		this.InSelectedState = true;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		base.GetButton(1).RootUIComp.Get().SetUIActive(this.SelectedSex.GetValueOrDefault() != LoginDefine.ELoginSex.Boy);
		UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
		LoginDefine.ELoginSex? selectedSex = this.SelectedSex;
		LoginDefine.ELoginSex eloginSex = LoginDefine.ELoginSex.Girl;
		uuiitem.SetUIActive(!(selectedSex.GetValueOrDefault() == eloginSex & selectedSex != null));
	}

	// Token: 0x06009604 RID: 38404 RVA: 0x002C780C File Offset: 0x002C5A0C
	protected override void OnStart()
	{
		this.UiViewSequence.AddSequenceFinishEvent("hide", delegate(string _)
		{
			this.HideTextInput();
		}, false);
		this.InitialRoles = CreateCharacterConfig.Instance.GetInitialRoles();
		this.InitTextInputModule();
		this.InitGenderButton();
		this.HideNameView(false);
		base.GetItem(3).SetUIActive(true);
		base.GetItem(4).SetUIActive(true);
	}

	// Token: 0x06009605 RID: 38405 RVA: 0x002C7873 File Offset: 0x002C5A73
	protected override void OnAfterDestroy()
	{
		LoginModel.Instance.FinishLoginPromise();
	}

	// Token: 0x06009606 RID: 38406 RVA: 0x002C787F File Offset: 0x002C5A7F
	private void HideTextInput()
	{
		this.TextInputModule.SetActive(false);
	}

	// Token: 0x06009607 RID: 38407 RVA: 0x002C788D File Offset: 0x002C5A8D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CreateRoleShowInputName, new Action(this.ShowInputName));
	}

	// Token: 0x06009608 RID: 38408 RVA: 0x002C78AB File Offset: 0x002C5AAB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CreateRoleShowInputName, new Action(this.ShowInputName));
	}

	// Token: 0x06009609 RID: 38409 RVA: 0x002C78C9 File Offset: 0x002C5AC9
	private void ShowInputName()
	{
		this.ShowNameView();
	}

	// Token: 0x0600960A RID: 38410 RVA: 0x002C78D4 File Offset: 0x002C5AD4
	private void InitTextInputModule()
	{
		TextInputData inputData = new TextInputData
		{
			ConfirmFunc = new TConfirm(this.ConfirmFunc),
			ResultFunc = new TResult(this.CreateCharacterResult),
			InputText = "",
			IsCheckNone = true
		};
		this.TextInputModule = new TextInputComponent(base.GetItem(0), inputData);
	}

	// Token: 0x0600960B RID: 38411 RVA: 0x002C7930 File Offset: 0x002C5B30
	private void InitGenderButton()
	{
		CreateCharacterView.GenderButton genderButton = new CreateCharacterView.GenderButton(base.GetButton(2), this.InitialRoles[0]);
		genderButton.BindFunction();
		this.GenderButtonList.Add(genderButton);
		CreateCharacterView.GenderButton genderButton2 = new CreateCharacterView.GenderButton(base.GetButton(1), this.InitialRoles[1]);
		genderButton2.BindFunction();
		this.GenderButtonList.Add(genderButton2);
	}

	// Token: 0x0600960C RID: 38412 RVA: 0x002C7994 File Offset: 0x002C5B94
	protected override void OnBeforeDestroy()
	{
		for (int i = 0; i < this.GenderButtonList.Count; i++)
		{
			CreateCharacterView.GenderButton genderButton = this.GenderButtonList[i];
			genderButton.RemoveRoleChooseRenderingMaterial();
			genderButton.UnbindFunction();
		}
		this.TextInputModule.Destroy(null);
	}

	// Token: 0x0600960D RID: 38413 RVA: 0x002C79DA File Offset: 0x002C5BDA
	private void ShowNameView()
	{
		base.PlaySequence("show", null, false);
		this.TextInputModule.SetActive(true);
	}

	// Token: 0x0600960E RID: 38414 RVA: 0x002C79F5 File Offset: 0x002C5BF5
	private void HideNameView(bool isPlaySequence = true)
	{
		if (isPlaySequence)
		{
			base.PlaySequence("hide", null, true);
			return;
		}
		this.TextInputModule.SetActive(false);
	}

	// Token: 0x0600960F RID: 38415 RVA: 0x002C7A14 File Offset: 0x002C5C14
	[NullableContext(0)]
	private UniTask<ErrorCode> ConfirmFunc([Nullable(1)] string inputText)
	{
		CreateCharacterView.<ConfirmFunc>d__25 <ConfirmFunc>d__;
		<ConfirmFunc>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<ConfirmFunc>d__.<>4__this = this;
		<ConfirmFunc>d__.inputText = inputText;
		<ConfirmFunc>d__.<>1__state = -1;
		<ConfirmFunc>d__.<>t__builder.Start<CreateCharacterView.<ConfirmFunc>d__25>(ref <ConfirmFunc>d__);
		return <ConfirmFunc>d__.<>t__builder.Task;
	}

	// Token: 0x06009610 RID: 38416 RVA: 0x002C7A60 File Offset: 0x002C5C60
	private void CreateCharacterResult(bool result)
	{
		if (result)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "创角界面请求创角成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			LoginModel.Instance.CreateLoginPromise();
			LoginController.Instance.HandleLoginGame(false, result).ContinueWith(delegate(bool ret)
			{
				LoginController.Instance.DisConnect(ret);
				if (!ret)
				{
					LoginController.Instance.CreateCharacterViewToLoginView();
					return;
				}
				this.HideNameView(true);
				base.GetItem(3).SetUIActive(false);
				UiLoginSceneManager.Instance.PlayRoleMontage(this.InitialRoles[(int)this.SelectedSex.Value], EPerformanceRoleState.CreateRole_Head);
				UiLoginSceneManager.Instance.LoadSequenceAsync(this.GetResultSequenceName(), delegate
				{
					RecommendQualityModel.Instance.CheckOpenRecommendQuality();
				}, false, null);
			}).Forget();
			return;
		}
		Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "创角界面请求创角失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.TextInputModule.ClearText();
		base.GetItem(3).SetUIActive(true);
	}

	// Token: 0x06009611 RID: 38417 RVA: 0x002C7AED File Offset: 0x002C5CED
	private string GetResultSequenceName()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_MaleTurnHead";
		}
		return "LevelSequence_FemaleTurnHead";
	}

	// Token: 0x04005A23 RID: 23075
	private LoginDefine.ELoginSex? SelectedSex;

	// Token: 0x04005A24 RID: 23076
	private bool InSelectedState;

	// Token: 0x04005A25 RID: 23077
	private IReadOnlyList<int> InitialRoles = Array.Empty<int>();

	// Token: 0x04005A26 RID: 23078
	private readonly List<CreateCharacterView.GenderButton> GenderButtonList = new List<CreateCharacterView.GenderButton>();

	// Token: 0x04005A27 RID: 23079
	[Nullable(2)]
	private TextInputComponent TextInputModule;

	// Token: 0x020070A6 RID: 28838
	[NullableContext(0)]
	private class ECreateCharacterCom
	{
		// Token: 0x04024B81 RID: 150401
		public const int TextInputModule = 0;

		// Token: 0x04024B82 RID: 150402
		public const int MaleButton = 1;

		// Token: 0x04024B83 RID: 150403
		public const int FemaleButton = 2;

		// Token: 0x04024B84 RID: 150404
		public const int GenderPanel = 3;

		// Token: 0x04024B85 RID: 150405
		public const int TitleItem = 4;
	}

	// Token: 0x020070A7 RID: 28839
	[Nullable(0)]
	private class GenderButton
	{
		// Token: 0x060400C1 RID: 262337 RVA: 0x012C16EE File Offset: 0x012BF8EE
		public GenderButton(UUIButtonComponent uiButton, int roleId)
		{
			this.Button = uiButton;
			this.RoleId = roleId;
		}

		// Token: 0x060400C2 RID: 262338 RVA: 0x012C1704 File Offset: 0x012BF904
		public void BindFunction()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.Button.OnPointEnterCallBack.Bind(new Action(this.SetRoleSelectRenderingMaterial));
			this.Button.OnPointExitCallBack.Bind(new Action(this.RemoveRoleRenderingMaterial));
		}

		// Token: 0x060400C3 RID: 262339 RVA: 0x012C1758 File Offset: 0x012BF958
		private void SetRoleSelectRenderingMaterial()
		{
			this.RemoveRoleRenderingMaterial();
			this.RoleSelectMaterialId = new int?(UiLoginSceneManager.Instance.SetRoleRenderingMaterial(this.RoleId, "CreateCharacterMaterialController"));
			this.HuluSelectMaterialId = new int?(UiLoginSceneManager.Instance.SetHuluRenderingMaterial(this.RoleId, "CreateCharacterMaterialController"));
		}

		// Token: 0x060400C4 RID: 262340 RVA: 0x012C17AC File Offset: 0x012BF9AC
		public void RemoveRoleRenderingMaterial()
		{
			if (this.RoleSelectMaterialId != null)
			{
				UiLoginSceneManager.Instance.RemoveRoleRenderingMaterialWithEnding(this.RoleId, this.RoleSelectMaterialId.Value);
				this.RoleSelectMaterialId = null;
			}
			if (this.HuluSelectMaterialId != null)
			{
				UiLoginSceneManager.Instance.RemoveHuluRenderingMaterialWithEnding(this.RoleId, this.HuluSelectMaterialId.Value);
				this.HuluSelectMaterialId = null;
			}
		}

		// Token: 0x060400C5 RID: 262341 RVA: 0x012C1824 File Offset: 0x012BFA24
		public void SetRoleChooseRenderingMaterial()
		{
			this.RemoveRoleChooseRenderingMaterial();
			this.RoleChooseMaterialId = new int?(UiLoginSceneManager.Instance.SetRoleRenderingMaterial(this.RoleId, "ChooseCharacterMaterialController"));
			this.HuluChooseMaterialId = new int?(UiLoginSceneManager.Instance.SetHuluRenderingMaterial(this.RoleId, "ChooseCharacterMaterialController"));
		}

		// Token: 0x060400C6 RID: 262342 RVA: 0x012C1878 File Offset: 0x012BFA78
		public void RemoveRoleChooseRenderingMaterial()
		{
			if (this.RoleChooseMaterialId != null)
			{
				UiLoginSceneManager.Instance.RemoveRoleRenderingMaterialWithEnding(this.RoleId, this.RoleChooseMaterialId.Value);
				this.RoleChooseMaterialId = null;
			}
			if (this.HuluChooseMaterialId != null)
			{
				UiLoginSceneManager.Instance.RemoveHuluRenderingMaterialWithEnding(this.RoleId, this.HuluChooseMaterialId.Value);
				this.HuluChooseMaterialId = null;
			}
		}

		// Token: 0x060400C7 RID: 262343 RVA: 0x012C18ED File Offset: 0x012BFAED
		public void UnbindFunction()
		{
			this.Button.OnPointEnterCallBack.Unbind();
			this.Button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x04024B86 RID: 150406
		private int? RoleSelectMaterialId;

		// Token: 0x04024B87 RID: 150407
		private int? HuluSelectMaterialId;

		// Token: 0x04024B88 RID: 150408
		private int? RoleChooseMaterialId;

		// Token: 0x04024B89 RID: 150409
		private int? HuluChooseMaterialId;

		// Token: 0x04024B8A RID: 150410
		private readonly UUIButtonComponent Button;

		// Token: 0x04024B8B RID: 150411
		private readonly int RoleId;
	}
}
