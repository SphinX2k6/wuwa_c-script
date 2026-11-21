using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B3 RID: 9651
	public class EFollowShooterLeisureInteractTypeJsonConverter : JsonConverter<EFollowShooterLeisureInteractType>
	{
		// Token: 0x0600D101 RID: 53505 RVA: 0x001E47A8 File Offset: 0x001E29A8
		public override EFollowShooterLeisureInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFollowShooterLeisureInteractType.ResetToPlayer;
			}
			return EFollowShooterLeisureInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x001E47CC File Offset: 0x001E29CC
		public override void Write(Utf8JsonWriter writer, EFollowShooterLeisureInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
