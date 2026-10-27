using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A3 RID: 18083
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ImmersiveMouseConfig : ConfigBase
	{
		// Token: 0x0602E9F1 RID: 190961 RVA: 0x00ACB3C5 File Offset: 0x00AC95C5
		public IReadOnlyList<ImmersiveMouse> GetAllImmersiveMouseViewConfig()
		{
			return ConfigImmersiveMouseAll.GetConfigList(true);
		}

		// Token: 0x0602E9F2 RID: 190962 RVA: 0x00ACB3D0 File Offset: 0x00AC95D0
		public ImmersiveMouse GetImmersiveMouseViewConfigByViewName(EUiViewName viewName)
		{
			return ConfigImmersiveMouseByViewName.GetConfig(viewName, true).Value;
		}

		// Token: 0x17007636 RID: 30262
		// (get) Token: 0x0602E9F3 RID: 190963 RVA: 0x00ACB3F1 File Offset: 0x00AC95F1
		public static ImmersiveMouseConfig Instance
		{
			get
			{
				return ImmersiveMouseConfig._Instance;
			}
		}

		// Token: 0x0602E9F4 RID: 190964 RVA: 0x00ACB3F8 File Offset: 0x00AC95F8
		public static ImmersiveMouseConfig GetOrCreateInstance()
		{
			if (ImmersiveMouseConfig._Instance == null)
			{
				ImmersiveMouseConfig.CreateInstance();
			}
			return ImmersiveMouseConfig._Instance;
		}

		// Token: 0x0602E9F5 RID: 190965 RVA: 0x00ACB40C File Offset: 0x00AC960C
		public static bool CreateInstance()
		{
			if (ImmersiveMouseConfig._Instance != null)
			{
				return true;
			}
			ImmersiveMouseConfig._Instance = new ImmersiveMouseConfig();
			return true;
		}

		// Token: 0x0602E9F6 RID: 190966 RVA: 0x00ACB422 File Offset: 0x00AC9622
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E9F7 RID: 190967 RVA: 0x00ACB424 File Offset: 0x00AC9624
		public static void ResetStaticDefaultValue()
		{
			ImmersiveMouseConfig._Instance = null;
		}

		// Token: 0x0602E9F8 RID: 190968 RVA: 0x00ACB42C File Offset: 0x00AC962C
		static ImmersiveMouseConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ImmersiveMouseConfig.CreateStaticDefaultValue), new Action(ImmersiveMouseConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401965D RID: 104029
		[Nullable(2)]
		private static ImmersiveMouseConfig _Instance;
	}
}
