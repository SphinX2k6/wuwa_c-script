using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001691 RID: 5777
[NullableContext(1)]
[Nullable(0)]
public class LordGymLordEntranceSelectView : UiViewBase
{
	// Token: 0x17001587 RID: 5511
	// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x0041F559 File Offset: 0x0041D759
	protected virtual string ShopTextId
	{
		get
		{
			return this._shopTextIdOverride ?? "Text_GymShopNew_Text";
		}
	}

	// Token: 0x17001588 RID: 5512
	// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x0041F56A File Offset: 0x0041D76A
	protected virtual string ConfirmTextId
	{
		get
		{
			return "NewChallenge_Start";
		}
	}

	// Token: 0x17001589 RID: 5513
	// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x0041F571 File Offset: 0x0041D771
	protected virtual int ShopTabIndex
	{
		get
		{
			return this._shopTabIndexOverride.GetValueOrDefault(3);
		}
	}

	// Token: 0x0600E0DF RID: 57567 RVA: 0x0041F57F File Offset: 0x0041D77F
	public LordGymLordEntranceSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0E0 RID: 57568 RVA: 0x0041F588 File Offset: 0x0041D788
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

	// Token: 0x0600E0E1 RID: 57569 RVA: 0x0041F648 File Offset: 0x0041D848
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymLordEntranceSelectView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymLordEntranceSelectView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0E2 RID: 57570 RVA: 0x0041F68C File Offset: 0x0041D88C
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

	// Token: 0x0600E0E3 RID: 57571 RVA: 0x0041F730 File Offset: 0x0041D930
	protected virtual void ReBuildLordEntranceList()
	{
	}

	// Token: 0x0600E0E4 RID: 57572 RVA: 0x0041F732 File Offset: 0x0041D932
	protected override void OnHandleLoadScene()
	{
		UiSceneManager.Instance.InitLordSkeletalHandle();
		LordGymController.Instance.CreateLordModelByEntranceId();
		LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, false);
	}

	// Token: 0x0600E0E5 RID: 57573 RVA: 0x0041F75B File Offset: 0x0041D95B
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x0600E0E6 RID: 57574 RVA: 0x0041F767 File Offset: 0x0041D967
	protected virtual void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E0E7 RID: 57575 RVA: 0x0041F770 File Offset: 0x0041D970
	private void OnHelpBtnClick()
	{
		int helpId = ConfigLordGymEntranceSetById.GetConfig(this.EntranceSetId, true).Value.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x0600E0E8 RID: 57576 RVA: 0x0041F7A5 File Offset: 0x0041D9A5
	private LordGymLordEntranceItem CreateLordEntranceLoopItem()
	{
		return this.CreateItem();
	}

	// Token: 0x0600E0E9 RID: 57577 RVA: 0x0041F7AD File Offset: 0x0041D9AD
	protected virtual LordGymLordEntranceItem CreateItem()
	{
		return new LordGymLordEntranceItem
		{
			OnToggleClick = new Action<int>(this.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(this.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x0600E0EA RID: 57578 RVA: 0x0041F7D8 File Offset: 0x0041D9D8
	protected void OnLordEntranceToggleClick(int index)
	{
		if (!this.CanLordEntranceToggleChange(index))
		{
			return;
		}
		this.SelectLordEntranceByIndex(index);
	}

	// Token: 0x0600E0EB RID: 57579 RVA: 0x0041F7EB File Offset: 0x0041D9EB
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

	// Token: 0x0600E0EC RID: 57580 RVA: 0x0041F824 File Offset: 0x0041DA24
	protected void ScrollEntranceIntoView(int index)
	{
		GenericScrollViewNew<LordGymLordEntranceItem, int> lordEntranceScrollView = this.LordEntranceScrollView;
		UUIItem uuiitem = (lordEntranceScrollView != null) ? lordEntranceScrollView.GetItemByIndex(index) : null;
		if (uuiitem != null)
		{
			this.LordEntranceScrollView.LateScrollTo(uuiitem, null, false);
		}
	}

	// Token: 0x0600E0ED RID: 57581 RVA: 0x0041F856 File Offset: 0x0041DA56
	private void OnLordEntranceSelect()
	{
		LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, false);
	}

	// Token: 0x0600E0EE RID: 57582 RVA: 0x0041F86C File Offset: 0x0041DA6C
	public void RefreshLordGymCurrency()
	{
		ValueTuple<int, int> lordGymCurrencyRewardAndTotalCount = LordGymModel.Instance.GetLordGymCurrencyRewardAndTotalCount(this.EntranceSetId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.ShopTextId, new <>z__ReadOnlyArray<object>(new object[]
		{
			lordGymCurrencyRewardAndTotalCount.Item1,
			lordGymCurrencyRewardAndTotalCount.Item2
		}));
	}

	// Token: 0x0600E0EF RID: 57583 RVA: 0x0041F8C8 File Offset: 0x0041DAC8
	protected bool CanLordEntranceToggleChange(int index)
	{
		return index != this.LordEntranceScrollView.GetGenericLayout().GetSelectedGridIndex();
	}

	// Token: 0x0600E0F0 RID: 57584 RVA: 0x0041F8E0 File Offset: 0x0041DAE0
	private void OnShopButtonClick()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, this.ShopTabIndex);
	}

	// Token: 0x0600E0F1 RID: 57585 RVA: 0x0041F8F3 File Offset: 0x0041DAF3
	private void OnConfirmButtonClick(int _)
	{
		this.OpenSelectView();
	}

	// Token: 0x0600E0F2 RID: 57586 RVA: 0x0041F8FC File Offset: 0x0041DAFC
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

	// Token: 0x040080DB RID: 32987
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x040080DC RID: 32988
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<LordGymLordEntranceItem, int> LordEntranceScrollView;

	// Token: 0x040080DD RID: 32989
	protected int EntranceSetId;

	// Token: 0x040080DE RID: 32990
	protected int SelectedEntranceId;

	// Token: 0x040080DF RID: 32991
	[Nullable(2)]
	protected List<int> LordEntranceList;

	// Token: 0x040080E0 RID: 32992
	[Nullable(2)]
	protected ButtonItem ConfirmButtonItem;

	// Token: 0x040080E1 RID: 32993
	[Nullable(2)]
	private string _shopTextIdOverride;

	// Token: 0x040080E2 RID: 32994
	private int? _shopTabIndexOverride;

	// Token: 0x0200786D RID: 30829
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027152 RID: 160082
		public const int CaptionItem = 0;

		// Token: 0x04027153 RID: 160083
		public const int LordEntranceScrollView = 1;

		// Token: 0x04027154 RID: 160084
		public const int LordEntranceLoopItem = 2;

		// Token: 0x04027155 RID: 160085
		public const int ShopButton = 3;

		// Token: 0x04027156 RID: 160086
		public const int ShopText = 4;

		// Token: 0x04027157 RID: 160087
		public const int ConfirmButton = 5;
	}
}
