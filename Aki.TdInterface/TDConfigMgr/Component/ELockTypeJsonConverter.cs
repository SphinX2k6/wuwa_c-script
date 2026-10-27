using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000991 RID: 2449
	public class ELockTypeJsonConverter : JsonConverter<ELockType>
	{
		// Token: 0x060036BF RID: 14015 RVA: 0x0008E8E0 File Offset: 0x0008CAE0
		public override ELockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELockType.Default;
			}
			return ELockTypeExtensions.FromString(@string);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0008E904 File Offset: 0x0008CB04
		public override void Write(Utf8JsonWriter writer, ELockType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
