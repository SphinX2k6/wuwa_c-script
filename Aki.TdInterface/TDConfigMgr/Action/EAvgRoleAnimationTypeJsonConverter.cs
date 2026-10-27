using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AC RID: 8876
	public class EAvgRoleAnimationTypeJsonConverter : JsonConverter<EAvgRoleAnimationType>
	{
		// Token: 0x0600C286 RID: 49798 RVA: 0x001C6C84 File Offset: 0x001C4E84
		public override EAvgRoleAnimationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgRoleAnimationType.Idle;
			}
			return EAvgRoleAnimationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C287 RID: 49799 RVA: 0x001C6CA8 File Offset: 0x001C4EA8
		public override void Write(Utf8JsonWriter writer, EAvgRoleAnimationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
