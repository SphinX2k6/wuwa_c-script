using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003587 RID: 13703
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class UiCommonConfig : ConfigBase
	{
		// Token: 0x06022EFF RID: 143103 RVA: 0x009EA31A File Offset: 0x009E851A
		public NpcSystemBackground? GetNpcSystemBackgroundByViewName(string viewName)
		{
			return ConfigNpcSystemBackgroundByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06022F00 RID: 143104 RVA: 0x009EA323 File Offset: 0x009E8523
		public InteractBackGround? GetInteractBackgroundByViewName(string viewName)
		{
			return ConfigInteractBackGroundByViewName.GetConfig(viewName, true);
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06022F01 RID: 143105 RVA: 0x009EA32C File Offset: 0x009E852C
		public static UiCommonConfig Instance
		{
			get
			{
				return UiCommonConfig._Instance;
			}
		}

		// Token: 0x06022F02 RID: 143106 RVA: 0x009EA333 File Offset: 0x009E8533
		public static UiCommonConfig GetOrCreateInstance()
		{
			if (UiCommonConfig._Instance == null)
			{
				UiCommonConfig.CreateInstance();
			}
			return UiCommonConfig._Instance;
		}

		// Token: 0x06022F03 RID: 143107 RVA: 0x009EA347 File Offset: 0x009E8547
		public static bool CreateInstance()
		{
			if (UiCommonConfig._Instance != null)
			{
				return true;
			}
			UiCommonConfig._Instance = new UiCommonConfig();
			return true;
		}

		// Token: 0x06022F04 RID: 143108 RVA: 0x009EA35D File Offset: 0x009E855D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022F05 RID: 143109 RVA: 0x009EA35F File Offset: 0x009E855F
		public static void ResetStaticDefaultValue()
		{
			UiCommonConfig._Instance = null;
		}

		// Token: 0x06022F06 RID: 143110 RVA: 0x009EA367 File Offset: 0x009E8567
		static UiCommonConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCommonConfig.CreateStaticDefaultValue), new Action(UiCommonConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401348A RID: 78986
		[Nullable(2)]
		private static UiCommonConfig _Instance;
	}
}
