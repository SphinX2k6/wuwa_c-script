using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024A1 RID: 9377
internal class EquipRoleAttribute : UiPanelBase
{
	// Token: 0x06012D3B RID: 77115 RVA: 0x004A5A56 File Offset: 0x004A3C56
	[NullableContext(1)]
	public EquipRoleAttribute(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x06012D3C RID: 77116 RVA: 0x004A5A6B File Offset: 0x004A3C6B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012D3D RID: 77117 RVA: 0x004A5AA4 File Offset: 0x004A3CA4
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
			if (roleSkinConfigParam != null && roleSkinConfigParam != "")
			{
				RoleSkin roleSkin = roleSkinConfig;
				PropertyInfo property = roleSkin.GetType().GetProperty(roleSkinConfigParam);
				if (property != null)
				{
					string text = property.GetValue(roleSkin) as string;
					if (text != null)
					{
						base.SetTextureByPath(text, base.GetTexture(0), null, null);
					}
				}
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

	// Token: 0x02008A23 RID: 35363
	private enum EUnderRoleAttribute
	{
		// Token: 0x0402CDB3 RID: 183731
		RoleTexture,
		// Token: 0x0402CDB4 RID: 183732
		RoleText
	}
}
