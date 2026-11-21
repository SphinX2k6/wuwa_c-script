using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor
{
	// Token: 0x02005B70 RID: 23408
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequencePreprocessHelper : Singleton
	{
		// Token: 0x0603993E RID: 235838 RVA: 0x0102BD1C File Offset: 0x01029F1C
		public void Apply(ULevelSequence sequence, [Nullable(2)] IFloatingSubtitleLanguageDiff operation)
		{
			if (operation == null)
			{
				return;
			}
			if (operation.Type == EPreprocessOperation.FloatingSubtitleLanguageDiff)
			{
				FloatingSubtitleLanguageDiffPreprocessor.Instance.Apply(sequence);
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[LevelSequencePreprocessHelper]未知预处理操作";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", operation.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x17006D8F RID: 28047
		// (get) Token: 0x0603993F RID: 235839 RVA: 0x0102BD72 File Offset: 0x01029F72
		public static LevelSequencePreprocessHelper Instance
		{
			get
			{
				if (LevelSequencePreprocessHelper._instance == null)
				{
					LevelSequencePreprocessHelper._instance = new LevelSequencePreprocessHelper();
					LevelSequencePreprocessHelper._instance.OnInit();
				}
				return LevelSequencePreprocessHelper._instance;
			}
		}

		// Token: 0x06039940 RID: 235840 RVA: 0x0102BD95 File Offset: 0x01029F95
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039941 RID: 235841 RVA: 0x0102BD97 File Offset: 0x01029F97
		public static void ResetStaticDefaultValue()
		{
			LevelSequencePreprocessHelper instance = LevelSequencePreprocessHelper._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelSequencePreprocessHelper._instance = null;
		}

		// Token: 0x06039942 RID: 235842 RVA: 0x0102BDB0 File Offset: 0x01029FB0
		static LevelSequencePreprocessHelper()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelSequencePreprocessHelper.CreateStaticDefaultValue), new Action(LevelSequencePreprocessHelper.ResetStaticDefaultValue));
		}

		// Token: 0x0401E65D RID: 124509
		[Nullable(2)]
		private static LevelSequencePreprocessHelper _instance;
	}
}
