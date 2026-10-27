using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064A9 RID: 25769
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MatchThreeConfig : ConfigBase
	{
		// Token: 0x06040B48 RID: 265032 RVA: 0x00FAA7D3 File Offset: 0x00FA89D3
		public MatchThreePiece? GetPieceConfig(int id)
		{
			return ConfigMatchThreePieceById.GetConfig(id, true);
		}

		// Token: 0x06040B49 RID: 265033 RVA: 0x00FAA7DC File Offset: 0x00FA89DC
		public MatchThreeEliminate? GetEliminateConfig(int id)
		{
			return ConfigMatchThreeEliminateById.GetConfig(id, true);
		}

		// Token: 0x06040B4A RID: 265034 RVA: 0x00FAA7E5 File Offset: 0x00FA89E5
		public MatchThreeComponent? GetComponentConfig(int id)
		{
			return ConfigMatchThreeComponentById.GetConfig(id, true);
		}

		// Token: 0x06040B4B RID: 265035 RVA: 0x00FAA7EE File Offset: 0x00FA89EE
		public MatchThreeGameplay? GetGameplayConfig(int id)
		{
			return ConfigMatchThreeGameplayById.GetConfig(id, true);
		}

		// Token: 0x06040B4C RID: 265036 RVA: 0x00FAA7F7 File Offset: 0x00FA89F7
		public MatchThreeGoal? GetGoalConfig(int id)
		{
			return ConfigMatchThreeGoalById.GetConfig(id, true);
		}

		// Token: 0x06040B4D RID: 265037 RVA: 0x00FAA800 File Offset: 0x00FA8A00
		public MatchThreeEnviroment? GetEnviromentConfig(int id)
		{
			return ConfigMatchThreeEnviromentById.GetConfig(id, true);
		}

		// Token: 0x06040B4E RID: 265038 RVA: 0x00FAA809 File Offset: 0x00FA8A09
		public MatchThreeRole? GetRoleConfig(int id)
		{
			return ConfigMatchThreeRoleById.GetConfig(id, true);
		}

		// Token: 0x06040B4F RID: 265039 RVA: 0x00FAA812 File Offset: 0x00FA8A12
		public MatchThreeSkill? GetSkillConfig(int id)
		{
			return ConfigMatchThreeSkillById.GetConfig(id, true);
		}

		// Token: 0x06040B50 RID: 265040 RVA: 0x00FAA81B File Offset: 0x00FA8A1B
		[NullableContext(2)]
		public IReadOnlyList<MatchThreeBoard> GetBoardConfigList(int boardId)
		{
			return ConfigMatchThreeBoardByBoardId.GetConfigList(boardId, true);
		}

		// Token: 0x06040B51 RID: 265041 RVA: 0x00FAA824 File Offset: 0x00FA8A24
		protected override bool OnClear()
		{
			this.ScoreComments = null;
			return true;
		}

		// Token: 0x06040B52 RID: 265042 RVA: 0x00FAA830 File Offset: 0x00FA8A30
		public ScoreComment? GetCommentConfig(int score)
		{
			int num;
			return this.GetCommentConfig(score, out num);
		}

		// Token: 0x06040B53 RID: 265043 RVA: 0x00FAA848 File Offset: 0x00FA8A48
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

		// Token: 0x170094B7 RID: 38071
		// (get) Token: 0x06040B54 RID: 265044 RVA: 0x00FAA8AD File Offset: 0x00FA8AAD
		public int ScoreGradeCount
		{
			get
			{
				return this.EnsureScoreComments().Length;
			}
		}

		// Token: 0x06040B55 RID: 265045 RVA: 0x00FAA8B8 File Offset: 0x00FA8AB8
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

		// Token: 0x06040B56 RID: 265046 RVA: 0x00FAA959 File Offset: 0x00FA8B59
		public MatchThreeFillRules? GetFillRulesConfig(int id)
		{
			return ConfigMatchThreeFillRulesById.GetConfig(id, true);
		}

		// Token: 0x170094B8 RID: 38072
		// (get) Token: 0x06040B57 RID: 265047 RVA: 0x00FAA962 File Offset: 0x00FA8B62
		public static MatchThreeConfig Instance
		{
			get
			{
				return MatchThreeConfig._Instance;
			}
		}

		// Token: 0x06040B58 RID: 265048 RVA: 0x00FAA969 File Offset: 0x00FA8B69
		public static MatchThreeConfig GetOrCreateInstance()
		{
			if (MatchThreeConfig._Instance == null)
			{
				MatchThreeConfig.CreateInstance();
			}
			return MatchThreeConfig._Instance;
		}

		// Token: 0x06040B59 RID: 265049 RVA: 0x00FAA97D File Offset: 0x00FA8B7D
		public static bool CreateInstance()
		{
			if (MatchThreeConfig._Instance != null)
			{
				return true;
			}
			MatchThreeConfig._Instance = new MatchThreeConfig();
			return true;
		}

		// Token: 0x06040B5A RID: 265050 RVA: 0x00FAA993 File Offset: 0x00FA8B93
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040B5B RID: 265051 RVA: 0x00FAA995 File Offset: 0x00FA8B95
		public static void ResetStaticDefaultValue()
		{
			MatchThreeConfig._Instance = null;
		}

		// Token: 0x06040B5C RID: 265052 RVA: 0x00FAA99D File Offset: 0x00FA8B9D
		static MatchThreeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatchThreeConfig.CreateStaticDefaultValue), new Action(MatchThreeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021AC7 RID: 137927
		[Nullable(2)]
		private ScoreComment[] ScoreComments;

		// Token: 0x04021AC8 RID: 137928
		[Nullable(2)]
		private static MatchThreeConfig _Instance;
	}
}
