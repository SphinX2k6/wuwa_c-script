using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200136C RID: 4972
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsBase : UiPanelBase
{
	// Token: 0x0600C55B RID: 50523 RVA: 0x003AB270 File Offset: 0x003A9470
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickedLock))
		};
	}

	// Token: 0x0600C55C RID: 50524 RVA: 0x003AB4F8 File Offset: 0x003A96F8
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
		this.LevelPlaySequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnCloseSequenceFinish), false);
		this.LevelPlaySequence.AddSequenceStartEvent("Start", new Action<string>(this.OnCloseSequenceStart));
	}

	// Token: 0x0600C55D RID: 50525 RVA: 0x003AB558 File Offset: 0x003A9758
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemTipsBase.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemTipsBase.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C55E RID: 50526 RVA: 0x003AB59C File Offset: 0x003A979C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(19);
		this.SideButtonWidth = ((item != null) ? item.GetWidth() : 0f);
		EventSystem.Instance.Add(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
		EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600C55F RID: 50527 RVA: 0x003AB600 File Offset: 0x003A9800
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		this.ButtonRightA = null;
		this.ButtonLeftA = null;
		this.ButtonLeftB = null;
		this.ButtonRightB = null;
	}

	// Token: 0x0600C560 RID: 50528 RVA: 0x003AB664 File Offset: 0x003A9864
	protected void InitButtonState()
	{
		this.ConfirmQuick = new ButtonItem(base.GetItem(15));
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickedQuick));
		this.ConfirmQuick.SetLocalTextNew("HonamiStory_Tips_QuickEquipped", Array.Empty<object>());
		this.ConfirmRight = new ButtonItem(base.GetItem(14));
		this.ConfirmRight.SetFunction(new Action<int>(this.OnClickedConfirm));
		string textId = (this.TipsState == EHonamiStoryTipsState.InGame) ? "HonamiStory_Tips_Drop" : "HonamiStory_Tips_Sell";
		this.ConfirmRight.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x0600C561 RID: 50529 RVA: 0x003AB700 File Offset: 0x003A9900
	protected void RefreshButton(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(backpackType != EHonamiStoryBackpackType.PickUpBox);
		}
		if (backpackType != EHonamiStoryBackpackType.PickUpBox)
		{
			EToggleState state = data.IsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(6);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleState(state, false, false, false);
			}
		}
		this.RefreshConfirmButton(data, backpackType);
		this.RefreshSideButton(data, backpackType);
	}

	// Token: 0x0600C562 RID: 50530 RVA: 0x003AB76C File Offset: 0x003A996C
	protected void RefreshConfirmButton(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType)
	{
		if (this.TipsState == EHonamiStoryTipsState.ShopView)
		{
			ButtonItem confirmRight = this.ConfirmRight;
			if (confirmRight != null)
			{
				confirmRight.SetUiActive(false);
			}
			ButtonItem confirmQuick = this.ConfirmQuick;
			if (confirmQuick != null)
			{
				confirmQuick.SetUiActive(false);
			}
			UUIItem item = base.GetItem(23);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			EHonamiStoryItemType itemType = data.GetItemType();
			bool flag = itemType == EHonamiStoryItemType.Plugin || backpackType == EHonamiStoryBackpackType.PickUpBox;
			ButtonItem confirmQuick2 = this.ConfirmQuick;
			if (confirmQuick2 != null)
			{
				confirmQuick2.SetUiActive(flag);
			}
			if (backpackType == EHonamiStoryBackpackType.PickUpBox)
			{
				ButtonItem confirmRight2 = this.ConfirmRight;
				if (confirmRight2 != null)
				{
					confirmRight2.SetUiActive(false);
				}
				bool flag2 = false;
				ButtonItem confirmQuick3 = this.ConfirmQuick;
				if (confirmQuick3 != null)
				{
					confirmQuick3.SetLocalTextNew("HonamiStory_Tips_QuickPickUp", Array.Empty<object>());
				}
				UUIItem item2 = base.GetItem(23);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(flag2 || flag);
				return;
			}
			else
			{
				if ((backpackType == EHonamiStoryBackpackType.Backpack || backpackType == EHonamiStoryBackpackType.Inventory) && itemType == EHonamiStoryItemType.Plugin)
				{
					ButtonItem confirmQuick4 = this.ConfirmQuick;
					if (confirmQuick4 != null)
					{
						confirmQuick4.SetLocalTextNew("HonamiStory_Tips_QuickEquipped", Array.Empty<object>());
					}
				}
				else if (backpackType == EHonamiStoryBackpackType.Player)
				{
					ButtonItem confirmQuick5 = this.ConfirmQuick;
					if (confirmQuick5 != null)
					{
						confirmQuick5.SetLocalTextNew("HonamiStory_Tips_QuickUnload", Array.Empty<object>());
					}
				}
				bool flag2 = this.TipsState == EHonamiStoryTipsState.InGame || this.ActivityOpen;
				ButtonItem confirmRight3 = this.ConfirmRight;
				if (confirmRight3 != null)
				{
					confirmRight3.SetUiActive(flag2);
				}
				UUIItem item3 = base.GetItem(23);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(flag2 || flag);
				return;
			}
		}
	}

	// Token: 0x0600C563 RID: 50531 RVA: 0x003AB8AC File Offset: 0x003A9AAC
	protected void RefreshSideButton(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType)
	{
		bool flag = data.GetItemType() == EHonamiStoryItemType.Plugin && backpackType != EHonamiStoryBackpackType.Player;
		this.ButtonLeftA.SetUiActive(flag);
		this.ButtonRightA.SetUiActive(flag);
		bool flag2 = backpackType != EHonamiStoryBackpackType.Backpack && backpackType > EHonamiStoryBackpackType.Inventory;
		this.ButtonLeftB.SetUiActive(flag2);
		this.ButtonRightB.SetUiActive(flag2);
		this.SideButtonActive = (flag2 || flag);
	}

	// Token: 0x0600C564 RID: 50532 RVA: 0x003AB914 File Offset: 0x003A9B14
	public bool Refresh(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType, int curPos, Action cb, Vector2D gridLoc, Vector2D gridSize)
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		if (data == this.ItemData)
		{
			this.ItemData = null;
			this.OnClickedMask();
			return false;
		}
		if (this.OnHideCb != null)
		{
			this.OnHideCb();
		}
		this.GridLoc = gridLoc;
		this.GridSize = gridSize;
		this.OnHideCb = cb;
		this.SetTipsVisible(true);
		EHonamiStoryBackpackLogicState state = (data.GetItemType() == EHonamiStoryItemType.Plugin) ? EHonamiStoryBackpackLogicState.TipsWithPlugins : EHonamiStoryBackpackLogicState.Tips;
		HonamiStoryItemDataBase insteadItem = (data.GetItemType() == EHonamiStoryItemType.Plugin) ? data : null;
		EHonamiStoryBackpack value;
		if (!HonamiStoryDefine.Instance.HonamiBackpackTypeMap.TryGetValue(backpackType, out value))
		{
			return false;
		}
		backpackLogic.SetLogicState(state, insteadItem, new EHonamiStoryBackpack?(value));
		this.CurrentPos = curPos;
		this.ItemData = data;
		this.BackpackType = backpackType;
		this.RefreshButton(data, backpackType);
		this.RefreshDoubleClicked();
		string name = data.GetName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
		string desc = data.GetDesc();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), desc, Array.Empty<object>());
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		string resourceId = (data.GetItemType() == EHonamiStoryItemType.Plugin) ? "SP_TipsTypeIcon1" : "SP_TipsTypeIcon2";
		UiResourceConfig instance = UiResourceConfig.Instance;
		string text = (instance != null) ? instance.GetResourcePath(resourceId) : null;
		this.SetSpriteByPath(text ?? string.Empty, base.GetSprite(2), false, null, null);
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(data.GetItemTypeText());
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetText(configTextByKey, true);
		}
		UUITexture texture = base.GetTexture(22);
		base.SetItemIcon(texture, data.GetItemId(), null, null);
		this.SetSpriteByPath(HonamiStoryConfig.Instance.GetHonamiStoryQuality(data.GetQuality()).Value.Bg, base.GetSprite(1), false, null, null);
		UUIText text3 = base.GetText(5);
		if (text3 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetSellPrice());
			text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int itemType = (int)data.GetItemType();
		this.UpdateHeight = 0f;
		if (itemType != 2)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData = data as HonamiStoryEquipItemData;
			if (honamiStoryEquipItemData == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SDC Data Transform Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data.GetItemId());
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int[] mainPropList = honamiStoryEquipItemData.GetMainPropList();
			List<IHonamiStoryTipsPropertyData> list = new List<IHonamiStoryTipsPropertyData>();
			foreach (int propId in mainPropList)
			{
				list.Add(new HonamiStoryTipsPropertyData
				{
					PropId = propId
				});
			}
			List<IHonamiStoryTipsBuffInfo> buffTempIdList = honamiStoryEquipItemData.GetBuffTempIdList(false);
			GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> propertyLayout = this.PropertyLayout;
			if (propertyLayout != null)
			{
				propertyLayout.RefreshByDataDirectlySync(list);
			}
			GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> skillLayout = this.SkillLayout;
			if (skillLayout != null)
			{
				skillLayout.RefreshByDataDirectlySync(buffTempIdList);
			}
		}
		else
		{
			GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> propertyLayout2 = this.PropertyLayout;
			if (propertyLayout2 != null)
			{
				propertyLayout2.RefreshByDataDirectlySync(new List<IHonamiStoryTipsPropertyData>());
			}
			GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> skillLayout2 = this.SkillLayout;
			if (skillLayout2 != null)
			{
				skillLayout2.RefreshByDataDirectlySync(new List<IHonamiStoryTipsBuffInfo>());
			}
		}
		return true;
	}

	// Token: 0x0600C565 RID: 50533 RVA: 0x003ABC2C File Offset: 0x003A9E2C
	public void SetAutoLocation(Vector2D gridLoc, Vector2D gridSize)
	{
		float width = this.RootItem.GetWidth();
		float height = this.RootItem.GetHeight();
		FVector uiworldPosition = this.RootItem.GetUIWorldPosition();
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		float num = viewportSize.X / viewportScale;
		float num2 = viewportSize.Y / viewportScale;
		float num3 = num / 2f;
		float num4 = num2 / 2f;
		double num5 = gridLoc.X + gridSize.X / 2.0;
		double y = gridLoc.Y;
		float num6 = this.SideButtonActive ? this.SideButtonWidth : 0f;
		int num7 = Info.Instance.IsMobileInputModel() ? 0 : 60;
		bool flag = num5 + (double)width + (double)num6 + (double)num7 < (double)num3;
		bool flag2 = y - (double)height > (double)(-(double)num4 + 100f);
		double num8;
		if (flag)
		{
			num8 = num5 + (double)(width / 2f) + (double)num7;
		}
		else
		{
			num8 = gridLoc.X - gridSize.X / 2.0 - (double)(width / 2f);
		}
		double num9;
		if (flag2)
		{
			num9 = y + gridSize.Y / 2.0;
		}
		else
		{
			num9 = (double)(-(double)num4 + height + this.BottomOffset);
		}
		if (Info.Instance.IsInGamepad())
		{
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		else if (Info.Instance.IsMobileInputModel())
		{
			bool flag3 = false;
			if (this.SideButtonActive)
			{
				flag3 = (num5 + (double)(width / 2f) + (double)this.SideButtonWidth > 0.0);
				if (!flag3)
				{
					num8 += (double)this.SideButtonWidth;
				}
				else if (!flag)
				{
					num8 -= (double)this.SideButtonWidth;
				}
			}
			UUIItem item3 = base.GetItem(19);
			if (item3 != null)
			{
				item3.SetUIActive(!flag3 && this.SideButtonActive);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 != null)
			{
				item4.SetUIActive(flag3 && this.SideButtonActive);
			}
		}
		else
		{
			UUIItem item5 = base.GetItem(19);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(16);
			if (item6 != null)
			{
				item6.SetUIActive(this.SideButtonActive);
			}
			if (!flag && this.SideButtonActive)
			{
				num8 -= (double)this.SideButtonWidth;
			}
		}
		FVector fvector = new FVector((float)num8, uiworldPosition.Y, (float)num9);
		this.RootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x0600C566 RID: 50534 RVA: 0x003ABEBF File Offset: 0x003AA0BF
	public void SetMaskAttach(UUIButtonComponent uiItem)
	{
		this.MaskButton = uiItem;
	}

	// Token: 0x0600C567 RID: 50535 RVA: 0x003ABEC8 File Offset: 0x003AA0C8
	public void SetTipsVisible(bool isVisible)
	{
		this.MaskButton.RootUIComp.Get().SetUIActive(isVisible);
		if (isVisible)
		{
			UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
			if (levelPlaySequence != null)
			{
				levelPlaySequence.PlaySequence("Start", false, null);
			}
		}
		else
		{
			UiBehaviorLevelSequence levelPlaySequence2 = this.LevelPlaySequence;
			if (levelPlaySequence2 != null)
			{
				levelPlaySequence2.PlaySequence("Close", false, null);
			}
		}
		if (!isVisible)
		{
			this.ItemData = null;
			HonamiStoryModel.Instance.GetInteractController().OnClickedItem(false, -1, null);
			if (this.OnHideCb != null)
			{
				this.OnHideCb();
			}
			this.OnHideCb = null;
		}
	}

	// Token: 0x0600C568 RID: 50536 RVA: 0x003ABF69 File Offset: 0x003AA169
	[NullableContext(2)]
	public void SetItemDataOut(HonamiStoryItemDataBase data)
	{
		this.ItemData = data;
	}

	// Token: 0x0600C569 RID: 50537 RVA: 0x003ABF72 File Offset: 0x003AA172
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetItemDataOut()
	{
		return this.ItemData;
	}

	// Token: 0x0600C56A RID: 50538 RVA: 0x003ABF7A File Offset: 0x003AA17A
	public void SetTipsState(EHonamiStoryTipsState state)
	{
		this.TipsState = state;
	}

	// Token: 0x0600C56B RID: 50539 RVA: 0x003ABF83 File Offset: 0x003AA183
	public void SetBottomOffset(float value)
	{
		this.BottomOffset = value;
	}

	// Token: 0x0600C56C RID: 50540 RVA: 0x003ABF8C File Offset: 0x003AA18C
	protected void OnDiscardItem()
	{
		if (this.ItemData.IsLock())
		{
			this.SetTipsVisible(false);
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_TryDiscardLockItem", Array.Empty<object>());
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
			return;
		}
		EHonamiStoryBackpack ehonamiStoryBackpack = (this.BackpackType == EHonamiStoryBackpackType.Backpack) ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Player;
		if (HonamiStoryModel.Instance.GetBackpackLogic().IsBackpackView())
		{
			HonamiStoryController.Instance.RequestDiscardItem(this.ItemData, ehonamiStoryBackpack);
			this.SetTipsVisible(false);
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
			return;
		}
		if (HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, ehonamiStoryBackpack, EHonamiStoryBackpack.PickUpBox))
		{
			this.SetTipsVisible(false);
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		}
	}

	// Token: 0x0600C56D RID: 50541 RVA: 0x003AC03C File Offset: 0x003AA23C
	private void RefreshDoubleClicked()
	{
		if (Info.Instance.IsInGamepad())
		{
			UUIItem item = base.GetItem(24);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			if (this.ItemData == null)
			{
				return;
			}
			bool flag = this.ItemData.GetItemType() == EHonamiStoryItemType.Normal;
			bool flag2 = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) == null;
			if ((this.BackpackType != EHonamiStoryBackpackType.Inventory && (this.BackpackType != EHonamiStoryBackpackType.Backpack || flag2)) || !flag)
			{
				UUIItem item2 = base.GetItem(24);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				string textStringId = string.Empty;
				if (this.BackpackType == EHonamiStoryBackpackType.Player)
				{
					textStringId = "HonamiStory_DoubleClickTip_UnloadPlugin";
				}
				else if (!flag2)
				{
					textStringId = "HonamiStory_DoubleClickTip_Equip";
				}
				else if (this.BackpackType != EHonamiStoryBackpackType.PickUpBox)
				{
					textStringId = "HonamiStory_DoubleClickTip_Discard";
				}
				else
				{
					textStringId = (flag ? "HonamiStory_DoubleClickTip_Pick" : "HonamiStory_DoubleClickTip_PickPlugin");
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(25), textStringId, Array.Empty<object>());
				return;
			}
			UUIItem item3 = base.GetItem(24);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600C56E RID: 50542 RVA: 0x003AC138 File Offset: 0x003AA338
	private void OnClickedLock(EToggleState toggleState)
	{
		bool curLock = this.ItemData.IsLock();
		EHonamiStoryBackpack backType;
		if (!HonamiStoryDefine.Instance.HonamiBackpackTypeMap.TryGetValue(this.BackpackType, out backType))
		{
			return;
		}
		HonamiStoryController.Instance.RequestHonamiStoryLockItem(this.ItemData.GetIncId(), backType, !curLock).ContinueWith(delegate(bool value)
		{
			EToggleState state = (value != curLock) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			UUIExtendToggle extendToggle = this.GetExtendToggle(6);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			HonamiStoryItemDataBase itemData = this.ItemData;
			if (itemData != null)
			{
				itemData.SetIsLock(!curLock);
			}
			HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
			if (backpackLogic == null)
			{
				return;
			}
			backpackLogic.RefreshItemLockState(this.ItemData, this.BackpackType);
		});
	}

	// Token: 0x0600C56F RID: 50543 RVA: 0x003AC1AE File Offset: 0x003AA3AE
	public void OnClickedMask()
	{
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		this.SetTipsVisible(false);
	}

	// Token: 0x0600C570 RID: 50544 RVA: 0x003AC1C2 File Offset: 0x003AA3C2
	private HonamiStoryTipsPropertyItem CreateProp()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600C571 RID: 50545 RVA: 0x003AC1C9 File Offset: 0x003AA3C9
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x0600C572 RID: 50546 RVA: 0x003AC1D0 File Offset: 0x003AA3D0
	private void OnClickedQuick(int _)
	{
		if (this.BackpackType == EHonamiStoryBackpackType.Player)
		{
			EHonamiStoryBackpack toBackpack = (this.TipsState == EHonamiStoryTipsState.InGame) ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
			if (!HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, EHonamiStoryBackpack.Player, toBackpack))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
				return;
			}
		}
		else if ((this.BackpackType == EHonamiStoryBackpackType.Backpack || this.BackpackType == EHonamiStoryBackpackType.Inventory) && this.ItemData.GetItemType() == EHonamiStoryItemType.Plugin)
		{
			if (!HonamiStoryModel.Instance.QuickEquipFromBackpack(this.ItemData, this.CurrentPos))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_ShowTips_CantQuickEquip", Array.Empty<object>());
				return;
			}
		}
		else if (this.BackpackType == EHonamiStoryBackpackType.PickUpBox)
		{
			HonamiStoryModel.Instance.QuickPickUpFromPickUpBox(this.ItemData, this.CurrentPos);
		}
		this.SetTipsVisible(false);
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
	}

	// Token: 0x0600C573 RID: 50547 RVA: 0x003AC29C File Offset: 0x003AA49C
	private void OnClickedConfirm(int _)
	{
		if (this.TipsState == EHonamiStoryTipsState.InGame)
		{
			this.OnDiscardItem();
			return;
		}
		if (this.TipsState == EHonamiStoryTipsState.Inventory)
		{
			EHonamiStoryBackpack backpack = (this.BackpackType == EHonamiStoryBackpackType.Inventory) ? EHonamiStoryBackpack.Inventory : EHonamiStoryBackpack.Player;
			HonamiStoryModel.Instance.SellSingleItem(this.ItemData, backpack).ContinueWith(delegate(bool value)
			{
				if (value)
				{
					this.SetTipsVisible(false);
					HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
				}
			});
		}
	}

	// Token: 0x0600C574 RID: 50548 RVA: 0x003AC2F4 File Offset: 0x003AA4F4
	private void OnClickedToBackpack()
	{
		EHonamiStoryBackpack curBackpack = (this.BackpackType == EHonamiStoryBackpackType.Player) ? EHonamiStoryBackpack.Player : EHonamiStoryBackpack.PickUpBox;
		EHonamiStoryBackpack toBackpack = (this.TipsState == EHonamiStoryTipsState.InGame) ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		if (!HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, curBackpack, toBackpack))
		{
			return;
		}
		this.SetTipsVisible(false);
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
	}

	// Token: 0x0600C575 RID: 50549 RVA: 0x003AC344 File Offset: 0x003AA544
	private void OnClickedInstead()
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpack value;
		if (!HonamiStoryDefine.Instance.HonamiBackpackTypeMap.TryGetValue(this.BackpackType, out value))
		{
			return;
		}
		if (backpackLogic != null)
		{
			backpackLogic.SetLogicState(EHonamiStoryBackpackLogicState.Instead, this.ItemData, new EHonamiStoryBackpack?(value));
		}
		this.SetTipsVisible(false);
	}

	// Token: 0x0600C576 RID: 50550 RVA: 0x003AC393 File Offset: 0x003AA593
	public void SetEnable(bool value)
	{
		base.SetUiActive(value);
		UUIItem originalItem = this.GetOriginalItem();
		if (originalItem == null)
		{
			return;
		}
		originalItem.SetUIActive(value);
	}

	// Token: 0x0600C577 RID: 50551 RVA: 0x003AC3AD File Offset: 0x003AA5AD
	private void OnCloseSequenceStart(string _)
	{
		this.SetEnable(true);
	}

	// Token: 0x0600C578 RID: 50552 RVA: 0x003AC3B8 File Offset: 0x003AA5B8
	private void OnLayoutUpdate(float _)
	{
		float height = this.RootItem.GetHeight();
		if (height != this.UpdateHeight)
		{
			this.UpdateHeight = height;
			this.SetAutoLocation(this.GridLoc, this.GridSize);
		}
	}

	// Token: 0x0600C579 RID: 50553 RVA: 0x003AC3F4 File Offset: 0x003AA5F4
	private void OnSkillDescModeChange(bool isSimple)
	{
		if (this.ItemData == null || this.ItemData.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return;
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = this.ItemData as HonamiStoryEquipItemData;
		if (honamiStoryEquipItemData == null)
		{
			return;
		}
		List<IHonamiStoryTipsBuffInfo> buffTempIdList = honamiStoryEquipItemData.GetBuffTempIdList(false);
		GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> skillLayout = this.SkillLayout;
		if (skillLayout == null)
		{
			return;
		}
		skillLayout.RefreshByDataDirectlySync(buffTempIdList);
	}

	// Token: 0x0600C57A RID: 50554 RVA: 0x003AC442 File Offset: 0x003AA642
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		this.RefreshDoubleClicked();
	}

	// Token: 0x0600C57B RID: 50555 RVA: 0x003AC44C File Offset: 0x003AA64C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "SkillRoleText"))
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> skillLayout = this.SkillLayout;
		HonamiStoryTipsTextItem honamiStoryTipsTextItem = (skillLayout != null) ? skillLayout.GetLayoutItemByIndex(index) : null;
		UUIItem uuiitem = (honamiStoryTipsTextItem != null) ? honamiStoryTipsTextItem.GetGuideUiItem("0") : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0600C57C RID: 50556 RVA: 0x003AC4B1 File Offset: 0x003AA6B1
	private void OnCloseSequenceFinish(string _)
	{
		this.SetEnable(false);
	}

	// Token: 0x04007071 RID: 28785
	private const int RIGHT_OFFSET = 60;

	// Token: 0x04007072 RID: 28786
	private const int PROPERTY_MAX_COUNT = 3;

	// Token: 0x04007073 RID: 28787
	private const int BUFF_MAX_COUNT = 1;

	// Token: 0x04007074 RID: 28788
	protected bool ActivityOpen;

	// Token: 0x04007075 RID: 28789
	protected float SideButtonWidth;

	// Token: 0x04007076 RID: 28790
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x04007077 RID: 28791
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x04007078 RID: 28792
	[Nullable(2)]
	protected UUIButtonComponent MaskButton;

	// Token: 0x04007079 RID: 28793
	protected EHonamiStoryTipsState TipsState;

	// Token: 0x0400707A RID: 28794
	[Nullable(2)]
	protected ButtonItem ConfirmQuick;

	// Token: 0x0400707B RID: 28795
	[Nullable(2)]
	protected ButtonItem ConfirmRight;

	// Token: 0x0400707C RID: 28796
	[Nullable(2)]
	protected HonamiStoryItemDataBase ItemData;

	// Token: 0x0400707D RID: 28797
	protected EHonamiStoryBackpackType BackpackType;

	// Token: 0x0400707E RID: 28798
	protected float BottomOffset = 200f;

	// Token: 0x0400707F RID: 28799
	protected int CurrentPos = -1;

	// Token: 0x04007080 RID: 28800
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonRightA;

	// Token: 0x04007081 RID: 28801
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonRightB;

	// Token: 0x04007082 RID: 28802
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonLeftA;

	// Token: 0x04007083 RID: 28803
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonLeftB;

	// Token: 0x04007084 RID: 28804
	protected bool SideButtonActive;

	// Token: 0x04007085 RID: 28805
	[Nullable(2)]
	protected Action OnHideCb;

	// Token: 0x04007086 RID: 28806
	protected Vector2D GridLoc;

	// Token: 0x04007087 RID: 28807
	protected Vector2D GridSize;

	// Token: 0x04007088 RID: 28808
	protected float UpdateHeight;

	// Token: 0x04007089 RID: 28809
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x02007600 RID: 30208
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x040264F7 RID: 156919
		TxtName,
		// Token: 0x040264F8 RID: 156920
		SpriteTitleBg,
		// Token: 0x040264F9 RID: 156921
		SpriteTypeIcon,
		// Token: 0x040264FA RID: 156922
		TxtType,
		// Token: 0x040264FB RID: 156923
		TexCost,
		// Token: 0x040264FC RID: 156924
		TxtLevel,
		// Token: 0x040264FD RID: 156925
		TogLock,
		// Token: 0x040264FE RID: 156926
		PanelTipsTime,
		// Token: 0x040264FF RID: 156927
		TxtTime,
		// Token: 0x04026500 RID: 156928
		PanelTipsProperty,
		// Token: 0x04026501 RID: 156929
		PanelList,
		// Token: 0x04026502 RID: 156930
		PanelSkill,
		// Token: 0x04026503 RID: 156931
		MainDescItem,
		// Token: 0x04026504 RID: 156932
		TxtDesc,
		// Token: 0x04026505 RID: 156933
		BtnConfirmA,
		// Token: 0x04026506 RID: 156934
		BtnConfirmB,
		// Token: 0x04026507 RID: 156935
		PanelBtnR,
		// Token: 0x04026508 RID: 156936
		BtnRA,
		// Token: 0x04026509 RID: 156937
		BtnRB,
		// Token: 0x0402650A RID: 156938
		PanelBtnL,
		// Token: 0x0402650B RID: 156939
		BtnLA,
		// Token: 0x0402650C RID: 156940
		BtnLB,
		// Token: 0x0402650D RID: 156941
		TexIcon,
		// Token: 0x0402650E RID: 156942
		PanelBottom,
		// Token: 0x0402650F RID: 156943
		PanelDoubleClicked,
		// Token: 0x04026510 RID: 156944
		TxtDoubleClicked
	}
}
