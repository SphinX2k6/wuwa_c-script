using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002641 RID: 9793
	public class ENpcGroupSequenceBlendAnimTypeJsonConverter : JsonConverter<ENpcGroupSequenceBlendAnimType>
	{
		// Token: 0x0600D380 RID: 54144 RVA: 0x001EBAE4 File Offset: 0x001E9CE4
		public override ENpcGroupSequenceBlendAnimType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcGroupSequenceBlendAnimType.AnimSequence;
			}
			return ENpcGroupSequenceBlendAnimTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x001EBB08 File Offset: 0x001E9D08
		public override void Write(Utf8JsonWriter writer, ENpcGroupSequenceBlendAnimType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
