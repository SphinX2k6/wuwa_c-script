using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C45 RID: 23621
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleLinkConfig : ConfigBase
	{
		// Token: 0x0603BACE RID: 244430 RVA: 0x00E3E5CC File Offset: 0x00E3C7CC
		public LinkData? GetLinkDataConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkDataById.GetConfig(id, true);
		}

		// Token: 0x0603BACF RID: 244431 RVA: 0x00E3E5F0 File Offset: 0x00E3C7F0
		public LinkCharacter? GetRoleConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkCharacterById.GetConfig(id, true);
		}

		// Token: 0x0603BAD0 RID: 244432 RVA: 0x00E3E614 File Offset: 0x00E3C814
		public LinkParam? GetLinkParam(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkParamById.GetConfig(id, true);
		}

		// Token: 0x0603BAD1 RID: 244433 RVA: 0x00E3E638 File Offset: 0x00E3C838
		public LinkPreload? GetLinkPreloadConfig(int id)
		{
			if (id == 0)
			{
				return null;
			}
			return ConfigLinkPreloadById.GetConfig(id, true);
		}

		// Token: 0x17008DB6 RID: 36278
		// (get) Token: 0x0603BAD2 RID: 244434 RVA: 0x00E3E659 File Offset: 0x00E3C859
		public static BattleLinkConfig Instance
		{
			get
			{
				return BattleLinkConfig._Instance;
			}
		}

		// Token: 0x0603BAD3 RID: 244435 RVA: 0x00E3E660 File Offset: 0x00E3C860
		public static BattleLinkConfig GetOrCreateInstance()
		{
			if (BattleLinkConfig._Instance == null)
			{
				BattleLinkConfig.CreateInstance();
			}
			return BattleLinkConfig._Instance;
		}

		// Token: 0x0603BAD4 RID: 244436 RVA: 0x00E3E674 File Offset: 0x00E3C874
		public static bool CreateInstance()
		{
			if (BattleLinkConfig._Instance != null)
			{
				return true;
			}
			BattleLinkConfig._Instance = new BattleLinkConfig();
			return true;
		}

		// Token: 0x0603BAD5 RID: 244437 RVA: 0x00E3E68A File Offset: 0x00E3C88A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BAD6 RID: 244438 RVA: 0x00E3E68C File Offset: 0x00E3C88C
		public static void ResetStaticDefaultValue()
		{
			BattleLinkConfig._Instance = null;
		}

		// Token: 0x0603BAD7 RID: 244439 RVA: 0x00E3E694 File Offset: 0x00E3C894
		static BattleLinkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleLinkConfig.CreateStaticDefaultValue), new Action(BattleLinkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401F10F RID: 127247
		[Nullable(2)]
		private static BattleLinkConfig _Instance;
	}
}
