using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002ACF RID: 10959
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardComponentWeaponItem : SurvivorsRogueCardComponent
{
	// Token: 0x06016CC6 RID: 93382 RVA: 0x005CA064 File Offset: 0x005C8264
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016CC7 RID: 93383 RVA: 0x005CA0BE File Offset: 0x005C82BE
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardWeapon";
	}

	// Token: 0x06016CC8 RID: 93384 RVA: 0x005CA0C5 File Offset: 0x005C82C5
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Center;
	}

	// Token: 0x06016CC9 RID: 93385 RVA: 0x005CA0C8 File Offset: 0x005C82C8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardComponentWeaponItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardComponentWeaponItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016CCA RID: 93386 RVA: 0x005CA10C File Offset: 0x005C830C
	protected override void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		int weaponId = (params_.Length != 0 && params_[0] != null) ? ((int)params_[0]) : 0;
		int qualityId = (params_.Length > 1 && params_[1] != null) ? ((int)params_[1]) : 0;
		int? num = (params_.Length > 2 && params_[2] != null) ? ((int?)params_[2]) : null;
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId);
		if (survivorsWeapon == null)
		{
			this.SetActive(false);
			return;
		}
		base.SetTextureByPath(SurvivorsRogueConfig.Instance.GetQualityConfig(qualityId).Value.WeaponBasePath, base.GetTexture(0), null, null);
		base.SetTextureShowUntilLoaded(survivorsWeapon.Value.Icon, base.GetTexture(1), null);
		if (num != null)
		{
			SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(num.Value);
			this.AttributeItem.SetTextureIcon((propertyConfig != null) ? propertyConfig.GetValueOrDefault().Icon : null);
		}
		this.AttributeItem.SetActive(num != null);
		this.SetActive(true);
	}

	// Token: 0x0400A961 RID: 43361
	private SurvivorsRogueCardAttributeItem AttributeItem;
}
