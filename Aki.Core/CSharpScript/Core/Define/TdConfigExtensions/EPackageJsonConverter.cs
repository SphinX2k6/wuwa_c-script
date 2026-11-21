using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x0200014C RID: 332
	public class EPackageJsonConverter : JsonConverter<EPackage>
	{
		// Token: 0x06000BE1 RID: 3041 RVA: 0x00038458 File Offset: 0x00036658
		public override EPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPackage.Message;
			}
			return EPackageExtensions.FromString(@string);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0003847C File Offset: 0x0003667C
		public override void Write(Utf8JsonWriter writer, EPackage value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
