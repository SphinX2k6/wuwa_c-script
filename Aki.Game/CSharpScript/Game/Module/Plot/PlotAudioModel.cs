using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FDA RID: 20442
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotAudioModel : ModelBase
	{
		// Token: 0x060344E3 RID: 214243 RVA: 0x00C48BCC File Offset: 0x00C46DCC
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

		// Token: 0x060344E4 RID: 214244 RVA: 0x00C48CD0 File Offset: 0x00C46ED0
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

		// Token: 0x060344E5 RID: 214245 RVA: 0x00C48E18 File Offset: 0x00C47018
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

		// Token: 0x060344E6 RID: 214246 RVA: 0x00C48EF0 File Offset: 0x00C470F0
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

		// Token: 0x060344E7 RID: 214247 RVA: 0x00C48F3C File Offset: 0x00C4713C
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

		// Token: 0x17007FBC RID: 32700
		// (get) Token: 0x060344E8 RID: 214248 RVA: 0x00C48FBC File Offset: 0x00C471BC
		public static PlotAudioModel Instance
		{
			get
			{
				return PlotAudioModel._Instance;
			}
		}

		// Token: 0x060344E9 RID: 214249 RVA: 0x00C48FC3 File Offset: 0x00C471C3
		public static PlotAudioModel GetOrCreateInstance()
		{
			if (PlotAudioModel._Instance == null)
			{
				PlotAudioModel.CreateInstance();
			}
			return PlotAudioModel._Instance;
		}

		// Token: 0x060344EA RID: 214250 RVA: 0x00C48FD7 File Offset: 0x00C471D7
		public static bool CreateInstance()
		{
			if (PlotAudioModel._Instance != null)
			{
				return true;
			}
			PlotAudioModel._Instance = new PlotAudioModel();
			return true;
		}

		// Token: 0x060344EB RID: 214251 RVA: 0x00C48FED File Offset: 0x00C471ED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060344EC RID: 214252 RVA: 0x00C48FEF File Offset: 0x00C471EF
		public static void ResetStaticDefaultValue()
		{
			PlotAudioModel._Instance = null;
		}

		// Token: 0x060344ED RID: 214253 RVA: 0x00C48FF7 File Offset: 0x00C471F7
		static PlotAudioModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotAudioModel.CreateStaticDefaultValue), new Action(PlotAudioModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD1A RID: 113946
		private const string GLOBAL = "gl";

		// Token: 0x0401BD1B RID: 113947
		[Nullable(2)]
		private static PlotAudioModel _Instance;
	}
}
