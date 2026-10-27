using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004674 RID: 18036
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InputDistributeConfig : ConfigBase
	{
		// Token: 0x0602E8AB RID: 190635 RVA: 0x00AC6534 File Offset: 0x00AC4734
		public bool IsViewAllowFightInput(EUiViewName viewName)
		{
			UiShow? config = ConfigUiShowByViewName.GetConfig(viewName, true);
			return config != null && config.Value.IsAllowFightInput;
		}

		// Token: 0x1700762C RID: 30252
		// (get) Token: 0x0602E8AC RID: 190636 RVA: 0x00AC6568 File Offset: 0x00AC4768
		public static InputDistributeConfig Instance
		{
			get
			{
				return InputDistributeConfig._Instance;
			}
		}

		// Token: 0x0602E8AD RID: 190637 RVA: 0x00AC656F File Offset: 0x00AC476F
		public static InputDistributeConfig GetOrCreateInstance()
		{
			if (InputDistributeConfig._Instance == null)
			{
				InputDistributeConfig.CreateInstance();
			}
			return InputDistributeConfig._Instance;
		}

		// Token: 0x0602E8AE RID: 190638 RVA: 0x00AC6583 File Offset: 0x00AC4783
		public static bool CreateInstance()
		{
			if (InputDistributeConfig._Instance != null)
			{
				return true;
			}
			InputDistributeConfig._Instance = new InputDistributeConfig();
			return true;
		}

		// Token: 0x0602E8AF RID: 190639 RVA: 0x00AC6599 File Offset: 0x00AC4799
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E8B0 RID: 190640 RVA: 0x00AC659B File Offset: 0x00AC479B
		public static void ResetStaticDefaultValue()
		{
			InputDistributeConfig._Instance = null;
		}

		// Token: 0x0602E8B1 RID: 190641 RVA: 0x00AC65A3 File Offset: 0x00AC47A3
		static InputDistributeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeConfig.CreateStaticDefaultValue), new Action(InputDistributeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019518 RID: 103704
		[Nullable(2)]
		private static InputDistributeConfig _Instance;
	}
}
