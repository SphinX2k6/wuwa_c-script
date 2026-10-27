using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E3 RID: 5603
	[JsonConverter(typeof(EFadeInScreenShowTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeInScreenShowType
	{
		// Token: 0x04004AC4 RID: 19140
		White,
		// Token: 0x04004AC5 RID: 19141
		Black
	}
}
