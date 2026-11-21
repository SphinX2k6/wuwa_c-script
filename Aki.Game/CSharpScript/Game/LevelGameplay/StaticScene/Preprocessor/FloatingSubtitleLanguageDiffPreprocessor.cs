using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor
{
	// Token: 0x02005B6F RID: 23407
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitleLanguageDiffPreprocessor : Singleton
	{
		// Token: 0x06039934 RID: 235828 RVA: 0x0102BB0C File Offset: 0x01029D0C
		public void Apply(ULevelSequence sequence)
		{
			string layoutTag = this.GetLayoutTag();
			string name = (layoutTag == "VT") ? "HR" : "VT";
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName(layoutTag), false);
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName(name), true);
			this.MarkCompiledDataDirty(sequence);
		}

		// Token: 0x06039935 RID: 235829 RVA: 0x0102BB5B File Offset: 0x01029D5B
		public void Reset(ULevelSequence sequence)
		{
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName("VT"), false);
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName("HR"), false);
			this.MarkCompiledDataDirty(sequence);
		}

		// Token: 0x06039936 RID: 235830 RVA: 0x0102BB88 File Offset: 0x01029D88
		public string GetLayoutTag()
		{
			ELanguageType? packageLanguageType = LanguageSystem.Instance.PackageLanguageType;
			if (packageLanguageType != null)
			{
				switch (packageLanguageType.GetValueOrDefault())
				{
				case ELanguageType.Zh:
				case ELanguageType.Ja:
				case ELanguageType.Ko:
				case ELanguageType.Zht:
					return "VT";
				}
			}
			return "HR";
		}

		// Token: 0x06039937 RID: 235831 RVA: 0x0102BBDC File Offset: 0x01029DDC
		public bool IsLayoutTag(string tag)
		{
			return tag == "VT" || tag == "HR";
		}

		// Token: 0x06039938 RID: 235832 RVA: 0x0102BBF8 File Offset: 0x01029DF8
		private void MarkCompiledDataDirty(UMovieSceneSequence sequence)
		{
			sequence.SequenceFlags |= EMovieSceneSequenceFlags.Volatile;
			sequence.Signature = FGuid.NewGuid();
			ULevelSequence ulevelSequence = sequence as ULevelSequence;
			TArray<UMovieSceneTrack> tarray;
			if (ulevelSequence == null)
			{
				tarray = null;
			}
			else
			{
				UMovieScene movieScene = ulevelSequence.MovieScene;
				tarray = ((movieScene != null) ? movieScene.MasterTracks : null);
			}
			TArray<UMovieSceneTrack> tarray2 = tarray;
			int num = (tarray2 != null) ? tarray2.Num() : 0;
			for (int i = 0; i < num; i++)
			{
				UMovieSceneSubTrack umovieSceneSubTrack = ((tarray2 != null) ? tarray2.Get(i) : null) as UMovieSceneSubTrack;
				if (umovieSceneSubTrack != null)
				{
					TArray<UMovieSceneSection> sections = umovieSceneSubTrack.Sections;
					for (int j = 0; j < sections.Num(); j++)
					{
						UMovieSceneSubSection umovieSceneSubSection = sections.Get(j) as UMovieSceneSubSection;
						if (umovieSceneSubSection != null && umovieSceneSubSection.SubSequence != null)
						{
							this.MarkCompiledDataDirty(umovieSceneSubSection.SubSequence);
						}
					}
				}
			}
		}

		// Token: 0x17006D8E RID: 28046
		// (get) Token: 0x06039939 RID: 235833 RVA: 0x0102BCB4 File Offset: 0x01029EB4
		public static FloatingSubtitleLanguageDiffPreprocessor Instance
		{
			get
			{
				if (FloatingSubtitleLanguageDiffPreprocessor._instance == null)
				{
					FloatingSubtitleLanguageDiffPreprocessor._instance = new FloatingSubtitleLanguageDiffPreprocessor();
					FloatingSubtitleLanguageDiffPreprocessor._instance.OnInit();
				}
				return FloatingSubtitleLanguageDiffPreprocessor._instance;
			}
		}

		// Token: 0x0603993A RID: 235834 RVA: 0x0102BCD7 File Offset: 0x01029ED7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603993B RID: 235835 RVA: 0x0102BCD9 File Offset: 0x01029ED9
		public static void ResetStaticDefaultValue()
		{
			FloatingSubtitleLanguageDiffPreprocessor instance = FloatingSubtitleLanguageDiffPreprocessor._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FloatingSubtitleLanguageDiffPreprocessor._instance = null;
		}

		// Token: 0x0603993C RID: 235836 RVA: 0x0102BCF2 File Offset: 0x01029EF2
		static FloatingSubtitleLanguageDiffPreprocessor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FloatingSubtitleLanguageDiffPreprocessor.CreateStaticDefaultValue), new Action(FloatingSubtitleLanguageDiffPreprocessor.ResetStaticDefaultValue));
		}

		// Token: 0x0401E65A RID: 124506
		public const string FLOATING_SUBTITLE_VERTICAL_TAG = "VT";

		// Token: 0x0401E65B RID: 124507
		public const string FLOATING_SUBTITLE_HORIZONTAL_TAG = "HR";

		// Token: 0x0401E65C RID: 124508
		[Nullable(2)]
		private static FloatingSubtitleLanguageDiffPreprocessor _instance;
	}
}
