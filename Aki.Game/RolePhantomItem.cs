using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E57 RID: 7767
public class RolePhantomItem : UiPanelBase
{
	// Token: 0x06013375 RID: 78709 RVA: 0x0059DB7D File Offset: 0x0059BD7D
	[NullableContext(1)]
	public RolePhantomItem(UUIItem uiItem, Action<int> onFunction, EPhantomItemIndex index)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		this.ClickFunction = onFunction;
		this.Index = index;
	}

	// Token: 0x06013376 RID: 78710 RVA: 0x0059DBA0 File Offset: 0x0059BDA0
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

	// Token: 0x06013377 RID: 78711 RVA: 0x0059DC49 File Offset: 0x0059BE49
	public virtual void UpdateItem(int id)
	{
		this.Id = id;
		this.RefreshIcon();
		this.RefreshQuality();
		this.RefreshLevel();
	}

	// Token: 0x06013378 RID: 78712 RVA: 0x0059DC64 File Offset: 0x0059BE64
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

	// Token: 0x06013379 RID: 78713 RVA: 0x0059DD10 File Offset: 0x0059BF10
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

	// Token: 0x0601337A RID: 78714 RVA: 0x0059DD70 File Offset: 0x0059BF70
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

	// Token: 0x0601337B RID: 78715 RVA: 0x0059DDF2 File Offset: 0x0059BFF2
	private void RefreshLevel()
	{
		base.GetItem(4).SetUIActive(this.Id != 0);
		if (this.Id == 0)
		{
			return;
		}
		this.SetLevelText();
	}

	// Token: 0x0601337C RID: 78716 RVA: 0x0059DE18 File Offset: 0x0059C018
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

	// Token: 0x0601337D RID: 78717 RVA: 0x0059DE72 File Offset: 0x0059C072
	protected void OnClick()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction((int)this.Index);
		}
	}

	// Token: 0x0601337E RID: 78718 RVA: 0x0059DE90 File Offset: 0x0059C090
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

	// Token: 0x0400A49D RID: 42141
	[Nullable(1)]
	protected readonly Action<int> ClickFunction;

	// Token: 0x0400A49E RID: 42142
	protected int Id;

	// Token: 0x0400A49F RID: 42143
	protected readonly EPhantomItemIndex Index;

	// Token: 0x02008132 RID: 33074
	private enum EPhantomItemDefine
	{
		// Token: 0x04029C72 RID: 171122
		ItemButton,
		// Token: 0x04029C73 RID: 171123
		PhantomIconTexture,
		// Token: 0x04029C74 RID: 171124
		QualitySprite,
		// Token: 0x04029C75 RID: 171125
		EquipSkillItem,
		// Token: 0x04029C76 RID: 171126
		LevelItem,
		// Token: 0x04029C77 RID: 171127
		LevelText
	}
}
