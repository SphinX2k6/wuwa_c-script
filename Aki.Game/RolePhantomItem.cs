using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028DC RID: 10460
public class RolePhantomItem : UiPanelBase
{
	// Token: 0x06015971 RID: 88433 RVA: 0x00572CB5 File Offset: 0x00570EB5
	[NullableContext(1)]
	public RolePhantomItem(UUIItem uiItem, Action<int> onFunction, EPhantomItemIndex index)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		this.ClickFunction = onFunction;
		this.Index = index;
	}

	// Token: 0x06015972 RID: 88434 RVA: 0x00572CD8 File Offset: 0x00570ED8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x06015973 RID: 88435 RVA: 0x00572D81 File Offset: 0x00570F81
	public virtual void UpdateItem(int id)
	{
		this.Id = id;
		this.RefreshIcon();
		this.RefreshQuality();
		this.RefreshLevel();
	}

	// Token: 0x06015974 RID: 88436 RVA: 0x00572D9C File Offset: 0x00570F9C
	public void UpdateTrialItem(int itemId)
	{
		base.GetSprite(2).SetUIActive(itemId != 0);
		base.GetTexture(1).SetUIActive(itemId != 0);
		base.GetItem(4).SetUIActive(itemId != 0);
		if (itemId != 0)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(itemConfigData.QualityId);
			if (qualityConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(qualityConfig.Value.BackgroundSprite, base.GetSprite(2), false, null, null);
			base.SetItemIcon(base.GetTexture(1), itemId, null, null);
			this.SetLevelText();
		}
	}

	// Token: 0x06015975 RID: 88437 RVA: 0x00572E48 File Offset: 0x00571048
	private void RefreshIcon()
	{
		base.GetTexture(1).SetUIActive(this.Id != 0);
		if (this.Id == 0)
		{
			return;
		}
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.Id);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		base.SetItemIcon(base.GetTexture(1), phantomItemDataByUniqueId.GetConfigId(false), null, null);
	}

	// Token: 0x06015976 RID: 88438 RVA: 0x00572EA8 File Offset: 0x005710A8
	private void RefreshQuality()
	{
		base.GetSprite(2).SetUIActive(this.Id != 0);
		if (this.Id == 0)
		{
			return;
		}
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.Id);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(phantomItemDataByUniqueId.GetQuality());
		if (qualityConfig == null)
		{
			return;
		}
		this.SetSpriteByPath(qualityConfig.Value.BackgroundSprite, base.GetSprite(2), false, null, null);
	}

	// Token: 0x06015977 RID: 88439 RVA: 0x00572F2A File Offset: 0x0057112A
	private void RefreshLevel()
	{
		base.GetItem(4).SetUIActive(this.Id != 0);
		if (this.Id == 0)
		{
			return;
		}
		this.SetLevelText();
	}

	// Token: 0x06015978 RID: 88440 RVA: 0x00572F50 File Offset: 0x00571150
	private void SetLevelText()
	{
		RoleInstance curSelectMainRoleInstance = RoleModel.Instance.GetCurSelectMainRoleInstance();
		if (curSelectMainRoleInstance == null)
		{
			return;
		}
		PhantomDataBase dataByIndex = curSelectMainRoleInstance.GetPhantomData().GetDataByIndex((int)this.Index);
		if (dataByIndex == null)
		{
			base.GetItem(4).SetUIActive(false);
			return;
		}
		base.GetText(5).SetText(dataByIndex.GetPhantomLevel().ToString(), true);
	}

	// Token: 0x06015979 RID: 88441 RVA: 0x00572FAA File Offset: 0x005711AA
	protected void OnClick()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction((int)this.Index);
		}
	}

	// Token: 0x0601597A RID: 88442 RVA: 0x00572FC8 File Offset: 0x005711C8
	protected void OnClickSkillButton()
	{
		RoleInstance curSelectMainRoleInstance = RoleModel.Instance.GetCurSelectMainRoleInstance();
		if (curSelectMainRoleInstance == null)
		{
			return;
		}
		PhantomDataBase dataByIndex = curSelectMainRoleInstance.GetPhantomData().GetDataByIndex((int)this.Index);
		if (dataByIndex == null)
		{
			return;
		}
		Dictionary<string, object> param = new Dictionary<string, object>
		{
			{
				"SkillInfoData",
				ESkillInfoType.SkillType
			},
			{
				"SkillId",
				this.Id
			},
			{
				"SkillLevel",
				dataByIndex.GetPhantomLevel()
			}
		};
		UiManager.Instance.OpenView(EUiViewName.PhantomBattleSkillInfoView, param, null);
	}

	// Token: 0x0400A0B3 RID: 41139
	[Nullable(1)]
	protected readonly Action<int> ClickFunction;

	// Token: 0x0400A0B4 RID: 41140
	protected int Id;

	// Token: 0x0400A0B5 RID: 41141
	protected readonly EPhantomItemIndex Index;

	// Token: 0x02008EEA RID: 36586
	private enum EPhantomItemDefine
	{
		// Token: 0x0402E577 RID: 189815
		ItemButton,
		// Token: 0x0402E578 RID: 189816
		PhantomIconTexture,
		// Token: 0x0402E579 RID: 189817
		QualitySprite,
		// Token: 0x0402E57A RID: 189818
		EquipSkillItem,
		// Token: 0x0402E57B RID: 189819
		LevelItem,
		// Token: 0x0402E57C RID: 189820
		LevelText
	}
}
