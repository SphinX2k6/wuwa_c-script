using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AE8 RID: 6888
[NullableContext(2)]
[Nullable(0)]
public class PowerTipsItem : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x06011188 RID: 70024 RVA: 0x005057EC File Offset: 0x005039EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.ClickBackBtn))
		};
	}

	// Token: 0x06011189 RID: 70025 RVA: 0x005058ED File Offset: 0x00503AED
	[NullableContext(1)]
	public void SetBackBackCallBack(Action callBack)
	{
		this.BackBtnCallBack = callBack;
	}

	// Token: 0x0601118A RID: 70026 RVA: 0x005058F6 File Offset: 0x00503AF6
	private void ClickBackBtn()
	{
		Action backBtnCallBack = this.BackBtnCallBack;
		if (backBtnCallBack == null)
		{
			return;
		}
		backBtnCallBack();
	}

	// Token: 0x0601118B RID: 70027 RVA: 0x00505908 File Offset: 0x00503B08
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Energy_Title", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Energy_Text", Array.Empty<object>());
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIItem item = base.GetItem(2);
		this.ShowItem.GetOriginalItem().SetUIParent(item, false);
		this.AddEventListener();
	}

	// Token: 0x0601118C RID: 70028 RVA: 0x0050597C File Offset: 0x00503B7C
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
	}

	// Token: 0x0601118D RID: 70029 RVA: 0x0050599A File Offset: 0x00503B9A
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
	}

	// Token: 0x0601118E RID: 70030 RVA: 0x005059B8 File Offset: 0x00503BB8
	private void OnPowerChanged()
	{
		this.RefreshTitle();
		this.RefreshRecoveryText();
	}

	// Token: 0x0601118F RID: 70031 RVA: 0x005059C6 File Offset: 0x00503BC6
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x06011190 RID: 70032 RVA: 0x005059D0 File Offset: 0x00503BD0
	public void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x06011191 RID: 70033 RVA: 0x00505A00 File Offset: 0x00503C00
	public UniTask PlayCloseSequence()
	{
		PowerTipsItem.<PlayCloseSequence>d__18 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PowerTipsItem.<PlayCloseSequence>d__18>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06011192 RID: 70034 RVA: 0x00505A44 File Offset: 0x00503C44
	protected override UniTask OnCreateAsync()
	{
		PowerTipsItem.<OnCreateAsync>d__19 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<PowerTipsItem.<OnCreateAsync>d__19>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011193 RID: 70035 RVA: 0x00505A88 File Offset: 0x00503C88
	[NullableContext(1)]
	public void Refresh(ItemTipsData data)
	{
		this.CurrentData = (data as TipsOverPowerData);
		this.CurrentDataItemConfig = InventoryConfig.Instance.GetItemConfigData(this.CurrentData.ConfigId);
		this.CurrentPowerData = PowerModel.Instance.GetPowerDataById(this.CurrentData.ConfigId);
		this.ShowItem.HideExchangePopViewElement();
		PayShopGoods data2 = this.ConvertToPayShopGoods(this.CurrentData);
		this.ShowItem.Refresh(data2, false, 0);
		this.TimeHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnTimer();
		}, 1000f, 1f, null, null, true);
		this.RefreshView();
	}

	// Token: 0x06011194 RID: 70036 RVA: 0x00505B2C File Offset: 0x00503D2C
	private void RefreshView()
	{
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshBgDesc();
		this.RefreshRecoveryText();
	}

	// Token: 0x06011195 RID: 70037 RVA: 0x00505B48 File Offset: 0x00503D48
	private void RefreshRecoveryText()
	{
		EPowerRecoveryMode powerRecoveryMode = this.CurrentPowerData.GetPowerRecoveryMode();
		if (powerRecoveryMode == EPowerRecoveryMode.Full)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PowerMax", Array.Empty<object>());
			return;
		}
		if (powerRecoveryMode == EPowerRecoveryMode.Stop)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PowerStopRecovery", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PowerNextRecovery", new <>z__ReadOnlySingleElementList<object>(this.CurrentPowerData.GetNextTimerRecoverText()));
	}

	// Token: 0x06011196 RID: 70038 RVA: 0x00505BC8 File Offset: 0x00503DC8
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Energy_Number", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.CurrentPowerData.GetCurrentPower(),
			this.CurrentPowerData.GetPowerLimit()
		}));
	}

	// Token: 0x06011197 RID: 70039 RVA: 0x00505C1C File Offset: 0x00503E1C
	private void RefreshDesc()
	{
		string attributesDescription = this.CurrentDataItemConfig.AttributesDescription;
		base.GetText(3).ShowTextNew(attributesDescription);
	}

	// Token: 0x06011198 RID: 70040 RVA: 0x00505C44 File Offset: 0x00503E44
	private void RefreshBgDesc()
	{
		string bgDescription = this.CurrentDataItemConfig.BgDescription;
		if (bgDescription != null && bgDescription.Length > 0)
		{
			base.GetText(8).ShowTextNew(bgDescription);
		}
	}

	// Token: 0x06011199 RID: 70041 RVA: 0x00505C76 File Offset: 0x00503E76
	private void RefreshTime()
	{
		this.RefreshRecoveryText();
	}

	// Token: 0x0601119A RID: 70042 RVA: 0x00505C7E File Offset: 0x00503E7E
	private void OnTimer()
	{
		this.RefreshTime();
	}

	// Token: 0x0601119B RID: 70043 RVA: 0x00505C86 File Offset: 0x00503E86
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		if (this.TimeHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandle);
			this.TimeHandle = null;
		}
	}

	// Token: 0x0601119C RID: 70044 RVA: 0x00505CAE File Offset: 0x00503EAE
	public override void SetActive(bool visibility)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(visibility);
	}

	// Token: 0x0601119D RID: 70045 RVA: 0x00505CC4 File Offset: 0x00503EC4
	[NullableContext(1)]
	private PayShopGoods ConvertToPayShopGoods(TipsOverPowerData data)
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromTempData(data.ConfigId, 0);
		PayShopGoods payShopGoods = new PayShopGoods(PayShopDefine.EPayShopTabType.None);
		payShopGoods.SetGoodsData(payShopGoodsData);
		return payShopGoods;
	}

	// Token: 0x04009675 RID: 38517
	private const int GAP = 1000;

	// Token: 0x04009676 RID: 38518
	private PayShopItem ShowItem;

	// Token: 0x04009677 RID: 38519
	private TimerHandle TimeHandle;

	// Token: 0x04009678 RID: 38520
	private TipsOverPowerData CurrentData;

	// Token: 0x04009679 RID: 38521
	private PowerData CurrentPowerData;

	// Token: 0x0400967A RID: 38522
	private ItemConfig CurrentDataItemConfig;

	// Token: 0x0400967B RID: 38523
	private Action BackBtnCallBack;

	// Token: 0x0400967C RID: 38524
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007DB8 RID: 32184
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028B45 RID: 166725
		BgItem,
		// Token: 0x04028B46 RID: 166726
		TitleText,
		// Token: 0x04028B47 RID: 166727
		ShopItemPanel,
		// Token: 0x04028B48 RID: 166728
		DetailText,
		// Token: 0x04028B49 RID: 166729
		TimeText,
		// Token: 0x04028B4A RID: 166730
		BackBtn,
		// Token: 0x04028B4B RID: 166731
		WindowNameText,
		// Token: 0x04028B4C RID: 166732
		PowerDesc,
		// Token: 0x04028B4D RID: 166733
		BgDesc
	}
}
