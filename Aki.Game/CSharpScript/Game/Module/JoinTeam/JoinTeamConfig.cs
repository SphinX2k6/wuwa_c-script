using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x02004780 RID: 18304
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class JoinTeamConfig : ConfigBase
	{
		// Token: 0x0602DF50 RID: 188240 RVA: 0x00CDC459 File Offset: 0x00CDA659
		public RoleDescription? GetRoleDescriptionConfig(int roleDescriptionId)
		{
			return ConfigRoleDescriptionById.GetConfig(roleDescriptionId, true);
		}

		// Token: 0x0602DF51 RID: 188241 RVA: 0x00CDC462 File Offset: 0x00CDA662
		public RoleInfo? GetRoleConfig(int roleConfigId)
		{
			return ConfigRoleInfoById.GetConfig(roleConfigId, true);
		}

		// Token: 0x0602DF52 RID: 188242 RVA: 0x00CDC46C File Offset: 0x00CDA66C
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

		// Token: 0x0602DF53 RID: 188243 RVA: 0x00CDC4C0 File Offset: 0x00CDA6C0
		public string GetRoleTexturePath(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return roleDescriptionConfig.Value.Texture;
		}

		// Token: 0x0602DF54 RID: 188244 RVA: 0x00CDC4F0 File Offset: 0x00CDA6F0
		public string GetRoleDescriptionId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return roleDescriptionConfig.Value.Description;
		}

		// Token: 0x0602DF55 RID: 188245 RVA: 0x00CDC520 File Offset: 0x00CDA720
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

		// Token: 0x0602DF56 RID: 188246 RVA: 0x00CDC58C File Offset: 0x00CDA78C
		public int? GetRoleConfigId(int roleDescriptionId)
		{
			RoleDescription? roleDescriptionConfig = this.GetRoleDescriptionConfig(roleDescriptionId);
			if (roleDescriptionConfig == null)
			{
				return null;
			}
			return new int?(roleDescriptionConfig.Value.RoleId);
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x0602DF57 RID: 188247 RVA: 0x00CDC5C8 File Offset: 0x00CDA7C8
		[Nullable(1)]
		public static JoinTeamConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return JoinTeamConfig._Instance;
			}
		}

		// Token: 0x0602DF58 RID: 188248 RVA: 0x00CDC5CF File Offset: 0x00CDA7CF
		[NullableContext(1)]
		public static JoinTeamConfig GetOrCreateInstance()
		{
			if (JoinTeamConfig._Instance == null)
			{
				JoinTeamConfig.CreateInstance();
			}
			return JoinTeamConfig._Instance;
		}

		// Token: 0x0602DF59 RID: 188249 RVA: 0x00CDC5E3 File Offset: 0x00CDA7E3
		public static bool CreateInstance()
		{
			if (JoinTeamConfig._Instance != null)
			{
				return true;
			}
			JoinTeamConfig._Instance = new JoinTeamConfig();
			return true;
		}

		// Token: 0x0602DF5A RID: 188250 RVA: 0x00CDC5F9 File Offset: 0x00CDA7F9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DF5B RID: 188251 RVA: 0x00CDC5FB File Offset: 0x00CDA7FB
		public static void ResetStaticDefaultValue()
		{
			JoinTeamConfig._Instance = null;
		}

		// Token: 0x0602DF5C RID: 188252 RVA: 0x00CDC603 File Offset: 0x00CDA803
		static JoinTeamConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamConfig.CreateStaticDefaultValue), new Action(JoinTeamConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401888B RID: 100491
		private static JoinTeamConfig _Instance;
	}
}
