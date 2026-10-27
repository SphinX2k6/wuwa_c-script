using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002809 RID: 10249
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomHeadItem : UiPanelBase
{
	// Token: 0x06015079 RID: 86137 RVA: 0x00552E9D File Offset: 0x0055109D
	public RoleDevPhantomHeadItem(int index)
	{
		this.Index = index;
	}

	// Token: 0x0601507A RID: 86138 RVA: 0x00552EAC File Offset: 0x005510AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickHeadItem))
		};
	}

	// Token: 0x0601507B RID: 86139 RVA: 0x00552FC4 File Offset: 0x005511C4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomHeadItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomHeadItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601507C RID: 86140 RVA: 0x00553007 File Offset: 0x00551207
	public void SetRoleId(int roleId)
	{
		this.CurrentRoleId = new int?(roleId);
	}

	// Token: 0x0601507D RID: 86141 RVA: 0x00553015 File Offset: 0x00551215
	public void UpdateItem(PhantomDataBase data)
	{
		this.CurrentData = data;
		this.OnUpdateItem(data);
	}

	// Token: 0x0601507E RID: 86142 RVA: 0x00553028 File Offset: 0x00551228
	protected void OnUpdateItem(PhantomDataBase data)
	{
		if (data != null)
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.RefreshIcon(data);
			this.RefreshQuality(data);
			this.RefreshNum(data);
			this.RefreshLevel(data);
			this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(data.GetFetterGroupConfig()));
			return;
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(9);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(true);
	}

	// Token: 0x0601507F RID: 86143 RVA: 0x005530B8 File Offset: 0x005512B8
	[NullableContext(1)]
	private void RefreshIcon(PhantomDataBase data)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture != null && data != null)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.GetConfigId(true));
			string text = (itemConfigData != null) ? itemConfigData.Icon : null;
			if (!string.IsNullOrEmpty(text))
			{
				base.SetTextureByPath(text, texture, null, null);
			}
		}
	}

	// Token: 0x06015080 RID: 86144 RVA: 0x0055310C File Offset: 0x0055130C
	[NullableContext(1)]
	private void RefreshQuality(PhantomDataBase data)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null && data != null)
		{
			int quality = data.GetQuality();
			string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality);
			if (!string.IsNullOrEmpty(phantomQualityBgSprite))
			{
				this.SetSpriteByPath(phantomQualityBgSprite, sprite, false, null, null);
			}
		}
	}

	// Token: 0x06015081 RID: 86145 RVA: 0x00553158 File Offset: 0x00551358
	[NullableContext(1)]
	private void RefreshNum(PhantomDataBase data)
	{
		UUIText text = base.GetText(4);
		if (text != null && data != null)
		{
			text.SetText(data.GetCost().ToString(), true);
		}
	}

	// Token: 0x06015082 RID: 86146 RVA: 0x00553188 File Offset: 0x00551388
	[NullableContext(1)]
	private void RefreshLevel(PhantomDataBase data)
	{
		UUIText text = base.GetText(7);
		if (text != null && data != null)
		{
			text.SetText("+" + data.GetPhantomLevel().ToString(), true);
		}
	}

	// Token: 0x06015083 RID: 86147 RVA: 0x005531C2 File Offset: 0x005513C2
	public PhantomDataBase GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x06015084 RID: 86148 RVA: 0x005531CC File Offset: 0x005513CC
	private void OnClickHeadItem()
	{
		if (this.CurrentRoleId == null)
		{
			return;
		}
		int index = this.Index;
		PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = index;
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(this.CurrentRoleId.Value, index);
		PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
		PhantomUtil.OpenVisionEquipmentView(this.CurrentRoleId.Value, index, null);
	}

	// Token: 0x04009E16 RID: 40470
	private PhantomDataBase CurrentData;

	// Token: 0x04009E17 RID: 40471
	private int? CurrentRoleId;

	// Token: 0x04009E18 RID: 40472
	private readonly int Index;

	// Token: 0x04009E19 RID: 40473
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008E4B RID: 36427
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E281 RID: 189057
		ButtonHeadItem,
		// Token: 0x0402E282 RID: 189058
		CircleItemTexture,
		// Token: 0x0402E283 RID: 189059
		QualitySprite,
		// Token: 0x0402E284 RID: 189060
		CostItem,
		// Token: 0x0402E285 RID: 189061
		CostNumText,
		// Token: 0x0402E286 RID: 189062
		SuitElementItem,
		// Token: 0x0402E287 RID: 189063
		LevelItem,
		// Token: 0x0402E288 RID: 189064
		LevelText,
		// Token: 0x0402E289 RID: 189065
		PanelNor,
		// Token: 0x0402E28A RID: 189066
		PanelEmpty
	}
}
