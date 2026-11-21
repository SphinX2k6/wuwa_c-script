using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002585 RID: 9605
	public class EElementalBoxTargetPosTypeJsonConverter : JsonConverter<EElementalBoxTargetPosType>
	{
		// Token: 0x0600D032 RID: 53298 RVA: 0x001E2A30 File Offset: 0x001E0C30
		public override EElementalBoxTargetPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			}
			return EElementalBoxTargetPosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D033 RID: 53299 RVA: 0x001E2A54 File Offset: 0x001E0C54
		public override void Write(Utf8JsonWriter writer, EElementalBoxTargetPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
