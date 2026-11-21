using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048A8 RID: 18600
	public class InstanceDungeonDefine : IStaticVariableResetter
	{
		// Token: 0x0602EBA1 RID: 191393 RVA: 0x00D0920A File Offset: 0x00D0740A
		static InstanceDungeonDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonDefine.CreateStaticDefaultValue), new Action(InstanceDungeonDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602EBA2 RID: 191394 RVA: 0x00D09229 File Offset: 0x00D07429
		public static void CreateStaticDefaultValue()
		{
			InstanceDungeonDefine.TrialRoleSkipCheckInstanceType = new EDungeonSubType[]
			{
				EDungeonSubType.RhythmShip,
				EDungeonSubType.PinballBattle,
				EDungeonSubType.DangoBrawl
			};
		}

		// Token: 0x0602EBA3 RID: 191395 RVA: 0x00D09241 File Offset: 0x00D07441
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonDefine.TrialRoleSkipCheckInstanceType = null;
		}

		// Token: 0x04018D58 RID: 101720
		public const int DUNGEON_ARCHIVE_HELP_ID = 242;

		// Token: 0x04018D59 RID: 101721
		[Nullable(2)]
		public static EDungeonSubType[] TrialRoleSkipCheckInstanceType;
	}
}
