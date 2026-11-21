using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F5 RID: 9717
	public class ELiveLikeStateJsonConverter : JsonConverter<ELiveLikeState>
	{
		// Token: 0x0600D22A RID: 53802 RVA: 0x001E8DCC File Offset: 0x001E6FCC
		public override ELiveLikeState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveLikeState.Enable;
			}
			return ELiveLikeStateExtensions.FromString(@string);
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x001E8DF0 File Offset: 0x001E6FF0
		public override void Write(Utf8JsonWriter writer, ELiveLikeState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
