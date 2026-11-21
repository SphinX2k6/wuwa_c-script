using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F1 RID: 9713
	public class ELiveForceDanmakuStateJsonConverter : JsonConverter<ELiveForceDanmakuState>
	{
		// Token: 0x0600D218 RID: 53784 RVA: 0x001E8B60 File Offset: 0x001E6D60
		public override ELiveForceDanmakuState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveForceDanmakuState.Force;
			}
			return ELiveForceDanmakuStateExtensions.FromString(@string);
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x001E8B84 File Offset: 0x001E6D84
		public override void Write(Utf8JsonWriter writer, ELiveForceDanmakuState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
