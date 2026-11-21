using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A28 RID: 2600
	public class EInteractEntityPartBindTypeJsonConverter : JsonConverter<EInteractEntityPartBindType>
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x000957F8 File Offset: 0x000939F8
		public override EInteractEntityPartBindType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractEntityPartBindType.Prefab;
			}
			return EInteractEntityPartBindTypeExtensions.FromString(@string);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0009581C File Offset: 0x00093A1C
		public override void Write(Utf8JsonWriter writer, EInteractEntityPartBindType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
