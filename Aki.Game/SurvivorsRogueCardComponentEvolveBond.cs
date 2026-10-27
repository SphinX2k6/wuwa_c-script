using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AC9 RID: 10953
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardComponentEvolveBond : SurvivorsRogueCardComponent
{
	// Token: 0x06016CB4 RID: 93364 RVA: 0x005C9C08 File Offset: 0x005C7E08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06016CB5 RID: 93365 RVA: 0x005C9C64 File Offset: 0x005C7E64
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardComponentEvolveBond.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardComponentEvolveBond.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016CB6 RID: 93366 RVA: 0x005C9CA7 File Offset: 0x005C7EA7
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardBind";
	}

	// Token: 0x06016CB7 RID: 93367 RVA: 0x005C9CAE File Offset: 0x005C7EAE
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x06016CB8 RID: 93368 RVA: 0x005C9CB4 File Offset: 0x005C7EB4
	protected override void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		int num = (params_.Length != 0 && params_[0] != null) ? ((int)params_[0]) : 0;
		if (num == 0)
		{
			this.SetActive(false);
			return;
		}
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(num);
		if (survivorsWeapon == null)
		{
			this.SetActive(false);
			return;
		}
		this.AttributeItemCurrent.SetIsUp(false);
		this.AttributeItemCurrent.SetTextureIcon(survivorsWeapon.Value.Icon);
		int weaponBondOwnedWeaponId = SurvivorsRogueModel.Instance.GainData.GetWeaponBondOwnedWeaponId(num);
		if (weaponBondOwnedWeaponId != 0)
		{
			SurvivorsWeapon? survivorsWeapon2 = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponBondOwnedWeaponId);
			this.AttributeItemBind.SetIsUp(true);
			this.AttributeItemBind.SetTextureIcon(survivorsWeapon2.Value.Icon);
			this.AttributeItemBind.SetTextureIcon(survivorsWeapon2.Value.Icon);
			this.SetActive(true);
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x0400A955 RID: 43349
	private SurvivorsRogueCardAttributeItem AttributeItemCurrent;

	// Token: 0x0400A956 RID: 43350
	private SurvivorsRogueCardAttributeItem AttributeItemBind;
}
