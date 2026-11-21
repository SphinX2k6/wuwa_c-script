using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D4 RID: 13780
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ImmersiveMouseConfig : ConfigBase
	{
		// Token: 0x0602313D RID: 143677 RVA: 0x009F9C99 File Offset: 0x009F7E99
		public IReadOnlyList<ImmersiveMouse> GetAllImmersiveMouseViewConfig()
		{
			return ConfigImmersiveMouseAll.GetConfigList(true);
		}

		// Token: 0x0602313E RID: 143678 RVA: 0x009F9CA4 File Offset: 0x009F7EA4
		public ImmersiveMouse GetImmersiveMouseViewConfigByViewName(EUiViewName viewName)
		{
			return ConfigImmersiveMouseByViewName.GetConfig(viewName, true).Value;
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x0602313F RID: 143679 RVA: 0x009F9CC5 File Offset: 0x009F7EC5
		public static ImmersiveMouseConfig Instance
		{
			get
			{
				return ImmersiveMouseConfig._Instance;
			}
		}

		// Token: 0x06023140 RID: 143680 RVA: 0x009F9CCC File Offset: 0x009F7ECC
		public static ImmersiveMouseConfig GetOrCreateInstance()
		{
			if (ImmersiveMouseConfig._Instance == null)
			{
				ImmersiveMouseConfig.CreateInstance();
			}
			return ImmersiveMouseConfig._Instance;
		}

		// Token: 0x06023141 RID: 143681 RVA: 0x009F9CE0 File Offset: 0x009F7EE0
		public static bool CreateInstance()
		{
			if (ImmersiveMouseConfig._Instance != null)
			{
				return true;
			}
			ImmersiveMouseConfig._Instance = new ImmersiveMouseConfig();
			return true;
		}

		// Token: 0x06023142 RID: 143682 RVA: 0x009F9CF6 File Offset: 0x009F7EF6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023143 RID: 143683 RVA: 0x009F9CF8 File Offset: 0x009F7EF8
		public static void ResetStaticDefaultValue()
		{
			ImmersiveMouseConfig._Instance = null;
		}

		// Token: 0x06023144 RID: 143684 RVA: 0x009F9D00 File Offset: 0x009F7F00
		static ImmersiveMouseConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ImmersiveMouseConfig.CreateStaticDefaultValue), new Action(ImmersiveMouseConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04013D02 RID: 81154
		[Nullable(2)]
		private static ImmersiveMouseConfig _Instance;
	}
}
