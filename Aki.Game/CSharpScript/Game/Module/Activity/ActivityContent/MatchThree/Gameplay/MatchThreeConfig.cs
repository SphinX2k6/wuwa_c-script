using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005427 RID: 21543
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MatchThreeConfig : ConfigBase
	{
		// Token: 0x0603580C RID: 219148 RVA: 0x00EF181B File Offset: 0x00EEFA1B
		public MatchThreePiece? GetPieceConfig(int id)
		{
			return ConfigMatchThreePieceById.GetConfig(id, true);
		}

		// Token: 0x0603580D RID: 219149 RVA: 0x00EF1824 File Offset: 0x00EEFA24
		public MatchThreeEliminate? GetEliminateConfig(int id)
		{
			return ConfigMatchThreeEliminateById.GetConfig(id, true);
		}

		// Token: 0x0603580E RID: 219150 RVA: 0x00EF182D File Offset: 0x00EEFA2D
		public MatchThreeComponent? GetComponentConfig(int id)
		{
			return ConfigMatchThreeComponentById.GetConfig(id, true);
		}

		// Token: 0x0603580F RID: 219151 RVA: 0x00EF1836 File Offset: 0x00EEFA36
		public MatchThreeGameplay? GetGameplayConfig(int id)
		{
			return ConfigMatchThreeGameplayById.GetConfig(id, true);
		}

		// Token: 0x06035810 RID: 219152 RVA: 0x00EF183F File Offset: 0x00EEFA3F
		public MatchThreeGoal? GetGoalConfig(int id)
		{
			return ConfigMatchThreeGoalById.GetConfig(id, true);
		}

		// Token: 0x06035811 RID: 219153 RVA: 0x00EF1848 File Offset: 0x00EEFA48
		public MatchThreeEnviroment? GetEnviromentConfig(int id)
		{
			return ConfigMatchThreeEnviromentById.GetConfig(id, true);
		}

		// Token: 0x06035812 RID: 219154 RVA: 0x00EF1851 File Offset: 0x00EEFA51
		public MatchThreeRole? GetRoleConfig(int id)
		{
			return ConfigMatchThreeRoleById.GetConfig(id, true);
		}

		// Token: 0x06035813 RID: 219155 RVA: 0x00EF185A File Offset: 0x00EEFA5A
		public MatchThreeSkill? GetSkillConfig(int id)
		{
			return ConfigMatchThreeSkillById.GetConfig(id, true);
		}

		// Token: 0x06035814 RID: 219156 RVA: 0x00EF1863 File Offset: 0x00EEFA63
		[NullableContext(2)]
		public IReadOnlyList<MatchThreeBoard> GetBoardConfigList(int boardId)
		{
			return ConfigMatchThreeBoardByBoardId.GetConfigList(boardId, true);
		}

		// Token: 0x06035815 RID: 219157 RVA: 0x00EF186C File Offset: 0x00EEFA6C
		protected override bool OnClear()
		{
			this.ScoreComments = null;
			return true;
		}

		// Token: 0x06035816 RID: 219158 RVA: 0x00EF1878 File Offset: 0x00EEFA78
		public ScoreComment? GetCommentConfig(int score)
		{
			int num;
			return this.GetCommentConfig(score, out num);
		}

		// Token: 0x06035817 RID: 219159 RVA: 0x00EF1890 File Offset: 0x00EEFA90
		public ScoreComment? GetCommentConfig(int score, out int gradeLevel)
		{
			ScoreComment[] array = this.EnsureScoreComments();
			gradeLevel = 0;
			if (array.Length == 0)
			{
				return null;
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (array[i].Count <= score)
				{
					gradeLevel = i + 1;
					return new ScoreComment?(array[i]);
				}
			}
			gradeLevel = 1;
			return new ScoreComment?(array[0]);
		}

		// Token: 0x17006819 RID: 26649
		// (get) Token: 0x06035818 RID: 219160 RVA: 0x00EF18F5 File Offset: 0x00EEFAF5
		public int ScoreGradeCount
		{
			get
			{
				return this.EnsureScoreComments().Length;
			}
		}

		// Token: 0x06035819 RID: 219161 RVA: 0x00EF1900 File Offset: 0x00EEFB00
		private ScoreComment[] EnsureScoreComments()
		{
			if (this.ScoreComments != null)
			{
				return this.ScoreComments;
			}
			IReadOnlyList<MatchThreeComment> configList = ConfigMatchThreeCommentAll.GetConfigList(true);
			if (configList == null)
			{
				return Array.Empty<ScoreComment>();
			}
			this.ScoreComments = new ScoreComment[configList.Count];
			for (int i = 0; i < configList.Count; i++)
			{
				this.ScoreComments[i] = new ScoreComment(configList[i].Count, configList[i].Color1, configList[i].Color2, configList[i].Icon);
			}
			return this.ScoreComments;
		}

		// Token: 0x0603581A RID: 219162 RVA: 0x00EF19A1 File Offset: 0x00EEFBA1
		public MatchThreeFillRules? GetFillRulesConfig(int id)
		{
			return ConfigMatchThreeFillRulesById.GetConfig(id, true);
		}

		// Token: 0x1700681A RID: 26650
		// (get) Token: 0x0603581B RID: 219163 RVA: 0x00EF19AA File Offset: 0x00EEFBAA
		public static MatchThreeConfig Instance
		{
			get
			{
				return MatchThreeConfig._Instance;
			}
		}

		// Token: 0x0603581C RID: 219164 RVA: 0x00EF19B1 File Offset: 0x00EEFBB1
		public static MatchThreeConfig GetOrCreateInstance()
		{
			if (MatchThreeConfig._Instance == null)
			{
				MatchThreeConfig.CreateInstance();
			}
			return MatchThreeConfig._Instance;
		}

		// Token: 0x0603581D RID: 219165 RVA: 0x00EF19C5 File Offset: 0x00EEFBC5
		public static bool CreateInstance()
		{
			if (MatchThreeConfig._Instance != null)
			{
				return true;
			}
			MatchThreeConfig._Instance = new MatchThreeConfig();
			return true;
		}

		// Token: 0x0603581E RID: 219166 RVA: 0x00EF19DB File Offset: 0x00EEFBDB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603581F RID: 219167 RVA: 0x00EF19DD File Offset: 0x00EEFBDD
		public static void ResetStaticDefaultValue()
		{
			MatchThreeConfig._Instance = null;
		}

		// Token: 0x06035820 RID: 219168 RVA: 0x00EF19E5 File Offset: 0x00EEFBE5
		static MatchThreeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatchThreeConfig.CreateStaticDefaultValue), new Action(MatchThreeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C3F8 RID: 115704
		[Nullable(2)]
		private ScoreComment[] ScoreComments;

		// Token: 0x0401C3F9 RID: 115705
		[Nullable(2)]
		private static MatchThreeConfig _Instance;
	}
}
