using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253D RID: 9533
	public class ECameraShakeTypeJsonConverter : JsonConverter<ECameraShakeType>
	{
		// Token: 0x0600CEEE RID: 52974 RVA: 0x001E01D0 File Offset: 0x001DE3D0
		public override ECameraShakeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraShakeType.Constant;
			}
			return ECameraShakeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x001E01F4 File Offset: 0x001DE3F4
		public override void Write(Utf8JsonWriter writer, ECameraShakeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
