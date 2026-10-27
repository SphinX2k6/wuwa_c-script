using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CE RID: 9166
	public class EPlayerInputConstraintTypeJsonConverter : JsonConverter<EPlayerInputConstraintType>
	{
		// Token: 0x0600C79F RID: 51103 RVA: 0x001D3918 File Offset: 0x001D1B18
		public override EPlayerInputConstraintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerInputConstraintType.Left;
			}
			return EPlayerInputConstraintTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x001D393C File Offset: 0x001D1B3C
		public override void Write(Utf8JsonWriter writer, EPlayerInputConstraintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
