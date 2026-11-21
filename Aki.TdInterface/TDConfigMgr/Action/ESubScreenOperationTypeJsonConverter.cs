using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D9 RID: 9945
	public class ESubScreenOperationTypeJsonConverter : JsonConverter<ESubScreenOperationType>
	{
		// Token: 0x0600D62C RID: 54828 RVA: 0x001F1FAC File Offset: 0x001F01AC
		public override ESubScreenOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenOperationType.Init;
			}
			return ESubScreenOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x001F1FD0 File Offset: 0x001F01D0
		public override void Write(Utf8JsonWriter writer, ESubScreenOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
