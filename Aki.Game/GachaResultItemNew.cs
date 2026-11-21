using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200115B RID: 4443
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaResultItemNew : GridProxyAbstract<global::GachaResult>
{
	// Token: 0x0600B11B RID: 45339 RVA: 0x003446B8 File Offset: 0x003428B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUINiagara))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnPreviewBtnClick))
		};
	}

	// Token: 0x0600B11C RID: 45340 RVA: 0x00344800 File Offset: 0x00342A00
	protected override UniTask OnBeforeStartAsync()
	{
		GachaResultItemNew.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaResultItemNew.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B11D RID: 45341 RVA: 0x00344844 File Offset: 0x00342A44
	private unsafe void OnPreviewBtnClick()
	{
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(this.ItemId);
		if (itemIdType == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleController instance = RoleController.Instance;
			ERoleAgentType agentType = ERoleAgentType.Preview;
			int trialId = this.TrialId;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = this.TrialId;
			instance.OpenRoleMainView(agentType, trialId, list, null, null);
			return;
		}
		if (itemIdType != InventoryDefine.EItemDataType.WeaponItem)
		{
			return;
		}
		if (this.TrialId > 0)
		{
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(this.TrialId, true);
			IWeaponPreviewViewParam param = new WeaponPreviewViewParam
			{
				WeaponDataList = new WeaponDataBase[]
				{
					weaponTrialData
				},
				SelectedIndex = 0
			};
			UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
		}
	}

	// Token: 0x0600B11E RID: 45342 RVA: 0x00344904 File Offset: 0x00342B04
	public void UpdateQuality(int quality)
	{
		for (int i = 0; i < quality - 1; i++)
		{
			LguiUtil.Instance.CopyItem(base.GetItem(10), base.GetItem(9));
		}
		QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(quality);
		if (qualityConfig == null)
		{
			return;
		}
		string gachaQualityTexture = qualityConfig.Value.GachaQualityTexture;
		if (!string.IsNullOrEmpty(gachaQualityTexture))
		{
			this.SetSpriteByPath(gachaQualityTexture, base.GetSprite(1), true, new EUiViewName?(EUiViewName.GachaResultView), null);
		}
		string gachaBgTexture = qualityConfig.Value.GachaBgTexture;
		if (!string.IsNullOrEmpty(gachaBgTexture))
		{
			this.SetSpriteByPath(gachaBgTexture, base.GetSprite(0), true, new EUiViewName?(EUiViewName.GachaResultView), null);
		}
		string text = null;
		if (quality != 4)
		{
			if (quality == 5)
			{
				text = UiResourceConfig.Instance.GetResourcePath("NS_Fx_LGUI_GachaResultGold");
			}
		}
		else
		{
			text = UiResourceConfig.Instance.GetResourcePath("NS_Fx_LGUI_GachaResultPurple");
		}
		UUINiagara uiNiagara = base.GetUiNiagara(11);
		if (!string.IsNullOrEmpty(text))
		{
			uiNiagara.SetUIActive(true);
			base.SetNiagaraSystemByPath(text, uiNiagara, null);
			return;
		}
		uiNiagara.SetUIActive(false);
	}

	// Token: 0x0600B11F RID: 45343 RVA: 0x00344A18 File Offset: 0x00342C18
	public void Update(global::GachaResult data)
	{
		int itemId = data.Proto_GachaReward.ItemId;
		this.ItemId = itemId;
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId);
		if (gachaTextureInfo == null)
		{
			return;
		}
		this.TrialId = gachaTextureInfo.Value.TrialId;
		IReadOnlyList<GachaReward> proto_TransformRewards = data.Proto_TransformRewards;
		if (proto_TransformRewards != null && proto_TransformRewards.Count > 0)
		{
			base.GetItem(6).SetUIActive(true);
			GachaReward gachaReward = proto_TransformRewards[0];
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = gachaReward.ItemId,
				QualityId = new int?(0),
				ItemConfigId = new int?(gachaReward.ItemId),
				BottomText = gachaReward.ItemCount.ToString()
			};
			SmallItemGrid convertItem = this.ConvertItem;
			if (convertItem != null)
			{
				convertItem.Apply<PropSmallItemGrid>(parameters);
			}
			SmallItemGrid convertItem2 = this.ConvertItem;
			if (convertItem2 != null)
			{
				convertItem2.SetBottomTextVisible(gachaReward.ItemCount > 1);
			}
		}
		else
		{
			SmallItemGrid convertItem3 = this.ConvertItem;
			if (convertItem3 != null)
			{
				convertItem3.SetUiActive(false);
			}
			base.GetItem(6).SetUIActive(!data.IsNew);
		}
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
		int quality = 0;
		if (itemIdType != InventoryDefine.EItemDataType.RoleItem)
		{
			if (itemIdType != InventoryDefine.EItemDataType.WeaponItem)
			{
			}
			base.GetItem(3).SetUIActive(true);
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
			if (weaponConfigByItemId != null)
			{
				GachaWeaponTransform? gachaWeaponTransformConfig = GachaConfig.Instance.GetGachaWeaponTransformConfig(weaponConfigByItemId.Value.WeaponType);
				if (gachaWeaponTransformConfig != null)
				{
					base.SetTextureByPath(gachaWeaponTransformConfig.Value.WeaponTypeTexture, base.GetTexture(4), null, null);
				}
				quality = itemConfigData.QualityId;
				base.GetItem(5).SetUIActive(data.IsNew);
				base.GetItem(6).SetUIActive(false);
			}
		}
		else
		{
			base.GetItem(3).SetUIActive(true);
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId);
			if (roleInfoById != null)
			{
				object obj = CommonConfig.Instance.GetElementConfig(roleInfoById.Value.ElementId);
				if (obj != null)
				{
					ElementInfo elementInfo = (ElementInfo)obj;
					UUITexture texture = base.GetTexture(4);
					base.SetTextureByPath(elementInfo.Icon, texture, null, null);
					FColor color = FColor.FromHex(elementInfo.ElementColor);
					texture.SetColor(color);
				}
				quality = roleInfoById.Value.QualityId;
				base.GetItem(5).SetUIActive(data.IsNew);
			}
		}
		this.UpdateQuality(quality);
		base.SetTextureByPath(gachaTextureInfo.Value.GachaResultViewTexture, base.GetTexture(8), new EUiViewName?(EUiViewName.GachaResultView), null);
	}

	// Token: 0x0600B120 RID: 45344 RVA: 0x00344CEA File Offset: 0x00342EEA
	public override void Refresh(global::GachaResult data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x0600B121 RID: 45345 RVA: 0x00344CF3 File Offset: 0x00342EF3
	public void RefreshShare()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0400662F RID: 26159
	private int ItemId;

	// Token: 0x04006630 RID: 26160
	private int TrialId;

	// Token: 0x04006631 RID: 26161
	[Nullable(2)]
	private SmallItemGrid ConvertItem;

	// Token: 0x020073FC RID: 29692
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025C1C RID: 154652
		QualityBgSprite,
		// Token: 0x04025C1D RID: 154653
		QualitySprite,
		// Token: 0x04025C1E RID: 154654
		PreviewBtn,
		// Token: 0x04025C1F RID: 154655
		AttributeRootItem,
		// Token: 0x04025C20 RID: 154656
		AttributeTexture,
		// Token: 0x04025C21 RID: 154657
		NewItemTips,
		// Token: 0x04025C22 RID: 154658
		ConvertRootItem,
		// Token: 0x04025C23 RID: 154659
		ConvertItem,
		// Token: 0x04025C24 RID: 154660
		ItemTexture,
		// Token: 0x04025C25 RID: 154661
		StarRootItem,
		// Token: 0x04025C26 RID: 154662
		StarItem,
		// Token: 0x04025C27 RID: 154663
		QualityNiagara
	}
}
