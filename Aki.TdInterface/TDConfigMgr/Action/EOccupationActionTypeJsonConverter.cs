using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B4 RID: 9140
	public class EOccupationActionTypeJsonConverter : JsonConverter<EOccupationActionType>
	{
		// Token: 0x0600C72A RID: 50986 RVA: 0x001D294C File Offset: 0x001D0B4C
		public override EOccupationActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOccupationActionType.Request;
			}
			return EOccupationActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x001D2970 File Offset: 0x001D0B70
		public override void Write(Utf8JsonWriter writer, EOccupationActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
