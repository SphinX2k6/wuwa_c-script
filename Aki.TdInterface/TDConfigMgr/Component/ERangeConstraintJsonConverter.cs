using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EB RID: 2539
	public class ERangeConstraintJsonConverter : JsonConverter<ERangeConstraint>
	{
		// Token: 0x06003854 RID: 14420 RVA: 0x00091EF8 File Offset: 0x000900F8
		public override ERangeConstraint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERangeConstraint.SearchSpawnMonsterPoint;
			}
			return ERangeConstraintExtensions.FromString(@string);
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00091F1C File Offset: 0x0009011C
		public override void Write(Utf8JsonWriter writer, ERangeConstraint value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
