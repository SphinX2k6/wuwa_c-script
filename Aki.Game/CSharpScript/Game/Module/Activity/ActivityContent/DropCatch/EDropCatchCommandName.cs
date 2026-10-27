using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200668A RID: 26250
	[JsonConverter(typeof(EDropCatchCommandNameJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchCommandName
	{
		// Token: 0x04022390 RID: 140176
		[EnumStringMember("SpawnDropItem")]
		SpawnDropItem,
		// Token: 0x04022391 RID: 140177
		[EnumStringMember("AddEnergy")]
		AddEnergy,
		// Token: 0x04022392 RID: 140178
		[EnumStringMember("FullEnergy")]
		FullEnergy,
		// Token: 0x04022393 RID: 140179
		[EnumStringMember("AddScore")]
		AddScore,
		// Token: 0x04022394 RID: 140180
		[EnumStringMember("AddTime")]
		AddTime,
		// Token: 0x04022395 RID: 140181
		[EnumStringMember("MoveRole")]
		MoveRole,
		// Token: 0x04022396 RID: 140182
		[EnumStringMember("CrazyMode")]
		CrazyMode,
		// Token: 0x04022397 RID: 140183
		[EnumStringMember("AddShield")]
		AddShield,
		// Token: 0x04022398 RID: 140184
		[EnumStringMember("ConvertDropItem")]
		ConvertDropItem,
		// Token: 0x04022399 RID: 140185
		[EnumStringMember("ModifyRoleSpeed")]
		ModifyRoleSpeed,
		// Token: 0x0402239A RID: 140186
		[EnumStringMember("ModifyDropPoolTimeInterval")]
		ModifyDropPoolTimeInterval,
		// Token: 0x0402239B RID: 140187
		[EnumStringMember("ModifyAddScoreRate")]
		ModifyAddScoreRate,
		// Token: 0x0402239C RID: 140188
		[EnumStringMember("ModifyEnergyGetRate")]
		ModifyEnergyGetRate,
		// Token: 0x0402239D RID: 140189
		[EnumStringMember("ShowLeftMsg")]
		ShowLeftMsg,
		// Token: 0x0402239E RID: 140190
		[EnumStringMember("ShowFloatEff")]
		ShowFloatEff,
		// Token: 0x0402239F RID: 140191
		[EnumStringMember("ChangeRoleColor")]
		ChangeRoleColor,
		// Token: 0x040223A0 RID: 140192
		[EnumStringMember("PostAudioEvent")]
		PostAudioEvent,
		// Token: 0x040223A1 RID: 140193
		[EnumStringMember("PlayFlow")]
		PlayFlow,
		// Token: 0x040223A2 RID: 140194
		[EnumStringMember("SetInputEnabled")]
		SetInputEnabled
	}
}
