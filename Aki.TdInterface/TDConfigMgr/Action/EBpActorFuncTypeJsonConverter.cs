using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C4 RID: 8900
	public class EBpActorFuncTypeJsonConverter : JsonConverter<EBpActorFuncType>
	{
		// Token: 0x0600C2F2 RID: 49906 RVA: 0x001C7B6C File Offset: 0x001C5D6C
		public override EBpActorFuncType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBpActorFuncType.CarPaintChange;
			}
			return EBpActorFuncTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x001C7B90 File Offset: 0x001C5D90
		public override void Write(Utf8JsonWriter writer, EBpActorFuncType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
