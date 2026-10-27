using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000975 RID: 2421
	public class EInteractEntityPartBindTypeJsonConverter : JsonConverter<EInteractEntityPartBindType>
	{
		// Token: 0x06003641 RID: 13889 RVA: 0x0008D88C File Offset: 0x0008BA8C
		public override EInteractEntityPartBindType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractEntityPartBindType.Prefab;
			}
			return EInteractEntityPartBindTypeExtensions.FromString(@string);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0008D8B0 File Offset: 0x0008BAB0
		public override void Write(Utf8JsonWriter writer, EInteractEntityPartBindType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
