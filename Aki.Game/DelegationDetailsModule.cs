using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001312 RID: 4882
[NullableContext(1)]
[Nullable(0)]
public class DelegationDetailsModule : UiPanelBase
{
	// Token: 0x06008747 RID: 34631 RVA: 0x001CDDAC File Offset: 0x001CBFAC
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

	// Token: 0x06008748 RID: 34632 RVA: 0x001CDF38 File Offset: 0x001CC138
	private UniTask InitCostItem()
	{
		DelegationDetailsModule.<InitCostItem>d__12 <InitCostItem>d__;
		<InitCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostItem>d__.<>4__this = this;
		<InitCostItem>d__.<>1__state = -1;
		<InitCostItem>d__.<>t__builder.Start<DelegationDetailsModule.<InitCostItem>d__12>(ref <InitCostItem>d__);
		return <InitCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008749 RID: 34633 RVA: 0x001CDF7C File Offset: 0x001CC17C
	private UniTask InitRoleModule()
	{
		DelegationDetailsModule.<InitRoleModule>d__13 <InitRoleModule>d__;
		<InitRoleModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleModule>d__.<>4__this = this;
		<InitRoleModule>d__.<>1__state = -1;
		<InitRoleModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitRoleModule>d__13>(ref <InitRoleModule>d__);
		return <InitRoleModule>d__.<>t__builder.Task;
	}

	// Token: 0x0600874A RID: 34634 RVA: 0x001CDFC0 File Offset: 0x001CC1C0
	private UniTask InitCharacterListModule()
	{
		DelegationDetailsModule.<InitCharacterListModule>d__14 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitCharacterListModule>d__14>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x0600874B RID: 34635 RVA: 0x001CE004 File Offset: 0x001CC204
	private UniTask InitEditTeamModule()
	{
		DelegationDetailsModule.<InitEditTeamModule>d__15 <InitEditTeamModule>d__;
		<InitEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEditTeamModule>d__.<>4__this = this;
		<InitEditTeamModule>d__.<>1__state = -1;
		<InitEditTeamModule>d__.<>t__builder.Start<DelegationDetailsModule.<InitEditTeamModule>d__15>(ref <InitEditTeamModule>d__);
		return <InitEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x0600874C RID: 34636 RVA: 0x001CE047 File Offset: 0x001CC247
	private void InitBtn()
	{
		this.HelperBtn = new ButtonItem(base.GetItem(14));
		this.HelperBtn.SetFunction(delegate(int _)
		{
			this.OnSkipToHelper();
		});
	}

	// Token: 0x0600874D RID: 34637 RVA: 0x001CE074 File Offset: 0x001CC274
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationDetailsModule.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationDetailsModule.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600874E RID: 34638 RVA: 0x001CE0B8 File Offset: 0x001CC2B8
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		DelegationDetailsModule.<OnBeforeShowAsyncImplement>d__18 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DelegationDetailsModule.<OnBeforeShowAsyncImplement>d__18>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600874F RID: 34639 RVA: 0x001CE0FB File Offset: 0x001CC2FB
	protected override void OnAfterHide()
	{
		this.HelperBtn.UnBindGivenUid(0);
		this.SelectedRoleIdSet.Clear();
	}

	// Token: 0x06008750 RID: 34640 RVA: 0x001CE114 File Offset: 0x001CC314
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

	// Token: 0x06008751 RID: 34641 RVA: 0x001CE1CC File Offset: 0x001CC3CC
	private void RefreshTitle()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), delegationConfig.Title, Array.Empty<object>());
	}

