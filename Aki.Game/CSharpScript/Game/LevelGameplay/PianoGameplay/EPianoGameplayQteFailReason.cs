using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C1C RID: 23580
	[EnumExtensions]
	public enum EPianoGameplayQteFailReason
	{
		// Token: 0x0401E9C8 RID: 125384
		[EnumStringMember("超时")]
		Timeout,
		// Token: 0x0401E9C9 RID: 125385
		[EnumStringMember("按下按键顺序错误")]
		WrongKey
	}
}
