using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002573 RID: 9587
	public class EDisplayModeInPlayerOpJsonConverter : JsonConverter<EDisplayModeInPlayerOp>
	{
		// Token: 0x0600CFE1 RID: 53217 RVA: 0x001E1F84 File Offset: 0x001E0184
		public override EDisplayModeInPlayerOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDisplayModeInPlayerOp.ShowUi;
			}
			return EDisplayModeInPlayerOpExtensions.FromString(@string);
		}

		// Token: 0x0600CFE2 RID: 53218 RVA: 0x001E1FA8 File Offset: 0x001E01A8
		public override void Write(Utf8JsonWriter writer, EDisplayModeInPlayerOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
