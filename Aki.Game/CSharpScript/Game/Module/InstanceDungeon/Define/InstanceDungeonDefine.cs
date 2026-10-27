using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D0 RID: 22736
	public class InstanceDungeonDefine : IStaticVariableResetter
	{
		// Token: 0x06039C7E RID: 236670 RVA: 0x00DBA2F2 File Offset: 0x00DB84F2
		static InstanceDungeonDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonDefine.CreateStaticDefaultValue), new Action(InstanceDungeonDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06039C7F RID: 236671 RVA: 0x00DBA311 File Offset: 0x00DB8511
		public static void CreateStaticDefaultValue()
		{
			InstanceDungeonDefine.TrialRoleSkipCheckInstanceType = new EDungeonSubType[]
			{
				EDungeonSubType.RhythmShip,
				EDungeonSubType.PinballBattle,
				EDungeonSubType.DangoBrawl
			};
		}

		// Token: 0x06039C80 RID: 236672 RVA: 0x00DBA329 File Offset: 0x00DB8529
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonDefine.TrialRoleSkipCheckInstanceType = null;
		}

		// Token: 0x0401E2BB RID: 123579
		public const int DUNGEON_ARCHIVE_HELP_ID = 242;

		// Token: 0x0401E2BC RID: 123580
		[Nullable(2)]
		public static EDungeonSubType[] TrialRoleSkipCheckInstanceType;
	}
}
