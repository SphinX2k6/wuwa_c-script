using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x020043FE RID: 17406
	public class LanguageSettingViewBase : IStaticVariableResetter
	{
		// Token: 0x0602BF9E RID: 180126 RVA: 0x00C58F03 File Offset: 0x00C57103
		static LanguageSettingViewBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageSettingViewBase.CreateStaticDefaultValue), new Action(LanguageSettingViewBase.ResetStaticDefaultValue));
		}

		// Token: 0x0602BF9F RID: 180127 RVA: 0x00C58F22 File Offset: 0x00C57122
		public static void CreateStaticDefaultValue()
		{
			LanguageSettingViewBase.BackToPrevLangSettingViewName = null;
			LanguageSettingViewBase.ApplyValueFunc = null;
		}

		// Token: 0x0602BFA0 RID: 180128 RVA: 0x00C58F35 File Offset: 0x00C57135
		public static void ResetStaticDefaultValue()
		{
			LanguageSettingViewBase.BackToPrevLangSettingViewName = null;
			LanguageSettingViewBase.ApplyValueFunc = null;
		}

		// Token: 0x04017B06 RID: 97030
		public static EUiViewName? BackToPrevLangSettingViewName;

		// Token: 0x04017B07 RID: 97031
		[Nullable(2)]
		public static Action<int, float> ApplyValueFunc;
	}
}
