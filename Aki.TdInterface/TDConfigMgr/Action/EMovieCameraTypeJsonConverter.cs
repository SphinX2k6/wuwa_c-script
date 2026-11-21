using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262F RID: 9775
	public class EMovieCameraTypeJsonConverter : JsonConverter<EMovieCameraType>
	{
		// Token: 0x0600D32F RID: 54063 RVA: 0x001EB14C File Offset: 0x001E934C
		public override EMovieCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMovieCameraType.Common;
			}
			return EMovieCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D330 RID: 54064 RVA: 0x001EB170 File Offset: 0x001E9370
		public override void Write(Utf8JsonWriter writer, EMovieCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
