using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021A0 RID: 8608
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleItem : LoopScrollSmallItemGrid<RoleBrief>
{
	// Token: 0x06010BC9 RID: 68553 RVA: 0x00410CDC File Offset: 0x0040EEDC
	protected override UniTask OnCreateAsync()
	{
		RoleItem.<OnCreateAsync>d__1 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<RoleItem.<OnCreateAsync>d__1>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010BCA RID: 68554 RVA: 0x00410D20 File Offset: 0x0040EF20
	protected override void OnRefresh(RoleBrief data, bool isSelected, int gridIndex)
	{
		int roleId = data.RoleId;
		if (roleId > 0)
		{
			UUIItem noneRoleUi = this.NoneRoleUi;
			if (noneRoleUi != null)
			{
				noneRoleUi.SetUIActive(false);
			}
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = data,
				ElementId = new int?(value.ElementId),
				ItemConfigId = new int?(value.Id),
				QualityId = new int?(value.QualityId)
			};
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		base.ApplyEmptyWithoutAddSmallItemGrid(new EmptySmallItemGrid());
		UUIItem noneRoleUi2 = this.NoneRoleUi;
		if (noneRoleUi2 == null)
		{
			return;
		}
		noneRoleUi2.SetUIActive(true);
	}

	// Token: 0x04007F6F RID: 32623
	[Nullable(2)]
	private UUIItem NoneRoleUi;
}
