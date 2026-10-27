using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E4 RID: 8932
	public class EClientFollowShooterLeisureInteractTypeJsonConverter : JsonConverter<EClientFollowShooterLeisureInteractType>
	{
		// Token: 0x0600C382 RID: 50050 RVA: 0x001C9038 File Offset: 0x001C7238
		public override EClientFollowShooterLeisureInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientFollowShooterLeisureInteractType.ResetToPlayer;
			}
			return EClientFollowShooterLeisureInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C383 RID: 50051 RVA: 0x001C905C File Offset: 0x001C725C
		public override void Write(Utf8JsonWriter writer, EClientFollowShooterLeisureInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
