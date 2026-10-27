using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029CC RID: 10700
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleItem : GridProxyAbstract<ShipTowerRoleData>
{
	// Token: 0x060162D2 RID: 90834 RVA: 0x0059BD98 File Offset: 0x00599F98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060162D3 RID: 90835 RVA: 0x0059BE08 File Offset: 0x0059A008
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRoleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRoleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162D4 RID: 90836 RVA: 0x0059BE4C File Offset: 0x0059A04C
	public override void Refresh(ShipTowerRoleData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.SetShowRole(false);
		base.GetItem(3).SetUIActive(false);
		if (data.RoleIdEdit == 0)
		{
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data.RoleIdEdit, true);
		RoleInfo value = ((roleDataById != null) ? new RoleInfo?(roleDataById.GetRoleConfig()) : RoleConfig.Instance.GetRoleConfig(data.RoleIdEdit)).Value;
		string roleHeadIconCircle = value.RoleHeadIconCircle;
		int skinId = (roleDataById != null) ? roleDataById.GetRoleSkinId() : value.SkinId;
		base.SetRoleSkinIcon(roleHeadIconCircle, base.GetTexture(2), skinId, null, delegate(bool _)
		{
			this.SetShowRole(true);
		});
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(data.RoleIdEdit);
		base.GetItem(3).SetUIActive(roleSkillBranchIndexInCurrentGamePlay > -1);
		if (roleSkillBranchIndexInCurrentGamePlay > -1)
		{
			this.SetSkillBranchIndex(roleSkillBranchIndexInCurrentGamePlay);
		}
	}

	// Token: 0x060162D5 RID: 90837 RVA: 0x0059BF2A File Offset: 0x0059A12A
	private void SetShowRole(bool isShow)
	{
		base.GetTexture(2).SetUIActive(isShow);
		base.GetSprite(1).SetUIActive(!isShow);
	}

	// Token: 0x060162D6 RID: 90838 RVA: 0x0059BF4C File Offset: 0x0059A14C
	private void SetSkillBranchIndex(int skillBranchIndex)
	{
		FVector fvector = new FVector(0f, (float)(skillBranchIndex * 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		base.GetItem(3).SetUIRelativeRotation(frotator);
	}

	// Token: 0x0400A523 RID: 42275
	private ShipTowerRoleData ItemData;

	// Token: 0x0400A524 RID: 42276
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRoleData> ClickCallBack;

	// Token: 0x02008FEF RID: 36847
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E9BE RID: 190910
		public const int BtnRole = 0;

		// Token: 0x0402E9BF RID: 190911
		public const int SpriteEmpty = 1;

		// Token: 0x0402E9C0 RID: 190912
		public const int TextureRole = 2;

		// Token: 0x0402E9C1 RID: 190913
		public const int ItemSkillBranch = 3;
	}
}
