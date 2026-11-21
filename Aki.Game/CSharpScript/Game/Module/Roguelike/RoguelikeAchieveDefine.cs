using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D72 RID: 15730
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveDefine : IStaticVariableResetter
	{
		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x060283E2 RID: 164834 RVA: 0x00B461AB File Offset: 0x00B443AB
		public static string RoguelikeAchieveSavedStateIconPath
		{
			get
			{
				if (RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal == null)
				{
					RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal = UiResourceConfig.Instance.GetResourcePath("SP_RoguelikeSavedFileRecordIcon");
				}
				return RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal;
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x060283E3 RID: 164835 RVA: 0x00B461CD File Offset: 0x00B443CD
		public static string RoguelikeAchieveUnSavedStateIconPath
		{
			get
			{
				if (RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal == null)
				{
					RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal = UiResourceConfig.Instance.GetResourcePath("SP_RoguelikeUnSavedFileRecordIcon");
				}
				return RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal;
			}
		}

		// Token: 0x060283E4 RID: 164836 RVA: 0x00B461EF File Offset: 0x00B443EF
		static RoguelikeAchieveDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeAchieveDefine.CreateStaticDefaultValue), new Action(RoguelikeAchieveDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060283E5 RID: 164837 RVA: 0x00B4620E File Offset: 0x00B4440E
		public static void CreateStaticDefaultValue()
		{
			RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal = null;
			RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal = null;
		}

		// Token: 0x060283E6 RID: 164838 RVA: 0x00B4621C File Offset: 0x00B4441C
		public static void ResetStaticDefaultValue()
		{
			RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal = null;
			RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal = null;
		}

		// Token: 0x04015E33 RID: 89651
		public const int ROGUELIKE_ACHIEVE_TOKEN_PANEL_MORE_THRESHOLD = 8;

		// Token: 0x04015E34 RID: 89652
		[Nullable(2)]
		private static string RoguelikeAchieveSavedStateIconPathInternal;

		// Token: 0x04015E35 RID: 89653
		[Nullable(2)]
		private static string RoguelikeAchieveUnSavedStateIconPathInternal;
	}
}
