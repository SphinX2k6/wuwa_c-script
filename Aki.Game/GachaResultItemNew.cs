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

// Token: 0x02001C9C RID: 7324
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaResultItemNew : GridProxyAbstract<global::GachaResult>
{
	// Token: 0x0600DD05 RID: 56581 RVA: 0x00339170 File Offset: 0x00337370
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

	// Token: 0x0600DD06 RID: 56582 RVA: 0x003392B8 File Offset: 0x003374B8
	protected override UniTask OnBeforeStartAsync()
	{
		GachaResultItemNew.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaResultItemNew.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD07 RID: 56583 RVA: 0x003392FC File Offset: 0x003374FC
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

	// Token: 0x0600DD08 RID: 56584 RVA: 0x003393BC File Offset: 0x003375BC
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

	// Token: 0x0600DD09 RID: 56585 RVA: 0x003394D0 File Offset: 0x003376D0
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

	// Token: 0x0600DD0A RID: 56586 RVA: 0x003397A2 File Offset: 0x003379A2
	public override void Refresh(global::GachaResult data, bool isSelected, int gridIndex)
	{
		this.Update(data);
	}

	// Token: 0x0600DD0B RID: 56587 RVA: 0x003397AB File Offset: 0x003379AB
	public void RefreshShare()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0400655D RID: 25949
	private int ItemId;

	// Token: 0x0400655E RID: 25950
	private int TrialId;

	// Token: 0x0400655F RID: 25951
	[Nullable(2)]
	private SmallItemGrid ConvertItem;

	// Token: 0x02008275 RID: 33397
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A8FD RID: 174333
		QualityBgSprite,
		// Token: 0x0402A8FE RID: 174334
		QualitySprite,
		// Token: 0x0402A8FF RID: 174335
		PreviewBtn,
		// Token: 0x0402A900 RID: 174336
		AttributeRootItem,
		// Token: 0x0402A901 RID: 174337
		AttributeTexture,
		// Token: 0x0402A902 RID: 174338
		NewItemTips,
		// Token: 0x0402A903 RID: 174339
		ConvertRootItem,
		// Token: 0x0402A904 RID: 174340
		ConvertItem,
		// Token: 0x0402A905 RID: 174341
		ItemTexture,
		// Token: 0x0402A906 RID: 174342
		StarRootItem,
		// Token: 0x0402A907 RID: 174343
		StarItem,
		// Token: 0x0402A908 RID: 174344
		QualityNiagara
	}
}
