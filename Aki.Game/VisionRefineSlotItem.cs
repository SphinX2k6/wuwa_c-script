using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001772 RID: 6002
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineSlotItem : UiPanelBase, IGridProxy<VisionRefineSlotItemData>
{
	// Token: 0x0600AE0E RID: 44558 RVA: 0x00273923 File Offset: 0x00271B23
	public VisionRefineSlotItem(Action<bool, int> callBack = null)
	{
		this.ClickCallBack = callBack;
	}

	// Token: 0x17000E74 RID: 3700
	// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x00273932 File Offset: 0x00271B32
	// (set) Token: 0x0600AE10 RID: 44560 RVA: 0x0027393A File Offset: 0x00271B3A
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<VisionRefineSlotItemData>, VisionRefineSlotItemData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17000E75 RID: 3701
	// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x00273943 File Offset: 0x00271B43
	// (set) Token: 0x0600AE12 RID: 44562 RVA: 0x0027394B File Offset: 0x00271B4B
	public int GridIndex { get; set; }

	// Token: 0x17000E76 RID: 3702
	// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x00273954 File Offset: 0x00271B54
	// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x0027395C File Offset: 0x00271B5C
	public int DisplayIndex { get; set; }

	// Token: 0x0600AE15 RID: 44565 RVA: 0x00273965 File Offset: 0x00271B65
	[NullableContext(1)]
	public void Refresh(VisionRefineSlotItemData data, bool isSelected, int gridIndex)
	{
		if (data.ItemData == null)
		{
			this.RefreshEmpty();
			return;
		}
		this.RefreshByData(data.ItemData, data.IsConfirm, data.Cost);
	}

	// Token: 0x0600AE16 RID: 44566 RVA: 0x0027398E File Offset: 0x00271B8E
	[NullableContext(1)]
	public UniTask RefreshAsync(VisionRefineSlotItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x0600AE17 RID: 44567 RVA: 0x0027399E File Offset: 0x00271B9E
	public void Clear()
	{
	}

	// Token: 0x0600AE18 RID: 44568 RVA: 0x002739A0 File Offset: 0x00271BA0
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600AE19 RID: 44569 RVA: 0x002739A2 File Offset: 0x00271BA2
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600AE1A RID: 44570 RVA: 0x002739A4 File Offset: 0x00271BA4
	[NullableContext(1)]
	[return: Nullable(2)]
	public object GetKey(VisionRefineSlotItemData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600AE1B RID: 44571 RVA: 0x002739A8 File Offset: 0x00271BA8
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
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickAddButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickRemoveButton))
		};
	}

	// Token: 0x0600AE1C RID: 44572 RVA: 0x00273B20 File Offset: 0x00271D20
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineSlotItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineSlotItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE1D RID: 44573 RVA: 0x00273B64 File Offset: 0x00271D64
	protected override void OnStart()
	{
		bool enable = this.ClickCallBack != null;
		base.GetUiSpriteTransition(0).SetEnable(enable);
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600AE1E RID: 44574 RVA: 0x00273B9C File Offset: 0x00271D9C
	public void RefreshEmpty()
	{
		base.GetItem(1).SetUIActive(true);
		base.GetItem(7).SetUIActive(false);
		base.GetTexture(2).SetUIActive(false);
		base.GetSprite(3).SetUIActive(false);
		base.GetButton(5).RootUIComp.Get().SetUIActive(false);
		this.ElementItemUp.SetUiActive(false);
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(false);
	}

	// Token: 0x0600AE1F RID: 44575 RVA: 0x00273C40 File Offset: 0x00271E40
	[NullableContext(1)]
	public void RefreshByData(PhantomItemData itemData, bool isConfirm, int cost)
	{
		UUITexture icon = base.GetTexture(2);
		UUISprite qualitySprite = base.GetSprite(3);
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(itemData.GetQuality());
		this.SetSpriteByPath(phantomQualityBgSprite, qualitySprite, false, null, delegate(bool _)
		{
			qualitySprite.SetUIActive(true);
		});
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(itemData.GetUniqueId());
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleData.GetConfigId(true));
		base.SetTextureByPath(itemConfigData.IconMiddle, icon, null, delegate(bool _)
		{
			icon.SetUIActive(true);
			this.GetItem(1).SetUIActive(false);
			this.GetButton(5).RootUIComp.Get().SetUIActive(!isConfirm);
			PhantomFetterGroup? fetterGroupConfig = itemData.GetFetterGroupConfig();
			if (fetterGroupConfig != null)
			{
				this.ElementItemUp.Update(fetterGroupConfig);
			}
			this.ElementItemUp.SetUiActive(fetterGroupConfig != null);
			if (this.OnIsShouldElementItemDownCallback != null && this.OnIsShouldElementItemDownCallback() && fetterGroupConfig != null)
			{
				this.GetItem(7).SetUIActive(false);
			}
			else
			{
				this.GetItem(7).SetUIActive(true);
				this.GetText(8).SetText(cost.ToString(), true);
			}
			if (this.OnGetMainPropItemIdCallback == null)
			{
				UUIItem item = this.GetItem(11);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			else
			{
				int? num = this.OnGetMainPropItemIdCallback();
				if (num == null)
				{
					UUIItem item2 = this.GetItem(11);
					if (item2 != null)
					{
						item2.SetUIActive(false);
					}
				}
				else
				{
					PhantomItemData itemData2 = itemData;
					int? num2 = (itemData2 != null) ? new int?(itemData2.GetUniqueId()) : null;
					if (num2 != null)
					{
						PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(num2.Value);
						if (phantomDataBase != null)
						{
							UUIItem item3 = this.GetItem(11);
							if (item3 != null)
							{
								int? num3 = num;
								int phantomPropId = phantomDataBase.GetPhantomFirstMainProp().PhantomPropId;
								item3.SetUIActive(num3.GetValueOrDefault() == phantomPropId & num3 != null);
							}
						}
					}
				}
			}
			if (this.OnIsShouldElementItemDownCallback != null && this.OnIsShouldElementItemDownCallback())
			{
				UUIItem item4 = this.GetItem(9);
				if (item4 != null)
				{
					item4.SetUIActive(itemData.GetIsLock());
				}
				UUIItem item5 = this.GetItem(10);
				if (item5 == null)
				{
					return;
				}
				item5.SetUIActive(itemData.GetIsDeprecated());
				return;
			}
			else
			{
				UUIItem item6 = this.GetItem(9);
				if (item6 != null)
				{
					item6.SetUIActive(false);
				}
				UUIItem item7 = this.GetItem(10);
				if (item7 == null)
				{
					return;
				}
				item7.SetUIActive(false);
				return;
			}
		});
	}

	// Token: 0x0600AE20 RID: 44576 RVA: 0x00273D13 File Offset: 0x00271F13
	private void OnClickAddButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(true, this.GridIndex);
		}
	}

	// Token: 0x0600AE21 RID: 44577 RVA: 0x00273D2F File Offset: 0x00271F2F
	private void OnClickRemoveButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(false, this.GridIndex);
		}
	}

	// Token: 0x0600AE22 RID: 44578 RVA: 0x00273D4B File Offset: 0x00271F4B
	public void SetBtnInteractive(bool interActive)
	{
		UUIButtonComponent button = base.GetButton(4);
		button.SetSelectionState(EUISelectableSelectionState.Normal);
		button.SetSelfInteractive(interActive);
	}

	// Token: 0x04004F15 RID: 20245
	private VisionFetterSuitItem ElementItemUp;

	// Token: 0x04004F16 RID: 20246
	private readonly Action<bool, int> ClickCallBack;

	// Token: 0x04004F17 RID: 20247
	public Func<int?> OnGetMainPropItemIdCallback;

	// Token: 0x04004F18 RID: 20248
	public Func<bool> OnIsShouldElementItemDownCallback;

	// Token: 0x02007D67 RID: 32103
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402910B RID: 168203
		ChooseTransition,
		// Token: 0x0402910C RID: 168204
		EmptyItem,
		// Token: 0x0402910D RID: 168205
		Icon,
		// Token: 0x0402910E RID: 168206
		QualitySprite,
		// Token: 0x0402910F RID: 168207
		AddVisionButton,
		// Token: 0x04029110 RID: 168208
		RemoveButton,
		// Token: 0x04029111 RID: 168209
		ElementItemUp,
		// Token: 0x04029112 RID: 168210
		CostPanel,
		// Token: 0x04029113 RID: 168211
		CostText,
		// Token: 0x04029114 RID: 168212
		LockItem,
		// Token: 0x04029115 RID: 168213
		MarkDeleteItem,
		// Token: 0x04029116 RID: 168214
		WarningItem,
		// Token: 0x04029117 RID: 168215
		ElementItemDown
	}
}
