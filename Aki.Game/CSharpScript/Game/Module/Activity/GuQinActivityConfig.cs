using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EEF RID: 24303
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class GuQinActivityConfig : ConfigBase
	{
		// Token: 0x0603DC17 RID: 252951 RVA: 0x00EED934 File Offset: 0x00EEBB34
		public GuQinActivityParam GetGuQinActivityParamById(int id)
		{
			return ConfigGuQinActivityParamById.GetConfig(id, true).Value;
		}

		// Token: 0x0603DC18 RID: 252952 RVA: 0x00EED950 File Offset: 0x00EEBB50
		public GuQinActivityTask GetGuQinActivityTaskById(int id)
		{
			return ConfigGuQinActivityTaskById.GetConfig(id, true).Value;
		}

		// Token: 0x17008EEA RID: 36586
		// (get) Token: 0x0603DC19 RID: 252953 RVA: 0x00EED96C File Offset: 0x00EEBB6C
		public static GuQinActivityConfig Instance
		{
			get
			{
				return GuQinActivityConfig._Instance;
			}
		}

		// Token: 0x0603DC1A RID: 252954 RVA: 0x00EED973 File Offset: 0x00EEBB73
		public static GuQinActivityConfig GetOrCreateInstance()
		{
			if (GuQinActivityConfig._Instance == null)
			{
				GuQinActivityConfig.CreateInstance();
			}
			return GuQinActivityConfig._Instance;
		}

		// Token: 0x0603DC1B RID: 252955 RVA: 0x00EED987 File Offset: 0x00EEBB87
		public static bool CreateInstance()
		{
			if (GuQinActivityConfig._Instance != null)
			{
				return true;
			}
			GuQinActivityConfig._Instance = new GuQinActivityConfig();
			return true;
		}

		// Token: 0x0603DC1C RID: 252956 RVA: 0x00EED99D File Offset: 0x00EEBB9D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DC1D RID: 252957 RVA: 0x00EED99F File Offset: 0x00EEBB9F
		public static void ResetStaticDefaultValue()
		{
			GuQinActivityConfig._Instance = null;
		}

		// Token: 0x0603DC1E RID: 252958 RVA: 0x00EED9A7 File Offset: 0x00EEBBA7
		static GuQinActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuQinActivityConfig.CreateStaticDefaultValue), new Action(GuQinActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020455 RID: 132181
		[Nullable(2)]
		private static GuQinActivityConfig _Instance;
	}
}
