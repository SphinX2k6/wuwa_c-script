using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001743 RID: 5955
	[JsonConverter(typeof(EFadeInScreenShowTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeInScreenShowType
	{
		// Token: 0x04004E84 RID: 20100
		White,
		// Token: 0x04004E85 RID: 20101
		Black
	}
}
