using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000B5 RID: 181
	[NullableContext(1)]
	[Nullable(0)]
	public class PackSelectionTables : IStaticVariableResetter
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00036BE8 File Offset: 0x00034DE8
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

		// Token: 0x06000623 RID: 1571 RVA: 0x00036C4F File Offset: 0x00034E4F
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

		// Token: 0x06000624 RID: 1572 RVA: 0x00036C87 File Offset: 0x00034E87
		static PackSelectionTables()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PackSelectionTables.CreateStaticDefaultValue), new Action(PackSelectionTables.ResetStaticDefaultValue));
		}

		// Token: 0x040003C0 RID: 960
		public static DownLoadSubPackageTable DownLoadSubPackageTableInstance;

		// Token: 0x040003C1 RID: 961
		public static DungeonPackInfoTable DungeonPackInfoTableInstance;

		// Token: 0x040003C2 RID: 962
		public static MapBlockInfoTable MapBlockInfoTableInstance;

		// Token: 0x040003C3 RID: 963
		public static QuestRefMapBlockTable QuestRefMapBlockTableInstance;

		// Token: 0x040003C4 RID: 964
		public static QuestRefVideoConfigTable QuestRefVideoConfigTableInstance;

		// Token: 0x040003C5 RID: 965
		public static RefResourceQuestListTable RefResourceQuestListTableInstance;

		// Token: 0x040003C6 RID: 966
		public static RecommendPackTable RecommendPackTableInstance;

		// Token: 0x040003C7 RID: 967
		public static RoleVoiceLanguageTable RoleVoiceLanguageTableInstance;

		// Token: 0x040003C8 RID: 968
		public static RecallConfigTable RecallConfigTableInstance;
	}
}
