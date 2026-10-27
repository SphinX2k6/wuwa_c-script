using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A31 RID: 2609
	public class ETeleControlLockingPerformJsonConverter : JsonConverter<ETeleControlLockingPerform>
	{
		// Token: 0x0600398F RID: 14735 RVA: 0x000949F8 File Offset: 0x00092BF8
		public override ETeleControlLockingPerform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleControlLockingPerform.RightMatch;
			}
			return ETeleControlLockingPerformExtensions.FromString(@string);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00094A1C File Offset: 0x00092C1C
		public override void Write(Utf8JsonWriter writer, ETeleControlLockingPerform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
