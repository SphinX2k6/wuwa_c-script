using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002ACD RID: 10957
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueCardComponentRoleItem : SurvivorsRogueCardComponent
{
	// Token: 0x06016CC0 RID: 93376 RVA: 0x005C9E9B File Offset: 0x005C809B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06016CC1 RID: 93377 RVA: 0x005C9ED4 File Offset: 0x005C80D4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardComponentRoleItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardComponentRoleItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016CC2 RID: 93378 RVA: 0x005C9F17 File Offset: 0x005C8117
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardRole";
	}

	// Token: 0x06016CC3 RID: 93379 RVA: 0x005C9F1E File Offset: 0x005C811E
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Center;
	}

	// Token: 0x06016CC4 RID: 93380 RVA: 0x005C9F24 File Offset: 0x005C8124
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

	// Token: 0x0400A95C RID: 43356
	private SurvivorsRogueCardAttributeItem AttributeItem;
}
