using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B5 RID: 5045
	public class ERangeLimitingPriorityJsonConverter : JsonConverter<ERangeLimitingPriority>
	{
		// Token: 0x0600710A RID: 28938 RVA: 0x0010DB7C File Offset: 0x0010BD7C
		public override ERangeLimitingPriority Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERangeLimitingPriority.Low;
			}
			return ERangeLimitingPriorityExtensions.FromString(@string);
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0010DBA0 File Offset: 0x0010BDA0
		public override void Write(Utf8JsonWriter writer, ERangeLimitingPriority value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
