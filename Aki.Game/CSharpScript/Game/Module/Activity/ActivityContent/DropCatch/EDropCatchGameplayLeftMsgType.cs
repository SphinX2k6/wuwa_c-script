using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005600 RID: 22016
	[JsonConverter(typeof(EDropCatchGameplayLeftMsgTypeJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchGameplayLeftMsgType
	{
		// Token: 0x0401CC56 RID: 117846
		[EnumStringMember("Gameplay")]
		Gameplay,
		// Token: 0x0401CC57 RID: 117847
		[EnumStringMember("DropItem")]
		DropItem
	}
}
