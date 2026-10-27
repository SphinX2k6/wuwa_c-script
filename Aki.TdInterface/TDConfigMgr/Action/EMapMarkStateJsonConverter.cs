using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237E RID: 9086
	public class EMapMarkStateJsonConverter : JsonConverter<EMapMarkState>
	{
		// Token: 0x0600C637 RID: 50743 RVA: 0x001D0968 File Offset: 0x001CEB68
		public override EMapMarkState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapMarkState.Show;
			}
			return EMapMarkStateExtensions.FromString(@string);
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x001D098C File Offset: 0x001CEB8C
		public override void Write(Utf8JsonWriter writer, EMapMarkState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
