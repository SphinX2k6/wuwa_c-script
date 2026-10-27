using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021AD RID: 8621
[NullableContext(1)]
[Nullable(0)]
public class LordGymLordEntranceSelectView : UiViewBase
{
	// Token: 0x17001550 RID: 5456
	// (get) Token: 0x06010C4B RID: 68683 RVA: 0x00412C71 File Offset: 0x00410E71
	protected virtual string ShopTextId
	{
		get
		{
			return this._shopTextIdOverride ?? "Text_GymShopNew_Text";
		}
	}

	// Token: 0x17001551 RID: 5457
	// (get) Token: 0x06010C4C RID: 68684 RVA: 0x00412C82 File Offset: 0x00410E82
	protected virtual string ConfirmTextId
	{
		get
		{
			return "NewChallenge_Start";
		}
	}

	// Token: 0x17001552 RID: 5458
	// (get) Token: 0x06010C4D RID: 68685 RVA: 0x00412C89 File Offset: 0x00410E89
	protected virtual int ShopTabIndex
	{
		get
		{
			return this._shopTabIndexOverride.GetValueOrDefault(3);
		}
	}

	// Token: 0x06010C4E RID: 68686 RVA: 0x00412C97 File Offset: 0x00410E97
	public LordGymLordEntranceSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C4F RID: 68687 RVA: 0x00412CA0 File Offset: 0x00410EA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnShopButtonClick))
		};
	}

	// Token: 0x06010C50 RID: 68688 RVA: 0x00412D60 File Offset: 0x00410F60
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymLordEntranceSelectView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymLordEntranceSelectView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C51 RID: 68689 RVA: 0x00412DA4 File Offset: 0x00410FA4
	protected virtual void InitSelect()
	{
		int index = 0;
		int lastChallengeLordEntranceId = LordGymModel.Instance.LastChallengeLordEntranceId;
		if (lastChallengeLordEntranceId > 0)
		{
			for (int i = 0; i < this.LordEntranceList.Count; i++)
			{
				if (this.LordEntranceList[i] == lastChallengeLordEntranceId)
				{
					index = i;
					break;
				}
			}
		}
		this.SelectLordEntranceByIndex(index);
		this.RefreshLordGymCurrency();
		LordGymModel instance = LordGymModel.Instance;
		foreach (int entranceId in this.LordEntranceList)
		{
			instance.RecordNewLordGymEntrance(entranceId);
		}
	}

	// Token: 0x06010C52 RID: 68690 RVA: 0x00412E48 File Offset: 0x00411048
	protected virtual void ReBuildLordEntranceList()
	{
	}

	// Token: 0x06010C53 RID: 68691 RVA: 0x00412E4A File Offset: 0x0041104A
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, false);
	}

	// Token: 0x06010C54 RID: 68692 RVA: 0x00412E73 File Offset: 0x00411073
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x06010C55 RID: 68693 RVA: 0x00412E7F File Offset: 0x0041107F
	protected virtual void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010C56 RID: 68694 RVA: 0x00412E88 File Offset: 0x00411088
	private void OnHelpBtnClick()
	{
		int helpId = ConfigLordGymEntranceSetById.GetConfig(this.EntranceSetId, true).Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06010C57 RID: 68695 RVA: 0x00412EBD File Offset: 0x004110BD
	private LordGymLordEntranceItem CreateLordEntranceLoopItem()
	{
		return this.CreateItem();
	}

	// Token: 0x06010C58 RID: 68696 RVA: 0x00412EC5 File Offset: 0x004110C5
	protected virtual LordGymLordEntranceItem CreateItem()
	{
		return new LordGymLordEntranceItem
		{
			OnToggleClick = new Action<int>(this.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(this.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x06010C59 RID: 68697 RVA: 0x00412EF0 File Offset: 0x004110F0
	protected void OnLordEntranceToggleClick(int index)
	{
		if (!this.CanLordEntranceToggleChange(index))
		{
			return;
		}
		this.SelectLordEntranceByIndex(index);
	}

	// Token: 0x06010C5A RID: 68698 RVA: 0x00412F03 File Offset: 0x00411103
	public virtual void SelectLordEntranceByIndex(int index)
	{
		GenericScrollViewNew<LordGymLordEntranceItem, int> lordEntranceScrollView = this.LordEntranceScrollView;
		if (lordEntranceScrollView != null)
		{
			GenericLayout<LordGymLordEntranceItem, int> genericLayout = lordEntranceScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(index, false);
			}
		}
		this.SelectedEntranceId = this.LordEntranceList[index];
		this.OnLordEntranceSelect();
	}

	// Token: 0x06010C5B RID: 68699 RVA: 0x00412F3C File Offset: 0x0041113C
	protected void ScrollEntranceIntoView(int index)
	{
		GenericScrollViewNew<LordGymLordEntranceItem, int> lordEntranceScrollView = this.LordEntranceScrollView;
		UUIItem uuiitem = (lordEntranceScrollView != null) ? lordEntranceScrollView.GetItemByIndex(index) : null;
		if (uuiitem != null)
		{
			this.LordEntranceScrollView.LateScrollTo(uuiitem, null, false);
		}
	}

	// Token: 0x06010C5C RID: 68700 RVA: 0x00412F6E File Offset: 0x0041116E
	private void OnLordEntranceSelect()
	{
		LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, false);
	}

	// Token: 0x06010C5D RID: 68701 RVA: 0x00412F84 File Offset: 0x00411184
	public void RefreshLordGymCurrency()
	{
		ValueTuple<int, int> lordGymCurrencyRewardAndTotalCount = LordGymModel.Instance.GetLordGymCurrencyRewardAndTotalCount(this.EntranceSetId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.ShopTextId, new <>z__ReadOnlyArray<object>(new object[]
		{
			lordGymCurrencyRewardAndTotalCount.Item1,
			lordGymCurrencyRewardAndTotalCount.Item2
		}));
	}

	// Token: 0x06010C5E RID: 68702 RVA: 0x00412FE0 File Offset: 0x004111E0
	protected bool CanLordEntranceToggleChange(int index)
	{
		return index != this.LordEntranceScrollView.GetGenericLayout().GetSelectedGridIndex();
	}

	// Token: 0x06010C5F RID: 68703 RVA: 0x00412FF8 File Offset: 0x004111F8
	private void OnShopButtonClick()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, this.ShopTabIndex);
	}

	// Token: 0x06010C60 RID: 68704 RVA: 0x0041300B File Offset: 0x0041120B
	private void OnConfirmButtonClick(int _)
	{
		this.OpenSelectView();
	}

	// Token: 0x06010C61 RID: 68705 RVA: 0x00413014 File Offset: 0x00411214
	protected virtual void OpenSelectView()
	{
		LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
		{
			LordEntranceSetId = this.EntranceSetId,
			LordEntranceId = this.SelectedEntranceId,
			IsPlaySpecialSequence = false
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymDifficultySelectView, param, null);
	}

	// Token: 0x04007F94 RID: 32660
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04007F95 RID: 32661
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<LordGymLordEntranceItem, int> LordEntranceScrollView;

	// Token: 0x04007F96 RID: 32662
	protected int EntranceSetId;

	// Token: 0x04007F97 RID: 32663
	protected int SelectedEntranceId;

	// Token: 0x04007F98 RID: 32664
	[Nullable(2)]
	protected List<int> LordEntranceList;

	// Token: 0x04007F99 RID: 32665
	[Nullable(2)]
	protected ButtonItem ConfirmButtonItem;

	// Token: 0x04007F9A RID: 32666
	[Nullable(2)]
	private string _shopTextIdOverride;

	// Token: 0x04007F9B RID: 32667
	private int? _shopTabIndexOverride;

	// Token: 0x020086E2 RID: 34530
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402BE31 RID: 179761
		public const int CaptionItem = 0;

		// Token: 0x0402BE32 RID: 179762
		public const int LordEntranceScrollView = 1;

		// Token: 0x0402BE33 RID: 179763
		public const int LordEntranceLoopItem = 2;

		// Token: 0x0402BE34 RID: 179764
		public const int ShopButton = 3;

		// Token: 0x0402BE35 RID: 179765
		public const int ShopText = 4;

		// Token: 0x0402BE36 RID: 179766
		public const int ConfirmButton = 5;
	}
}
