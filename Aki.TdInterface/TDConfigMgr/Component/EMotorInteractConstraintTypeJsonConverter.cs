using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A5A RID: 2650
	public class EMotorInteractConstraintTypeJsonConverter : JsonConverter<EMotorInteractConstraintType>
	{
		// Token: 0x06003AA9 RID: 15017 RVA: 0x000974E4 File Offset: 0x000956E4
		public override EMotorInteractConstraintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorInteractConstraintType.FaceToTarget;
			}
			return EMotorInteractConstraintTypeExtensions.FromString(@string);
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x00097508 File Offset: 0x00095708
		public override void Write(Utf8JsonWriter writer, EMotorInteractConstraintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
