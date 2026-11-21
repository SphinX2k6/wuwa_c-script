using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FD RID: 9725
	public class ELockStateJsonConverter : JsonConverter<ELockState>
	{
		// Token: 0x0600D24E RID: 53838 RVA: 0x001E9390 File Offset: 0x001E7590
		public override ELockState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELockState.Lock;
			}
			return ELockStateExtensions.FromString(@string);
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x001E93B4 File Offset: 0x001E75B4
		public override void Write(Utf8JsonWriter writer, ELockState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
