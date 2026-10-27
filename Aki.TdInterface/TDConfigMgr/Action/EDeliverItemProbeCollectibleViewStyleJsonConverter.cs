using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FC RID: 8956
	public class EDeliverItemProbeCollectibleViewStyleJsonConverter : JsonConverter<EDeliverItemProbeCollectibleViewStyle>
	{
		// Token: 0x0600C3EE RID: 50158 RVA: 0x001C9D14 File Offset: 0x001C7F14
		public override EDeliverItemProbeCollectibleViewStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
			}
			return EDeliverItemProbeCollectibleViewStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C3EF RID: 50159 RVA: 0x001C9D38 File Offset: 0x001C7F38
		public override void Write(Utf8JsonWriter writer, EDeliverItemProbeCollectibleViewStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
