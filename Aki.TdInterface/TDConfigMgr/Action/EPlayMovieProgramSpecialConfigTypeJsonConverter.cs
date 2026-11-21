using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266F RID: 9839
	public class EPlayMovieProgramSpecialConfigTypeJsonConverter : JsonConverter<EPlayMovieProgramSpecialConfigType>
	{
		// Token: 0x0600D44F RID: 54351 RVA: 0x001ED760 File Offset: 0x001EB960
		public override EPlayMovieProgramSpecialConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
			}
			return EPlayMovieProgramSpecialConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x001ED784 File Offset: 0x001EB984
		public override void Write(Utf8JsonWriter writer, EPlayMovieProgramSpecialConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
