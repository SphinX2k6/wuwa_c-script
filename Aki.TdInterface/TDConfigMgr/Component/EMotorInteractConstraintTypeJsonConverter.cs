using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A5 RID: 2469
	public class EMotorInteractConstraintTypeJsonConverter : JsonConverter<EMotorInteractConstraintType>
	{
		// Token: 0x06003719 RID: 14105 RVA: 0x0008F420 File Offset: 0x0008D620
		public override EMotorInteractConstraintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorInteractConstraintType.FaceToTarget;
			}
			return EMotorInteractConstraintTypeExtensions.FromString(@string);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x0008F444 File Offset: 0x0008D644
		public override void Write(Utf8JsonWriter writer, EMotorInteractConstraintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
