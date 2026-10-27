using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000995 RID: 2453
	public class ELookAtRotateModeJsonConverter : JsonConverter<ELookAtRotateMode>
	{
		// Token: 0x060036D1 RID: 14033 RVA: 0x0008EB08 File Offset: 0x0008CD08
		public override ELookAtRotateMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtRotateMode.KeepInitialPitchRoll;
			}
			return ELookAtRotateModeExtensions.FromString(@string);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0008EB2C File Offset: 0x0008CD2C
		public override void Write(Utf8JsonWriter writer, ELookAtRotateMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
