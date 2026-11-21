using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002555 RID: 9557
	public class EClientFollowShooterLeisureInteractTypeJsonConverter : JsonConverter<EClientFollowShooterLeisureInteractType>
	{
		// Token: 0x0600CF5A RID: 53082 RVA: 0x001E0F60 File Offset: 0x001DF160
		public override EClientFollowShooterLeisureInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientFollowShooterLeisureInteractType.PlayAnimation;
			}
			return EClientFollowShooterLeisureInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x001E0F84 File Offset: 0x001DF184
		public override void Write(Utf8JsonWriter writer, EClientFollowShooterLeisureInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
