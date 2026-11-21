using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200000E RID: 14
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OneOfJsonConvertor : JsonConverter<IOneOfObject>
{
	// Token: 0x06000096 RID: 150 RVA: 0x000046BC File Offset: 0x000028BC
	public override bool CanConvert(Type typeToConvert)
	{
		return true;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000046BF File Offset: 0x000028BF
	public override IOneOfObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000046C6 File Offset: 0x000028C6
	public override void Write(Utf8JsonWriter writer, IOneOfObject value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToString());
	}
}
