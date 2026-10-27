using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using AkiClient.Game.Aki.UI.Framework;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005045 RID: 20549
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitleLanguageUtil : Singleton
	{
		// Token: 0x06034973 RID: 215411 RVA: 0x00C6BAE8 File Offset: 0x00C69CE8
		public float GetFontSize(FloatingSubtitle3D config)
		{
			float langFontSize = this.GetLangFontSize(config);
			if (langFontSize <= 0f)
			{
				return config.Size;
			}
			return langFontSize;
		}

		// Token: 0x06034974 RID: 215412 RVA: 0x00C6BB10 File Offset: 0x00C69D10
		[NullableContext(2)]
		public void EnableTextAdaptSize(UUIText text)
		{
			object obj;
			if (text == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = text.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(BP_3DTextAdaptSize_C.StaticClass()) : null);
			}
			BP_3DTextAdaptSize_C bp_3DTextAdaptSize_C = obj as BP_3DTextAdaptSize_C;
			if (bp_3DTextAdaptSize_C == null)
			{
				return;
			}
			bp_3DTextAdaptSize_C.Vertical = (FloatingSubtitleLanguageDiffPreprocessor.Instance.GetLayoutTag() == "VT");
			bp_3DTextAdaptSize_C.AdaptEnabled = true;
		}

		// Token: 0x06034975 RID: 215413 RVA: 0x00C6BB6A File Offset: 0x00C69D6A
		public float GetLayoutScale(float fontSize)
		{
			if (fontSize <= 0f)
			{
				return 1f;
			}
			return fontSize / 110f;
		}

		// Token: 0x06034976 RID: 215414 RVA: 0x00C6BB81 File Offset: 0x00C69D81
		public int GetSpaceSize(float fontSize)
		{
			if (fontSize <= 0f)
			{
				return 0;
			}
			return Math.Max(1, (int)MathF.Round(fontSize * 0.465f));
		}

		// Token: 0x06034977 RID: 215415 RVA: 0x00C6BBA0 File Offset: 0x00C69DA0
		[NullableContext(2)]
		public void ApplySpaceMark(UUIText text)
		{
			if (text == null)
			{
				return;
			}
			this.RefreshSpaceMark(text, text.GetText(), this.GetSpaceSize(text.GetSize()));
		}

		// Token: 0x06034978 RID: 215416 RVA: 0x00C6BBC0 File Offset: 0x00C69DC0
		public bool RefreshSpaceMark([Nullable(2)] UUIText text, string rawText, int spaceSize)
		{
			if (text == null || spaceSize <= 0 || FloatingSubtitleLanguageDiffPreprocessor.Instance.GetLayoutTag() != "VT")
			{
				return false;
			}
			string text2 = this.ReplaceSpaceMark(rawText, spaceSize);
			if (text2 == null)
			{
				return false;
			}
			text.SetRichText(true);
			text.SetText(text2, true);
			return true;
		}

		// Token: 0x06034979 RID: 215417 RVA: 0x00C6BC0C File Offset: 0x00C69E0C
		[return: Nullable(2)]
		private string ReplaceSpaceMark(string text, int spaceSize)
		{
			if (string.IsNullOrEmpty(text) || text.IndexOf('#') < 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(text.Length + 32);
			bool flag = false;
			bool flag2 = false;
			int i = 0;
			while (i < text.Length)
			{
				char c = text[i];
				if (c == '<')
				{
					flag = true;
					goto IL_AE;
				}
				if (c == '>')
				{
					flag = false;
					goto IL_AE;
				}
				if (flag || c != '#')
				{
					goto IL_AE;
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(39, 2, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("<size=");
				appendInterpolatedStringHandler.AppendFormatted<int>(spaceSize);
				appendInterpolatedStringHandler.AppendLiteral("><color=#00000000>");
				appendInterpolatedStringHandler.AppendFormatted("\u3000");
				appendInterpolatedStringHandler.AppendLiteral("</color></size>");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				flag2 = true;
				IL_B7:
				i++;
				continue;
				IL_AE:
				stringBuilder.Append(c);
				goto IL_B7;
			}
			if (!flag2)
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0603497A RID: 215418 RVA: 0x00C6BCF0 File Offset: 0x00C69EF0
		public Dictionary<string, float> GetScaleMap(string sequenceName)
		{
			Dictionary<string, float> dictionary = new Dictionary<string, float>();
			IReadOnlyList<FloatingSubtitle2D> configList = ConfigFloatingSubtitle2DAll.GetConfigList(true);
			if (configList == null)
			{
				return dictionary;
			}
			foreach (FloatingSubtitle2D config in configList)
			{
				if (!(config.SequenceName != sequenceName))
				{
					float langScale = this.GetLangScale(config);
					dictionary[config.TextKey] = ((langScale > 0f) ? langScale : 1f);
				}
			}
			return dictionary;
		}

		// Token: 0x0603497B RID: 215419 RVA: 0x00C6BD7C File Offset: 0x00C69F7C
		private float GetLangFontSize(FloatingSubtitle3D config)
		{
			ELanguageType? packageLanguageType = LanguageSystem.Instance.PackageLanguageType;
			if (packageLanguageType != null)
			{
				switch (packageLanguageType.GetValueOrDefault())
				{
				case ELanguageType.En:
					return config.SizeEn;
				case ELanguageType.Ja:
					return config.SizeJa;
				case ELanguageType.Ko:
					return config.SizeKo;
				case ELanguageType.Ru:
					return config.SizeRu;
				case ELanguageType.Zht:
					return config.SizeZhHant;
				case ELanguageType.De:
					return config.SizeDe;
				case ELanguageType.Es:
					return config.SizeEs;
				case ELanguageType.Pt:
					return config.SizePt;
				case ELanguageType.Id:
					return config.SizeIdn;
				case ELanguageType.Fr:
					return config.SizeFr;
				case ELanguageType.Vi:
					return config.SizeVi;
				case ELanguageType.Th:
					return config.SizeTh;
				}
			}
			return 0f;
		}

		// Token: 0x0603497C RID: 215420 RVA: 0x00C6BE48 File Offset: 0x00C6A048
		private float GetLangScale(FloatingSubtitle2D config)
		{
			ELanguageType? packageLanguageType = LanguageSystem.Instance.PackageLanguageType;
			if (packageLanguageType != null)
			{
				switch (packageLanguageType.GetValueOrDefault())
				{
				case ELanguageType.En:
					return config.ScaleEn;
				case ELanguageType.Ja:
					return config.ScaleJa;
				case ELanguageType.Ko:
					return config.ScaleKo;
				case ELanguageType.Ru:
					return config.ScaleRu;
				case ELanguageType.Zht:
					return config.ScaleZhHant;
				case ELanguageType.De:
					return config.ScaleDe;
				case ELanguageType.Es:
					return config.ScaleEs;
				case ELanguageType.Pt:
					return config.ScalePt;
				case ELanguageType.Id:
					return config.ScaleIdn;
				case ELanguageType.Fr:
					return config.ScaleFr;
				case ELanguageType.Vi:
					return config.ScaleVi;
				case ELanguageType.Th:
					return config.ScaleTh;
				}
			}
			return 0f;
		}

		// Token: 0x1700802B RID: 32811
		// (get) Token: 0x0603497D RID: 215421 RVA: 0x00C6BF13 File Offset: 0x00C6A113
		public static FloatingSubtitleLanguageUtil Instance
		{
			get
			{
				if (FloatingSubtitleLanguageUtil._instance == null)
				{
					FloatingSubtitleLanguageUtil._instance = new FloatingSubtitleLanguageUtil();
					FloatingSubtitleLanguageUtil._instance.OnInit();
				}
				return FloatingSubtitleLanguageUtil._instance;
			}
		}

		// Token: 0x0603497E RID: 215422 RVA: 0x00C6BF36 File Offset: 0x00C6A136
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603497F RID: 215423 RVA: 0x00C6BF38 File Offset: 0x00C6A138
		public static void ResetStaticDefaultValue()
		{
			FloatingSubtitleLanguageUtil instance = FloatingSubtitleLanguageUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FloatingSubtitleLanguageUtil._instance = null;
		}

		// Token: 0x06034980 RID: 215424 RVA: 0x00C6BF51 File Offset: 0x00C6A151
		static FloatingSubtitleLanguageUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FloatingSubtitleLanguageUtil.CreateStaticDefaultValue), new Action(FloatingSubtitleLanguageUtil.ResetStaticDefaultValue));
		}

		// Token: 0x0401C06E RID: 114798
		private const char SPACE_MARK = '#';

		// Token: 0x0401C06F RID: 114799
		private const string SPACE_GLYPH = "\u3000";

		// Token: 0x0401C070 RID: 114800
		private const float SPACE_SIZE_RATIO = 0.465f;

		// Token: 0x0401C071 RID: 114801
		private const float LAYOUT_BASE_FONT_SIZE = 110f;

		// Token: 0x0401C072 RID: 114802
		[Nullable(2)]
		private static FloatingSubtitleLanguageUtil _instance;
	}
}
