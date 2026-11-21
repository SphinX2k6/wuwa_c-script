using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055F8 RID: 22008
	[JsonConverter(typeof(EDropCatchModifierTypeJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchModifierType
	{
		// Token: 0x0401CC41 RID: 117825
		[EnumStringMember("Override")]
		Override,
		// Token: 0x0401CC42 RID: 117826
		[EnumStringMember("Rate")]
		Rate,
		// Token: 0x0401CC43 RID: 117827
		[EnumStringMember("Offset")]
		Offset
	}
}
