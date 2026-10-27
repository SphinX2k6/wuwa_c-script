using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000973 RID: 2419
	public class EInteractDefaultIconJsonConverter : JsonConverter<EInteractDefaultIcon>
	{
		// Token: 0x06003638 RID: 13880 RVA: 0x0008D778 File Offset: 0x0008B978
		public override EInteractDefaultIcon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractDefaultIcon.Collect;
			}
			return EInteractDefaultIconExtensions.FromString(@string);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0008D79C File Offset: 0x0008B99C
		public override void Write(Utf8JsonWriter writer, EInteractDefaultIcon value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
