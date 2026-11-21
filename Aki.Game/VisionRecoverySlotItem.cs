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

// Token: 0x02000C16 RID: 3094
[NullableContext(2)]
[Nullable(0)]
public class VisionRecoverySlotItem : UiPanelBase
{
	// Token: 0x06008100 RID: 33024 RVA: 0x00278CF9 File Offset: 0x00276EF9
	public VisionRecoverySlotItem(Action<bool, PhantomItemData> callBack = null, bool showRemoveBtn = true)
	{
		this.ClickCallBack = callBack;
		this.ShowRemoveBtn = showRemoveBtn;
	}

	// Token: 0x06008101 RID: 33025 RVA: 0x00278D10 File Offset: 0x00276F10
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

	// Token: 0x06008102 RID: 33026 RVA: 0x00278E58 File Offset: 0x00277058
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoverySlotItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoverySlotItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008103 RID: 33027 RVA: 0x00278E9C File Offset: 0x0027709C
	protected override void OnStart()
	{
		this.RefreshUi(this.VisionData);
		bool enable = this.ClickCallBack != null;
		base.GetUiSpriteTransition(0).SetEnable(enable);
		base.GetItem(7).SetUIActive(false);
		this.OnAddEvent();
	}

	// Token: 0x06008104 RID: 33028 RVA: 0x00278EDF File Offset: 0x002770DF
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEvent();
	}

	// Token: 0x06008105 RID: 33029 RVA: 0x00278EE7 File Offset: 0x002770E7
	private void OnAddEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
	}

	// Token: 0x06008106 RID: 33030 RVA: 0x00278F05 File Offset: 0x00277105
	private void OnRemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnFuncValueChange));
	}

	// Token: 0x06008107 RID: 33031 RVA: 0x00278F23 File Offset: 0x00277123
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

	// Token: 0x06008108 RID: 33032 RVA: 0x00278F40 File Offset: 0x00277140
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

	// Token: 0x06008109 RID: 33033 RVA: 0x00278FC4 File Offset: 0x002771C4
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

	// Token: 0x0600810A RID: 33034 RVA: 0x002790F4 File Offset: 0x002772F4
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

	// Token: 0x0600810B RID: 33035 RVA: 0x00279168 File Offset: 0x00277368
	private void OnClickAddButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(true, this.VisionData);
		}
	}

	// Token: 0x0600810C RID: 33036 RVA: 0x00279184 File Offset: 0x00277384
	private void OnClickRemoveButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(false, this.VisionData);
		}
	}

	// Token: 0x0600810D RID: 33037 RVA: 0x002791A0 File Offset: 0x002773A0
	private void OnFuncValueChange(int uniqueId)
	{
		if (this.VisionData != null && this.VisionData.GetUniqueId() == uniqueId)
		{
			this.RefreshLockAndDeprecate();
		}
	}

	// Token: 0x04004F5F RID: 20319
	private PhantomItemData VisionData;

	// Token: 0x04004F60 RID: 20320
	private VisionFetterSuitItem VisionElementItem;

	// Token: 0x04004F61 RID: 20321
	private readonly Action<bool, PhantomItemData> ClickCallBack;

	// Token: 0x04004F62 RID: 20322
	private readonly bool ShowRemoveBtn;

	// Token: 0x02006ECB RID: 28363
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402437D RID: 148349
		ChooseTransition,
		// Token: 0x0402437E RID: 148350
		EmptyItem,
		// Token: 0x0402437F RID: 148351
		Icon,
		// Token: 0x04024380 RID: 148352
		QualitySprite,
		// Token: 0x04024381 RID: 148353
		AddVisionButton,
		// Token: 0x04024382 RID: 148354
		RemoveVisionButton,
		// Token: 0x04024383 RID: 148355
		VisionElementItem,
		// Token: 0x04024384 RID: 148356
		CostPanel,
		// Token: 0x04024385 RID: 148357
		CostText,
		// Token: 0x04024386 RID: 148358
		PanelLock,
		// Token: 0x04024387 RID: 148359
		PanelDeprecate
	}
}
