using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055FD RID: 22013
	[JsonConverter(typeof(EDropCatchCommandSourceJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchCommandSource
	{
		// Token: 0x0401CC4F RID: 117839
		[EnumStringMember("Skill")]
		Skill
	}
}
