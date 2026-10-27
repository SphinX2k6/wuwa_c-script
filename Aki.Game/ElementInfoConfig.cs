using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001800 RID: 6144
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ElementInfoConfig : ConfigBase
{
	// Token: 0x0600B417 RID: 46103 RVA: 0x0028AAC0 File Offset: 0x00288CC0
	public List<ElementInfo> GetConfigList(int[] idList)
	{
		List<ElementInfo> list = new List<ElementInfo>();
		for (int i = 0; i < idList.Length; i++)
		{
			ElementInfo? config = ConfigElementInfoById.GetConfig(idList[i], true);
			if (config != null)
			{
				list.Add(config.Value);
			}
		}
		list.Sort((ElementInfo a, ElementInfo b) => a.Id.CompareTo(b.Id));
		return list;
	}

	// Token: 0x0600B418 RID: 46104 RVA: 0x0028AB29 File Offset: 0x00288D29
	public ElementInfo? GetElementInfo(int elementId)
	{
		return ConfigElementInfoById.GetConfig(elementId, true);
	}

	// Token: 0x0600B419 RID: 46105 RVA: 0x0028AB34 File Offset: 0x00288D34
	[NullableContext(2)]
	public string GetElementInfoValueByParam(int elementId, string param, [Nullable(1)] string tag)
	{
		ElementInfo? elementInfo = this.GetElementInfo(elementId);
		if (elementInfo == null || param == null)
		{
			return null;
		}
		if (param != null)
		{
			switch (param.Length)
			{
			case 4:
			{
				char c = param[0];
				if (c != 'I')
				{
					if (c == 'N')
					{
						if (param == "Name")
						{
							return elementInfo.Value.Name;
						}
					}
				}
				else if (param == "Icon")
				{
					return elementInfo.Value.Icon;
				}
				break;
			}
			case 5:
				switch (param[4])
				{
				case '2':
					if (param == "Icon2")
					{
						return elementInfo.Value.Icon2;
					}
					break;
				case '3':
					if (param == "Icon3")
					{
						return elementInfo.Value.Icon3;
					}
					break;
				case '4':
					if (param == "Icon4")
					{
						return elementInfo.Value.Icon4;
					}
					break;
				case '5':
					if (param == "Icon5")
					{
						return elementInfo.Value.Icon5;
					}
					break;
				case '6':
					if (param == "Icon6")
					{
						return elementInfo.Value.Icon6;
					}
					break;
				case '7':
					if (param == "Icon7")
					{
						return elementInfo.Value.Icon7;
					}
					break;
				}
				break;
			case 6:
				if (param == "Effect")
				{
					return elementInfo.Value.Effect;
				}
				break;
			case 8:
				if (param == "Describe")
				{
					return elementInfo.Value.Describe;
				}
				break;
			case 9:
				if (param == "Icon4Pure")
				{
					return elementInfo.Value.Icon4Pure;
				}
				break;
			case 10:
				if (param == "AudioEvent")
				{
					return elementInfo.Value.AudioEvent;
				}
				break;
			case 11:
				if (param == "SpriteIcon1")
				{
					return elementInfo.Value.SpriteIcon1;
				}
				break;
			case 12:
				if (param == "ElementColor")
				{
					return elementInfo.Value.ElementColor;
				}
				break;
			case 15:
				if (param == "GachaSpritePath")
				{
					return elementInfo.Value.GachaSpritePath;
				}
				break;
			case 16:
				if (param == "SkillEffectColor")
				{
					return elementInfo.Value.SkillEffectColor;
				}
				break;
			case 17:
				if (param == "EffectTexturePath")
				{
					return elementInfo.Value.EffectTexturePath;
				}
				break;
			case 18:
			{
				char c = param[9];
				if (c <= 'L')
				{
					if (c != 'I')
					{
						if (c == 'L')
						{
							if (param == "SkillTreeLineColor")
							{
								return elementInfo.Value.SkillTreeLineColor;
							}
						}
					}
					else if (param == "SkillTreeIconColor")
					{
						return elementInfo.Value.SkillTreeIconColor;
					}
				}
				else if (c != 'f')
				{
					if (c == 'k')
					{
						if (param == "UltimateSkillColor")
						{
							return elementInfo.Value.UltimateSkillColor;
						}
					}
				}
				else if (param == "ElementEffectColor")
				{
					return elementInfo.Value.ElementEffectColor;
				}
				break;
			}
			case 20:
			{
				char c = param[0];
				if (c != 'E')
				{
					if (c == 'S')
					{
						if (param == "SkillTreeEffectColor")
						{
							return elementInfo.Value.SkillTreeEffectColor;
						}
					}
				}
				else if (param == "ElementChangeTexture")
				{
					return elementInfo.Value.ElementChangeTexture;
				}
				break;
			}
			case 21:
			{
				char c = param[0];
				if (c != 'E')
				{
					if (c == 'S')
					{
						if (param == "SkillButtonEffectPath")
						{
							return elementInfo.Value.SkillButtonEffectPath;
						}
					}
				}
				else if (param == "ElementBallEffectPath")
				{
					return elementInfo.Value.ElementBallEffectPath;
				}
				break;
			}
			case 24:
				if (param == "GachaElementBgSpritePath")
				{
					return elementInfo.Value.GachaElementBgSpritePath;
				}
				break;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiImageSetting;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "配置的表格字段查询到的资源路径不是字符串类型";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", tag);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600B41A RID: 46106 RVA: 0x0028B089 File Offset: 0x00289289
	public string GetElementInfoLocalName(string name)
	{
		return ConfigMultiTextLang.GetLocalTextNew(name, null);
	}

	// Token: 0x0600B41B RID: 46107 RVA: 0x0028B094 File Offset: 0x00289294
	public string GetElementInfoNameByElementId(int elementId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetElementInfo(elementId).Value.Name, null);
	}

	// Token: 0x17000F20 RID: 3872
	// (get) Token: 0x0600B41C RID: 46108 RVA: 0x0028B0BE File Offset: 0x002892BE
	public static ElementInfoConfig Instance
	{
		get
		{
			return ElementInfoConfig._Instance;
		}
	}

	// Token: 0x0600B41D RID: 46109 RVA: 0x0028B0C5 File Offset: 0x002892C5
	public static ElementInfoConfig GetOrCreateInstance()
	{
		if (ElementInfoConfig._Instance == null)
		{
			ElementInfoConfig.CreateInstance();
		}
		return ElementInfoConfig._Instance;
	}

	// Token: 0x0600B41E RID: 46110 RVA: 0x0028B0D9 File Offset: 0x002892D9
	public static bool CreateInstance()
	{
		if (ElementInfoConfig._Instance != null)
		{
			return true;
		}
		ElementInfoConfig._Instance = new ElementInfoConfig();
		return true;
	}

	// Token: 0x0600B41F RID: 46111 RVA: 0x0028B0EF File Offset: 0x002892EF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B420 RID: 46112 RVA: 0x0028B0F1 File Offset: 0x002892F1
	public static void ResetStaticDefaultValue()
	{
		ElementInfoConfig._Instance = null;
	}

	// Token: 0x0600B421 RID: 46113 RVA: 0x0028B0F9 File Offset: 0x002892F9
	static ElementInfoConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ElementInfoConfig.CreateStaticDefaultValue), new Action(ElementInfoConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005167 RID: 20839
	[Nullable(2)]
	private static ElementInfoConfig _Instance;
}
