using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000141 RID: 321
	[JsonConverter(typeof(EPackageJsonConverter))]
	[EnumExtensions]
	public enum EPackage
	{
		// Token: 0x040006D8 RID: 1752
		[EnumStringMember("M")]
		Message,
		// Token: 0x040006D9 RID: 1753
		[EnumStringMember("C")]
		Connect,
		// Token: 0x040006DA RID: 1754
		[EnumStringMember("CA")]
		ConnectAck
	}
}
