using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C25 RID: 19493
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleLinkConfig : ConfigBase
	{
		// Token: 0x06030A19 RID: 199193 RVA: 0x00D8E950 File Offset: 0x00D8CB50
		public LinkData? GetLinkDataConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkDataById.GetConfig(id, true);
		}

		// Token: 0x06030A1A RID: 199194 RVA: 0x00D8E974 File Offset: 0x00D8CB74
		public LinkCharacter? GetRoleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkCharacterById.GetConfig(id, true);
		}

		// Token: 0x06030A1B RID: 199195 RVA: 0x00D8E998 File Offset: 0x00D8CB98
		public LinkParam? GetLinkParam(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkParamById.GetConfig(id, true);
		}

		// Token: 0x06030A1C RID: 199196 RVA: 0x00D8E9BC File Offset: 0x00D8CBBC
		public LinkPreload? GetLinkPreloadConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkPreloadById.GetConfig(id, true);
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x06030A1D RID: 199197 RVA: 0x00D8E9DD File Offset: 0x00D8CBDD
		public static BattleLinkConfig Instance
		{
			get
			{
				return BattleLinkConfig._Instance;
			}
		}

		// Token: 0x06030A1E RID: 199198 RVA: 0x00D8E9E4 File Offset: 0x00D8CBE4
		public static BattleLinkConfig GetOrCreateInstance()
		{
			if (BattleLinkConfig._Instance == null)
			{
				BattleLinkConfig.CreateInstance();
			}
			return BattleLinkConfig._Instance;
		}

		// Token: 0x06030A1F RID: 199199 RVA: 0x00D8E9F8 File Offset: 0x00D8CBF8
		public static bool CreateInstance()
		{
			if (BattleLinkConfig._Instance != null)
			{
				return true;
			}
			BattleLinkConfig._Instance = new BattleLinkConfig();
			return true;
		}

		// Token: 0x06030A20 RID: 199200 RVA: 0x00D8EA0E File Offset: 0x00D8CC0E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030A21 RID: 199201 RVA: 0x00D8EA10 File Offset: 0x00D8CC10
		public static void ResetStaticDefaultValue()
		{
			BattleLinkConfig._Instance = null;
		}

		// Token: 0x06030A22 RID: 199202 RVA: 0x00D8EA18 File Offset: 0x00D8CC18
		static BattleLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleLinkConfig.CreateStaticDefaultValue), new Action(BattleLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019BC0 RID: 105408
		[Nullable(2)]
		private static BattleLinkConfig _Instance;
	}
}
