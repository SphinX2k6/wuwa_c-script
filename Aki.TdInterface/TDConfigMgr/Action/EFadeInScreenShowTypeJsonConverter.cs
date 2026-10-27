using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233A RID: 9018
	public class EFadeInScreenShowTypeJsonConverter : JsonConverter<EFadeInScreenShowType>
	{
		// Token: 0x0600C505 RID: 50437 RVA: 0x001CC2CC File Offset: 0x001CA4CC
		public override EFadeInScreenShowType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeInScreenShowType.White;
			}
			return EFadeInScreenShowTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C506 RID: 50438 RVA: 0x001CC2F0 File Offset: 0x001CA4F0
		public override void Write(Utf8JsonWriter writer, EFadeInScreenShowType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
