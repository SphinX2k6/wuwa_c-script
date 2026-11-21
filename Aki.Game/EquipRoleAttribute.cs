using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001988 RID: 6536
internal class EquipRoleAttribute : UiPanelBase
{
	// Token: 0x060101FC RID: 66044 RVA: 0x004B355E File Offset: 0x004B175E
	[NullableContext(1)]
	public EquipRoleAttribute(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x060101FD RID: 66045 RVA: 0x004B3573 File Offset: 0x004B1773
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060101FE RID: 66046 RVA: 0x004B35AC File Offset: 0x004B17AC
	[NullableContext(1)]
	public void Update(PhantomBattleData data)
	{
		if (PhantomBattleController.Instance.CheckIsEquip(data.GetUniqueId()))
		{
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(data.GetUniqueId());
			RoleSkinModel instance = RoleSkinModel.Instance;
			RoleSkinData roleSkinData = (instance != null) ? instance.GetRoleSkinDataByRoleId(equipRole.Value) : null;
			if (roleSkinData == null)
			{
				return;
			}
			RoleSkin roleSkinConfig = roleSkinData.GetRoleSkinConfig();
			string tag = "RoleIcon1";
			string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
			string path;
			if (roleSkinConfigParam != null && roleSkinConfigParam != "" && roleSkinConfig.TryGetMember(roleSkinConfigParam, out path))
			{
				base.SetTextureByPath(path, base.GetTexture(0), null, null);
			}
			string item = RoleConfig.Instance.GetRoleName(roleSkinConfig.Name);
			IReadOnlyList<MainRoleConfig> allMainRoleConfig = RoleConfig.Instance.GetAllMainRoleConfig();
			bool flag = false;
			int count = allMainRoleConfig.Count;
			for (int i = 0; i < count; i++)
			{
				int id = allMainRoleConfig[i].Id;
				int? num = equipRole;
				if (id == num.GetValueOrDefault() & num != null)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				item = FunctionModel.Instance.GetPlayerName();
			}
			LguiUtil.Instance.SetLocalText(base.GetText(1), "VisionEquipping", new <>z__ReadOnlySingleElementList<object>(item));
		}
	}

	// Token: 0x02007BAD RID: 31661
	private enum EUnderRoleAttribute
	{
		// Token: 0x040280D3 RID: 164051
		RoleTexture,
		// Token: 0x040280D4 RID: 164052
		RoleText
	}
}
