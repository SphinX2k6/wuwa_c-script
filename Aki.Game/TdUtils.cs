using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.TDConfigMgr.Component;

// Token: 0x02002A3F RID: 10815
[NullableContext(1)]
[Nullable(0)]
public class TdUtils : IStaticVariableResetter
{
	// Token: 0x0601B400 RID: 111616 RVA: 0x0085E91E File Offset: 0x0085CB1E
	static TdUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TdUtils.CreateStaticDefaultValue), new Action(TdUtils.ResetStaticDefaultValue));
	}

	// Token: 0x17002C70 RID: 11376
	// (get) Token: 0x0601B401 RID: 111617 RVA: 0x0085E93D File Offset: 0x0085CB3D
	public static Dictionary<ELevelPrefabBpType, string> LevelPrefabBpPathConfig
	{
		get
		{
			return TdUtils._levelPrefabBpPathConfig;
		}
	}

	// Token: 0x0601B402 RID: 111618 RVA: 0x0085E944 File Offset: 0x0085CB44
	[NullableContext(0)]
	[return: Nullable(2)]
	public static T GetComponent<T>([Nullable(new byte[]
	{
		1,
		2
	})] Dictionary<EConfigComponent, IComponentBase> componentsData, EConfigComponent componentType) where T : IComponentBase
	{
		if (componentsData == null)
		{
			return default(T);
		}
		IComponentBase componentBase;
		if (!componentsData.TryGetValue(componentType, out componentBase))
		{
			return default(T);
		}
		if (componentBase != null && componentBase.Disabled.GetValueOrDefault())
		{
			return default(T);
		}
		return componentBase as T;
	}

	// Token: 0x0601B403 RID: 111619 RVA: 0x0085E99B File Offset: 0x0085CB9B
	public static void CreateStaticDefaultValue()
	{
		TdUtils._levelPrefabBpPathConfig = new Dictionary<ELevelPrefabBpType, string>
		{
			{
				ELevelPrefabBpType.Item,
				"/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C"
			},
			{
				ELevelPrefabBpType.InteractedBox,
				"/Game/Aki/GamePlay/InteractiveObject/BP_InteractedBox.BP_InteractedBox_C"
			},
			{
				ELevelPrefabBpType.PhysicsItem,
				"/Game/Aki/GamePlay/InteractiveObject/BP_PhysicsItem.BP_PhysicsItem_C"
			}
		};
	}

	// Token: 0x0601B404 RID: 111620 RVA: 0x0085E9CB File Offset: 0x0085CBCB
	public static void ResetStaticDefaultValue()
	{
		TdUtils._levelPrefabBpPathConfig = null;
	}

	// Token: 0x0601B405 RID: 111621 RVA: 0x0085E9D3 File Offset: 0x0085CBD3
	public static bool IgnoreUnderScore(string key)
	{
		return key.StartsWith('_');
	}

	// Token: 0x0601B406 RID: 111622 RVA: 0x0085E9DD File Offset: 0x0085CBDD
	public static bool IsGuid(string key)
	{
		return key == "Guid" || key == "ActionGuid";
	}

	// Token: 0x0601B407 RID: 111623 RVA: 0x0085E9F9 File Offset: 0x0085CBF9
	public static bool isTemplateOnly(string key)
	{
		return key == "EdIsLocked";
	}

	// Token: 0x0601B408 RID: 111624 RVA: 0x0085EA06 File Offset: 0x0085CC06
	public static bool EntityDataSerializeIgnoreFunc(string key)
	{
		return TdUtils.IgnoreUnderScore(key) || TdUtils.IsGuid(key) || TdUtils.isTemplateOnly(key);
	}

	// Token: 0x0601B409 RID: 111625 RVA: 0x0085EA20 File Offset: 0x0085CC20
	public static void Merge(JsonElement jElement1, JsonElement jElement2, ArrayBufferWriter<byte> outputBuffer)
	{
		outputBuffer.Clear();
		using (Utf8JsonWriter utf8JsonWriter = new Utf8JsonWriter(outputBuffer, default(JsonWriterOptions)))
		{
			if (jElement1.ValueKind != JsonValueKind.Object)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(94, 1);
				defaultInterpolatedStringHandler.AppendLiteral("The original JSON document to merge new content into must be a container type. Instead it is ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(jElement1.ValueKind);
				defaultInterpolatedStringHandler.AppendLiteral(".");
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (jElement1.ValueKind != jElement2.ValueKind)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
				defaultInterpolatedStringHandler.AppendLiteral("The json ValueKind is different ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(jElement1.ValueKind);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonValueKind>(jElement2.ValueKind);
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (jElement1.ValueKind == JsonValueKind.Object)
			{
				TdUtils.MergeObjects(utf8JsonWriter, jElement1, jElement2);
			}
		}
	}

	// Token: 0x0601B40A RID: 111626 RVA: 0x0085EB14 File Offset: 0x0085CD14
	private static void MergeObjects(Utf8JsonWriter jsonWriter, JsonElement jObject1, JsonElement jObject2)
	{
		jsonWriter.WriteStartObject();
		foreach (JsonProperty jsonProperty in jObject1.EnumerateObject())
		{
			string name = jsonProperty.Name;
			JsonElement jObject3;
			if (jObject2.TryGetProperty(name, out jObject3))
			{
				JsonValueKind valueKind = jObject3.ValueKind;
				if (valueKind != JsonValueKind.Null)
				{
					jsonWriter.WritePropertyName(name);
					JsonElement value = jsonProperty.Value;
					JsonValueKind valueKind2 = value.ValueKind;
					if (valueKind == JsonValueKind.Object && valueKind2 == JsonValueKind.Object)
					{
						TdUtils.MergeObjects(jsonWriter, value, jObject3);
					}
					else
					{
						jObject3.WriteTo(jsonWriter);
					}
				}
			}
			else
			{
				jsonProperty.WriteTo(jsonWriter);
			}
		}
		foreach (JsonProperty jsonProperty2 in jObject2.EnumerateObject())
		{
			JsonElement value2;
			if (!jObject1.TryGetProperty(jsonProperty2.Name, out value2))
			{
				value2 = jsonProperty2.Value;
				if (value2.ValueKind != JsonValueKind.Null)
				{
					jsonProperty2.WriteTo(jsonWriter);
				}
			}
		}
		jsonWriter.WriteEndObject();
	}

	// Token: 0x0400ECA1 RID: 60577
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ELevelPrefabBpType, string> _levelPrefabBpPathConfig;
}
