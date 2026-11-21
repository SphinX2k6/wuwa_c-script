using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256D RID: 9581
	public class EDeliverItemProbeCollectibleViewStyleJsonConverter : JsonConverter<EDeliverItemProbeCollectibleViewStyle>
	{
		// Token: 0x0600CFC6 RID: 53190 RVA: 0x001E1CB8 File Offset: 0x001DFEB8
		public override EDeliverItemProbeCollectibleViewStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
			}
			return EDeliverItemProbeCollectibleViewStyleExtensions.FromString(@string);
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x001E1CDC File Offset: 0x001DFEDC
		public override void Write(Utf8JsonWriter writer, EDeliverItemProbeCollectibleViewStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
