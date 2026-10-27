using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200175D RID: 5981
[NullableContext(2)]
[Nullable(0)]
public class VisionRecoverySlotItem : UiPanelBase
{
	// Token: 0x0600AD19 RID: 44313 RVA: 0x0026E885 File Offset: 0x0026CA85
	public VisionRecoverySlotItem(Action<bool, PhantomItemData> callBack = null, bool showRemoveBtn = true)
	{
		this.ClickCallBack = callBack;
		this.ShowRemoveBtn = showRemoveBtn;
	}

	// Token: 0x0600AD1A RID: 44314 RVA: 0x0026E89C File Offset: 0x0026CA9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(0, typeof(UUISpriteTransition)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickAddButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickRemoveButton))
		};
	}

	// Token: 0x0600AD1B RID: 44315 RVA: 0x0026E9E4 File Offset: 0x0026CBE4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoverySlotItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoverySlotItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD1C RID: 44316 RVA: 0x0026EA28 File Offset: 0x0026CC28
	protected override void OnStart()
	{
		this.RefreshUi(this.VisionData);
		bool enable = this.ClickCallBack != null;
		base.GetUiSpriteTransition(0).SetEnable(enable);
		base.GetItem(7).SetUIActive(false);
		this.OnAddEvent();
	}

	// Token: 0x0600AD1D RID: 44317 RVA: 0x0026EA6B File Offset: 0x0026CC6B
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEvent();
	}

	// Token: 0x0600AD1E RID: 44318 RVA: 0x0026EA73 File Offset: 0x0026CC73
	private void OnAddEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
	}

	// Token: 0x0600AD1F RID: 44319 RVA: 0x0026EA91 File Offset: 0x0026CC91
	private void OnRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
	}

	// Token: 0x0600AD20 RID: 44320 RVA: 0x0026EAAF File Offset: 0x0026CCAF
	public void RefreshUi(PhantomItemData data)
	{
		this.VisionData = data;
		if (data == null)
		{
			this.RefreshEmpty();
			return;
		}
		this.RefreshByData(data);
	}

	// Token: 0x0600AD21 RID: 44321 RVA: 0x0026EACC File Offset: 0x0026CCCC
	public void RefreshEmpty()
	{
		base.GetItem(1).SetUIActive(true);
		base.GetTexture(2).SetUIActive(false);
		base.GetSprite(3).SetUIActive(false);
		base.GetButton(5).RootUIComp.Get().SetUIActive(false);
		this.VisionElementItem.SetUiActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0600AD22 RID: 44322 RVA: 0x0026EB50 File Offset: 0x0026CD50
	[NullableContext(1)]
	public void RefreshByData(PhantomItemData data)
	{
		UUITexture icon = base.GetTexture(2);
		UUISprite qualitySprite = base.GetSprite(3);
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(data.GetQuality());
		this.SetSpriteByPath(phantomQualityBgSprite, qualitySprite, false, null, delegate(bool _)
		{
			qualitySprite.SetUIActive(true);
		});
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(data.GetUniqueId());
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleData.GetConfigId(true));
		base.SetTextureByPath(itemConfigData.IconMiddle, icon, null, delegate(bool _)
		{
			icon.SetUIActive(true);
			this.GetItem(1).SetUIActive(false);
			this.GetButton(5).RootUIComp.Get().SetUIActive(this.ShowRemoveBtn);
			PhantomFetterGroup? fetterGroupConfig = data.GetFetterGroupConfig();
			if (fetterGroupConfig != null)
			{
				this.VisionElementItem.Update(fetterGroupConfig);
			}
			this.VisionElementItem.SetUiActive(!this.ShowRemoveBtn && fetterGroupConfig != null);
		});
		int rarity = data.GetConfig().As<PhantomItem>().Value.Rarity;
		int cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
		base.GetItem(7).SetUIActive(true);
		base.GetText(8).SetText(cost.ToString(), true);
		this.RefreshLockAndDeprecate();
	}

	// Token: 0x0600AD23 RID: 44323 RVA: 0x0026EC80 File Offset: 0x0026CE80
	private void RefreshLockAndDeprecate()
	{
		AttributeItemData attributeItemData = (this.VisionData != null) ? InventoryModel.Instance.GetAttributeItemData(this.VisionData.GetUniqueId()) : null;
		if (attributeItemData == null)
		{
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
			return;
		}
		base.GetItem(9).SetUIActive(attributeItemData.GetIsLock());
		base.GetItem(10).SetUIActive(attributeItemData.GetIsDeprecated());
	}

	// Token: 0x0600AD24 RID: 44324 RVA: 0x0026ECF4 File Offset: 0x0026CEF4
	private void OnClickAddButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(true, this.VisionData);
		}
	}

	// Token: 0x0600AD25 RID: 44325 RVA: 0x0026ED10 File Offset: 0x0026CF10
	private void OnClickRemoveButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(false, this.VisionData);
		}
	}

	// Token: 0x0600AD26 RID: 44326 RVA: 0x0026ED2C File Offset: 0x0026CF2C
	private void OnFuncValueChange(int uniqueId)
	{
		if (this.VisionData != null && this.VisionData.GetUniqueId() == uniqueId)
		{
			this.RefreshLockAndDeprecate();
		}
	}

	// Token: 0x04004EB6 RID: 20150
	private PhantomItemData VisionData;

	// Token: 0x04004EB7 RID: 20151
	private VisionFetterSuitItem VisionElementItem;

	// Token: 0x04004EB8 RID: 20152
	private readonly Action<bool, PhantomItemData> ClickCallBack;

	// Token: 0x04004EB9 RID: 20153
	private readonly bool ShowRemoveBtn;

	// Token: 0x02007D45 RID: 32069
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029052 RID: 168018
		ChooseTransition,
		// Token: 0x04029053 RID: 168019
		EmptyItem,
		// Token: 0x04029054 RID: 168020
		Icon,
		// Token: 0x04029055 RID: 168021
		QualitySprite,
		// Token: 0x04029056 RID: 168022
		AddVisionButton,
		// Token: 0x04029057 RID: 168023
		RemoveVisionButton,
		// Token: 0x04029058 RID: 168024
		VisionElementItem,
		// Token: 0x04029059 RID: 168025
		CostPanel,
		// Token: 0x0402905A RID: 168026
		CostText,
		// Token: 0x0402905B RID: 168027
		PanelLock,
		// Token: 0x0402905C RID: 168028
		PanelDeprecate
	}
}
