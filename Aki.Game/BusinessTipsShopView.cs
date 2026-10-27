using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001330 RID: 4912
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsShopView : UiViewBase
{
	// Token: 0x0600888E RID: 34958 RVA: 0x001D296D File Offset: 0x001D0B6D
	[NullableContext(1)]
	public BusinessTipsShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600888F RID: 34959 RVA: 0x001D298C File Offset: 0x001D0B8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnConfirm)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnSkip))
		};
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x001D2B04 File Offset: 0x001D0D04
	private UniTask InitCharacterListModule()
	{
		BusinessTipsShopView.<InitCharacterListModule>d__16 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsShopView.<InitCharacterListModule>d__16>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x17000BA1 RID: 2977
	// (get) Token: 0x06008891 RID: 34961 RVA: 0x001D2B47 File Offset: 0x001D0D47
	private bool IsShoppingMoreSuccessful
	{
		get
		{
			return ((IBusinessTipsShopData)this.OpenParam).IsMoreSuccessful;
		}
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x001D2B5C File Offset: 0x001D0D5C
	private UniTask InitHelperRoleItem()
	{
		BusinessTipsShopView.<InitHelperRoleItem>d__19 <InitHelperRoleItem>d__;
		<InitHelperRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHelperRoleItem>d__.<>4__this = this;
		<InitHelperRoleItem>d__.<>1__state = -1;
		<InitHelperRoleItem>d__.<>t__builder.Start<BusinessTipsShopView.<InitHelperRoleItem>d__19>(ref <InitHelperRoleItem>d__);
		return <InitHelperRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008893 RID: 34963 RVA: 0x001D2BA0 File Offset: 0x001D0DA0
	private UniTask InitPlayerRoleItem()
	{
		BusinessTipsShopView.<InitPlayerRoleItem>d__20 <InitPlayerRoleItem>d__;
		<InitPlayerRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerRoleItem>d__.<>4__this = this;
		<InitPlayerRoleItem>d__.<>1__state = -1;
		<InitPlayerRoleItem>d__.<>t__builder.Start<BusinessTipsShopView.<InitPlayerRoleItem>d__20>(ref <InitPlayerRoleItem>d__);
		return <InitPlayerRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x001D2BE4 File Offset: 0x001D0DE4
	private void InitLevelItem()
	{
		IBusinessTipsShopData businessTipsShopData = (IBusinessTipsShopData)this.OpenParam;
		int roleId = businessTipsShopData.RoleId;
		EditTeamData editTeamDataById = MoonChasingBusinessModel.Instance.GetEditTeamDataById(roleId);
		this.IsShoppingLevelUp = (editTeamDataById.Level > businessTipsShopData.LastData.Level);
		if (this.IsShoppingLevelUp)
		{
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(businessTipsShopData.LastData.Level.ToString(), true);
			}
			UUIText text2 = base.GetText(6);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(editTeamDataById.Level.ToString(), true);
			return;
		}
		else
		{
			UUIText text3 = base.GetText(3);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(editTeamDataById.Level.ToString(), true);
			return;
		}
	}

	// Token: 0x06008895 RID: 34965 RVA: 0x001D2C98 File Offset: 0x001D0E98
	private UniTask InitRoleList()
	{
		BusinessTipsShopView.<InitRoleList>d__22 <InitRoleList>d__;
		<InitRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleList>d__.<>4__this = this;
		<InitRoleList>d__.<>1__state = -1;
		<InitRoleList>d__.<>t__builder.Start<BusinessTipsShopView.<InitRoleList>d__22>(ref <InitRoleList>d__);
		return <InitRoleList>d__.<>t__builder.Task;
	}

	// Token: 0x06008896 RID: 34966 RVA: 0x001D2CDC File Offset: 0x001D0EDC
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsShopView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsShopView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x001D2D20 File Offset: 0x001D0F20
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Moonfiesta_PartnerTip5", Array.Empty<object>());
		this.TimeHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimeHandle = null;
			this.OnShoppingFinish();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06008898 RID: 34968 RVA: 0x001D2D88 File Offset: 0x001D0F88
	protected override void OnBeforeDestroy()
	{
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayFillAmount));
			this.Delegate = null;
		}
		if (this.ValueDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayCurrentValue));
			this.ValueDelegate = null;
		}
		this.StopTween();
	}

	// Token: 0x06008899 RID: 34969 RVA: 0x001D2DDC File Offset: 0x001D0FDC
	private void PlayFillAmount(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshProgressAdd(value);
			if (value == 1f)
			{
				characterItemWithAdd.RefreshProgress(value);
				characterItemWithAdd.SetLightProgressWidth();
			}
		}
	}

	// Token: 0x0600889A RID: 34970 RVA: 0x001D2E4C File Offset: 0x001D104C
	private void OnConfirm()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x001D2E55 File Offset: 0x001D1055
	private void OnSkip()
	{
		if (this.RemoveTimerHandle())
		{
			this.OnShoppingFinish();
		}
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x001D2E65 File Offset: 0x001D1065
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x001D2E6C File Offset: 0x001D106C
	private void OnShoppingFinish()
	{
		if (this.IsShoppingLevelUp)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequencePurely("Success", false, false);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}
		else
		{
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.PlaySequencePurely("Fail", false, false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
		}
		if (this.IsShoppingMoreSuccessful)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Moonfiesta_TravelGreatSuccess", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Moonfiesta_PartnerTip4", Array.Empty<object>());
		}
		IBusinessTipsShopData businessTipsShopData = (IBusinessTipsShopData)this.OpenParam;
		CharacterListModule<CharacterItemWithAdd> characterListModule = this.CharacterListModule;
		if (characterListModule != null)
		{
			characterListModule.SetActive(true);
		}
		this.RefreshAddText();
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(true);
		}
		TrainRoleDialog trainRoleDialogByIdAndType = BusinessConfig.Instance.GetTrainRoleDialogByIdAndType(businessTipsShopData.RoleId, businessTipsShopData.TrainType);
		BusinessShopRoleItem helperRoleItem = this.HelperRoleItem;
		if (helperRoleItem != null)
		{
			helperRoleItem.ShowDialog(trainRoleDialogByIdAndType.Dialog);
		}
		BusinessShopRoleItem helperRoleItem2 = this.HelperRoleItem;
		if (helperRoleItem2 != null)
		{
			helperRoleItem2.SwitchRoleSpineAnim(ESpineAnimation.Success, 0f);
		}
		BusinessShopRoleItem playerRoleItem = this.PlayerRoleItem;
		if (playerRoleItem != null)
		{
			playerRoleItem.SwitchRoleSpineAnim(ESpineAnimation.Success, 0f);
		}
		AudioSystem.Instance.ExecuteAction("play_ui_zuiyuejie_loading", EAudioActionType.Stop, null);
		this.PlayCharacterRunFinishAction();
	}

	// Token: 0x0600889E RID: 34974 RVA: 0x001D2FE1 File Offset: 0x001D11E1
	protected bool RemoveTimerHandle()
	{
		if (this.TimeHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandle);
			this.TimeHandle = null;
			return true;
		}
		return false;
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x001D3008 File Offset: 0x001D1208
	private void RefreshAddText()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshAddText();
		}
	}

	// Token: 0x060088A0 RID: 34976 RVA: 0x001D3060 File Offset: 0x001D1260
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x060088A1 RID: 34977 RVA: 0x001D3080 File Offset: 0x001D1280
	private void PlayCharacterRunFinishAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.SetLightProgressWidth();
			characterItemWithAdd.PlayAddAction();
			characterItemWithAdd.RefreshAddText();
		}
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, 0f, 1f, 1f, 0f, LTweenEase.OutCubic);
		ULTweener expTweener = this.ExpTweener;
		if (expTweener != null)
		{
			expTweener.OnCompleteCallBack.Bind(new Action(this.OnComplete));
		}
		AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_favorability");
	}

	// Token: 0x060088A2 RID: 34978 RVA: 0x001D3140 File Offset: 0x001D1340
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x001D3198 File Offset: 0x001D1398
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x060088A4 RID: 34980 RVA: 0x001D31C5 File Offset: 0x001D13C5
	private void OnComplete()
	{
		this.PlayCharacterEndAction();
		this.PlayCurrentValueTween();
	}

	// Token: 0x060088A5 RID: 34981 RVA: 0x001D31D4 File Offset: 0x001D13D4
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x04003CDD RID: 15581
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003CDE RID: 15582
	protected BusinessShopRoleItem HelperRoleItem;

	// Token: 0x04003CDF RID: 15583
	protected BusinessShopRoleItem PlayerRoleItem;

	// Token: 0x04003CE0 RID: 15584
	[Nullable(1)]
	protected List<int> RoleIdList = new List<int>();

	// Token: 0x04003CE1 RID: 15585
	[Nullable(1)]
	private List<CharacterData> CharacterList = new List<CharacterData>();

	// Token: 0x04003CE2 RID: 15586
	protected ULTweener ExpTweener;

	// Token: 0x04003CE3 RID: 15587
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003CE4 RID: 15588
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003CE5 RID: 15589
	protected TimerHandle TimeHandle;

	// Token: 0x04003CE6 RID: 15590
	private bool IsShoppingLevelUp;

	// Token: 0x04003CE7 RID: 15591
	private const float SHOP_TWEEN_TIME = 1f;

	// Token: 0x04003CE8 RID: 15592
	private const float VALUE_TIME = 0.5f;

	// Token: 0x04003CE9 RID: 15593
	private const int SHOPPING_TIME = 2000;

	// Token: 0x02007992 RID: 31122
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402807D RID: 163965
		public const int Title = 0;

		// Token: 0x0402807E RID: 163966
		public const int CharacterListItem = 1;

		// Token: 0x0402807F RID: 163967
		public const int SingleLevelItem = 2;

		// Token: 0x04028080 RID: 163968
		public const int SingleLevel = 3;

		// Token: 0x04028081 RID: 163969
		public const int MultiLevelItem = 4;

		// Token: 0x04028082 RID: 163970
		public const int MultiLevelBefore = 5;

		// Token: 0x04028083 RID: 163971
		public const int MultiLevelAfter = 6;

		// Token: 0x04028084 RID: 163972
		public const int ConfirmBtn = 7;

		// Token: 0x04028085 RID: 163973
		public const int BestSuccessItem = 8;

		// Token: 0x04028086 RID: 163974
		public const int ShoppingItem = 9;

		// Token: 0x04028087 RID: 163975
		public const int PlayerRoleItem = 10;

		// Token: 0x04028088 RID: 163976
		public const int HelpRoleItem = 11;

		// Token: 0x04028089 RID: 163977
		public const int SkipBtn = 12;
	}
}
