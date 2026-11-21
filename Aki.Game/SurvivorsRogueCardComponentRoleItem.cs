using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002049 RID: 8265
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardComponentRoleItem : SurvivorsRogueCardComponent
{
	// Token: 0x060146F1 RID: 83697 RVA: 0x005F69EF File Offset: 0x005F4BEF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060146F2 RID: 83698 RVA: 0x005F6A28 File Offset: 0x005F4C28
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardComponentRoleItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardComponentRoleItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060146F3 RID: 83699 RVA: 0x005F6A6B File Offset: 0x005F4C6B
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardRole";
	}

	// Token: 0x060146F4 RID: 83700 RVA: 0x005F6A72 File Offset: 0x005F4C72
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Center;
	}

	// Token: 0x060146F5 RID: 83701 RVA: 0x005F6A78 File Offset: 0x005F4C78
	protected override void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		int roleId = (params_.Length != 0 && params_[0] != null) ? ((int)params_[0]) : 0;
		int? num = (params_.Length > 1 && params_[1] != null) ? ((int?)params_[1]) : null;
		SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(roleId);
		if (survivorsRole == null)
		{
			this.SetActive(false);
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(survivorsRole.Value.TrialRoleId, true);
		RoleInfo? roleInfo = (roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : null;
		if (roleInfo == null)
		{
			this.SetActive(false);
			return;
		}
		base.SetRoleIcon(roleInfo.Value.RoleHeadIconCircle, base.GetTexture(0), roleId, null, null);
		base.GetTexture(0).SetUIActive(true);
		if (num != null)
		{
			SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(num.Value);
			this.AttributeItem.SetTextureIcon((propertyConfig != null) ? propertyConfig.GetValueOrDefault().Icon : null);
		}
		this.AttributeItem.SetActive(num != null);
		this.SetActive(true);
	}

	// Token: 0x0400AD62 RID: 44386
	private SurvivorsRogueCardAttributeItem AttributeItem;
}
