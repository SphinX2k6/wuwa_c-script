using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor
{
	// Token: 0x02006A13 RID: 27155
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequencePreprocessHelper : Singleton
	{
		// Token: 0x060438F2 RID: 276722 RVA: 0x01087754 File Offset: 0x01085954
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

		// Token: 0x170098AA RID: 39082
		// (get) Token: 0x060438F3 RID: 276723 RVA: 0x010877AA File Offset: 0x010859AA
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

		// Token: 0x060438F4 RID: 276724 RVA: 0x010877CD File Offset: 0x010859CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060438F5 RID: 276725 RVA: 0x010877CF File Offset: 0x010859CF
		public static void ResetStaticDefaultValue()
		{
			LevelSequencePreprocessHelper instance = LevelSequencePreprocessHelper._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelSequencePreprocessHelper._instance = null;
		}

		// Token: 0x060438F6 RID: 276726 RVA: 0x010877E8 File Offset: 0x010859E8
		static LevelSequencePreprocessHelper()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelSequencePreprocessHelper.CreateStaticDefaultValue), new Action(LevelSequencePreprocessHelper.ResetStaticDefaultValue));
		}

		// Token: 0x0402346B RID: 144491
		[Nullable(2)]
		private static LevelSequencePreprocessHelper _instance;
	}
}
