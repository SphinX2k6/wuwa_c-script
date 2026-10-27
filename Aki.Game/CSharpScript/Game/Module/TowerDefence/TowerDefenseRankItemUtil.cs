using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B19 RID: 19225
	[NullableContext(1)]
	[Nullable(0)]
	internal class TowerDefenseRankItemUtil : Singleton
	{
		// Token: 0x06031CD8 RID: 203992 RVA: 0x00B8F94D File Offset: 0x00B8DB4D
		public string GetPosTexture(int index)
		{
			if (index == 0)
			{
				return "FormationOnline1PIcon";
			}
			if (index == 1)
			{
				return "FormationOnline2PIcon";
			}
			return "FormationOnline3PIcon";
		}

		// Token: 0x17007B4F RID: 31567
		// (get) Token: 0x06031CD9 RID: 203993 RVA: 0x00B8F967 File Offset: 0x00B8DB67
		public static TowerDefenseRankItemUtil Instance
		{
			get
			{
				if (TowerDefenseRankItemUtil._instance == null)
				{
					TowerDefenseRankItemUtil._instance = new TowerDefenseRankItemUtil();
					TowerDefenseRankItemUtil._instance.OnInit();
				}
				return TowerDefenseRankItemUtil._instance;
			}
		}

		// Token: 0x06031CDA RID: 203994 RVA: 0x00B8F98A File Offset: 0x00B8DB8A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031CDB RID: 203995 RVA: 0x00B8F98C File Offset: 0x00B8DB8C
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseRankItemUtil instance = TowerDefenseRankItemUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TowerDefenseRankItemUtil._instance = null;
		}

		// Token: 0x06031CDC RID: 203996 RVA: 0x00B8F9A5 File Offset: 0x00B8DBA5
		static TowerDefenseRankItemUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseRankItemUtil.CreateStaticDefaultValue), new Action(TowerDefenseRankItemUtil.ResetStaticDefaultValue));
		}

		// Token: 0x0401A93E RID: 108862
		public const string FIRSTPLAYER_ICON = "FormationOnline1PIcon";

		// Token: 0x0401A93F RID: 108863
		public const string SECONDPLAYER_ICON = "FormationOnline2PIcon";

		// Token: 0x0401A940 RID: 108864
		public const string THIRDPLAYER_ICON = "FormationOnline3PIcon";

		// Token: 0x0401A941 RID: 108865
		[Nullable(2)]
		private static TowerDefenseRankItemUtil _instance;
	}
}
