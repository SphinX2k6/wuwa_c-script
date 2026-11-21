using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007E4 RID: 2020
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsShopView : UiViewBase
{
	// Token: 0x06005C29 RID: 23593 RVA: 0x001DB7D9 File Offset: 0x001D99D9
	[NullableContext(1)]
	public BusinessTipsShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x001DB7F8 File Offset: 0x001D99F8
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

	// Token: 0x06005C2B RID: 23595 RVA: 0x001DB970 File Offset: 0x001D9B70
	private UniTask InitCharacterListModule()
	{
		BusinessTipsShopView.<InitCharacterListModule>d__16 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsShopView.<InitCharacterListModule>d__16>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x17000BC1 RID: 3009
	// (get) Token: 0x06005C2C RID: 23596 RVA: 0x001DB9B3 File Offset: 0x001D9BB3
	private bool IsShoppingMoreSuccessful
	{
		get
		{
			return ((IBusinessTipsShopData)this.OpenParam).IsMoreSuccessful;
		}
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x001DB9C8 File Offset: 0x001D9BC8
	private UniTask InitHelperRoleItem()
	{
		BusinessTipsShopView.<InitHelperRoleItem>d__19 <InitHelperRoleItem>d__;
		<InitHelperRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHelperRoleItem>d__.<>4__this = this;
		<InitHelperRoleItem>d__.<>1__state = -1;
		<InitHelperRoleItem>d__.<>t__builder.Start<BusinessTipsShopView.<InitHelperRoleItem>d__19>(ref <InitHelperRoleItem>d__);
		return <InitHelperRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x001DBA0C File Offset: 0x001D9C0C
	private UniTask InitPlayerRoleItem()
	{
		BusinessTipsShopView.<InitPlayerRoleItem>d__20 <InitPlayerRoleItem>d__;
		<InitPlayerRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerRoleItem>d__.<>4__this = this;
		<InitPlayerRoleItem>d__.<>1__state = -1;
		<InitPlayerRoleItem>d__.<>t__builder.Start<BusinessTipsShopView.<InitPlayerRoleItem>d__20>(ref <InitPlayerRoleItem>d__);
		return <InitPlayerRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005C2F RID: 23599 RVA: 0x001DBA50 File Offset: 0x001D9C50
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

	// Token: 0x06005C30 RID: 23600 RVA: 0x001DBB04 File Offset: 0x001D9D04
	private UniTask InitRoleList()
	{
		BusinessTipsShopView.<InitRoleList>d__22 <InitRoleList>d__;
		<InitRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleList>d__.<>4__this = this;
		<InitRoleList>d__.<>1__state = -1;
		<InitRoleList>d__.<>t__builder.Start<BusinessTipsShopView.<InitRoleList>d__22>(ref <InitRoleList>d__);
		return <InitRoleList>d__.<>t__builder.Task;
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x001DBB48 File Offset: 0x001D9D48
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsShopView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsShopView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x001DBB8C File Offset: 0x001D9D8C
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

	// Token: 0x06005C33 RID: 23603 RVA: 0x001DBBF4 File Offset: 0x001D9DF4
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

	// Token: 0x06005C34 RID: 23604 RVA: 0x001DBC48 File Offset: 0x001D9E48
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

	// Token: 0x06005C35 RID: 23605 RVA: 0x001DBCB8 File Offset: 0x001D9EB8
	private void OnConfirm()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x001DBCC1 File Offset: 0x001D9EC1
	private void OnSkip()
	{
		if (this.RemoveTimerHandle())
		{
			this.OnShoppingFinish();
		}
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x001DBCD1 File Offset: 0x001D9ED1
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x001DBCD8 File Offset: 0x001D9ED8
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

	// Token: 0x06005C39 RID: 23609 RVA: 0x001DBE4D File Offset: 0x001DA04D
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

	// Token: 0x06005C3A RID: 23610 RVA: 0x001DBE74 File Offset: 0x001DA074
	private void RefreshAddText()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshAddText();
		}
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x001DBECC File Offset: 0x001DA0CC
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x001DBEEC File Offset: 0x001DA0EC
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

	// Token: 0x06005C3D RID: 23613 RVA: 0x001DBFAC File Offset: 0x001DA1AC
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x001DC004 File Offset: 0x001DA204
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x001DC031 File Offset: 0x001DA231
	private void OnComplete()
	{
		this.PlayCharacterEndAction();
		this.PlayCurrentValueTween();
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x001DC040 File Offset: 0x001DA240
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x04003D75 RID: 15733
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003D76 RID: 15734
	protected BusinessShopRoleItem HelperRoleItem;

	// Token: 0x04003D77 RID: 15735
	protected BusinessShopRoleItem PlayerRoleItem;

	// Token: 0x04003D78 RID: 15736
	[Nullable(1)]
	protected List<int> RoleIdList = new List<int>();

	// Token: 0x04003D79 RID: 15737
	[Nullable(1)]
	private List<CharacterData> CharacterList = new List<CharacterData>();

	// Token: 0x04003D7A RID: 15738
	protected ULTweener ExpTweener;

	// Token: 0x04003D7B RID: 15739
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003D7C RID: 15740
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003D7D RID: 15741
	protected TimerHandle TimeHandle;

	// Token: 0x04003D7E RID: 15742
	private bool IsShoppingLevelUp;

	// Token: 0x04003D7F RID: 15743
	private const float SHOP_TWEEN_TIME = 1f;

	// Token: 0x04003D80 RID: 15744
	private const float VALUE_TIME = 0.5f;

	// Token: 0x04003D81 RID: 15745
	private const int SHOPPING_TIME = 2000;

	// Token: 0x02006B1C RID: 27420
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040233AA RID: 144298
		public const int Title = 0;

		// Token: 0x040233AB RID: 144299
		public const int CharacterListItem = 1;

		// Token: 0x040233AC RID: 144300
		public const int SingleLevelItem = 2;

		// Token: 0x040233AD RID: 144301
		public const int SingleLevel = 3;

		// Token: 0x040233AE RID: 144302
		public const int MultiLevelItem = 4;

		// Token: 0x040233AF RID: 144303
		public const int MultiLevelBefore = 5;

		// Token: 0x040233B0 RID: 144304
		public const int MultiLevelAfter = 6;

		// Token: 0x040233B1 RID: 144305
		public const int ConfirmBtn = 7;

		// Token: 0x040233B2 RID: 144306
		public const int BestSuccessItem = 8;

		// Token: 0x040233B3 RID: 144307
		public const int ShoppingItem = 9;

		// Token: 0x040233B4 RID: 144308
		public const int PlayerRoleItem = 10;

		// Token: 0x040233B5 RID: 144309
		public const int HelpRoleItem = 11;

		// Token: 0x040233B6 RID: 144310
		public const int SkipBtn = 12;
	}
}
