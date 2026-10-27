using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066A8 RID: 26280
	[JsonConverter(typeof(EDropCatchModifierTypeJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchModifierType
	{
		// Token: 0x040223E8 RID: 140264
		[EnumStringMember("Override")]
		Override,
		// Token: 0x040223E9 RID: 140265
		[EnumStringMember("Rate")]
		Rate,
		// Token: 0x040223EA RID: 140266
		[EnumStringMember("Offset")]
		Offset
	}
}
