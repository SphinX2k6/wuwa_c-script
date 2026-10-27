using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D16 RID: 11542
[NullableContext(1)]
[Nullable(0)]
public class WeaponDetailTipsComponent : UiPanelBase
{
	// Token: 0x06018407 RID: 99335 RVA: 0x0062B810 File Offset: 0x00629A10
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

	// Token: 0x06018408 RID: 99336 RVA: 0x0062BA8C File Offset: 0x00629C8C
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

	// Token: 0x06018409 RID: 99337 RVA: 0x0062BABC File Offset: 0x00629CBC
	protected override void OnStart()
	{
		this.ReplaceButtonItem = new ButtonItem(base.GetItem(11));
		this.CultureButtonItem = new ButtonItem(base.GetItem(12));
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(4), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(5), new Func<AttributeItem>(this.InitAttributeItem), null, false, true);
		this.EquipItem = new CommonEquippedItem();
		this.EquipItem.CreateThenShowByActor(base.GetItem(10).GetOwner(), null);
	}

	// Token: 0x0601840A RID: 99338 RVA: 0x0062BB55 File Offset: 0x00629D55
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

	// Token: 0x0601840B RID: 99339 RVA: 0x0062BB77 File Offset: 0x00629D77
	public void SetCanShowLock(bool canShowLock)
	{
		this.CanShowLock = canShowLock;
	}

	// Token: 0x0601840C RID: 99340 RVA: 0x0062BB80 File Offset: 0x00629D80
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

	// Token: 0x0601840D RID: 99341 RVA: 0x0062BC94 File Offset: 0x00629E94
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
		this.StarLayout.RefreshByData(array.ToList<IStarItemData>(), null, false);
	}

	// Token: 0x0601840E RID: 99342 RVA: 0x0062BD04 File Offset: 0x00629F04
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x0601840F RID: 99343 RVA: 0x0062BD0B File Offset: 0x00629F0B
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06018410 RID: 99344 RVA: 0x0062BD14 File Offset: 0x00629F14
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

	// Token: 0x06018411 RID: 99345 RVA: 0x0062BDAC File Offset: 0x00629FAC
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

	// Token: 0x06018412 RID: 99346 RVA: 0x0062C04C File Offset: 0x0062A24C
	public void UpdateWeaponLock(bool isLock)
	{
		EToggleState state = isLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(3).SetToggleState(state, false, false, false);
	}

	// Token: 0x06018413 RID: 99347 RVA: 0x0062C072 File Offset: 0x0062A272
	public void UpdateWeaponBreachRedDot(bool state)
	{
		this.CultureButtonItem.SetRedDotVisible(state);
	}

	// Token: 0x06018414 RID: 99348 RVA: 0x0062C080 File Offset: 0x0062A280
	public void SetReplaceFunction(TWeaponDetailsTipsFunctionWithNumber replaceFunction)
	{
		this.ReplaceButtonItem.SetFunction(new Action<int>(replaceFunction.Invoke));
	}

	// Token: 0x06018415 RID: 99349 RVA: 0x0062C099 File Offset: 0x0062A299
	public void SetReplaceEnableClick(bool bEnableClick)
	{
		this.ReplaceButtonItem.SetEnableClick(bEnableClick);
	}

	// Token: 0x06018416 RID: 99350 RVA: 0x0062C0A7 File Offset: 0x0062A2A7
	public void SetCultureFunction(TWeaponDetailsTipsFunctionWithNumber cultureFunction)
	{
		this.CultureButtonItem.SetFunction(new Action<int>(cultureFunction.Invoke));
	}

	// Token: 0x06018417 RID: 99351 RVA: 0x0062C0C0 File Offset: 0x0062A2C0
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

	// Token: 0x06018418 RID: 99352 RVA: 0x0062C1A4 File Offset: 0x0062A3A4
	public int GetWeaponIncId()
	{
		WeaponInstance weaponInstance = this.WeaponData as WeaponInstance;
		if (weaponInstance != null)
		{
			return weaponInstance.GetIncId().GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x06018419 RID: 99353 RVA: 0x0062C1D0 File Offset: 0x0062A3D0
	private void SetLockToggleActive(bool value)
	{
		base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(value && this.CanShowLock);
	}

	// Token: 0x0601841A RID: 99354 RVA: 0x0062C202 File Offset: 0x0062A402
	private void SetReplaceCultureActive(bool value)
	{
		this.ReplaceButtonItem.SetActive(value);
		this.CultureButtonItem.SetActive(value);
	}

	// Token: 0x0601841B RID: 99355 RVA: 0x0062C21C File Offset: 0x0062A41C
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

	// Token: 0x0400B430 RID: 46128
	[Nullable(2)]
	protected WeaponDataBase WeaponData;

	// Token: 0x0400B431 RID: 46129
	[Nullable(2)]
	protected ButtonItem ReplaceButtonItem;

	// Token: 0x0400B432 RID: 46130
	[Nullable(2)]
	protected ButtonItem CultureButtonItem;

	// Token: 0x0400B433 RID: 46131
	protected bool CanShowEquip;

	// Token: 0x0400B434 RID: 46132
	[Nullable(2)]
	private CommonEquippedItem EquipItem;

	// Token: 0x0400B435 RID: 46133
	protected bool CanShowLock = true;

	// Token: 0x0400B436 RID: 46134
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B437 RID: 46135
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x020092A8 RID: 37544
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402F696 RID: 194198
		WeaponSprite,
		// Token: 0x0402F697 RID: 194199
		WeaponNameText,
		// Token: 0x0402F698 RID: 194200
		LevelText,
		// Token: 0x0402F699 RID: 194201
		LockToggle,
		// Token: 0x0402F69A RID: 194202
		StarHorizontalLayout,
		// Token: 0x0402F69B RID: 194203
		AttributeLayout,
		// Token: 0x0402F69C RID: 194204
		ResonanceLevelText,
		// Token: 0x0402F69D RID: 194205
		SkillNameText,
		// Token: 0x0402F69E RID: 194206
		SkillDescText,
		// Token: 0x0402F69F RID: 194207
		BgDescText,
		// Token: 0x0402F6A0 RID: 194208
		EquipItem,
		// Token: 0x0402F6A1 RID: 194209
		ReplaceItem,
		// Token: 0x0402F6A2 RID: 194210
		CultureItem,
		// Token: 0x0402F6A3 RID: 194211
		WeaponSpriteBg,
		// Token: 0x0402F6A4 RID: 194212
		MaxItem,
		// Token: 0x0402F6A5 RID: 194213
		MaxLevelText
	}
}
