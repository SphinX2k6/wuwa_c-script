using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A4 RID: 9124
	public class EMovieCameraTypeJsonConverter : JsonConverter<EMovieCameraType>
	{
		// Token: 0x0600C6E2 RID: 50914 RVA: 0x001D1FAC File Offset: 0x001D01AC
		public override EMovieCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMovieCameraType.Common;
			}
			return EMovieCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x001D1FD0 File Offset: 0x001D01D0
		public override void Write(Utf8JsonWriter writer, EMovieCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
