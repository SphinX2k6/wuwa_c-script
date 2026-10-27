using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099B RID: 2459
	public class EMechHookConfigTypeJsonConverter : JsonConverter<EMechHookConfigType>
	{
		// Token: 0x060036EC RID: 14060 RVA: 0x0008EE44 File Offset: 0x0008D044
		public override EMechHookConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechHookConfigType.BurrowHook;
			}
			return EMechHookConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x0008EE68 File Offset: 0x0008D068
		public override void Write(Utf8JsonWriter writer, EMechHookConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
