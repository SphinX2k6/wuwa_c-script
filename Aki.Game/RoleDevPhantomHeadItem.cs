using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D84 RID: 7556
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomHeadItem : UiPanelBase
{
	// Token: 0x06012A79 RID: 76409 RVA: 0x0057DC71 File Offset: 0x0057BE71
	public RoleDevPhantomHeadItem(int index)
	{
		this.Index = index;
	}

	// Token: 0x06012A7A RID: 76410 RVA: 0x0057DC80 File Offset: 0x0057BE80
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

	// Token: 0x06012A7B RID: 76411 RVA: 0x0057DD98 File Offset: 0x0057BF98
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomHeadItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomHeadItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012A7C RID: 76412 RVA: 0x0057DDDB File Offset: 0x0057BFDB
	public void SetRoleId(int roleId)
	{
		this.CurrentRoleId = new int?(roleId);
	}

	// Token: 0x06012A7D RID: 76413 RVA: 0x0057DDE9 File Offset: 0x0057BFE9
	public void UpdateItem(PhantomDataBase data)
	{
		this.CurrentData = data;
		this.OnUpdateItem(data);
	}

	// Token: 0x06012A7E RID: 76414 RVA: 0x0057DDFC File Offset: 0x0057BFFC
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

	// Token: 0x06012A7F RID: 76415 RVA: 0x0057DE8C File Offset: 0x0057C08C
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

	// Token: 0x06012A80 RID: 76416 RVA: 0x0057DEE0 File Offset: 0x0057C0E0
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

	// Token: 0x06012A81 RID: 76417 RVA: 0x0057DF2C File Offset: 0x0057C12C
	[NullableContext(1)]
	private void RefreshNum(PhantomDataBase data)
	{
		UUIText text = base.GetText(4);
		if (text != null && data != null)
		{
			text.SetText(data.GetCost().ToString(), true);
		}
	}

	// Token: 0x06012A82 RID: 76418 RVA: 0x0057DF5C File Offset: 0x0057C15C
	[NullableContext(1)]
	private void RefreshLevel(PhantomDataBase data)
	{
		UUIText text = base.GetText(7);
		if (text != null && data != null)
		{
			text.SetText("+" + data.GetPhantomLevel().ToString(), true);
		}
	}

	// Token: 0x06012A83 RID: 76419 RVA: 0x0057DF96 File Offset: 0x0057C196
	public PhantomDataBase GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x06012A84 RID: 76420 RVA: 0x0057DFA0 File Offset: 0x0057C1A0
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

	// Token: 0x0400A1FF RID: 41471
	private PhantomDataBase CurrentData;

	// Token: 0x0400A200 RID: 41472
	private int? CurrentRoleId;

	// Token: 0x0400A201 RID: 41473
	private readonly int Index;

	// Token: 0x0400A202 RID: 41474
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008093 RID: 32915
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402997D RID: 170365
		ButtonHeadItem,
		// Token: 0x0402997E RID: 170366
		CircleItemTexture,
		// Token: 0x0402997F RID: 170367
		QualitySprite,
		// Token: 0x04029980 RID: 170368
		CostItem,
		// Token: 0x04029981 RID: 170369
		CostNumText,
		// Token: 0x04029982 RID: 170370
		SuitElementItem,
		// Token: 0x04029983 RID: 170371
		LevelItem,
		// Token: 0x04029984 RID: 170372
		LevelText,
		// Token: 0x04029985 RID: 170373
		PanelNor,
		// Token: 0x04029986 RID: 170374
		PanelEmpty
	}
}
