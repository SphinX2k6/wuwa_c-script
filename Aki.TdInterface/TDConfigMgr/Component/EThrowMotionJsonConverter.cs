using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A37 RID: 2615
	public class EThrowMotionJsonConverter : JsonConverter<EThrowMotion>
	{
		// Token: 0x060039AA RID: 14762 RVA: 0x00094DD8 File Offset: 0x00092FD8
		public override EThrowMotion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EThrowMotion.Projectile;
			}
			return EThrowMotionExtensions.FromString(@string);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00094DFC File Offset: 0x00092FFC
		public override void Write(Utf8JsonWriter writer, EThrowMotion value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
