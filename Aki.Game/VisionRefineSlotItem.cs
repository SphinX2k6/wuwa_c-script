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

// Token: 0x02000C2B RID: 3115
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineSlotItem : UiPanelBase, IGridProxy<VisionRefineSlotItemData>
{
	// Token: 0x060081F5 RID: 33269 RVA: 0x0027DDE7 File Offset: 0x0027BFE7
	public VisionRefineSlotItem(Action<bool, int> callBack = null)
	{
		this.ClickCallBack = callBack;
	}

	// Token: 0x17000E97 RID: 3735
	// (get) Token: 0x060081F6 RID: 33270 RVA: 0x0027DDF6 File Offset: 0x0027BFF6
	// (set) Token: 0x060081F7 RID: 33271 RVA: 0x0027DDFE File Offset: 0x0027BFFE
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

	// Token: 0x17000E98 RID: 3736
	// (get) Token: 0x060081F8 RID: 33272 RVA: 0x0027DE07 File Offset: 0x0027C007
	// (set) Token: 0x060081F9 RID: 33273 RVA: 0x0027DE0F File Offset: 0x0027C00F
	public int GridIndex { get; set; }

	// Token: 0x17000E99 RID: 3737
	// (get) Token: 0x060081FA RID: 33274 RVA: 0x0027DE18 File Offset: 0x0027C018
	// (set) Token: 0x060081FB RID: 33275 RVA: 0x0027DE20 File Offset: 0x0027C020
	public int DisplayIndex { get; set; }

	// Token: 0x060081FC RID: 33276 RVA: 0x0027DE29 File Offset: 0x0027C029
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

	// Token: 0x060081FD RID: 33277 RVA: 0x0027DE52 File Offset: 0x0027C052
	[NullableContext(1)]
	public UniTask RefreshAsync(VisionRefineSlotItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x060081FE RID: 33278 RVA: 0x0027DE62 File Offset: 0x0027C062
	public void Clear()
	{
	}

	// Token: 0x060081FF RID: 33279 RVA: 0x0027DE64 File Offset: 0x0027C064
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06008200 RID: 33280 RVA: 0x0027DE66 File Offset: 0x0027C066
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06008201 RID: 33281 RVA: 0x0027DE68 File Offset: 0x0027C068
	[NullableContext(1)]
	[return: Nullable(2)]
	public object GetKey(VisionRefineSlotItemData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x06008202 RID: 33282 RVA: 0x0027DE6C File Offset: 0x0027C06C
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

	// Token: 0x06008203 RID: 33283 RVA: 0x0027DFE4 File Offset: 0x0027C1E4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineSlotItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineSlotItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x0027E028 File Offset: 0x0027C228
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

	// Token: 0x06008205 RID: 33285 RVA: 0x0027E060 File Offset: 0x0027C260
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

	// Token: 0x06008206 RID: 33286 RVA: 0x0027E104 File Offset: 0x0027C304
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

	// Token: 0x06008207 RID: 33287 RVA: 0x0027E1D7 File Offset: 0x0027C3D7
	private void OnClickAddButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(true, this.GridIndex);
		}
	}

	// Token: 0x06008208 RID: 33288 RVA: 0x0027E1F3 File Offset: 0x0027C3F3
	private void OnClickRemoveButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(false, this.GridIndex);
		}
	}

	// Token: 0x06008209 RID: 33289 RVA: 0x0027E20F File Offset: 0x0027C40F
	public void SetBtnInteractive(bool interActive)
	{
		UUIButtonComponent button = base.GetButton(4);
		button.SetSelectionState(EUISelectableSelectionState.Normal);
		button.SetSelfInteractive(interActive);
	}

	// Token: 0x04004FBF RID: 20415
	private VisionFetterSuitItem ElementItemUp;

	// Token: 0x04004FC0 RID: 20416
	private readonly Action<bool, int> ClickCallBack;

	// Token: 0x04004FC1 RID: 20417
	public Func<int?> OnGetMainPropItemIdCallback;

	// Token: 0x04004FC2 RID: 20418
	public Func<bool> OnIsShouldElementItemDownCallback;

	// Token: 0x02006EED RID: 28397
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024436 RID: 148534
		ChooseTransition,
		// Token: 0x04024437 RID: 148535
		EmptyItem,
		// Token: 0x04024438 RID: 148536
		Icon,
		// Token: 0x04024439 RID: 148537
		QualitySprite,
		// Token: 0x0402443A RID: 148538
		AddVisionButton,
		// Token: 0x0402443B RID: 148539
		RemoveButton,
		// Token: 0x0402443C RID: 148540
		ElementItemUp,
		// Token: 0x0402443D RID: 148541
		CostPanel,
		// Token: 0x0402443E RID: 148542
		CostText,
		// Token: 0x0402443F RID: 148543
		LockItem,
		// Token: 0x04024440 RID: 148544
		MarkDeleteItem,
		// Token: 0x04024441 RID: 148545
		WarningItem,
		// Token: 0x04024442 RID: 148546
		ElementItemDown
	}
}
