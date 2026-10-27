using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D8 RID: 9176
	public class EPlayMovieProgramSpecialConfigTypeJsonConverter : JsonConverter<EPlayMovieProgramSpecialConfigType>
	{
		// Token: 0x0600C7CC RID: 51148 RVA: 0x001D3FB4 File Offset: 0x001D21B4
		public override EPlayMovieProgramSpecialConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
			}
			return EPlayMovieProgramSpecialConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7CD RID: 51149 RVA: 0x001D3FD8 File Offset: 0x001D21D8
		public override void Write(Utf8JsonWriter writer, EPlayMovieProgramSpecialConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
