using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000009 RID: 9
[NullableContext(1)]
[JsonConverter(typeof(OneOfJsonConvertor))]
public interface IOneOfObject
{
	// Token: 0x06000007 RID: 7
	string ToString();
}
