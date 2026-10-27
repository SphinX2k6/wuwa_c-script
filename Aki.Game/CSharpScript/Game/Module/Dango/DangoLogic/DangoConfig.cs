using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Dango.DangoLogic
{
	// Token: 0x02005AE6 RID: 23270
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class DangoConfig : ConfigBase
	{
		// Token: 0x0603AEA7 RID: 241319 RVA: 0x00E0C0E8 File Offset: 0x00E0A2E8
		public Dango? GetDangoById(int id)
		{
			return ConfigDangoById.GetConfig(id, true);
		}

		// Token: 0x0603AEA8 RID: 241320 RVA: 0x00E0C0F1 File Offset: 0x00E0A2F1
		public Dice? GetDiceById(int id)
		{
			return ConfigDiceById.GetConfig(id, true);
		}

		// Token: 0x0603AEA9 RID: 241321 RVA: 0x00E0C0FA File Offset: 0x00E0A2FA
		public DangoSkill? GetDangoSkillById(int id)
		{
			return ConfigDangoSkillById.GetConfig(id, true);
		}

		// Token: 0x0603AEAA RID: 241322 RVA: 0x00E0C103 File Offset: 0x00E0A303
		public DangoSkillEffect? GetDangoSkillEffectById(int id)
		{
			return ConfigDangoSkillEffectById.GetConfig(id, true);
		}

		// Token: 0x17008C30 RID: 35888
		// (get) Token: 0x0603AEAB RID: 241323 RVA: 0x00E0C10C File Offset: 0x00E0A30C
		public static DangoConfig Instance
		{
			get
			{
				return DangoConfig._Instance;
			}
		}

		// Token: 0x0603AEAC RID: 241324 RVA: 0x00E0C113 File Offset: 0x00E0A313
		public static DangoConfig GetOrCreateInstance()
		{
			if (DangoConfig._Instance == null)
			{
				DangoConfig.CreateInstance();
			}
			return DangoConfig._Instance;
		}

		// Token: 0x0603AEAD RID: 241325 RVA: 0x00E0C127 File Offset: 0x00E0A327
		public static bool CreateInstance()
		{
			if (DangoConfig._Instance != null)
			{
				return true;
			}
			DangoConfig._Instance = new DangoConfig();
			return true;
		}

		// Token: 0x0603AEAE RID: 241326 RVA: 0x00E0C13D File Offset: 0x00E0A33D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AEAF RID: 241327 RVA: 0x00E0C13F File Offset: 0x00E0A33F
		public static void ResetStaticDefaultValue()
		{
			DangoConfig._Instance = null;
		}

		// Token: 0x0603AEB0 RID: 241328 RVA: 0x00E0C147 File Offset: 0x00E0A347
		static DangoConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DangoConfig.CreateStaticDefaultValue), new Action(DangoConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EBFC RID: 125948
		[Nullable(2)]
		private static DangoConfig _Instance;
	}
}
