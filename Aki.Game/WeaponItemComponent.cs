using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020BD RID: 8381
internal class WeaponItemComponent : GridProxyAbstract<int>
{
	// Token: 0x060149BD RID: 84413 RVA: 0x006018F8 File Offset: 0x005FFAF8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x060149BE RID: 84414 RVA: 0x0060198C File Offset: 0x005FFB8C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CachedSurvivorWeaponId = data;
		SurvivorsWeapon value = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(data).Value;
		SurvivorsWeaponEvolve value2 = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponDefaultEvolve(data).Value;
		SurvivorsQuality value3 = SurvivorsRogueConfig.Instance.GetQualityConfig(value2.Quality).Value;
		base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
		base.GetSprite(3).SetColor(FColor.FromHex(value3.WeaponColor));
	}

	// Token: 0x060149BF RID: 84415 RVA: 0x00601A38 File Offset: 0x005FFC38
	private void OnClickButton()
	{
		SurvivorsRogueWeaponCard param = SurvivorsRogueCardDataFactory.CreateGeneralWeapon(this.CachedSurvivorWeaponId);
		UiManager.Instance.OpenView(EUiViewName.SurvivorsCardTips, param, null);
	}

	// Token: 0x060149C0 RID: 84416 RVA: 0x00601A62 File Offset: 0x005FFC62
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0400AF48 RID: 44872
	private int CachedSurvivorWeaponId = -1;
}
