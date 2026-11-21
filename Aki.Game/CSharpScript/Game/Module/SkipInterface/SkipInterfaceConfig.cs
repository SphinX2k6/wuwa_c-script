using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02003B4A RID: 15178
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SkipInterfaceConfig : ConfigBase
	{
		// Token: 0x06027028 RID: 159784 RVA: 0x00AEBD9E File Offset: 0x00AE9F9E
		public AccessPath? GetAccessPathConfig(int id)
		{
			return ConfigAccessPathById.GetConfig(id, true);
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x06027029 RID: 159785 RVA: 0x00AEBDA7 File Offset: 0x00AE9FA7
		public static SkipInterfaceConfig Instance
		{
			get
			{
				return SkipInterfaceConfig._Instance;
			}
		}

		// Token: 0x0602702A RID: 159786 RVA: 0x00AEBDAE File Offset: 0x00AE9FAE
		public static SkipInterfaceConfig GetOrCreateInstance()
		{
			if (SkipInterfaceConfig._Instance == null)
			{
				SkipInterfaceConfig.CreateInstance();
			}
			return SkipInterfaceConfig._Instance;
		}

		// Token: 0x0602702B RID: 159787 RVA: 0x00AEBDC2 File Offset: 0x00AE9FC2
		public static bool CreateInstance()
		{
			if (SkipInterfaceConfig._Instance != null)
			{
				return true;
			}
			SkipInterfaceConfig._Instance = new SkipInterfaceConfig();
			return true;
		}

		// Token: 0x0602702C RID: 159788 RVA: 0x00AEBDD8 File Offset: 0x00AE9FD8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602702D RID: 159789 RVA: 0x00AEBDDA File Offset: 0x00AE9FDA
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceConfig._Instance = null;
		}

		// Token: 0x0602702E RID: 159790 RVA: 0x00AEBDE2 File Offset: 0x00AE9FE2
		static SkipInterfaceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceConfig.CreateStaticDefaultValue), new Action(SkipInterfaceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040154CD RID: 87245
		[Nullable(2)]
		private static SkipInterfaceConfig _Instance;
	}
}
