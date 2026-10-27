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

// Token: 0x02001EAA RID: 7850
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsBase : UiPanelBase
{
	// Token: 0x0600F13C RID: 61756 RVA: 0x0039F6B4 File Offset: 0x0039D8B4
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

	// Token: 0x0600F13D RID: 61757 RVA: 0x0039F93C File Offset: 0x0039DB3C
	protected override void OnBeforeCreateImplement()
	{
		this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.LevelPlaySequence);
		this.LevelPlaySequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnCloseSequenceFinish), false);
		this.LevelPlaySequence.AddSequenceStartEvent("Start", new Action<string>(this.OnCloseSequenceStart));
	}

	// Token: 0x0600F13E RID: 61758 RVA: 0x0039F99C File Offset: 0x0039DB9C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemTipsBase.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemTipsBase.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F13F RID: 61759 RVA: 0x0039F9E0 File Offset: 0x0039DBE0
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(19);
		this.SideButtonWidth = ((item != null) ? item.GetWidth() : 0f);
		EventSystem.Instance.Add(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
		EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
	}

	// Token: 0x0600F140 RID: 61760 RVA: 0x0039FA44 File Offset: 0x0039DC44
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		this.ButtonRightA = null;
		this.ButtonLeftA = null;
		this.ButtonLeftB = null;
		this.ButtonRightB = null;
	}

	// Token: 0x0600F141 RID: 61761 RVA: 0x0039FAA8 File Offset: 0x0039DCA8
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

	// Token: 0x0600F142 RID: 61762 RVA: 0x0039FB44 File Offset: 0x0039DD44
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

	// Token: 0x0600F143 RID: 61763 RVA: 0x0039FBB0 File Offset: 0x0039DDB0
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

	// Token: 0x0600F144 RID: 61764 RVA: 0x0039FCF0 File Offset: 0x0039DEF0
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

	// Token: 0x0600F145 RID: 61765 RVA: 0x0039FD58 File Offset: 0x0039DF58
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
		string text2 = PublicUtil.Instance.GetConfigTextByKey(data.GetItemTypeText());
		if (!Info.Instance.IsBuildShipping)
		{
			string str = text2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendLiteral(" ID:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetItemId());
			text2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
			if (data.GetItemType() == EHonamiStoryItemType.Plugin)
			{
				HonamiStoryEquipItemData honamiStoryEquipItemData = data as HonamiStoryEquipItemData;
				string str2 = text2;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral(" Type:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetSubType());
				defaultInterpolatedStringHandler.AppendLiteral(" Power:");
				defaultInterpolatedStringHandler.AppendFormatted<int?>((honamiStoryEquipItemData != null) ? new int?(honamiStoryEquipItemData.GetBaseEnhance()) : null);
				text2 = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetText(text2, true);
		}
		UUITexture texture = base.GetTexture(22);
		base.SetItemIcon(texture, data.GetItemId(), null, null);
		this.SetSpriteByPath(HonamiStoryConfig.Instance.GetHonamiStoryQuality(data.GetQuality()).Value.Bg, base.GetSprite(1), false, null, null);
		UUIText text4 = base.GetText(5);
		if (text4 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetSellPrice());
			text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int itemType = (int)data.GetItemType();
		this.UpdateHeight = 0f;
		if (itemType != 2)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData2 = data as HonamiStoryEquipItemData;
			if (honamiStoryEquipItemData2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SDC Data Transform Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data.GetItemId());
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int[] mainPropList = honamiStoryEquipItemData2.GetMainPropList();
			List<IHonamiStoryTipsPropertyData> list = new List<IHonamiStoryTipsPropertyData>();
			foreach (int propId in mainPropList)
			{
				list.Add(new HonamiStoryTipsPropertyData
				{
					PropId = propId
				});
			}
			List<IHonamiStoryTipsBuffInfo> buffTempIdList = honamiStoryEquipItemData2.GetBuffTempIdList(false);
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

	// Token: 0x0600F146 RID: 61766 RVA: 0x003A0124 File Offset: 0x0039E324
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

	// Token: 0x0600F147 RID: 61767 RVA: 0x003A03B7 File Offset: 0x0039E5B7
	public void SetMaskAttach(UUIButtonComponent uiItem)
	{
		this.MaskButton = uiItem;
	}

	// Token: 0x0600F148 RID: 61768 RVA: 0x003A03C0 File Offset: 0x0039E5C0
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

	// Token: 0x0600F149 RID: 61769 RVA: 0x003A0461 File Offset: 0x0039E661
	[NullableContext(2)]
	public void SetItemDataOut(HonamiStoryItemDataBase data)
	{
		this.ItemData = data;
	}

	// Token: 0x0600F14A RID: 61770 RVA: 0x003A046A File Offset: 0x0039E66A
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetItemDataOut()
	{
		return this.ItemData;
	}

	// Token: 0x0600F14B RID: 61771 RVA: 0x003A0472 File Offset: 0x0039E672
	public void SetTipsState(EHonamiStoryTipsState state)
	{
		this.TipsState = state;
	}

	// Token: 0x0600F14C RID: 61772 RVA: 0x003A047B File Offset: 0x0039E67B
	public void SetBottomOffset(float value)
	{
		this.BottomOffset = value;
	}

	// Token: 0x0600F14D RID: 61773 RVA: 0x003A0484 File Offset: 0x0039E684
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

	// Token: 0x0600F14E RID: 61774 RVA: 0x003A0534 File Offset: 0x0039E734
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

	// Token: 0x0600F14F RID: 61775 RVA: 0x003A0630 File Offset: 0x0039E830
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

	// Token: 0x0600F150 RID: 61776 RVA: 0x003A06A6 File Offset: 0x0039E8A6
	public void OnClickedMask()
	{
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		this.SetTipsVisible(false);
	}

	// Token: 0x0600F151 RID: 61777 RVA: 0x003A06BA File Offset: 0x0039E8BA
	private HonamiStoryTipsPropertyItem CreateProp()
	{
		return new HonamiStoryTipsPropertyItem();
	}

	// Token: 0x0600F152 RID: 61778 RVA: 0x003A06C1 File Offset: 0x0039E8C1
	private HonamiStoryTipsTextItem CreateSkill()
	{
		return new HonamiStoryTipsTextItem();
	}

	// Token: 0x0600F153 RID: 61779 RVA: 0x003A06C8 File Offset: 0x0039E8C8
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

	// Token: 0x0600F154 RID: 61780 RVA: 0x003A0794 File Offset: 0x0039E994
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

	// Token: 0x0600F155 RID: 61781 RVA: 0x003A07EC File Offset: 0x0039E9EC
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

	// Token: 0x0600F156 RID: 61782 RVA: 0x003A083C File Offset: 0x0039EA3C
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

	// Token: 0x0600F157 RID: 61783 RVA: 0x003A088B File Offset: 0x0039EA8B
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

	// Token: 0x0600F158 RID: 61784 RVA: 0x003A08A5 File Offset: 0x0039EAA5
	private void OnCloseSequenceStart(string _)
	{
		this.SetEnable(true);
	}

	// Token: 0x0600F159 RID: 61785 RVA: 0x003A08B0 File Offset: 0x0039EAB0
	private void OnLayoutUpdate(float _)
	{
		float height = this.RootItem.GetHeight();
		if (height != this.UpdateHeight)
		{
			this.UpdateHeight = height;
			this.SetAutoLocation(this.GridLoc, this.GridSize);
		}
	}

	// Token: 0x0600F15A RID: 61786 RVA: 0x003A08EC File Offset: 0x0039EAEC
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

	// Token: 0x0600F15B RID: 61787 RVA: 0x003A093A File Offset: 0x0039EB3A
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		this.RefreshDoubleClicked();
	}

	// Token: 0x0600F15C RID: 61788 RVA: 0x003A0944 File Offset: 0x0039EB44
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

	// Token: 0x0600F15D RID: 61789 RVA: 0x003A09A9 File Offset: 0x0039EBA9
	private void OnCloseSequenceFinish(string _)
	{
		this.SetEnable(false);
	}

	// Token: 0x04006F90 RID: 28560
	private const int RIGHT_OFFSET = 60;

	// Token: 0x04006F91 RID: 28561
	private const int PROPERTY_MAX_COUNT = 3;

	// Token: 0x04006F92 RID: 28562
	private const int BUFF_MAX_COUNT = 1;

	// Token: 0x04006F93 RID: 28563
	protected bool ActivityOpen;

	// Token: 0x04006F94 RID: 28564
	protected float SideButtonWidth;

	// Token: 0x04006F95 RID: 28565
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsPropertyItem, IHonamiStoryTipsPropertyData> PropertyLayout;

	// Token: 0x04006F96 RID: 28566
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<HonamiStoryTipsTextItem, IHonamiStoryTipsBuffInfo> SkillLayout;

	// Token: 0x04006F97 RID: 28567
	[Nullable(2)]
	protected UUIButtonComponent MaskButton;

	// Token: 0x04006F98 RID: 28568
	protected EHonamiStoryTipsState TipsState;

	// Token: 0x04006F99 RID: 28569
	[Nullable(2)]
	protected ButtonItem ConfirmQuick;

	// Token: 0x04006F9A RID: 28570
	[Nullable(2)]
	protected ButtonItem ConfirmRight;

	// Token: 0x04006F9B RID: 28571
	[Nullable(2)]
	protected HonamiStoryItemDataBase ItemData;

	// Token: 0x04006F9C RID: 28572
	protected EHonamiStoryBackpackType BackpackType;

	// Token: 0x04006F9D RID: 28573
	protected float BottomOffset = 200f;

	// Token: 0x04006F9E RID: 28574
	protected int CurrentPos = -1;

	// Token: 0x04006F9F RID: 28575
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonRightA;

	// Token: 0x04006FA0 RID: 28576
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonRightB;

	// Token: 0x04006FA1 RID: 28577
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonLeftA;

	// Token: 0x04006FA2 RID: 28578
	[Nullable(2)]
	protected HonamiStoryItemTipsSideButton ButtonLeftB;

	// Token: 0x04006FA3 RID: 28579
	protected bool SideButtonActive;

	// Token: 0x04006FA4 RID: 28580
	[Nullable(2)]
	protected Action OnHideCb;

	// Token: 0x04006FA5 RID: 28581
	protected Vector2D GridLoc;

	// Token: 0x04006FA6 RID: 28582
	protected Vector2D GridSize;

	// Token: 0x04006FA7 RID: 28583
	protected float UpdateHeight;

	// Token: 0x04006FA8 RID: 28584
	[Nullable(2)]
	private UiBehaviorLevelSequence LevelPlaySequence;

	// Token: 0x0200847B RID: 33915
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B1D3 RID: 176595
		TxtName,
		// Token: 0x0402B1D4 RID: 176596
		SpriteTitleBg,
		// Token: 0x0402B1D5 RID: 176597
		SpriteTypeIcon,
		// Token: 0x0402B1D6 RID: 176598
		TxtType,
		// Token: 0x0402B1D7 RID: 176599
		TexCost,
		// Token: 0x0402B1D8 RID: 176600
		TxtLevel,
		// Token: 0x0402B1D9 RID: 176601
		TogLock,
		// Token: 0x0402B1DA RID: 176602
		PanelTipsTime,
		// Token: 0x0402B1DB RID: 176603
		TxtTime,
		// Token: 0x0402B1DC RID: 176604
		PanelTipsProperty,
		// Token: 0x0402B1DD RID: 176605
		PanelList,
		// Token: 0x0402B1DE RID: 176606
		PanelSkill,
		// Token: 0x0402B1DF RID: 176607
		MainDescItem,
		// Token: 0x0402B1E0 RID: 176608
		TxtDesc,
		// Token: 0x0402B1E1 RID: 176609
		BtnConfirmA,
		// Token: 0x0402B1E2 RID: 176610
		BtnConfirmB,
		// Token: 0x0402B1E3 RID: 176611
		PanelBtnR,
		// Token: 0x0402B1E4 RID: 176612
		BtnRA,
		// Token: 0x0402B1E5 RID: 176613
		BtnRB,
		// Token: 0x0402B1E6 RID: 176614
		PanelBtnL,
		// Token: 0x0402B1E7 RID: 176615
		BtnLA,
		// Token: 0x0402B1E8 RID: 176616
		BtnLB,
		// Token: 0x0402B1E9 RID: 176617
		TexIcon,
		// Token: 0x0402B1EA RID: 176618
		PanelBottom,
		// Token: 0x0402B1EB RID: 176619
		PanelDoubleClicked,
		// Token: 0x0402B1EC RID: 176620
		TxtDoubleClicked
	}
}
