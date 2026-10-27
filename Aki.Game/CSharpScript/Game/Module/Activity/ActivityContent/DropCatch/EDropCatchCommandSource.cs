using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066AD RID: 26285
	[JsonConverter(typeof(EDropCatchCommandSourceJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchCommandSource
	{
		// Token: 0x040223F6 RID: 140278
		[EnumStringMember("Skill")]
		Skill
	}
}
