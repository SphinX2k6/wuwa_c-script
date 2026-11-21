using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055DA RID: 21978
	[JsonConverter(typeof(EDropCatchCommandNameJsonConverter))]
	[EnumExtensions]
	public enum EDropCatchCommandName
	{
		// Token: 0x0401CBE9 RID: 117737
		[EnumStringMember("SpawnDropItem")]
		SpawnDropItem,
		// Token: 0x0401CBEA RID: 117738
		[EnumStringMember("AddEnergy")]
		AddEnergy,
		// Token: 0x0401CBEB RID: 117739
		[EnumStringMember("FullEnergy")]
		FullEnergy,
		// Token: 0x0401CBEC RID: 117740
		[EnumStringMember("AddScore")]
		AddScore,
		// Token: 0x0401CBED RID: 117741
		[EnumStringMember("AddTime")]
		AddTime,
		// Token: 0x0401CBEE RID: 117742
		[EnumStringMember("MoveRole")]
		MoveRole,
		// Token: 0x0401CBEF RID: 117743
		[EnumStringMember("CrazyMode")]
		CrazyMode,
		// Token: 0x0401CBF0 RID: 117744
		[EnumStringMember("AddShield")]
		AddShield,
		// Token: 0x0401CBF1 RID: 117745
		[EnumStringMember("ConvertDropItem")]
		ConvertDropItem,
		// Token: 0x0401CBF2 RID: 117746
		[EnumStringMember("ModifyRoleSpeed")]
		ModifyRoleSpeed,
		// Token: 0x0401CBF3 RID: 117747
		[EnumStringMember("ModifyDropPoolTimeInterval")]
		ModifyDropPoolTimeInterval,
		// Token: 0x0401CBF4 RID: 117748
		[EnumStringMember("ModifyAddScoreRate")]
		ModifyAddScoreRate,
		// Token: 0x0401CBF5 RID: 117749
		[EnumStringMember("ModifyEnergyGetRate")]
		ModifyEnergyGetRate,
		// Token: 0x0401CBF6 RID: 117750
		[EnumStringMember("ShowLeftMsg")]
		ShowLeftMsg,
		// Token: 0x0401CBF7 RID: 117751
		[EnumStringMember("ShowFloatEff")]
		ShowFloatEff,
		// Token: 0x0401CBF8 RID: 117752
		[EnumStringMember("ChangeRoleColor")]
		ChangeRoleColor,
		// Token: 0x0401CBF9 RID: 117753
		[EnumStringMember("PostAudioEvent")]
		PostAudioEvent,
		// Token: 0x0401CBFA RID: 117754
		[EnumStringMember("PlayFlow")]
		PlayFlow,
		// Token: 0x0401CBFB RID: 117755
		[EnumStringMember("SetInputEnabled")]
		SetInputEnabled
	}
}
