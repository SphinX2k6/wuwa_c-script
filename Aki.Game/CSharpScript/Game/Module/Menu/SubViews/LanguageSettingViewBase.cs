using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200541B RID: 21531
	public class LanguageSettingViewBase : IStaticVariableResetter
	{
		// Token: 0x06037055 RID: 225365 RVA: 0x00D09AE3 File Offset: 0x00D07CE3
		static LanguageSettingViewBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageSettingViewBase.CreateStaticDefaultValue), new Action(LanguageSettingViewBase.ResetStaticDefaultValue));
		}

		// Token: 0x06037056 RID: 225366 RVA: 0x00D09B02 File Offset: 0x00D07D02
		public static void CreateStaticDefaultValue()
		{
			LanguageSettingViewBase.BackToPrevLangSettingViewName = null;
			LanguageSettingViewBase.ApplyValueFunc = null;
		}

		// Token: 0x06037057 RID: 225367 RVA: 0x00D09B15 File Offset: 0x00D07D15
		public static void ResetStaticDefaultValue()
		{
			LanguageSettingViewBase.BackToPrevLangSettingViewName = null;
			LanguageSettingViewBase.ApplyValueFunc = null;
		}

		// Token: 0x0401D06D RID: 118893
		public static EUiViewName? BackToPrevLangSettingViewName;

		// Token: 0x0401D06E RID: 118894
		[Nullable(2)]
		public static Action<int, float> ApplyValueFunc;
	}
}
