using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor
{
	// Token: 0x02006A12 RID: 27154
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitleLanguageDiffPreprocessor : Singleton
	{
		// Token: 0x060438E8 RID: 276712 RVA: 0x01087544 File Offset: 0x01085744
		public void Apply(ULevelSequence sequence)
		{
			string layoutTag = this.GetLayoutTag();
			string name = (layoutTag == "VT") ? "HR" : "VT";
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName(layoutTag), false);
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName(name), true);
			this.MarkCompiledDataDirty(sequence);
		}

		// Token: 0x060438E9 RID: 276713 RVA: 0x01087593 File Offset: 0x01085793
		public void Reset(ULevelSequence sequence)
		{
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName("VT"), false);
			UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(sequence, new FName("HR"), false);
			this.MarkCompiledDataDirty(sequence);
		}

		// Token: 0x060438EA RID: 276714 RVA: 0x010875C0 File Offset: 0x010857C0
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

		// Token: 0x060438EB RID: 276715 RVA: 0x01087614 File Offset: 0x01085814
		public bool IsLayoutTag(string tag)
		{
			return tag == "VT" || tag == "HR";
		}

		// Token: 0x060438EC RID: 276716 RVA: 0x01087630 File Offset: 0x01085830
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

		// Token: 0x170098A9 RID: 39081
		// (get) Token: 0x060438ED RID: 276717 RVA: 0x010876EC File Offset: 0x010858EC
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

		// Token: 0x060438EE RID: 276718 RVA: 0x0108770F File Offset: 0x0108590F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060438EF RID: 276719 RVA: 0x01087711 File Offset: 0x01085911
		public static void ResetStaticDefaultValue()
		{
			FloatingSubtitleLanguageDiffPreprocessor instance = FloatingSubtitleLanguageDiffPreprocessor._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FloatingSubtitleLanguageDiffPreprocessor._instance = null;
		}

		// Token: 0x060438F0 RID: 276720 RVA: 0x0108772A File Offset: 0x0108592A
		static FloatingSubtitleLanguageDiffPreprocessor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FloatingSubtitleLanguageDiffPreprocessor.CreateStaticDefaultValue), new Action(FloatingSubtitleLanguageDiffPreprocessor.ResetStaticDefaultValue));
		}

		// Token: 0x04023468 RID: 144488
		public const string FLOATING_SUBTITLE_VERTICAL_TAG = "VT";

		// Token: 0x04023469 RID: 144489
		public const string FLOATING_SUBTITLE_HORIZONTAL_TAG = "HR";

		// Token: 0x0402346A RID: 144490
		[Nullable(2)]
		private static FloatingSubtitleLanguageDiffPreprocessor _instance;
	}
}
