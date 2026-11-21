using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA4 RID: 16292
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotAudioModel : ModelBase
	{
		// Token: 0x0602936C RID: 168812 RVA: 0x00B92C24 File Offset: 0x00B90E24
		public string GetExternalSourcesMediaName(PlotAudio config)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			string value = "";
			string value2 = this.UpdateVarExtension(config.VarParams, config.FileName);
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			if (!(packageAudio == "zh"))
			{
				if (!(packageAudio == "en"))
				{
					if (!(packageAudio == "ja"))
					{
						if (packageAudio == "ko")
						{
							flag = config.CheckGenderKo;
						}
					}
					else
					{
						flag = config.CheckGenderJa;
					}
				}
				else
				{
					flag = config.CheckGenderEn;
				}
			}
			else
			{
				flag = config.CheckGenderZh;
			}
			string value3 = LanguageSystem.Instance.PackageAudio;
			if (config.GlobalLanguage)
			{
				value3 = "gl";
			}
			if (flag)
			{
				value = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "_F" : "_M");
			}
			stringBuilder.Append(value3).Append("_").Append(value2).Append(value).Append(".wem");
			return stringBuilder.ToString();
		}

		// Token: 0x0602936D RID: 168813 RVA: 0x00B92D28 File Offset: 0x00B90F28
		public string GetAudioMouthAnimName(PlotAudio config)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			string value = "";
			string value2 = this.UpdateVarExtension(config.VarParams, config.FileName);
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			if (!(packageAudio == "zh"))
			{
				if (!(packageAudio == "en"))
				{
					if (!(packageAudio == "ja"))
					{
						if (packageAudio == "ko")
						{
							flag = config.CheckGenderKo;
						}
					}
					else
					{
						flag = config.CheckGenderJa;
					}
				}
				else
				{
					flag = config.CheckGenderEn;
				}
			}
			else
			{
				flag = config.CheckGenderZh;
			}
			string value3 = LanguageSystem.Instance.PackageAudio;
			if (config.GlobalLanguage)
			{
				value3 = "gl";
			}
			if (flag)
			{
				value = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "_F" : "_M");
			}
			stringBuilder.Append(value3).Append("_").Append(value2).Append(value);
			string value4 = stringBuilder.ToString();
			stringBuilder.Clear();
			stringBuilder.Append("/Game/Aki/Sequence/SequenceAnim/VoiceMouth/").Append(LanguageSystem.Instance.PackageAudio).Append("/").Append(value4).Append(".").Append(value4);
			return stringBuilder.ToString();
		}

		// Token: 0x0602936E RID: 168814 RVA: 0x00B92E70 File Offset: 0x00B91070
		public string GetExternalSourcesMediaNameForEditor(PlotAudio config, bool isFemale)
		{
			bool flag = false;
			string value = "";
			string value2 = this.UpdateVarExtension(config.VarParams, config.FileName);
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			if (!(packageAudio == "zh"))
			{
				if (!(packageAudio == "en"))
				{
					if (!(packageAudio == "ja"))
					{
						if (packageAudio == "ko")
						{
							flag = config.CheckGenderKo;
						}
					}
					else
					{
						flag = config.CheckGenderJa;
					}
				}
				else
				{
					flag = config.CheckGenderEn;
				}
			}
			else
			{
				flag = config.CheckGenderZh;
			}
			if (flag)
			{
				value = (isFemale ? "_F" : "_M");
			}
			return new StringBuilder(LanguageSystem.Instance.PackageAudio).Append("_").Append(value2).Append(value).Append(".wem").ToString();
		}

		// Token: 0x0602936F RID: 168815 RVA: 0x00B92F48 File Offset: 0x00B91148
		private Dictionary<string, string> ParseParamString(string paramString)
		{
			string[] array = paramString.Split(' ', StringSplitOptions.None);
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split('=', StringSplitOptions.None);
				if (array3.Length == 2)
				{
					dictionary[array3[0]] = array3[1];
				}
			}
			return dictionary;
		}

		// Token: 0x06029370 RID: 168816 RVA: 0x00B92F94 File Offset: 0x00B91194
		private string UpdateVarExtension(string info, string name)
		{
			string text = "";
			if (StringUtils.IsBlank(info))
			{
				return name;
			}
			Dictionary<string, string> dictionary = this.ParseParamString(info);
			string a;
			string key;
			if (dictionary.TryGetValue("VarType", out a) && a == "Global" && dictionary.TryGetValue("Key", out key))
			{
				text = (WorldModel.Instance.GetWorldStateString(key) ?? "");
			}
			if (StringUtils.IsBlank(text))
			{
				return name;
			}
			return new Regex("\\{VarParams\\}").Replace(name, text);
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x06029371 RID: 168817 RVA: 0x00B93014 File Offset: 0x00B91214
		public static PlotAudioModel Instance
		{
			get
			{
				return PlotAudioModel._Instance;
			}
		}

		// Token: 0x06029372 RID: 168818 RVA: 0x00B9301B File Offset: 0x00B9121B
		public static PlotAudioModel GetOrCreateInstance()
		{
			if (PlotAudioModel._Instance == null)
			{
				PlotAudioModel.CreateInstance();
			}
			return PlotAudioModel._Instance;
		}

		// Token: 0x06029373 RID: 168819 RVA: 0x00B9302F File Offset: 0x00B9122F
		public static bool CreateInstance()
		{
			if (PlotAudioModel._Instance != null)
			{
				return true;
			}
			PlotAudioModel._Instance = new PlotAudioModel();
			return true;
		}

		// Token: 0x06029374 RID: 168820 RVA: 0x00B93045 File Offset: 0x00B91245
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029375 RID: 168821 RVA: 0x00B93047 File Offset: 0x00B91247
		public static void ResetStaticDefaultValue()
		{
			PlotAudioModel._Instance = null;
		}

		// Token: 0x06029376 RID: 168822 RVA: 0x00B9304F File Offset: 0x00B9124F
		static PlotAudioModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotAudioModel.CreateStaticDefaultValue), new Action(PlotAudioModel.ResetStaticDefaultValue));
		}

		// Token: 0x040166F5 RID: 91893
		private const string GLOBAL = "gl";

		// Token: 0x040166F6 RID: 91894
		[Nullable(2)]
		private static PlotAudioModel _Instance;
	}
}
