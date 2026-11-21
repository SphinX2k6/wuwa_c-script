using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002603 RID: 9731
	public class ELoopStateTypeJsonConverter : JsonConverter<ELoopStateType>
	{
		// Token: 0x0600D269 RID: 53865 RVA: 0x001E9708 File Offset: 0x001E7908
		public override ELoopStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELoopStateType.Prev;
			}
			return ELoopStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x001E972C File Offset: 0x001E792C
		public override void Write(Utf8JsonWriter writer, ELoopStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
