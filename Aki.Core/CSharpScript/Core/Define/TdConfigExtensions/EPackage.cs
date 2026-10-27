using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x0200013D RID: 317
	[JsonConverter(typeof(EPackageJsonConverter))]
	[EnumExtensions]
	public enum EPackage
	{
		// Token: 0x040006CA RID: 1738
		[EnumStringMember("M")]
		Message,
		// Token: 0x040006CB RID: 1739
		[EnumStringMember("C")]
		Connect,
		// Token: 0x040006CC RID: 1740
		[EnumStringMember("CA")]
		ConnectAck
	}
}
