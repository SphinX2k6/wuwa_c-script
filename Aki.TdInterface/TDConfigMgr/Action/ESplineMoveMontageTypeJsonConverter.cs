using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C9 RID: 9929
	public class ESplineMoveMontageTypeJsonConverter : JsonConverter<ESplineMoveMontageType>
	{
		// Token: 0x0600D5E4 RID: 54756 RVA: 0x001F13B4 File Offset: 0x001EF5B4
		public override ESplineMoveMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveMontageType.ThreeStageMontage;
			}
			return ESplineMoveMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x001F13D8 File Offset: 0x001EF5D8
		public override void Write(Utf8JsonWriter writer, ESplineMoveMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
