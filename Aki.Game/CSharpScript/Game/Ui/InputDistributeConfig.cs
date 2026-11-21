using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A5 RID: 13733
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InputDistributeConfig : ConfigBase
	{
		// Token: 0x06022FF5 RID: 143349 RVA: 0x009F4094 File Offset: 0x009F2294
		public bool IsViewAllowFightInput(EUiViewName viewName)
		{
			UiShow? config = ConfigUiShowByViewName.GetConfig(viewName, true);
			return config != null && config.Value.IsAllowFightInput;
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x06022FF6 RID: 143350 RVA: 0x009F40C8 File Offset: 0x009F22C8
		public static InputDistributeConfig Instance
		{
			get
			{
				return InputDistributeConfig._Instance;
			}
		}

		// Token: 0x06022FF7 RID: 143351 RVA: 0x009F40CF File Offset: 0x009F22CF
		public static InputDistributeConfig GetOrCreateInstance()
		{
			if (InputDistributeConfig._Instance == null)
			{
				InputDistributeConfig.CreateInstance();
			}
			return InputDistributeConfig._Instance;
		}

		// Token: 0x06022FF8 RID: 143352 RVA: 0x009F40E3 File Offset: 0x009F22E3
		public static bool CreateInstance()
		{
			if (InputDistributeConfig._Instance != null)
			{
				return true;
			}
			InputDistributeConfig._Instance = new InputDistributeConfig();
			return true;
		}

		// Token: 0x06022FF9 RID: 143353 RVA: 0x009F40F9 File Offset: 0x009F22F9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022FFA RID: 143354 RVA: 0x009F40FB File Offset: 0x009F22FB
		public static void ResetStaticDefaultValue()
		{
			InputDistributeConfig._Instance = null;
		}

		// Token: 0x06022FFB RID: 143355 RVA: 0x009F4103 File Offset: 0x009F2303
		static InputDistributeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeConfig.CreateStaticDefaultValue), new Action(InputDistributeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04013BBF RID: 80831
		[Nullable(2)]
		private static InputDistributeConfig _Instance;
	}
}
