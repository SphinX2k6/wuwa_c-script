using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002316 RID: 8982
	public class EElementalBoxTargetPosTypeJsonConverter : JsonConverter<EElementalBoxTargetPosType>
	{
		// Token: 0x0600C463 RID: 50275 RVA: 0x001CAB68 File Offset: 0x001C8D68
		public override EElementalBoxTargetPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			}
			return EElementalBoxTargetPosTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x001CAB8C File Offset: 0x001C8D8C
		public override void Write(Utf8JsonWriter writer, EElementalBoxTargetPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
