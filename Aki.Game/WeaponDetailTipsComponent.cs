using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002270 RID: 8816
[NullableContext(1)]
[Nullable(0)]
public class WeaponDetailTipsComponent : UiPanelBase
{
	// Token: 0x06015CA8 RID: 89256 RVA: 0x00651808 File Offset: 0x0064FA08
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.LockToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015CA9 RID: 89257 RVA: 0x00651A84 File Offset: 0x0064FC84
	private void LockToggleClick(EToggleState state)
	{
		bool bLock = state != EToggleState.ETT_Checked;
		int weaponIncId = this.GetWeaponIncId();
		if (weaponIncId <= 0)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(weaponIncId, bLock);
	}

	// Token: 0x06015CAA RID: 89258 RVA: 0x00651AB4 File Offset: 0x0064FCB4
	protected override void OnStart()
	{
		this.ReplaceButtonItem = new ButtonItem(base.GetItem(11));
		this.CultureButtonItem = new ButtonItem(base.GetItem(12));
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(4), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(5), new Func<AttributeItem>(this.InitAttributeItem), null, false, true);
		this.EquipItem = new CommonEquippedItem();
		this.EquipItem.CreateThenShowByActor(base.GetItem(10).GetOwner(), null);
	}

	// Token: 0x06015CAB RID: 89259 RVA: 0x00651B4D File Offset: 0x0064FD4D
	public void SetCanShowEquip(bool canShowEquip = false)
	{
		this.CanShowEquip = canShowEquip;
		if (!this.CanShowEquip)
		{
			CommonEquippedItem equipItem = this.EquipItem;
			if (equipItem == null)
			{
				return;
			}
			equipItem.SetIconRootItemState(false);
		}
	}

	// Token: 0x06015CAC RID: 89260 RVA: 0x00651B6F File Offset: 0x0064FD6F
	public void SetCanShowLock(bool canShowLock)
	{
		this.CanShowLock = canShowLock;
	}

	// Token: 0x06015CAD RID: 89261 RVA: 0x00651B78 File Offset: 0x0064FD78
	private void UpdateAttribute(WeaponConf weaponConfig)
	{
		WeaponAttributeParam[] array = new WeaponAttributeParam[]
		{
			new WeaponAttributeParam
			{
				PropId = weaponConfig.FirstPropId.Value,
				CurveId = weaponConfig.FirstCurve
			},
			new WeaponAttributeParam
			{
				PropId = weaponConfig.SecondPropId.Value,
				CurveId = weaponConfig.SecondCurve
			}
		};
		int level = this.WeaponData.GetLevel();
		int breachLevel = this.WeaponData.GetBreachLevel();
		List<CSharpScript.Game.Module.Common.AttributeData> list = new List<CSharpScript.Game.Module.Common.AttributeData>();
		foreach (WeaponAttributeParam weaponAttributeParam in array)
		{
			ConfigPropValue propId = weaponAttributeParam.PropId;
			float curveValue = WeaponModel.Instance.GetCurveValue(weaponAttributeParam.CurveId, propId.Value, level, breachLevel);
			CSharpScript.Game.Module.Common.AttributeData item = new CSharpScript.Game.Module.Common.AttributeData
			{
				Id = propId.Id,
				IsRatio = propId.IsRatio,
				CurValue = curveValue,
				BgActive = new bool?(true)
			};
			list.Add(item);
		}
		this.AttributeLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06015CAE RID: 89262 RVA: 0x00651C8C File Offset: 0x0064FE8C
	private void UpdateStar(int breachLevel, int maxLevel)
	{
		IStarItemData[] array = new IStarItemData[maxLevel];
		for (int i = 0; i < maxLevel; i++)
		{
			StarItemData starItemData = new StarItemData
			{
				StarOnActive = (i < breachLevel),
				StarOffActive = (i >= breachLevel),
				StarNextActive = false,
				StarLoopActive = false,
				PlayLoopSequence = false,
				PlayActivateSequence = false
			};
			array[i] = starItemData;
		}
		this.StarLayout.RefreshByData(array, null, false);
	}

	// Token: 0x06015CAF RID: 89263 RVA: 0x00651CF7 File Offset: 0x0064FEF7
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06015CB0 RID: 89264 RVA: 0x00651CFE File Offset: 0x0064FEFE
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06015CB1 RID: 89265 RVA: 0x00651D08 File Offset: 0x0064FF08
	private void UpdateWeaponIcon(int weaponType)
	{
		foreach (Mapping mapping in MappingConfig.Instance.GetWeaponConfList())
		{
			if (weaponType == mapping.Value)
			{
				this.SetSpriteByPath(mapping.Icon, base.GetSprite(0), false, null, null);
				this.SetSpriteByPath(mapping.Icon, base.GetSprite(13), false, null, null);
				break;
			}
		}
	}

	// Token: 0x06015CB2 RID: 89266 RVA: 0x00651DA0 File Offset: 0x0064FFA0
	public void UpdateComponent(WeaponDataBase weaponData)
	{
		this.WeaponData = weaponData;
		WeaponConf value = weaponData.GetWeaponConfig().Value;
		int level = weaponData.GetLevel();
		int breachLevel = weaponData.GetBreachLevel();
		string weaponName = value.WeaponName;
		int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(value.BreachId);
		WeaponBreach? breachConfig = weaponData.GetBreachConfig();
		int resonanceLevel = weaponData.GetResonanceLevel();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Level_Text_New", new <>z__ReadOnlyArray<object>(new object[]
		{
			level,
			breachConfig.Value.LevelLimit
		}));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "Level_Text_New_Suffix", new <>z__ReadOnlySingleElementList<object>(breachConfig.Value.LevelLimit.ToString()));
		base.GetItem(14).SetUIActive(level >= breachConfig.Value.LevelLimit);
		FColor color = FColor.FromHex(ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(1).SetColor(color);
		base.GetText(1).ShowTextNew(weaponName);
		this.UpdateWeaponIcon(value.WeaponType);
		this.UpdateAttribute(value);
		this.UpdateStar(breachLevel, weaponBreachMaxLevel);
		LguiUtil.Instance.SetLocalText(base.GetText(6), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>(resonanceLevel));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.BgDescription, Array.Empty<object>());
		WeaponReson? weaponResonanceConfig = WeaponConfig.Instance.GetWeaponResonanceConfig(value.ResonId, resonanceLevel);
		if (weaponResonanceConfig != null)
		{
			base.GetText(7).SetUIActive(true);
			base.GetText(8).SetUIActive(true);
			base.GetText(7).SetText(WeaponConfig.Instance.GetWeaponResonanceDesc(weaponResonanceConfig.Value.Name), true);
			string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(value, resonanceLevel);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.Desc, weaponConfigDescParams);
		}
		else
		{
			base.GetText(7).SetUIActive(false);
			base.GetText(8).SetUIActive(false);
		}
		WeaponInstance weaponInstance = weaponData as WeaponInstance;
		if (weaponInstance != null)
		{
			this.SetLockToggleActive(true);
			this.SetReplaceCultureActive(true);
			int value2 = weaponInstance.GetIncId().Value;
			this.ReplaceButtonItem.SetData(value2);
			this.CultureButtonItem.SetData(value2);
			this.UpdateWeaponLock(weaponInstance.IsLock());
			return;
		}
		this.SetLockToggleActive(false);
		this.SetReplaceCultureActive(false);
	}

	// Token: 0x06015CB3 RID: 89267 RVA: 0x00652040 File Offset: 0x00650240
	public void UpdateWeaponLock(bool isLock)
	{
		EToggleState state = isLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(3).SetToggleState(state, false, false, false);
	}

	// Token: 0x06015CB4 RID: 89268 RVA: 0x00652066 File Offset: 0x00650266
	public void UpdateWeaponBreachRedDot(bool state)
	{
		this.CultureButtonItem.SetRedDotVisible(state);
	}

	// Token: 0x06015CB5 RID: 89269 RVA: 0x00652074 File Offset: 0x00650274
	public void SetReplaceFunction(TWeaponDetailsTipsFunctionWithNumber replaceFunction)
	{
		this.ReplaceButtonItem.SetFunction(new Action<int>(replaceFunction.Invoke));
	}

	// Token: 0x06015CB6 RID: 89270 RVA: 0x0065208D File Offset: 0x0065028D
	public void SetReplaceEnableClick(bool bEnableClick)
	{
		this.ReplaceButtonItem.SetEnableClick(bEnableClick);
	}

	// Token: 0x06015CB7 RID: 89271 RVA: 0x0065209B File Offset: 0x0065029B
	public void SetCultureFunction(TWeaponDetailsTipsFunctionWithNumber cultureFunction)
	{
		this.CultureButtonItem.SetFunction(new Action<int>(cultureFunction.Invoke));
	}

	// Token: 0x06015CB8 RID: 89272 RVA: 0x006520B4 File Offset: 0x006502B4
	public void UpdateEquip(int roleId)
	{
		if (!this.CanShowEquip)
		{
			return;
		}
		WeaponInstance weaponInstance = this.WeaponData as WeaponInstance;
		if (weaponInstance != null)
		{
			int roleId2 = weaponInstance.GetRoleId();
			if (roleId2 == 0)
			{
				this.EquipItem.SetCurrentEquippedState(false);
				this.EquipItem.SetIconRootItemState(false);
				this.ReplaceButtonItem.SetEnableClick(true);
				return;
			}
			this.ReplaceButtonItem.SetEnableClick(roleId2 != roleId);
			this.EquipItem.SetCurrentEquippedState(true);
			this.EquipItem.SetIconRootItemState(true);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId2, true);
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleDataById.GetRoleSkinId());
			this.EquipItem.SetEquipIcon(roleSkinData.GetRoleSkinConfig().RoleHeadIcon);
			this.EquipItem.SetEquipText("WeaponTipsRoleText", new object[]
			{
				new TableTextArgNew(roleSkinData.GetName(), Array.Empty<object>())
			});
		}
	}

	// Token: 0x06015CB9 RID: 89273 RVA: 0x00652198 File Offset: 0x00650398
	public int GetWeaponIncId()
	{
		WeaponInstance weaponInstance = this.WeaponData as WeaponInstance;
		if (weaponInstance != null)
		{
			return weaponInstance.GetIncId().GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x06015CBA RID: 89274 RVA: 0x006521C4 File Offset: 0x006503C4
	private void SetLockToggleActive(bool value)
	{
		base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(value && this.CanShowLock);
	}

	// Token: 0x06015CBB RID: 89275 RVA: 0x006521F6 File Offset: 0x006503F6
	private void SetReplaceCultureActive(bool value)
	{
		this.ReplaceButtonItem.SetActive(value);
		this.CultureButtonItem.SetActive(value);
	}

	// Token: 0x06015CBC RID: 89276 RVA: 0x00652210 File Offset: 0x00650410
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "武器详情界面聚焦引导的额外参数配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		UUIItem guideUiItem = base.GetGuideUiItem(configParams[1]);
		if (guideUiItem == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "武器详情界面聚焦引导的额外参数配置错误";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("configParams", configParams);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return new UUIItem[]
		{
			guideUiItem,
			guideUiItem
		};
	}

	// Token: 0x0400B7A5 RID: 47013
	[Nullable(2)]
	protected WeaponDataBase WeaponData;

	// Token: 0x0400B7A6 RID: 47014
	[Nullable(2)]
	protected ButtonItem ReplaceButtonItem;

	// Token: 0x0400B7A7 RID: 47015
	[Nullable(2)]
	protected ButtonItem CultureButtonItem;

	// Token: 0x0400B7A8 RID: 47016
	protected bool CanShowEquip;

	// Token: 0x0400B7A9 RID: 47017
	[Nullable(2)]
	private CommonEquippedItem EquipItem;

	// Token: 0x0400B7AA RID: 47018
	protected bool CanShowLock = true;

	// Token: 0x0400B7AB RID: 47019
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B7AC RID: 47020
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x020084D0 RID: 34000
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402AD20 RID: 175392
		WeaponSprite,
		// Token: 0x0402AD21 RID: 175393
		WeaponNameText,
		// Token: 0x0402AD22 RID: 175394
		LevelText,
		// Token: 0x0402AD23 RID: 175395
		LockToggle,
		// Token: 0x0402AD24 RID: 175396
		StarHorizontalLayout,
		// Token: 0x0402AD25 RID: 175397
		AttributeLayout,
		// Token: 0x0402AD26 RID: 175398
		ResonanceLevelText,
		// Token: 0x0402AD27 RID: 175399
		SkillNameText,
		// Token: 0x0402AD28 RID: 175400
		SkillDescText,
		// Token: 0x0402AD29 RID: 175401
		BgDescText,
		// Token: 0x0402AD2A RID: 175402
		EquipItem,
		// Token: 0x0402AD2B RID: 175403
		ReplaceItem,
		// Token: 0x0402AD2C RID: 175404
		CultureItem,
		// Token: 0x0402AD2D RID: 175405
		WeaponSpriteBg,
		// Token: 0x0402AD2E RID: 175406
		MaxItem,
		// Token: 0x0402AD2F RID: 175407
		MaxLevelText
	}
}
