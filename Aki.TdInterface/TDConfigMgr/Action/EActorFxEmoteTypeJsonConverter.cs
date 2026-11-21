using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FD RID: 9469
	public class EActorFxEmoteTypeJsonConverter : JsonConverter<EActorFxEmoteType>
	{
		// Token: 0x0600CDCE RID: 52686 RVA: 0x001DD11C File Offset: 0x001DB31C
		public override EActorFxEmoteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActorFxEmoteType.Play;
			}
			return EActorFxEmoteTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x001DD140 File Offset: 0x001DB340
		public override void Write(Utf8JsonWriter writer, EActorFxEmoteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
