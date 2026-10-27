using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02004BA0 RID: 19360
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SkipInterfaceConfig : ConfigBase
	{
		// Token: 0x06032298 RID: 205464 RVA: 0x00BA7C52 File Offset: 0x00BA5E52
		public AccessPath? GetAccessPathConfig(int id)
		{
			return ConfigAccessPathById.GetConfig(id, true);
		}

		// Token: 0x17007C4B RID: 31819
		// (get) Token: 0x06032299 RID: 205465 RVA: 0x00BA7C5B File Offset: 0x00BA5E5B
		public static SkipInterfaceConfig Instance
		{
			get
			{
				return SkipInterfaceConfig._Instance;
			}
		}

		// Token: 0x0603229A RID: 205466 RVA: 0x00BA7C62 File Offset: 0x00BA5E62
		public static SkipInterfaceConfig GetOrCreateInstance()
		{
			if (SkipInterfaceConfig._Instance == null)
			{
				SkipInterfaceConfig.CreateInstance();
			}
			return SkipInterfaceConfig._Instance;
		}

		// Token: 0x0603229B RID: 205467 RVA: 0x00BA7C76 File Offset: 0x00BA5E76
		public static bool CreateInstance()
		{
			if (SkipInterfaceConfig._Instance != null)
			{
				return true;
			}
			SkipInterfaceConfig._Instance = new SkipInterfaceConfig();
			return true;
		}

		// Token: 0x0603229C RID: 205468 RVA: 0x00BA7C8C File Offset: 0x00BA5E8C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603229D RID: 205469 RVA: 0x00BA7C8E File Offset: 0x00BA5E8E
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceConfig._Instance = null;
		}

		// Token: 0x0603229E RID: 205470 RVA: 0x00BA7C96 File Offset: 0x00BA5E96
		static SkipInterfaceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceConfig.CreateStaticDefaultValue), new Action(SkipInterfaceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB79 RID: 109433
		[Nullable(2)]
		private static SkipInterfaceConfig _Instance;
	}
}
