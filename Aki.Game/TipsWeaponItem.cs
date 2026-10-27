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

// Token: 0x020019CC RID: 6604
public class TipsWeaponItem : UiPanelBase
{
	// Token: 0x0600C0CA RID: 49354 RVA: 0x002B7EEC File Offset: 0x002B60EC
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

	// Token: 0x0600C0CB RID: 49355 RVA: 0x002B7F88 File Offset: 0x002B6188
	protected override UniTask OnBeforeStartAsync()
	{
		TipsWeaponItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TipsWeaponItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C0CC RID: 49356 RVA: 0x002B7FCC File Offset: 0x002B61CC
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

	// Token: 0x040056B0 RID: 22192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<CSharpScript.Game.Module.RoleUi.StarItem> StarItemList;

	// Token: 0x02007EF1 RID: 32497
	private enum ETipsWeaponItemDefine
	{
		// Token: 0x0402979C RID: 169884
		DescribeText = 8,
		// Token: 0x0402979D RID: 169885
		ResonanceLevelText = 0,
		// Token: 0x0402979E RID: 169886
		ResonanceDescribeText = 7,
		// Token: 0x0402979F RID: 169887
		SkillNameText = 1,
		// Token: 0x040297A0 RID: 169888
		PanelStar = 3,
		// Token: 0x040297A1 RID: 169889
		WeaponLevelText = 2
	}
}
