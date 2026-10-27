using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C5A RID: 23642
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BattleScoreModel : ModelBase
	{
		// Token: 0x0603BC2F RID: 244783 RVA: 0x00E46181 File Offset: 0x00E44381
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603BC30 RID: 244784 RVA: 0x00E46184 File Offset: 0x00E44384
		protected override bool OnLeaveLevel()
		{
			this.ScoreMap.Clear();
			this.ScoreEnableMap.Clear();
			this.CurScoreId = 0;
			this.RougeScoreMusicState.State = "none";
			return true;
		}

		// Token: 0x0603BC31 RID: 244785 RVA: 0x00E461B4 File Offset: 0x00E443B4
		public void HandleBattleScoreNotify(BattleScoreNotify notify)
		{
			this.UpdateScore(notify.BattleScoreConfId, notify.ScoreTotal);
		}

		// Token: 0x0603BC32 RID: 244786 RVA: 0x00E461C8 File Offset: 0x00E443C8
		public void HandleBattleScoreEnableNotify(BattleScoreEnableNotify notify)
		{
			this.UpdateScoreEnable(notify.BattleScoreConfId, notify.Enable);
		}

		// Token: 0x0603BC33 RID: 244787 RVA: 0x00E461DC File Offset: 0x00E443DC
		public void CacheScoreConfig(int scoreId)
		{
			if (!this.ScoreConfigMap.ContainsKey(scoreId))
			{
				BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(scoreId);
				if (battleScoreConfig != null)
				{
					this.ScoreConfigMap[scoreId] = battleScoreConfig.Value;
				}
			}
		}

		// Token: 0x0603BC34 RID: 244788 RVA: 0x00E4621F File Offset: 0x00E4441F
		public void UpdateScore(int scoreId, int score)
		{
			this.ScoreMap[scoreId] = score;
			if (this.CurScoreId != scoreId)
			{
				this.CurScoreId = scoreId;
				this.CacheScoreConfig(scoreId);
			}
			EventSystem.Instance.Emit<int, int>(EEventName.BattleScoreChanged, scoreId, score);
		}

		// Token: 0x0603BC35 RID: 244789 RVA: 0x00E46257 File Offset: 0x00E44457
		public void UpdateScoreEnable(int scoreId, bool enable)
		{
			this.ScoreEnableMap[scoreId] = enable;
			if (!enable)
			{
				this.ScoreMap[scoreId] = 0;
			}
			this.CacheScoreConfig(scoreId);
			EventSystem.Instance.Emit<int, bool>(EEventName.BattleScoreEnableChanged, scoreId, enable);
		}

		// Token: 0x0603BC36 RID: 244790 RVA: 0x00E46290 File Offset: 0x00E44490
		public BattleScoreConf? GetScoreConfig(int scoreId, bool cache = false)
		{
			BattleScoreConf? valueOrNull = this.ScoreConfigMap.GetValueOrNull(scoreId);
			if (valueOrNull == null && cache)
			{
				this.CacheScoreConfig(scoreId);
				valueOrNull = this.ScoreConfigMap.GetValueOrNull(scoreId);
			}
			return valueOrNull;
		}

		// Token: 0x0603BC37 RID: 244791 RVA: 0x00E462CD File Offset: 0x00E444CD
		public int GetScore(int scoreId)
		{
			return this.ScoreMap.GetValueOrDefault(scoreId, 0);
		}

		// Token: 0x0603BC38 RID: 244792 RVA: 0x00E462DC File Offset: 0x00E444DC
		public IReadOnlyDictionary<int, int> GetScoreMap()
		{
			return this.ScoreMap;
		}

		// Token: 0x0603BC39 RID: 244793 RVA: 0x00E462E4 File Offset: 0x00E444E4
		public IReadOnlyDictionary<int, bool> GetScoreEnableMap()
		{
			return this.ScoreEnableMap;
		}

		// Token: 0x0603BC3A RID: 244794 RVA: 0x00E462EC File Offset: 0x00E444EC
		public int GetCurScoreId()
		{
			return this.CurScoreId;
		}

		// Token: 0x0603BC3B RID: 244795 RVA: 0x00E462F4 File Offset: 0x00E444F4
		public int GetCurScore()
		{
			return this.GetScore(this.CurScoreId);
		}

		// Token: 0x17008DBE RID: 36286
		// (get) Token: 0x0603BC3C RID: 244796 RVA: 0x00E46302 File Offset: 0x00E44502
		public static BattleScoreModel Instance
		{
			get
			{
				return BattleScoreModel._Instance;
			}
		}

		// Token: 0x0603BC3D RID: 244797 RVA: 0x00E46309 File Offset: 0x00E44509
		public static BattleScoreModel GetOrCreateInstance()
		{
			if (BattleScoreModel._Instance == null)
			{
				BattleScoreModel.CreateInstance();
			}
			return BattleScoreModel._Instance;
		}

		// Token: 0x0603BC3E RID: 244798 RVA: 0x00E4631D File Offset: 0x00E4451D
		public static bool CreateInstance()
		{
			if (BattleScoreModel._Instance != null)
			{
				return true;
			}
			BattleScoreModel._Instance = new BattleScoreModel();
			return true;
		}

		// Token: 0x0603BC3F RID: 244799 RVA: 0x00E46333 File Offset: 0x00E44533
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BC40 RID: 244800 RVA: 0x00E46335 File Offset: 0x00E44535
		public static void ResetStaticDefaultValue()
		{
			BattleScoreModel._Instance = null;
		}

		// Token: 0x0603BC41 RID: 244801 RVA: 0x00E4633D File Offset: 0x00E4453D
		static BattleScoreModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreModel.CreateStaticDefaultValue), new Action(BattleScoreModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F1E6 RID: 127462
		private readonly Dictionary<int, int> ScoreMap = new Dictionary<int, int>();

		// Token: 0x0401F1E7 RID: 127463
		private readonly Dictionary<int, bool> ScoreEnableMap = new Dictionary<int, bool>();

		// Token: 0x0401F1E8 RID: 127464
		private readonly Dictionary<int, BattleScoreConf> ScoreConfigMap = new Dictionary<int, BattleScoreConf>();

		// Token: 0x0401F1E9 RID: 127465
		private int CurScoreId;

		// Token: 0x0401F1EA RID: 127466
		public StateRef RougeScoreMusicState = new StateRef("game_rogue_combat_combo_rank", "none");

		// Token: 0x0401F1EB RID: 127467
		[Nullable(2)]
		private static BattleScoreModel _Instance;
	}
}
