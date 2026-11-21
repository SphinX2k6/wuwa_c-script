using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC1 RID: 15041
	[NullableContext(1)]
	[Nullable(0)]
	internal class TowerDefenseRankItemUtil : Singleton
	{
		// Token: 0x06026A68 RID: 158312 RVA: 0x00AD39B1 File Offset: 0x00AD1BB1
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

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x06026A69 RID: 158313 RVA: 0x00AD39CB File Offset: 0x00AD1BCB
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

		// Token: 0x06026A6A RID: 158314 RVA: 0x00AD39EE File Offset: 0x00AD1BEE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026A6B RID: 158315 RVA: 0x00AD39F0 File Offset: 0x00AD1BF0
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseRankItemUtil instance = TowerDefenseRankItemUtil._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TowerDefenseRankItemUtil._instance = null;
		}

		// Token: 0x06026A6C RID: 158316 RVA: 0x00AD3A09 File Offset: 0x00AD1C09
		static TowerDefenseRankItemUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseRankItemUtil.CreateStaticDefaultValue), new Action(TowerDefenseRankItemUtil.ResetStaticDefaultValue));
		}

		// Token: 0x04015290 RID: 86672
		public const string FIRSTPLAYER_ICON = "FormationOnline1PIcon";

		// Token: 0x04015291 RID: 86673
		public const string SECONDPLAYER_ICON = "FormationOnline2PIcon";

		// Token: 0x04015292 RID: 86674
		public const string THIRDPLAYER_ICON = "FormationOnline3PIcon";

		// Token: 0x04015293 RID: 86675
		[Nullable(2)]
		private static TowerDefenseRankItemUtil _instance;
	}
}
