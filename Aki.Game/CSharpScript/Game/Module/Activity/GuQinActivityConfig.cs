using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004ED6 RID: 20182
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class GuQinActivityConfig : ConfigBase
	{
		// Token: 0x06032BB2 RID: 207794 RVA: 0x00E3F5F8 File Offset: 0x00E3D7F8
		public GuQinActivityParam GetGuQinActivityParamById(int id)
		{
			return ConfigGuQinActivityParamById.GetConfig(id, true).Value;
		}

		// Token: 0x06032BB3 RID: 207795 RVA: 0x00E3F614 File Offset: 0x00E3D814
		public GuQinActivityTask GetGuQinActivityTaskById(int id)
		{
			return ConfigGuQinActivityTaskById.GetConfig(id, true).Value;
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x06032BB4 RID: 207796 RVA: 0x00E3F630 File Offset: 0x00E3D830
		public static GuQinActivityConfig Instance
		{
			get
			{
				return GuQinActivityConfig._Instance;
			}
		}

		// Token: 0x06032BB5 RID: 207797 RVA: 0x00E3F637 File Offset: 0x00E3D837
		public static GuQinActivityConfig GetOrCreateInstance()
		{
			if (GuQinActivityConfig._Instance == null)
			{
				GuQinActivityConfig.CreateInstance();
			}
			return GuQinActivityConfig._Instance;
		}

		// Token: 0x06032BB6 RID: 207798 RVA: 0x00E3F64B File Offset: 0x00E3D84B
		public static bool CreateInstance()
		{
			if (GuQinActivityConfig._Instance != null)
			{
				return true;
			}
			GuQinActivityConfig._Instance = new GuQinActivityConfig();
			return true;
		}

		// Token: 0x06032BB7 RID: 207799 RVA: 0x00E3F661 File Offset: 0x00E3D861
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032BB8 RID: 207800 RVA: 0x00E3F663 File Offset: 0x00E3D863
		public static void ResetStaticDefaultValue()
		{
			GuQinActivityConfig._Instance = null;
		}

		// Token: 0x06032BB9 RID: 207801 RVA: 0x00E3F66B File Offset: 0x00E3D86B
		static GuQinActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuQinActivityConfig.CreateStaticDefaultValue), new Action(GuQinActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AF27 RID: 110375
		[Nullable(2)]
		private static GuQinActivityConfig _Instance;
	}
}