	// Token: 0x06008752 RID: 34642 RVA: 0x001CE20C File Offset: 0x001CC40C
	private void RefreshStar()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		this.StarLayout.RefreshByDataAsync(new List<object>(), false, new int?(delegationConfig.Star)).Forget();
	}

	// Token: 0x06008753 RID: 34643 RVA: 0x001CE254 File Offset: 0x001CC454
	private void RefreshContent()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), delegationConfig.Content, Array.Empty<object>());
	}

	// Token: 0x06008754 RID: 34644 RVA: 0x001CE294 File Offset: 0x001CC494
	private void RefreshEvaluate()
	{
		base.GetItem(4).SetUIActive(this.Data.HasBestEvaluate());
		if (this.Data.HasBestEvaluate())
		{
			base.SetTextureByPath(BusinessConfig.Instance.GetEvaluateByLevel(this.Data.BestEvaluateLevel).Icon, base.GetTexture(5), null, null);
		}
	}

	// Token: 0x06008755 RID: 34645 RVA: 0x001CE2FC File Offset: 0x001CC4FC
	private UniTask RefreshRecommend()
	{
		DelegationDetailsModule.<RefreshRecommend>d__25 <RefreshRecommend>d__;
		<RefreshRecommend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRecommend>d__.<>4__this = this;
		<RefreshRecommend>d__.<>1__state = -1;
		<RefreshRecommend>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshRecommend>d__25>(ref <RefreshRecommend>d__);
		return <RefreshRecommend>d__.<>t__builder.Task;
	}

	// Token: 0x06008756 RID: 34646 RVA: 0x001CE340 File Offset: 0x001CC540
	private UniTask RefreshCharacterList()
	{
		DelegationDetailsModule.<RefreshCharacterList>d__26 <RefreshCharacterList>d__;
		<RefreshCharacterList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCharacterList>d__.<>4__this = this;
		<RefreshCharacterList>d__.<>1__state = -1;
		<RefreshCharacterList>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshCharacterList>d__26>(ref <RefreshCharacterList>d__);
		return <RefreshCharacterList>d__.<>t__builder.Task;
	}

	// Token: 0x06008757 RID: 34647 RVA: 0x001CE384 File Offset: 0x001CC584
	private UniTask RefreshEditTeamModule()
	{
		DelegationDetailsModule.<RefreshEditTeamModule>d__27 <RefreshEditTeamModule>d__;
		<RefreshEditTeamModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEditTeamModule>d__.<>4__this = this;
		<RefreshEditTeamModule>d__.<>1__state = -1;
		<RefreshEditTeamModule>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshEditTeamModule>d__27>(ref <RefreshEditTeamModule>d__);
		return <RefreshEditTeamModule>d__.<>t__builder.Task;
	}

	// Token: 0x06008758 RID: 34648 RVA: 0x001CE3C7 File Offset: 0x001CC5C7
	private void RefreshRole()
	{
		this.RoleModule.Refresh(this.SelectedRoleIdSet);
	}

	// Token: 0x06008759 RID: 34649 RVA: 0x001CE3DC File Offset: 0x001CC5DC
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

	// Token: 0x0600875A RID: 34650 RVA: 0x001CE447 File Offset: 0x001CC647
	private void RefreshConfirm()
	{
		base.GetButton(12).SetSelfInteractive(this.FirstCost.IsEnough && this.SecondCost.IsEnough);
	}

	// Token: 0x0600875B RID: 34651 RVA: 0x001CE471 File Offset: 0x001CC671
	private void RefreshRedDot()
	{
		this.HelperBtn.BindGivenUid(ERedDotName.MoonChasingRole, 0);
	}

	// Token: 0x0600875C RID: 34652 RVA: 0x001CE484 File Offset: 0x001CC684
	private CharacterItem InitCharacterItem()
	{
		return new CharacterItem();
	}

	// Token: 0x0600875D RID: 34653 RVA: 0x001CE48B File Offset: 0x001CC68B
	private CharacterNameWithBg InitRecommendItem()
	{
		return new CharacterNameWithBg();
	}

	// Token: 0x0600875E RID: 34654 RVA: 0x001CE492 File Offset: 0x001CC692
	private DelegationDetailsModuleStarItem InitStarItem()
	{
		return new DelegationDetailsModuleStarItem();
	}

	// Token: 0x0600875F RID: 34655 RVA: 0x001CE49C File Offset: 0x001CC69C
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

	// Token: 0x06008760 RID: 34656 RVA: 0x001CE527 File Offset: 0x001CC727
	private void OnSkipToHelper()
	{
		MoonChasingController.Instance.OpenHelperView();
	}

	// Token: 0x06008761 RID: 34657 RVA: 0x001CE534 File Offset: 0x001CC734
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

	// Token: 0x06008762 RID: 34658 RVA: 0x001CE588 File Offset: 0x001CC788
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

	// Token: 0x06008763 RID: 34659 RVA: 0x001CE5C5 File Offset: 0x001CC7C5
	private bool IsItemSelected(int roleId)
	{
		return this.SelectedRoleIdSet.Contains(roleId);
	}

	// Token: 0x06008764 RID: 34660 RVA: 0x001CE5D3 File Offset: 0x001CC7D3
	public void SetDelegationData(DelegationData data)
	{
		this.Data = data;
	}

	// Token: 0x06008765 RID: 34661 RVA: 0x001CE5DC File Offset: 0x001CC7DC
	public UniTask RefreshAsync()
	{
		DelegationDetailsModule.<RefreshAsync>d__41 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<DelegationDetailsModule.<RefreshAsync>d__41>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008769 RID: 34665 RVA: 0x001CE644 File Offset: 0x001CC844
	[CompilerGenerated]
	private void <OnConfirm>g__AcceptDelegateRequest|35_0()
	{
		List<int> roleIdList = this.SelectedRoleIdSet.ToList<int>();
		MoonChasingController.Instance.AcceptDelegateRequest(this.Data.Id, roleIdList);
	}

	// Token: 0x04003C62 RID: 15458
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<CharacterNameWithBg, int> RecommendLayout;

	// Token: 0x04003C63 RID: 15459
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItem> CharacterListModule;

	// Token: 0x04003C64 RID: 15460
	[Nullable(2)]
	protected DelegationRoleModule RoleModule;

	// Token: 0x04003C65 RID: 15461
	protected CommonCostItem FirstCost;

	// Token: 0x04003C66 RID: 15462
	protected CommonCostItem SecondCost;

	// Token: 0x04003C67 RID: 15463
	[Nullable(2)]
	protected EditTeamModule EditTeamModule;

	// Token: 0x04003C68 RID: 15464
	protected DelegationData Data;

	// Token: 0x04003C69 RID: 15465
	protected OrderedSet<int> SelectedRoleIdSet = new OrderedSet<int>();

	// Token: 0x04003C6A RID: 15466
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	protected GenericLayout<DelegationDetailsModuleStarItem, object> StarLayout;

	// Token: 0x04003C6B RID: 15467
	protected ButtonItem HelperBtn;

	// Token: 0x02007951 RID: 31057
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F4F RID: 163663
		public const int Title = 0;

		// Token: 0x04027F50 RID: 163664
		public const int StarLayout = 1;

		// Token: 0x04027F51 RID: 163665
		public const int StarItem = 2;

		// Token: 0x04027F52 RID: 163666
		public const int Content = 3;

		// Token: 0x04027F53 RID: 163667
		public const int BestEvaluateItem = 4;

		// Token: 0x04027F54 RID: 163668
		public const int BestEvaluateTexture = 5;

		// Token: 0x04027F55 RID: 163669
		public const int RecommendLayout = 6;

		// Token: 0x04027F56 RID: 163670
		public const int RecommendItem = 7;

		// Token: 0x04027F57 RID: 163671
		public const int CharacterListItem = 8;

		// Token: 0x04027F58 RID: 163672
		public const int SelectedRoleRootItem = 9;

		// Token: 0x04027F59 RID: 163673
		public const int FirstCost = 10;

		// Token: 0x04027F5A RID: 163674
		public const int SecondCost = 11;

		// Token: 0x04027F5B RID: 163675
		public const int ConfirmBtn = 12;

		// Token: 0x04027F5C RID: 163676
		public const int RoleListRootItem = 13;

		// Token: 0x04027F5D RID: 163677
		public const int HelperItem = 14;
	}
}
