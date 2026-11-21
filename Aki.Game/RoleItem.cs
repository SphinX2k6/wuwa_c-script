using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001684 RID: 5764
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleItem : LoopScrollSmallItemGrid<RoleBrief>
{
	// Token: 0x0600E05A RID: 57434 RVA: 0x0041D5C4 File Offset: 0x0041B7C4
	protected override UniTask OnCreateAsync()
	{
		RoleItem.<OnCreateAsync>d__1 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<RoleItem.<OnCreateAsync>d__1>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E05B RID: 57435 RVA: 0x0041D608 File Offset: 0x0041B808
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

	// Token: 0x040080B6 RID: 32950
	[Nullable(2)]
	private UUIItem NoneRoleUi;
}
