using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007C6 RID: 1990
[NullableContext(1)]
[Nullable(0)]
public class DelegationDetailsModule : UiPanelBase
{
	// Token: 0x06005AE2 RID: 23266 RVA: 0x001D6C18 File Offset: 0x001D4E18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.OnConfirm))
		};
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x001D6DA4 File Offset: 0x001D4FA4
	private UniTask InitCostItem()
	{
		DelegationDetailsModule.<InitCostItem>d__12 <InitCostItem>d__;
		<InitCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostItem>d__.<>4__this = this;
		<InitCostItem>d__.<>1__state = -1;
		<InitCostItem>d__.<>t__builder.Start<DelegationDetailsModule.<InitCostItem>d__12>(ref <InitCostItem>d__);
		return <InitCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x001D6DE8 File Offset: 0x001D4FE8
	private UniTask InitRoleModule()
	{
		DelegationDetailsModule.<InitRoleModule>d__13 <InitRoleModule>d__;
		<InitRoleModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleModule>d__.<>4__this = this;
		<InitRoleModule>d__.<>1__state = -1;
		<InitRoleModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitRoleModule>d__13>(ref <InitRoleModule>d__);
		return <InitRoleModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x001D6E2C File Offset: 0x001D502C
	private UniTask InitCharacterListModule()
	{
		DelegationDetailsModule.<InitCharacterListModule>d__14 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitCharacterListModule>d__14>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x001D6E70 File Offset: 0x001D5070
	private UniTask InitEditTeamModule()
	{
		DelegationDetailsModule.<InitEditTeamModule>d__15 <InitEditTeamModule>d__;
		<InitEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEditTeamModule>d__.<>4__this = this;
		<InitEditTeamModule>d__.<>1__state = -1;
		<InitEditTeamModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitEditTeamModule>d__15>(ref <InitEditTeamModule>d__);
		return <InitEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x001D6EB3 File Offset: 0x001D50B3
	private void InitBtn()
	{
		this.HelperBtn = new ButtonItem(base.GetItem(14));
		this.HelperBtn.SetFunction(delegate(int _)
		{
			this.OnSkipToHelper();
		});
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x001D6EE0 File Offset: 0x001D50E0
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationDetailsModule.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationDetailsModule.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x001D6F24 File Offset: 0x001D5124
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		DelegationDetailsModule.<OnBeforeShowAsyncImplement>d__18 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DelegationDetailsModule.<OnBeforeShowAsyncImplement>d__18>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x001D6F67 File Offset: 0x001D5167
	protected override void OnAfterHide()
	{
		this.HelperBtn.UnBindGivenUid(0);
		this.SelectedRoleIdSet.Clear();
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x001D6F80 File Offset: 0x001D5180
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2)
		{
			return null;
		}
		string text = configParams[1];
		UUIItem guideUiItem = base.GetGuideUiItem(text);
		string a = text;
		if (a == "0".ToString() || a == "1".ToString() || a == "2".ToString() || a == "3".ToString() || a == "4".ToString())
		{
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}
		else
		{
			if (!(a == "EditTeam".ToString()))
			{
				return null;
			}
			EditTeamModule editTeamModule = this.EditTeamModule;
			if (editTeamModule == null)
			{
				return null;
			}
			return editTeamModule.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x001D7038 File Offset: 0x001D5238
	private void RefreshTitle()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), delegationConfig.Title, Array.Empty<object>());
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x001D7078 File Offset: 0x001D5278
	private void RefreshStar()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		this.StarLayout.RefreshByDataAsync(new List<object>(), false, new int?(delegationConfig.Star)).Forget();
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x001D70C0 File Offset: 0x001D52C0
	private void RefreshContent()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), delegationConfig.Content, Array.Empty<object>());
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x001D7100 File Offset: 0x001D5300
	private void RefreshEvaluate()
	{
		base.GetItem(4).SetUIActive(this.Data.HasBestEvaluate());
		if (this.Data.HasBestEvaluate())
		{
			base.SetTextureByPath(BusinessConfig.Instance.GetEvaluateByLevel(this.Data.BestEvaluateLevel).Icon, base.GetTexture(5), null, null);
		}
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x001D7168 File Offset: 0x001D5368
	private UniTask RefreshRecommend()
	{
		DelegationDetailsModule.<RefreshRecommend>d__25 <RefreshRecommend>d__;
		<RefreshRecommend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRecommend>d__.<>4__this = this;
		<RefreshRecommend>d__.<>1__state = -1;
		<RefreshRecommend>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshRecommend>d__25>(ref <RefreshRecommend>d__);
		return <RefreshRecommend>d__.<>t__builder.Task;
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x001D71AC File Offset: 0x001D53AC
	private UniTask RefreshCharacterList()
	{
		DelegationDetailsModule.<RefreshCharacterList>d__26 <RefreshCharacterList>d__;
		<RefreshCharacterList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCharacterList>d__.<>4__this = this;
		<RefreshCharacterList>d__.<>1__state = -1;
		<RefreshCharacterList>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshCharacterList>d__26>(ref <RefreshCharacterList>d__);
		return <RefreshCharacterList>d__.<>t__builder.Task;
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x001D71F0 File Offset: 0x001D53F0
	private UniTask RefreshEditTeamModule()
	{
		DelegationDetailsModule.<RefreshEditTeamModule>d__27 <RefreshEditTeamModule>d__;
		<RefreshEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEditTeamModule>d__.<>4__this = this;
		<RefreshEditTeamModule>d__.<>1__state = -1;
		<RefreshEditTeamModule>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshEditTeamModule>d__27>(ref <RefreshEditTeamModule>d__);
		return <RefreshEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x001D7233 File Offset: 0x001D5433
	private void RefreshRole()
	{
		this.RoleModule.Refresh(this.SelectedRoleIdSet);
	}

	// Token: 0x06005AF4 RID: 23284 RVA: 0x001D7248 File Offset: 0x001D5448
	private void RefreshConsume()
	{
		List<IItemData> consumeList = this.Data.GetConsumeList();
		IItemData itemData = consumeList[0];
		this.FirstCost.UpdateItem(itemData.ItemId, itemData.Count);
		this.FirstCost.RefreshCountEnableState();
		IItemData itemData2 = consumeList[1];
		this.SecondCost.UpdateItem(itemData2.ItemId, itemData2.Count);
		this.SecondCost.RefreshCountEnableState();
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x001D72B3 File Offset: 0x001D54B3
	private void RefreshConfirm()
	{
		base.GetButton(12).SetSelfInteractive(this.FirstCost.IsEnough && this.SecondCost.IsEnough);
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x001D72DD File Offset: 0x001D54DD
	private void RefreshRedDot()
	{
		this.HelperBtn.BindGivenUid(ERedDotName.MoonChasingRole, 0);
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x001D72F0 File Offset: 0x001D54F0
	private CharacterItem InitCharacterItem()
	{
		return new CharacterItem();
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x001D72F7 File Offset: 0x001D54F7
	private CharacterNameWithBg InitRecommendItem()
	{
		return new CharacterNameWithBg();
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x001D72FE File Offset: 0x001D54FE
	private DelegationDetailsModuleStarItem InitStarItem()
	{
		return new DelegationDetailsModuleStarItem();
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x001D7308 File Offset: 0x001D5508
	private void OnConfirm()
	{
		if (this.SelectedRoleIdSet.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_EditBattleTeamLastRole_Text", Array.Empty<object>());
			return;
		}
		if (this.SelectedRoleIdSet.Count < 3 && this.SelectedRoleIdSet.Count < this.EditTeamModule.GetDataLength())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingEditTeam);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.<OnConfirm>g__AcceptDelegateRequest|35_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.<OnConfirm>g__AcceptDelegateRequest|35_0();
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x001D7393 File Offset: 0x001D5593
	private void OnSkipToHelper()
	{
		MoonChasingController.Instance.OpenHelperView();
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x001D73A0 File Offset: 0x001D55A0
	private void RefreshDetails(int roleId, bool isSelected)
	{
		if (isSelected)
		{
			this.SelectedRoleIdSet.Add(roleId);
		}
		else
		{
			this.SelectedRoleIdSet.Remove(roleId);
		}
		DelegationRoleModule roleModule = this.RoleModule;
		if (roleModule != null)
		{
			roleModule.Refresh(this.SelectedRoleIdSet);
		}
		this.RefreshCharacterList().Forget();
		this.RefreshConfirm();
	}

	// Token: 0x06005AFD RID: 23293 RVA: 0x001D73F4 File Offset: 0x001D55F4
	private bool CanExecuteChange(int roleId, EToggleState toggle)
	{
		if (toggle == EToggleState.ETT_Checked)
		{
			return true;
		}
		if (this.SelectedRoleIdSet.Count < 3)
		{
			return true;
		}
		if (this.SelectedRoleIdSet.Contains(roleId))
		{
			return true;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("Moonfiesta_PartnerFull", Array.Empty<object>());
		return false;
	}

	// Token: 0x06005AFE RID: 23294 RVA: 0x001D7431 File Offset: 0x001D5631
	private bool IsItemSelected(int roleId)
	{
		return this.SelectedRoleIdSet.Contains(roleId);
	}

	// Token: 0x06005AFF RID: 23295 RVA: 0x001D743F File Offset: 0x001D563F
	public void SetDelegationData(DelegationData data)
	{
		this.Data = data;
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x001D7448 File Offset: 0x001D5648
	public UniTask RefreshAsync()
	{
		DelegationDetailsModule.<RefreshAsync>d__41 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshAsync>d__41>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005B04 RID: 23300 RVA: 0x001D74B0 File Offset: 0x001D56B0
	[CompilerGenerated]
	private void <OnConfirm>g__AcceptDelegateRequest|35_0()
	{
		List<int> roleIdList = new List<int>(this.SelectedRoleIdSet);
		MoonChasingController.Instance.AcceptDelegateRequest(this.Data.Id, roleIdList);
	}

	// Token: 0x04003CFA RID: 15610
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<CharacterNameWithBg, int> RecommendLayout;

	// Token: 0x04003CFB RID: 15611
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItem> CharacterListModule;

	// Token: 0x04003CFC RID: 15612
	[Nullable(2)]
	protected DelegationRoleModule RoleModule;

	// Token: 0x04003CFD RID: 15613
	protected CommonCostItem FirstCost;

	// Token: 0x04003CFE RID: 15614
	protected CommonCostItem SecondCost;

	// Token: 0x04003CFF RID: 15615
	[Nullable(2)]
	protected EditTeamModule EditTeamModule;

	// Token: 0x04003D00 RID: 15616
	protected DelegationData Data;

	// Token: 0x04003D01 RID: 15617
	protected OrderedSet<int> SelectedRoleIdSet = new OrderedSet<int>();

	// Token: 0x04003D02 RID: 15618
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	protected GenericLayout<DelegationDetailsModuleStarItem, object> StarLayout;

	// Token: 0x04003D03 RID: 15619
	protected ButtonItem HelperBtn;

	// Token: 0x02006ADB RID: 27355
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402327C RID: 143996
		public const int Title = 0;

		// Token: 0x0402327D RID: 143997
		public const int StarLayout = 1;

		// Token: 0x0402327E RID: 143998
		public const int StarItem = 2;

		// Token: 0x0402327F RID: 143999
		public const int Content = 3;

		// Token: 0x04023280 RID: 144000
		public const int BestEvaluateItem = 4;

		// Token: 0x04023281 RID: 144001
		public const int BestEvaluateTexture = 5;

		// Token: 0x04023282 RID: 144002
		public const int RecommendLayout = 6;

		// Token: 0x04023283 RID: 144003
		public const int RecommendItem = 7;

		// Token: 0x04023284 RID: 144004
		public const int CharacterListItem = 8;

		// Token: 0x04023285 RID: 144005
		public const int SelectedRoleRootItem = 9;

		// Token: 0x04023286 RID: 144006
		public const int FirstCost = 10;

		// Token: 0x04023287 RID: 144007
		public const int SecondCost = 11;

		// Token: 0x04023288 RID: 144008
		public const int ConfirmBtn = 12;

		// Token: 0x04023289 RID: 144009
		public const int RoleListRootItem = 13;

		// Token: 0x0402328A RID: 144010
		public const int HelperItem = 14;
	}
}
