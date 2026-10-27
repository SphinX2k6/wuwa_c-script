using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x020057A9 RID: 22441
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class JoinTeamConfig : ConfigBase
	{
		// Token: 0x06039040 RID: 233536 RVA: 0x00D8D69D File Offset: 0x00D8B89D
		public RoleDescription? GetRoleDescriptionConfig(int roleDescriptionId)
		{
			return ConfigRoleDescriptionById.GetConfig(roleDescriptionId, true);
		}

		// Token: 0x06039041 RID: 233537 RVA: 0x00D8D6A6 File Offset: 0x00D8B8A6
		public RoleInfo? GetRoleConfig(int roleConfigId)
		{
			return ConfigRoleInfoById.GetConfig(roleConfigId, true);
		}

		// Token: 0x06039042 RID: 233538 RVA: 0x00D8D6B0 File Offset: 0x00D8B8B0
		public string GetRoleNameId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			int roleId = roleDescriptionConfig.Value.RoleId;
			RoleInfo? roleConfig = this.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				return null;
			}
			return roleConfig.GetValueOrDefault().Name;
		}

		// Token: 0x06039043 RID: 233539 RVA: 0x00D8D704 File Offset: 0x00D8B904
		public string GetRoleTexturePath(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return roleDescriptionConfig.Value.Texture;
		}

		// Token: 0x06039044 RID: 233540 RVA: 0x00D8D734 File Offset: 0x00D8B934
		public string GetRoleDescriptionId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return roleDescriptionConfig.Value.Description;
		}

		// Token: 0x06039045 RID: 233541 RVA: 0x00D8D764 File Offset: 0x00D8B964
		public int? GetRoleElementId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			int roleId = roleDescriptionConfig.Value.RoleId;
			RoleInfo? roleConfig = this.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				return null;
			}
			return new int?(roleConfig.GetValueOrDefault().ElementId);
		}

		// Token: 0x06039046 RID: 233542 RVA: 0x00D8D7D0 File Offset: 0x00D8B9D0
		public int? GetRoleConfigId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return new int?(roleDescriptionConfig.Value.RoleId);
		}

		// Token: 0x170088D5 RID: 35029
		// (get) Token: 0x06039047 RID: 233543 RVA: 0x00D8D80C File Offset: 0x00D8BA0C
		[Nullable(1)]
		public static JoinTeamConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return JoinTeamConfig._Instance;
			}
		}

		// Token: 0x06039048 RID: 233544 RVA: 0x00D8D813 File Offset: 0x00D8BA13
		[NullableContext(1)]
		public static JoinTeamConfig GetOrCreateInstance()
		{
			if (JoinTeamConfig._Instance == null)
			{
				JoinTeamConfig.CreateInstance();
			}
			return JoinTeamConfig._Instance;
		}

		// Token: 0x06039049 RID: 233545 RVA: 0x00D8D827 File Offset: 0x00D8BA27
		public static bool CreateInstance()
		{
			if (JoinTeamConfig._Instance != null)
			{
				return true;
			}
			JoinTeamConfig._Instance = new JoinTeamConfig();
			return true;
		}

		// Token: 0x0603904A RID: 233546 RVA: 0x00D8D83D File Offset: 0x00D8BA3D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603904B RID: 233547 RVA: 0x00D8D83F File Offset: 0x00D8BA3F
		public static void ResetStaticDefaultValue()
		{
			JoinTeamConfig._Instance = null;
		}

		// Token: 0x0603904C RID: 233548 RVA: 0x00D8D847 File Offset: 0x00D8BA47
		static JoinTeamConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamConfig.CreateStaticDefaultValue), new Action(JoinTeamConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DDF5 RID: 122357
		private static JoinTeamConfig _Instance;
	}
}
