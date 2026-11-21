using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF6 RID: 2806
	public class ETeleControlLockingPerformJsonConverter : JsonConverter<ETeleControlLockingPerform>
	{
		// Token: 0x06003D67 RID: 15719 RVA: 0x0009D32C File Offset: 0x0009B52C
		public override ETeleControlLockingPerform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleControlLockingPerform.RightMatch;
			}
			return ETeleControlLockingPerformExtensions.FromString(@string);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0009D350 File Offset: 0x0009B550
		public override void Write(Utf8JsonWriter writer, ETeleControlLockingPerform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
