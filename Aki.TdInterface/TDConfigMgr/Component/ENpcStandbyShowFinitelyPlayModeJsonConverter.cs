using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A6C RID: 2668
	public class ENpcStandbyShowFinitelyPlayModeJsonConverter : JsonConverter<ENpcStandbyShowFinitelyPlayMode>
	{
		// Token: 0x06003AFA RID: 15098 RVA: 0x000982A8 File Offset: 0x000964A8
		public override ENpcStandbyShowFinitelyPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcStandbyShowFinitelyPlayMode.Randomly;
			}
			return ENpcStandbyShowFinitelyPlayModeExtensions.FromString(@string);
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x000982CC File Offset: 0x000964CC
		public override void Write(Utf8JsonWriter writer, ENpcStandbyShowFinitelyPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
