using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004656 RID: 18006
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class UiCommonConfig : ConfigBase
	{
		// Token: 0x0602E7B5 RID: 190389 RVA: 0x00ABCCEA File Offset: 0x00ABAEEA
		public NpcSystemBackground? GetNpcSystemBackgroundByViewName(string viewName)
		{
			return ConfigNpcSystemBackgroundByViewName.GetConfig(viewName, true);
		}

		// Token: 0x0602E7B6 RID: 190390 RVA: 0x00ABCCF3 File Offset: 0x00ABAEF3
		public InteractBackGround? GetInteractBackgroundByViewName(string viewName)
		{
			return ConfigInteractBackGroundByViewName.GetConfig(viewName, true);
		}

		// Token: 0x17007600 RID: 30208
		// (get) Token: 0x0602E7B7 RID: 190391 RVA: 0x00ABCCFC File Offset: 0x00ABAEFC
		public static UiCommonConfig Instance
		{
			get
			{
				return UiCommonConfig._Instance;
			}
		}

		// Token: 0x0602E7B8 RID: 190392 RVA: 0x00ABCD03 File Offset: 0x00ABAF03
		public static UiCommonConfig GetOrCreateInstance()
		{
			if (UiCommonConfig._Instance == null)
			{
				UiCommonConfig.CreateInstance();
			}
			return UiCommonConfig._Instance;
		}

		// Token: 0x0602E7B9 RID: 190393 RVA: 0x00ABCD17 File Offset: 0x00ABAF17
		public static bool CreateInstance()
		{
			if (UiCommonConfig._Instance != null)
			{
				return true;
			}
			UiCommonConfig._Instance = new UiCommonConfig();
			return true;
		}

		// Token: 0x0602E7BA RID: 190394 RVA: 0x00ABCD2D File Offset: 0x00ABAF2D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E7BB RID: 190395 RVA: 0x00ABCD2F File Offset: 0x00ABAF2F
		public static void ResetStaticDefaultValue()
		{
			UiCommonConfig._Instance = null;
		}

		// Token: 0x0602E7BC RID: 190396 RVA: 0x00ABCD37 File Offset: 0x00ABAF37
		static UiCommonConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCommonConfig.CreateStaticDefaultValue), new Action(UiCommonConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018E31 RID: 101937
		[Nullable(2)]
		private static UiCommonConfig _Instance;
	}
}
