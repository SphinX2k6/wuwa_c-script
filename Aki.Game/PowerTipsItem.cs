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

// Token: 0x020025FD RID: 9725
[NullableContext(2)]
[Nullable(0)]
public class PowerTipsItem : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x06013CA6 RID: 81062 RVA: 0x004F6A58 File Offset: 0x004F4C58
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

	// Token: 0x06013CA7 RID: 81063 RVA: 0x004F6B59 File Offset: 0x004F4D59
	[NullableContext(1)]
	public void SetBackBackCallBack(Action callBack)
	{
		this.BackBtnCallBack = callBack;
	}

	// Token: 0x06013CA8 RID: 81064 RVA: 0x004F6B62 File Offset: 0x004F4D62
	private void ClickBackBtn()
	{
		Action backBtnCallBack = this.BackBtnCallBack;
		if (backBtnCallBack == null)
		{
			return;
		}
		backBtnCallBack();
	}

	// Token: 0x06013CA9 RID: 81065 RVA: 0x004F6B74 File Offset: 0x004F4D74
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Energy_Title", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Energy_Text", Array.Empty<object>());
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIItem item = base.GetItem(2);
		this.ShowItem.GetOriginalItem().SetUIParent(item, false);
		this.AddEventListener();
	}

	// Token: 0x06013CAA RID: 81066 RVA: 0x004F6BE8 File Offset: 0x004F4DE8
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
	}

	// Token: 0x06013CAB RID: 81067 RVA: 0x004F6C06 File Offset: 0x004F4E06
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChanged));
	}

	// Token: 0x06013CAC RID: 81068 RVA: 0x004F6C24 File Offset: 0x004F4E24
	private void OnPowerChanged()
	{
		this.RefreshTitle();
		this.RefreshRecoveryText();
	}

	// Token: 0x06013CAD RID: 81069 RVA: 0x004F6C32 File Offset: 0x004F4E32
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x06013CAE RID: 81070 RVA: 0x004F6C3C File Offset: 0x004F4E3C
	public void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x06013CAF RID: 81071 RVA: 0x004F6C6C File Offset: 0x004F4E6C
	public UniTask PlayCloseSequence()
	{
		PowerTipsItem.<PlayCloseSequence>d__18 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<PowerTipsItem.<PlayCloseSequence>d__18>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06013CB0 RID: 81072 RVA: 0x004F6CB0 File Offset: 0x004F4EB0
	protected override UniTask OnCreateAsync()
	{
		PowerTipsItem.<OnCreateAsync>d__19 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<PowerTipsItem.<OnCreateAsync>d__19>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CB1 RID: 81073 RVA: 0x004F6CF4 File Offset: 0x004F4EF4
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

	// Token: 0x06013CB2 RID: 81074 RVA: 0x004F6D98 File Offset: 0x004F4F98
	private void RefreshView()
	{
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshBgDesc();
		this.RefreshRecoveryText();
	}

	// Token: 0x06013CB3 RID: 81075 RVA: 0x004F6DB4 File Offset: 0x004F4FB4
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

	// Token: 0x06013CB4 RID: 81076 RVA: 0x004F6E34 File Offset: 0x004F5034
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Energy_Number", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.CurrentPowerData.GetCurrentPower(),
			this.CurrentPowerData.GetPowerLimit()
		}));
	}

	// Token: 0x06013CB5 RID: 81077 RVA: 0x004F6E88 File Offset: 0x004F5088
	private void RefreshDesc()
	{
		string attributesDescription = this.CurrentDataItemConfig.AttributesDescription;
		base.GetText(3).ShowTextNew(attributesDescription);
	}

	// Token: 0x06013CB6 RID: 81078 RVA: 0x004F6EB0 File Offset: 0x004F50B0
	private void RefreshBgDesc()
	{
		string bgDescription = this.CurrentDataItemConfig.BgDescription;
		if (bgDescription != null && bgDescription.Length > 0)
		{
			base.GetText(8).ShowTextNew(bgDescription);
		}
	}

	// Token: 0x06013CB7 RID: 81079 RVA: 0x004F6EE2 File Offset: 0x004F50E2
	private void RefreshTime()
	{
		this.RefreshRecoveryText();
	}

	// Token: 0x06013CB8 RID: 81080 RVA: 0x004F6EEA File Offset: 0x004F50EA
	private void OnTimer()
	{
		this.RefreshTime();
	}

	// Token: 0x06013CB9 RID: 81081 RVA: 0x004F6EF2 File Offset: 0x004F50F2
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		if (this.TimeHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandle);
			this.TimeHandle = null;
		}
	}

	// Token: 0x06013CBA RID: 81082 RVA: 0x004F6F1A File Offset: 0x004F511A
	public override void SetActive(bool visibility)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(visibility);
	}

	// Token: 0x06013CBB RID: 81083 RVA: 0x004F6F30 File Offset: 0x004F5130
	[NullableContext(1)]
	private PayShopGoods ConvertToPayShopGoods(TipsOverPowerData data)
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromTempData(data.ConfigId, 0);
		PayShopGoods payShopGoods = new PayShopGoods(PayShopDefine.EPayShopTabType.None);
		payShopGoods.SetGoodsData(payShopGoodsData);
		return payShopGoods;
	}

	// Token: 0x0400951E RID: 38174
	private const int GAP = 1000;

	// Token: 0x0400951F RID: 38175
	private PayShopItem ShowItem;

	// Token: 0x04009520 RID: 38176
	private TimerHandle TimeHandle;

	// Token: 0x04009521 RID: 38177
	private TipsOverPowerData CurrentData;

	// Token: 0x04009522 RID: 38178
	private PowerData CurrentPowerData;

	// Token: 0x04009523 RID: 38179
	private ItemConfig CurrentDataItemConfig;

	// Token: 0x04009524 RID: 38180
	private Action BackBtnCallBack;

	// Token: 0x04009525 RID: 38181
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008C2F RID: 35887
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D82D RID: 186413
		BgItem,
		// Token: 0x0402D82E RID: 186414
		TitleText,
		// Token: 0x0402D82F RID: 186415
		ShopItemPanel,
		// Token: 0x0402D830 RID: 186416
		DetailText,
		// Token: 0x0402D831 RID: 186417
		TimeText,
		// Token: 0x0402D832 RID: 186418
		BackBtn,
		// Token: 0x0402D833 RID: 186419
		WindowNameText,
		// Token: 0x0402D834 RID: 186420
		PowerDesc,
		// Token: 0x0402D835 RID: 186421
		BgDesc
	}
}
