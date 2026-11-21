using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B8 RID: 184
	[NullableContext(1)]
	[Nullable(0)]
	public class PackSelectionTables : IStaticVariableResetter
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x000386E8 File Offset: 0x000368E8
		public static void CreateStaticDefaultValue()
		{
			PackSelectionTables.DownLoadSubPackageTableInstance = new DownLoadSubPackageTable();
			PackSelectionTables.DungeonPackInfoTableInstance = new DungeonPackInfoTable();
			PackSelectionTables.MapBlockInfoTableInstance = new MapBlockInfoTable();
			PackSelectionTables.QuestRefMapBlockTableInstance = new QuestRefMapBlockTable();
			PackSelectionTables.QuestRefVideoConfigTableInstance = new QuestRefVideoConfigTable();
			PackSelectionTables.RefResourceQuestListTableInstance = new RefResourceQuestListTable();
			PackSelectionTables.RecommendPackTableInstance = new RecommendPackTable();
			PackSelectionTables.RoleVoiceLanguageTableInstance = new RoleVoiceLanguageTable();
			PackSelectionTables.RecallConfigTableInstance = new RecallConfigTable();
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0003874F File Offset: 0x0003694F
		public static void ResetStaticDefaultValue()
		{
			PackSelectionTables.DownLoadSubPackageTableInstance = null;
			PackSelectionTables.DungeonPackInfoTableInstance = null;
			PackSelectionTables.MapBlockInfoTableInstance = null;
			PackSelectionTables.QuestRefMapBlockTableInstance = null;
			PackSelectionTables.QuestRefVideoConfigTableInstance = null;
			PackSelectionTables.RefResourceQuestListTableInstance = null;
			PackSelectionTables.RecommendPackTableInstance = null;
			PackSelectionTables.RoleVoiceLanguageTableInstance = null;
			PackSelectionTables.RecallConfigTableInstance = null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00038787 File Offset: 0x00036987
		static PackSelectionTables()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PackSelectionTables.CreateStaticDefaultValue), new Action(PackSelectionTables.ResetStaticDefaultValue));
		}

		// Token: 0x040003EF RID: 1007
		public static DownLoadSubPackageTable DownLoadSubPackageTableInstance;

		// Token: 0x040003F0 RID: 1008
		public static DungeonPackInfoTable DungeonPackInfoTableInstance;

		// Token: 0x040003F1 RID: 1009
		public static MapBlockInfoTable MapBlockInfoTableInstance;

		// Token: 0x040003F2 RID: 1010
		public static QuestRefMapBlockTable QuestRefMapBlockTableInstance;

		// Token: 0x040003F3 RID: 1011
		public static QuestRefVideoConfigTable QuestRefVideoConfigTableInstance;

		// Token: 0x040003F4 RID: 1012
		public static RefResourceQuestListTable RefResourceQuestListTableInstance;

		// Token: 0x040003F5 RID: 1013
		public static RecommendPackTable RecommendPackTableInstance;

		// Token: 0x040003F6 RID: 1014
		public static RoleVoiceLanguageTable RoleVoiceLanguageTableInstance;

		// Token: 0x040003F7 RID: 1015
		public static RecallConfigTable RecallConfigTableInstance;
	}
}
