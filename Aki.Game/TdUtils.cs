using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.TDConfigMgr.Component;

// Token: 0x020034CB RID: 13515
[NullableContext(1)]
[Nullable(0)]
public class TdUtils : IStaticVariableResetter
{
	// Token: 0x0601D701 RID: 120577 RVA: 0x00837476 File Offset: 0x00835676
	static TdUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TdUtils.CreateStaticDefaultValue), new Action(TdUtils.ResetStaticDefaultValue));
	}

	// Token: 0x170028D8 RID: 10456
	// (get) Token: 0x0601D702 RID: 120578 RVA: 0x00837495 File Offset: 0x00835695
	public static Dictionary<ELevelPrefabBpType, string> LevelPrefabBpPathConfig
	{
		get
		{
			return TdUtils._levelPrefabBpPathConfig;
		}
	}

	// Token: 0x0601D703 RID: 120579 RVA: 0x0083749C File Offset: 0x0083569C
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

	// Token: 0x0601D704 RID: 120580 RVA: 0x008374F3 File Offset: 0x008356F3
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

	// Token: 0x0601D705 RID: 120581 RVA: 0x00837523 File Offset: 0x00835723
	public static void ResetStaticDefaultValue()
	{
		TdUtils._levelPrefabBpPathConfig = null;
	}

	// Token: 0x0601D706 RID: 120582 RVA: 0x0083752B File Offset: 0x0083572B
	public static bool IgnoreUnderScore(string key)
	{
		return key.StartsWith('_');
	}

	// Token: 0x0601D707 RID: 120583 RVA: 0x00837535 File Offset: 0x00835735
	public static bool IsGuid(string key)
	{
		return key == "Guid" || key == "ActionGuid";
	}

	// Token: 0x0601D708 RID: 120584 RVA: 0x00837551 File Offset: 0x00835751
	public static bool isTemplateOnly(string key)
	{
		return key == "EdIsLocked";
	}

	// Token: 0x0601D709 RID: 120585 RVA: 0x0083755E File Offset: 0x0083575E
	public static bool EntityDataSerializeIgnoreFunc(string key)
	{
		return TdUtils.IgnoreUnderScore(key) || TdUtils.IsGuid(key) || TdUtils.isTemplateOnly(key);
	}

	// Token: 0x0601D70A RID: 120586 RVA: 0x00837578 File Offset: 0x00835778
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

	// Token: 0x0601D70B RID: 120587 RVA: 0x0083766C File Offset: 0x0083586C
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

	// Token: 0x0400E7ED RID: 59373
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ELevelPrefabBpType, string> _levelPrefabBpPathConfig;
}
