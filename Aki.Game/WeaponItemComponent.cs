using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B41 RID: 11073
internal class WeaponItemComponent : GridProxyAbstract<int>
{
	// Token: 0x06016F8C RID: 94092 RVA: 0x005D4D8C File Offset: 0x005D2F8C
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

	// Token: 0x06016F8D RID: 94093 RVA: 0x005D4E20 File Offset: 0x005D3020
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

	// Token: 0x06016F8E RID: 94094 RVA: 0x005D4ECC File Offset: 0x005D30CC
	private void OnClickButton()
	{
		SurvivorsRogueWeaponCard param = SurvivorsRogueCardDataFactory.CreateGeneralWeapon(this.CachedSurvivorWeaponId);
		UiManager.Instance.OpenView(EUiViewName.SurvivorsCardTips, param, null);
	}

	// Token: 0x06016F8F RID: 94095 RVA: 0x005D4EF6 File Offset: 0x005D30F6
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0400AB42 RID: 43842
	private int CachedSurvivorWeaponId = -1;
}
