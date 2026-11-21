using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A90 RID: 23184
	public class ECommonChildViewNameJsonConverter : JsonConverter<ECommonChildViewName>
	{
		// Token: 0x06039245 RID: 234053 RVA: 0x01000DE0 File Offset: 0x00FFEFE0
		public override ECommonChildViewName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECommonChildViewName.SolarSchoolMain;
			}
			return ECommonChildViewNameExtensions.FromString(@string);
		}

		// Token: 0x06039246 RID: 234054 RVA: 0x01000E04 File Offset: 0x00FFF004
		public override void Write(Utf8JsonWriter writer, ECommonChildViewName value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
