using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002627 RID: 9767
	public class EMoveMotionJsonConverter : JsonConverter<EMoveMotion>
	{
		// Token: 0x0600D30B RID: 54027 RVA: 0x001EAC44 File Offset: 0x001E8E44
		public override EMoveMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveMotion.UniformMotion;
			}
			return EMoveMotionExtensions.FromString(@string);
		}

		// Token: 0x0600D30C RID: 54028 RVA: 0x001EAC68 File Offset: 0x001E8E68
		public override void Write(Utf8JsonWriter writer, EMoveMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
