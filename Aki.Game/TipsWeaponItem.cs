using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E8B RID: 3723
public class TipsWeaponItem : UiPanelBase
{
	// Token: 0x060094D7 RID: 38103 RVA: 0x002C2EB8 File Offset: 0x002C10B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x002C2F54 File Offset: 0x002C1154
	protected override UniTask OnBeforeStartAsync()
	{
		TipsWeaponItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TipsWeaponItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x002C2F98 File Offset: 0x002C1198
	[NullableContext(1)]
	public void UpdateItem(WeaponConf weaponConfig, int resonanceLevel, string descriptionText)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>(resonanceLevel));
		WeaponReson? weaponResonanceConfig = WeaponConfig.Instance.GetWeaponResonanceConfig(weaponConfig.ResonId, resonanceLevel);
		base.GetText(8).SetText(descriptionText, true);
		if (weaponResonanceConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), weaponResonanceConfig.Value.Name, Array.Empty<object>());
		}
		string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(weaponConfig, resonanceLevel);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), weaponConfig.Desc, weaponConfigDescParams);
		WeaponBreach? weaponBreach = WeaponConfig.Instance.GetWeaponBreach(weaponConfig.BreachId, 0);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "ShopWeaponLevelText", new <>z__ReadOnlyArray<object>(new object[]
		{
			1,
			weaponBreach.Value.LevelLimit
		}));
		UiComponentUtil.SetStarActiveNew(this.StarItemList.ToArray(), 0, null, false);
	}

	// Token: 0x04005762 RID: 22370
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<CSharpScript.Game.Module.RoleUi.StarItem> StarItemList;

	// Token: 0x02007080 RID: 28800
	private enum ETipsWeaponItemDefine
	{
		// Token: 0x04024AD9 RID: 150233
		DescribeText = 8,
		// Token: 0x04024ADA RID: 150234
		ResonanceLevelText = 0,
		// Token: 0x04024ADB RID: 150235
		ResonanceDescribeText = 7,
		// Token: 0x04024ADC RID: 150236
		SkillNameText = 1,
		// Token: 0x04024ADD RID: 150237
		PanelStar = 3,
		// Token: 0x04024ADE RID: 150238
		WeaponLevelText = 2
	}
}
