using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000977 RID: 2423
	public class EInteractPlayerDiractionTypeJsonConverter : JsonConverter<EInteractPlayerDiractionType>
	{
		// Token: 0x0600364A RID: 13898 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		public override EInteractPlayerDiractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractPlayerDiractionType.Npc;
			}
			return EInteractPlayerDiractionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0008D9C4 File Offset: 0x0008BBC4
		public override void Write(Utf8JsonWriter writer, EInteractPlayerDiractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
