using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB0 RID: 2736
	public class ERangeConstraintJsonConverter : JsonConverter<ERangeConstraint>
	{
		// Token: 0x06003C2C RID: 15404 RVA: 0x0009A7B8 File Offset: 0x000989B8
		public override ERangeConstraint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERangeConstraint.SearchSpawnMonsterPoint;
			}
			return ERangeConstraintExtensions.FromString(@string);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0009A7DC File Offset: 0x000989DC
		public override void Write(Utf8JsonWriter writer, ERangeConstraint value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
