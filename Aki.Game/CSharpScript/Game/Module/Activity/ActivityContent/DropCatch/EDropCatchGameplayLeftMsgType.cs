using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066B0 RID: 26288
	[JsonConverter(typeof(EDropCatchGameplayLeftMsgTypeJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchGameplayLeftMsgType
	{
		// Token: 0x040223FD RID: 140285
		[EnumStringMember("Gameplay")]
		Gameplay,
		// Token: 0x040223FE RID: 140286
		[EnumStringMember("DropItem")]
		DropItem
	}
}
