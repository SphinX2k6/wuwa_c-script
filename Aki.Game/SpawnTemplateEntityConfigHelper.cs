using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using UnrealEngine;

// Token: 0x020034D0 RID: 13520
public class SpawnTemplateEntityConfigHelper : IStaticVariableResetter
{
	// Token: 0x0601D71C RID: 120604 RVA: 0x00837A43 File Offset: 0x00835C43
	static SpawnTemplateEntityConfigHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpawnTemplateEntityConfigHelper.CreateStaticDefaultValue), new Action(SpawnTemplateEntityConfigHelper.ResetStaticDefaultValue));
	}

	// Token: 0x0601D71D RID: 120605 RVA: 0x00837A62 File Offset: 0x00835C62
	public static void CreateStaticDefaultValue()
	{
		SpawnTemplateEntityConfigHelper.CachedEntries = null;
		SpawnTemplateEntityConfigHelper.CachedTemplateHash = 0UL;
		SpawnTemplateEntityConfigHelper.CachedBlueprintHash = 0UL;
	}

	// Token: 0x0601D71E RID: 120606 RVA: 0x00837A78 File Offset: 0x00835C78
	public static void ResetStaticDefaultValue()
	{
		SpawnTemplateEntityConfigHelper.CachedEntries = null;
		SpawnTemplateEntityConfigHelper.CachedTemplateHash = 0UL;
		SpawnTemplateEntityConfigHelper.CachedBlueprintHash = 0UL;
	}

	// Token: 0x0601D71F RID: 120607 RVA: 0x00837A90 File Offset: 0x00835C90
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public unsafe static string[] GetEntityStrings()
	{
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/Template.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/Template.json");
		}
		string configPath2 = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Blueprint.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath2 = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Blueprint.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath) || !UBlueprintPathsLibrary.FileExists(configPath2))
		{
			return null;
		}
		TArray<byte> inArr = new TArray<byte>();
		UKuroStaticLibrary.LoadFileToArray(configPath, ref inArr);
		TArray<byte> inArr2 = new TArray<byte>();
		UKuroStaticLibrary.LoadFileToArray(configPath2, ref inArr2);
		Span<byte> span = inArr.AsSpan<byte>();
		Span<byte> span2 = inArr2.AsSpan<byte>();
		ulong num = SpawnTemplateEntityConfigHelper.Fnv1a64(span);
		ulong num2 = SpawnTemplateEntityConfigHelper.Fnv1a64(span2);
		string[] cachedEntries = SpawnTemplateEntityConfigHelper.CachedEntries;
		if (cachedEntries != null && num == SpawnTemplateEntityConfigHelper.CachedTemplateHash && num2 == SpawnTemplateEntityConfigHelper.CachedBlueprintHash)
		{
			return cachedEntries;
		}
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		Utf8JsonReader utf8JsonReader = new Utf8JsonReader(span, default(JsonReaderOptions));
		while (utf8JsonReader.Read())
		{
			if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && utf8JsonReader.ValueTextEquals(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.24FA54277D9E0E20A5D6DD6B327EFFABB7C942D44B84EBEB74A9FA15B295ACF5), 9)))
			{
				utf8JsonReader.Read();
				while (utf8JsonReader.Read())
				{
					if (utf8JsonReader.TokenType == JsonTokenType.EndArray)
					{
						break;
					}
					if (utf8JsonReader.TokenType == JsonTokenType.StartObject)
					{
						string text = null;
						int value = 0;
						while (utf8JsonReader.Read() && utf8JsonReader.TokenType != JsonTokenType.EndObject)
						{
							if (utf8JsonReader.TokenType == JsonTokenType.PropertyName)
							{
								if (utf8JsonReader.ValueTextEquals(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B474A192A6D98BF7961BB49EA6C0CFEF4E0C9C8241ED61E4EBD7A5DA0C9631CC), 13)))
								{
									utf8JsonReader.Read();
									text = utf8JsonReader.GetString();
								}
								else if (utf8JsonReader.ValueTextEquals(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.01B8FA292F56C20CC6159FF1EEDFD1254E07B65549BE854C6E27C3D00332D1C4), 2)))
								{
									utf8JsonReader.Read();
									value = utf8JsonReader.GetInt32();
								}
								else
								{
									utf8JsonReader.TrySkip();
								}
							}
						}
						dictionary[text ?? ""] = value;
					}
				}
				break;
			}
		}
		List<string> list = new List<string>();
		Utf8JsonReader utf8JsonReader2 = new Utf8JsonReader(span2, default(JsonReaderOptions));
		while (utf8JsonReader2.Read())
		{
			if (utf8JsonReader2.TokenType == JsonTokenType.PropertyName && utf8JsonReader2.ValueTextEquals(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.146483E89B2D135C15F0B5492FC2155506751A286ED53E930B9E68E85D529E99), 15)))
			{
				utf8JsonReader2.Read();
				while (utf8JsonReader2.Read())
				{
					if (utf8JsonReader2.TokenType == JsonTokenType.EndObject)
					{
						break;
					}
					if (utf8JsonReader2.TokenType == JsonTokenType.PropertyName)
					{
						string @string = utf8JsonReader2.GetString();
						utf8JsonReader2.Read();
						string text2 = null;
						while (utf8JsonReader2.Read() && utf8JsonReader2.TokenType != JsonTokenType.EndObject)
						{
							if (utf8JsonReader2.TokenType == JsonTokenType.PropertyName)
							{
								if (utf8JsonReader2.ValueTextEquals(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.5458F37977E6129640E9A702B17242E615BF4672EFF3161FE49121846D47A085), 4)))
								{
									utf8JsonReader2.Read();
									text2 = utf8JsonReader2.GetString();
								}
								else
								{
									utf8JsonReader2.TrySkip();
								}
							}
						}
						int value2;
						if (dictionary.TryGetValue(@string, out value2))
						{
							List<string> list2 = list;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
							defaultInterpolatedStringHandler.AppendFormatted(text2);
							defaultInterpolatedStringHandler.AppendLiteral("|");
							defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
							list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
						}
						else
						{
							list.Add(text2 + "|undefined");
						}
					}
				}
				break;
			}
		}
		string[] result = SpawnTemplateEntityConfigHelper.CachedEntries = list.ToArray();
		SpawnTemplateEntityConfigHelper.CachedTemplateHash = num;
		SpawnTemplateEntityConfigHelper.CachedBlueprintHash = num2;
		return result;
	}

	// Token: 0x0601D720 RID: 120608 RVA: 0x00837DEC File Offset: 0x00835FEC
	private unsafe static ulong Fnv1a64(ReadOnlySpan<byte> data)
	{
		ulong num = 14695981039346656037UL;
		int length = data.Length;
		int i = 0;
		while (i + 8 <= length)
		{
			ulong num2 = (ulong)(*data[i]) | (ulong)(*data[i + 1]) << 8 | (ulong)(*data[i + 2]) << 16 | (ulong)(*data[i + 3]) << 24 | (ulong)(*data[i + 4]) << 32 | (ulong)(*data[i + 5]) << 40 | (ulong)(*data[i + 6]) << 48 | (ulong)(*data[i + 7]) << 56;
			num ^= num2;
			num *= 1099511628211UL;
			i += 8;
		}
		while (i < length)
		{
			num ^= (ulong)(*data[i]);
			num *= 1099511628211UL;
			i++;
		}
		return num;
	}

	// Token: 0x0400E7FE RID: 59390
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static string[] CachedEntries;

	// Token: 0x0400E7FF RID: 59391
	private static ulong CachedTemplateHash;

	// Token: 0x0400E800 RID: 59392
	private static ulong CachedBlueprintHash;
}
