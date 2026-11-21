using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002665 RID: 9829
	public class EPlayerInputConstraintTypeJsonConverter : JsonConverter<EPlayerInputConstraintType>
	{
		// Token: 0x0600D422 RID: 54306 RVA: 0x001ED0C4 File Offset: 0x001EB2C4
		public override EPlayerInputConstraintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerInputConstraintType.Left;
			}
			return EPlayerInputConstraintTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x001ED0E8 File Offset: 0x001EB2E8
		public override void Write(Utf8JsonWriter writer, EPlayerInputConstraintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
