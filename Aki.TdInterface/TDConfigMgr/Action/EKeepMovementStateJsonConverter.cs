using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236C RID: 9068
	public class EKeepMovementStateJsonConverter : JsonConverter<EKeepMovementState>
	{
		// Token: 0x0600C5E6 RID: 50662 RVA: 0x001CEEF0 File Offset: 0x001CD0F0
		public override EKeepMovementState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKeepMovementState.Kite;
			}
			return EKeepMovementStateExtensions.FromString(@string);
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x001CEF14 File Offset: 0x001CD114
		public override void Write(Utf8JsonWriter writer, EKeepMovementState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
