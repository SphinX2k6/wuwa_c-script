using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DA9 RID: 19881
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveDefine : IStaticVariableResetter
	{
		// Token: 0x17007E9D RID: 32413
		// (get) Token: 0x06033575 RID: 210293 RVA: 0x00BFCC79 File Offset: 0x00BFAE79
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

		// Token: 0x17007E9E RID: 32414
		// (get) Token: 0x06033576 RID: 210294 RVA: 0x00BFCC9B File Offset: 0x00BFAE9B
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

		// Token: 0x06033577 RID: 210295 RVA: 0x00BFCCBD File Offset: 0x00BFAEBD
		static RoguelikeAchieveDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeAchieveDefine.CreateStaticDefaultValue), new Action(RoguelikeAchieveDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06033578 RID: 210296 RVA: 0x00BFCCDC File Offset: 0x00BFAEDC
		public static void CreateStaticDefaultValue()
		{
			RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal = null;
			RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal = null;
		}

		// Token: 0x06033579 RID: 210297 RVA: 0x00BFCCEA File Offset: 0x00BFAEEA
		public static void ResetStaticDefaultValue()
		{
			RoguelikeAchieveDefine.RoguelikeAchieveSavedStateIconPathInternal = null;
			RoguelikeAchieveDefine.RoguelikeAchieveUnSavedStateIconPathInternal = null;
		}

		// Token: 0x0401B460 RID: 111712
		public const int ROGUELIKE_ACHIEVE_TOKEN_PANEL_MORE_THRESHOLD = 8;

		// Token: 0x0401B461 RID: 111713
		[Nullable(2)]
		private static string RoguelikeAchieveSavedStateIconPathInternal;

		// Token: 0x0401B462 RID: 111714
		[Nullable(2)]
		private static string RoguelikeAchieveUnSavedStateIconPathInternal;
	}
}
