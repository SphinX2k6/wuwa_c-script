using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F47 RID: 8007
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleItem : GridProxyAbstract<ShipTowerRoleData>
{
	// Token: 0x06013CD8 RID: 81112 RVA: 0x005C6D50 File Offset: 0x005C4F50
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

	// Token: 0x06013CD9 RID: 81113 RVA: 0x005C6DC0 File Offset: 0x005C4FC0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRoleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRoleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CDA RID: 81114 RVA: 0x005C6E04 File Offset: 0x005C5004
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

	// Token: 0x06013CDB RID: 81115 RVA: 0x005C6EE2 File Offset: 0x005C50E2
	private void SetShowRole(bool isShow)
	{
		base.GetTexture(2).SetUIActive(isShow);
		base.GetSprite(1).SetUIActive(!isShow);
	}

	// Token: 0x06013CDC RID: 81116 RVA: 0x005C6F04 File Offset: 0x005C5104
	private void SetSkillBranchIndex(int skillBranchIndex)
	{
		FVector fvector = new FVector(0f, (float)(skillBranchIndex * 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		base.GetItem(3).SetUIRelativeRotation(frotator);
	}

	// Token: 0x0400A90D RID: 43277
	private ShipTowerRoleData ItemData;

	// Token: 0x0400A90E RID: 43278
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRoleData> ClickCallBack;

	// Token: 0x02008236 RID: 33334
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A0B6 RID: 172214
		public const int BtnRole = 0;

		// Token: 0x0402A0B7 RID: 172215
		public const int SpriteEmpty = 1;

		// Token: 0x0402A0B8 RID: 172216
		public const int TextureRole = 2;

		// Token: 0x0402A0B9 RID: 172217
		public const int ItemSkillBranch = 3;
	}
}
