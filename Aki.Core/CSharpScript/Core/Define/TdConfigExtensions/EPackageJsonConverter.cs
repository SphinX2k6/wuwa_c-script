using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000148 RID: 328
	public class EPackageJsonConverter : JsonConverter<EPackage>
	{
		// Token: 0x06000B85 RID: 2949 RVA: 0x00037888 File Offset: 0x00035A88
		public override EPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPackage.Message;
			}
			return EPackageExtensions.FromString(@string);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000378AC File Offset: 0x00035AAC
		public override void Write(Utf8JsonWriter writer, EPackage value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
