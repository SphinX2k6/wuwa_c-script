using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002045 RID: 8261
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardComponentEvolveBond : SurvivorsRogueCardComponent
{
	// Token: 0x060146E5 RID: 83685 RVA: 0x005F675C File Offset: 0x005F495C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060146E6 RID: 83686 RVA: 0x005F67B8 File Offset: 0x005F49B8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardComponentEvolveBond.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardComponentEvolveBond.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060146E7 RID: 83687 RVA: 0x005F67FB File Offset: 0x005F49FB
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardBind";
	}

	// Token: 0x060146E8 RID: 83688 RVA: 0x005F6802 File Offset: 0x005F4A02
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x060146E9 RID: 83689 RVA: 0x005F6808 File Offset: 0x005F4A08
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

	// Token: 0x0400AD5B RID: 44379
	private SurvivorsRogueCardAttributeItem AttributeItemCurrent;

	// Token: 0x0400AD5C RID: 44380
	private SurvivorsRogueCardAttributeItem AttributeItemBind;
}
