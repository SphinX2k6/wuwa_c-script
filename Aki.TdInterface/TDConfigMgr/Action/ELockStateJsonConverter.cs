using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002374 RID: 9076
	public class ELockStateJsonConverter : JsonConverter<ELockState>
	{
		// Token: 0x0600C60A RID: 50698 RVA: 0x001D03BC File Offset: 0x001CE5BC
		public override ELockState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELockState.Lock;
			}
			return ELockStateExtensions.FromString(@string);
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x001D03E0 File Offset: 0x001CE5E0
		public override void Write(Utf8JsonWriter writer, ELockState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
