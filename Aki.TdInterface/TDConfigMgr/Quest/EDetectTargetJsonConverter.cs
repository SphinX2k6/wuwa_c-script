using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001237 RID: 4663
	public class EDetectTargetJsonConverter : JsonConverter<EDetectTarget>
	{
		// Token: 0x060069A0 RID: 27040 RVA: 0x000FCDA0 File Offset: 0x000FAFA0
		public override EDetectTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectTarget.ControlledRole;
			}
			return EDetectTargetExtensions.FromString(@string);
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x000FCDC4 File Offset: 0x000FAFC4
		public override void Write(Utf8JsonWriter writer, EDetectTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
