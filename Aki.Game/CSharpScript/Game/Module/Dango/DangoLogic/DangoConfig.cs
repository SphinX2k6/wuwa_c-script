using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Dango.DangoLogic
{
	// Token: 0x02004AC7 RID: 19143
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class DangoConfig : ConfigBase
	{
		// Token: 0x0602FE19 RID: 196121 RVA: 0x00D5CDCC File Offset: 0x00D5AFCC
		public Dango? GetDangoById(int id)
		{
			return ConfigDangoById.GetConfig(id, true);
		}

		// Token: 0x0602FE1A RID: 196122 RVA: 0x00D5CDD5 File Offset: 0x00D5AFD5
		public Dice? GetDiceById(int id)
		{
			return ConfigDiceById.GetConfig(id, true);
		}

		// Token: 0x0602FE1B RID: 196123 RVA: 0x00D5CDDE File Offset: 0x00D5AFDE
		public DangoSkill? GetDangoSkillById(int id)
		{
			return ConfigDangoSkillById.GetConfig(id, true);
		}

		// Token: 0x0602FE1C RID: 196124 RVA: 0x00D5CDE7 File Offset: 0x00D5AFE7
		public DangoSkillEffect? GetDangoSkillEffectById(int id)
		{
			return ConfigDangoSkillEffectById.GetConfig(id, true);
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x0602FE1D RID: 196125 RVA: 0x00D5CDF0 File Offset: 0x00D5AFF0
		public static DangoConfig Instance
		{
			get
			{
				return DangoConfig._Instance;
			}
		}

		// Token: 0x0602FE1E RID: 196126 RVA: 0x00D5CDF7 File Offset: 0x00D5AFF7
		public static DangoConfig GetOrCreateInstance()
		{
			if (DangoConfig._Instance == null)
			{
				DangoConfig.CreateInstance();
			}
			return DangoConfig._Instance;
		}

		// Token: 0x0602FE1F RID: 196127 RVA: 0x00D5CE0B File Offset: 0x00D5B00B
		public static bool CreateInstance()
		{
			if (DangoConfig._Instance != null)
			{
				return true;
			}
			DangoConfig._Instance = new DangoConfig();
			return true;
		}

		// Token: 0x0602FE20 RID: 196128 RVA: 0x00D5CE21 File Offset: 0x00D5B021
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FE21 RID: 196129 RVA: 0x00D5CE23 File Offset: 0x00D5B023
		public static void ResetStaticDefaultValue()
		{
			DangoConfig._Instance = null;
		}

		// Token: 0x0602FE22 RID: 196130 RVA: 0x00D5CE2B File Offset: 0x00D5B02B
		static DangoConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DangoConfig.CreateStaticDefaultValue), new Action(DangoConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040196B8 RID: 104120
		[Nullable(2)]
		private static DangoConfig _Instance;
	}
}
