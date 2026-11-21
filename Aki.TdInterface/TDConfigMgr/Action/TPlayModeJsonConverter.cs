using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002767 RID: 10087
	public class TPlayModeJsonConverter : JsonConverter<TPlayMode>
	{
		// Token: 0x0600D8AB RID: 55467 RVA: 0x001FAA20 File Offset: 0x001F8C20
		public override TPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TPlayMode.direct;
			}
			return TPlayModeExtensions.FromString(@string);
		}

		// Token: 0x0600D8AC RID: 55468 RVA: 0x001FAA44 File Offset: 0x001F8C44
		public override void Write(Utf8JsonWriter writer, TPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
