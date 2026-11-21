using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E1 RID: 9697
	public class EKeepMovementStateJsonConverter : JsonConverter<EKeepMovementState>
	{
		// Token: 0x0600D1D0 RID: 53712 RVA: 0x001E71D0 File Offset: 0x001E53D0
		public override EKeepMovementState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKeepMovementState.Kite;
			}
			return EKeepMovementStateExtensions.FromString(@string);
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x001E71F4 File Offset: 0x001E53F4
		public override void Write(Utf8JsonWriter writer, EKeepMovementState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
