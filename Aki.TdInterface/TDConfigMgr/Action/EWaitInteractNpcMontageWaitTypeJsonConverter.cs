using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BE RID: 9406
	public class EWaitInteractNpcMontageWaitTypeJsonConverter : JsonConverter<EWaitInteractNpcMontageWaitType>
	{
		// Token: 0x0600CBD7 RID: 52183 RVA: 0x001E0358 File Offset: 0x001DE558
		public override EWaitInteractNpcMontageWaitType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWaitInteractNpcMontageWaitType.WaitForMontage;
			}
			return EWaitInteractNpcMontageWaitTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x001E037C File Offset: 0x001DE57C
		public override void Write(Utf8JsonWriter writer, EWaitInteractNpcMontageWaitType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
