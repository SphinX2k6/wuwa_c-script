using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002645 RID: 9797
	public class EOccupationActionTypeJsonConverter : JsonConverter<EOccupationActionType>
	{
		// Token: 0x0600D392 RID: 54162 RVA: 0x001EBD80 File Offset: 0x001E9F80
		public override EOccupationActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOccupationActionType.Request;
			}
			return EOccupationActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x001EBDA4 File Offset: 0x001E9FA4
		public override void Write(Utf8JsonWriter writer, EOccupationActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
