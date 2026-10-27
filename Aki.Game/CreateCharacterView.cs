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

// Token: 0x020019E8 RID: 6632
[NullableContext(1)]
[Nullable(0)]
public class CreateCharacterView : UiViewBase
{
	// Token: 0x0600C1EF RID: 49647 RVA: 0x002BC5A2 File Offset: 0x002BA7A2
	public CreateCharacterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C1F0 RID: 49648 RVA: 0x002BC5C4 File Offset: 0x002BA7C4
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

	// Token: 0x0600C1F1 RID: 49649 RVA: 0x002BC685 File Offset: 0x002BA885
	private void SelectedMale()
	{
		this.HandleGenderSwitch(LoginDefine.ELoginSex.Boy);
	}

	// Token: 0x0600C1F2 RID: 49650 RVA: 0x002BC68E File Offset: 0x002BA88E
	private void SelectedFemale()
	{
		this.HandleGenderSwitch(LoginDefine.ELoginSex.Girl);
	}

	// Token: 0x0600C1F3 RID: 49651 RVA: 0x002BC698 File Offset: 0x002BA898
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

	// Token: 0x0600C1F4 RID: 49652 RVA: 0x002BC775 File Offset: 0x002BA975
	private string GetSwitchSequence()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_SwitchMale";
		}
		return "LevelSequence_SwitchFemale";
	}

	// Token: 0x0600C1F5 RID: 49653 RVA: 0x002BC790 File Offset: 0x002BA990
	private string GetSelectSequence()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_SelectMale";
		}
		return "LevelSequence_SelectFemale";
	}

	// Token: 0x0600C1F6 RID: 49654 RVA: 0x002BC7AC File Offset: 0x002BA9AC
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

	// Token: 0x0600C1F7 RID: 49655 RVA: 0x002BC834 File Offset: 0x002BAA34
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

	// Token: 0x0600C1F8 RID: 49656 RVA: 0x002BC89B File Offset: 0x002BAA9B
	protected override void OnAfterDestroy()
	{
		LoginModel.Instance.FinishLoginPromise();
	}

	// Token: 0x0600C1F9 RID: 49657 RVA: 0x002BC8A7 File Offset: 0x002BAAA7
	private void HideTextInput()
	{
		this.TextInputModule.SetActive(false);
	}

	// Token: 0x0600C1FA RID: 49658 RVA: 0x002BC8B5 File Offset: 0x002BAAB5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CreateRoleShowInputName, new Action(this.ShowInputName));
	}

	// Token: 0x0600C1FB RID: 49659 RVA: 0x002BC8D3 File Offset: 0x002BAAD3
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CreateRoleShowInputName, new Action(this.ShowInputName));
	}

	// Token: 0x0600C1FC RID: 49660 RVA: 0x002BC8F1 File Offset: 0x002BAAF1
	private void ShowInputName()
	{
		this.ShowNameView();
	}

	// Token: 0x0600C1FD RID: 49661 RVA: 0x002BC8FC File Offset: 0x002BAAFC
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

	// Token: 0x0600C1FE RID: 49662 RVA: 0x002BC958 File Offset: 0x002BAB58
	private void InitGenderButton()
	{
		CreateCharacterView.GenderButton genderButton = new CreateCharacterView.GenderButton(base.GetButton(2), this.InitialRoles[0]);
		genderButton.BindFunction();
		this.GenderButtonList.Add(genderButton);
		CreateCharacterView.GenderButton genderButton2 = new CreateCharacterView.GenderButton(base.GetButton(1), this.InitialRoles[1]);
		genderButton2.BindFunction();
		this.GenderButtonList.Add(genderButton2);
	}

	// Token: 0x0600C1FF RID: 49663 RVA: 0x002BC9BC File Offset: 0x002BABBC
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

	// Token: 0x0600C200 RID: 49664 RVA: 0x002BCA02 File Offset: 0x002BAC02
	private void ShowNameView()
	{
		base.PlaySequence("show", null, false);
		this.TextInputModule.SetActive(true);
	}

	// Token: 0x0600C201 RID: 49665 RVA: 0x002BCA1D File Offset: 0x002BAC1D
	private void HideNameView(bool isPlaySequence = true)
	{
		if (isPlaySequence)
		{
			base.PlaySequence("hide", null, true);
			return;
		}
		this.TextInputModule.SetActive(false);
	}

	// Token: 0x0600C202 RID: 49666 RVA: 0x002BCA3C File Offset: 0x002BAC3C
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

	// Token: 0x0600C203 RID: 49667 RVA: 0x002BCA88 File Offset: 0x002BAC88
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

	// Token: 0x0600C204 RID: 49668 RVA: 0x002BCB15 File Offset: 0x002BAD15
	private string GetResultSequenceName()
	{
		if (this.SelectedSex.GetValueOrDefault() == LoginDefine.ELoginSex.Boy)
		{
			return "LevelSequence_MaleTurnHead";
		}
		return "LevelSequence_FemaleTurnHead";
	}

	// Token: 0x04005954 RID: 22868
	private LoginDefine.ELoginSex? SelectedSex;

	// Token: 0x04005955 RID: 22869
	private bool InSelectedState;

	// Token: 0x04005956 RID: 22870
	private IReadOnlyList<int> InitialRoles = Array.Empty<int>();

	// Token: 0x04005957 RID: 22871
	private readonly List<CreateCharacterView.GenderButton> GenderButtonList = new List<CreateCharacterView.GenderButton>();

	// Token: 0x04005958 RID: 22872
	[Nullable(2)]
	private TextInputComponent TextInputModule;

	// Token: 0x02007F17 RID: 32535
	[NullableContext(0)]
	private class ECreateCharacterCom
	{
		// Token: 0x04029844 RID: 170052
		public const int TextInputModule = 0;

		// Token: 0x04029845 RID: 170053
		public const int MaleButton = 1;

		// Token: 0x04029846 RID: 170054
		public const int FemaleButton = 2;

		// Token: 0x04029847 RID: 170055
		public const int GenderPanel = 3;

		// Token: 0x04029848 RID: 170056
		public const int TitleItem = 4;
	}

	// Token: 0x02007F18 RID: 32536
	[Nullable(0)]
	private class GenderButton
	{
		// Token: 0x06049CA3 RID: 302243 RVA: 0x0131E212 File Offset: 0x0131C412
		public GenderButton(UUIButtonComponent uiButton, int roleId)
		{
			this.Button = uiButton;
			this.RoleId = roleId;
		}

		// Token: 0x06049CA4 RID: 302244 RVA: 0x0131E228 File Offset: 0x0131C428
		public void BindFunction()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.Button.OnPointEnterCallBack.Bind(new Action(this.SetRoleSelectRenderingMaterial));
			this.Button.OnPointExitCallBack.Bind(new Action(this.RemoveRoleRenderingMaterial));
		}

		// Token: 0x06049CA5 RID: 302245 RVA: 0x0131E27C File Offset: 0x0131C47C
		private void SetRoleSelectRenderingMaterial()
		{
			this.RemoveRoleRenderingMaterial();
			this.RoleSelectMaterialId = new int?(UiLoginSceneManager.Instance.SetRoleRenderingMaterial(this.RoleId, "CreateCharacterMaterialController"));
			this.HuluSelectMaterialId = new int?(UiLoginSceneManager.Instance.SetHuluRenderingMaterial(this.RoleId, "CreateCharacterMaterialController"));
		}

		// Token: 0x06049CA6 RID: 302246 RVA: 0x0131E2D0 File Offset: 0x0131C4D0
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

		// Token: 0x06049CA7 RID: 302247 RVA: 0x0131E348 File Offset: 0x0131C548
		public void SetRoleChooseRenderingMaterial()
		{
			this.RemoveRoleChooseRenderingMaterial();
			this.RoleChooseMaterialId = new int?(UiLoginSceneManager.Instance.SetRoleRenderingMaterial(this.RoleId, "ChooseCharacterMaterialController"));
			this.HuluChooseMaterialId = new int?(UiLoginSceneManager.Instance.SetHuluRenderingMaterial(this.RoleId, "ChooseCharacterMaterialController"));
		}

		// Token: 0x06049CA8 RID: 302248 RVA: 0x0131E39C File Offset: 0x0131C59C
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

		// Token: 0x06049CA9 RID: 302249 RVA: 0x0131E411 File Offset: 0x0131C611
		public void UnbindFunction()
		{
			this.Button.OnPointEnterCallBack.Unbind();
			this.Button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x04029849 RID: 170057
		private int? RoleSelectMaterialId;

		// Token: 0x0402984A RID: 170058
		private int? HuluSelectMaterialId;

		// Token: 0x0402984B RID: 170059
		private int? RoleChooseMaterialId;

		// Token: 0x0402984C RID: 170060
		private int? HuluChooseMaterialId;

		// Token: 0x0402984D RID: 170061
		private readonly UUIButtonComponent Button;

		// Token: 0x0402984E RID: 170062
		private readonly int RoleId;
	}
}
