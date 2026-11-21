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
	// Token: 0x02004014 RID: 16404
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitleLanguageUtil : Singleton
	{
		// Token: 0x0602984F RID: 170063 RVA: 0x00BB8B88 File Offset: 0x00BB6D88
		public float GetFontSize(FloatingSubtitle3D config)
		{
			float langFontSize = this.GetLangFontSize(config);
			if (langFontSize <= 0f)
			{
				return config.Size;
			}
			return langFontSize;
		}

		// Token: 0x06029850 RID: 170064 RVA: 0x00BB8BB0 File Offset: 0x00BB6DB0
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

		// Token: 0x06029851 RID: 170065 RVA: 0x00BB8C0A File Offset: 0x00BB6E0A
		public float GetLayoutScale(float fontSize)
		{
			if (fontSize <= 0f)
			{
				return 1f;
			}
			return fontSize / 110f;
		}

		// Token: 0x06029852 RID: 170066 RVA: 0x00BB8C21 File Offset: 0x00BB6E21
		public int GetSpaceSize(float fontSize)
		{
			if (fontSize <= 0f)
			{
				return 0;
			}
			return Math.Max(1, (int)MathF.Round(fontSize * 0.465f));
		}

		// Token: 0x06029853 RID: 170067 RVA: 0x00BB8C40 File Offset: 0x00BB6E40
		[NullableContext(2)]
		public void ApplySpaceMark(UUIText text)
		{
			if (text == null)
			{
				return;
			}
			this.RefreshSpaceMark(text, text.GetText(), this.GetSpaceSize(text.GetSize()));
		}

		// Token: 0x06029854 RID: 170068 RVA: 0x00BB8C60 File Offset: 0x00BB6E60
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

		// Token: 0x06029855 RID: 170069 RVA: 0x00BB8CAC File Offset: 0x00BB6EAC
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

		// Token: 0x06029856 RID: 170070 RVA: 0x00BB8D90 File Offset: 0x00BB6F90
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

		// Token: 0x06029857 RID: 170071 RVA: 0x00BB8E1C File Offset: 0x00BB701C
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

		// Token: 0x06029858 RID: 170072 RVA: 0x00BB8EE8 File Offset: 0x00BB70E8
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

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x06029859 RID: 170073 RVA: 0x00BB8FB3 File Offset: 0x00BB71B3
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

		// Token: 0x0602985A RID: 170074 RVA: 0x00BB8FD6 File Offset: 0x00BB71D6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602985B RID: 170075 RVA: 0x00BB8FD8 File Offset: 0x00BB71D8
		public static void ResetStaticDefaultValue()
		{
			FloatingSubtitleLanguageUtil instance = FloatingSubtitleLanguageUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FloatingSubtitleLanguageUtil._instance = null;
		}

		// Token: 0x0602985C RID: 170076 RVA: 0x00BB8FF1 File Offset: 0x00BB71F1
		static FloatingSubtitleLanguageUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FloatingSubtitleLanguageUtil.CreateStaticDefaultValue), new Action(FloatingSubtitleLanguageUtil.ResetStaticDefaultValue));
		}

		// Token: 0x04016A91 RID: 92817
		private const char SPACE_MARK = '#';

		// Token: 0x04016A92 RID: 92818
		private const string SPACE_GLYPH = "\u3000";

		// Token: 0x04016A93 RID: 92819
		private const float SPACE_SIZE_RATIO = 0.465f;

		// Token: 0x04016A94 RID: 92820
		private const float LAYOUT_BASE_FONT_SIZE = 110f;

		// Token: 0x04016A95 RID: 92821
		[Nullable(2)]
		private static FloatingSubtitleLanguageUtil _instance;
	}
}
