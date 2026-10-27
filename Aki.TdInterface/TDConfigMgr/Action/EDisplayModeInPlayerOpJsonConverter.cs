using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002304 RID: 8964
	public class EDisplayModeInPlayerOpJsonConverter : JsonConverter<EDisplayModeInPlayerOp>
	{
		// Token: 0x0600C412 RID: 50194 RVA: 0x001CA0BC File Offset: 0x001C82BC
		public override EDisplayModeInPlayerOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDisplayModeInPlayerOp.ShowUi;
			}
			return EDisplayModeInPlayerOpExtensions.FromString(@string);
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x001CA0E0 File Offset: 0x001C82E0
		public override void Write(Utf8JsonWriter writer, EDisplayModeInPlayerOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
