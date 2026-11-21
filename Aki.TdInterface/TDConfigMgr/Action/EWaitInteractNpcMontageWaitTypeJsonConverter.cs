using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002763 RID: 10083
	public class EWaitInteractNpcMontageWaitTypeJsonConverter : JsonConverter<EWaitInteractNpcMontageWaitType>
	{
		// Token: 0x0600D899 RID: 55449 RVA: 0x001FA5EC File Offset: 0x001F87EC
		public override EWaitInteractNpcMontageWaitType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWaitInteractNpcMontageWaitType.WaitForMontage;
			}
			return EWaitInteractNpcMontageWaitTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x001FA610 File Offset: 0x001F8810
		public override void Write(Utf8JsonWriter writer, EWaitInteractNpcMontageWaitType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
