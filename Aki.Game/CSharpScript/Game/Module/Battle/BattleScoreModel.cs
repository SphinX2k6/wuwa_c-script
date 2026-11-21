using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C3A RID: 19514
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BattleScoreModel : ModelBase
	{
		// Token: 0x06030B7A RID: 199546 RVA: 0x00D96561 File Offset: 0x00D94761
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06030B7B RID: 199547 RVA: 0x00D96564 File Offset: 0x00D94764
		protected override bool OnLeaveLevel()
		{
			this.ScoreMap.Clear();
			this.ScoreEnableMap.Clear();
			this.CurScoreId = 0;
			this.RougeScoreMusicState.State = "none";
			return true;
		}

		// Token: 0x06030B7C RID: 199548 RVA: 0x00D96594 File Offset: 0x00D94794
		public void HandleBattleScoreNotify(BattleScoreNotify notify)
		{
			this.UpdateScore(notify.BattleScoreConfId, notify.ScoreTotal);
		}

		// Token: 0x06030B7D RID: 199549 RVA: 0x00D965A8 File Offset: 0x00D947A8
		public void HandleBattleScoreEnableNotify(BattleScoreEnableNotify notify)
		{
			this.UpdateScoreEnable(notify.BattleScoreConfId, notify.Enable);
		}

		// Token: 0x06030B7E RID: 199550 RVA: 0x00D965BC File Offset: 0x00D947BC
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

		// Token: 0x06030B7F RID: 199551 RVA: 0x00D965FF File Offset: 0x00D947FF
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

		// Token: 0x06030B80 RID: 199552 RVA: 0x00D96637 File Offset: 0x00D94837
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

		// Token: 0x06030B81 RID: 199553 RVA: 0x00D96670 File Offset: 0x00D94870
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

		// Token: 0x06030B82 RID: 199554 RVA: 0x00D966AD File Offset: 0x00D948AD
		public int GetScore(int scoreId)
		{
			return this.ScoreMap.GetValueOrDefault(scoreId, 0);
		}

		// Token: 0x06030B83 RID: 199555 RVA: 0x00D966BC File Offset: 0x00D948BC
		public IReadOnlyDictionary<int, int> GetScoreMap()
		{
			return this.ScoreMap;
		}

		// Token: 0x06030B84 RID: 199556 RVA: 0x00D966C4 File Offset: 0x00D948C4
		public IReadOnlyDictionary<int, bool> GetScoreEnableMap()
		{
			return this.ScoreEnableMap;
		}

		// Token: 0x06030B85 RID: 199557 RVA: 0x00D966CC File Offset: 0x00D948CC
		public int GetCurScoreId()
		{
			return this.CurScoreId;
		}

		// Token: 0x06030B86 RID: 199558 RVA: 0x00D966D4 File Offset: 0x00D948D4
		public int GetCurScore()
		{
			return this.GetScore(this.CurScoreId);
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x06030B87 RID: 199559 RVA: 0x00D966E2 File Offset: 0x00D948E2
		public static BattleScoreModel Instance
		{
			get
			{
				return BattleScoreModel._Instance;
			}
		}

		// Token: 0x06030B88 RID: 199560 RVA: 0x00D966E9 File Offset: 0x00D948E9
		public static BattleScoreModel GetOrCreateInstance()
		{
			if (BattleScoreModel._Instance == null)
			{
				BattleScoreModel.CreateInstance();
			}
			return BattleScoreModel._Instance;
		}

		// Token: 0x06030B89 RID: 199561 RVA: 0x00D966FD File Offset: 0x00D948FD
		public static bool CreateInstance()
		{
			if (BattleScoreModel._Instance != null)
			{
				return true;
			}
			BattleScoreModel._Instance = new BattleScoreModel();
			return true;
		}

		// Token: 0x06030B8A RID: 199562 RVA: 0x00D96713 File Offset: 0x00D94913
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030B8B RID: 199563 RVA: 0x00D96715 File Offset: 0x00D94915
		public static void ResetStaticDefaultValue()
		{
			BattleScoreModel._Instance = null;
		}

		// Token: 0x06030B8C RID: 199564 RVA: 0x00D9671D File Offset: 0x00D9491D
		static BattleScoreModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleScoreModel.CreateStaticDefaultValue), new Action(BattleScoreModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019C97 RID: 105623
		private readonly Dictionary<int, int> ScoreMap = new Dictionary<int, int>();

		// Token: 0x04019C98 RID: 105624
		private readonly Dictionary<int, bool> ScoreEnableMap = new Dictionary<int, bool>();

		// Token: 0x04019C99 RID: 105625
		private readonly Dictionary<int, BattleScoreConf> ScoreConfigMap = new Dictionary<int, BattleScoreConf>();

		// Token: 0x04019C9A RID: 105626
		private int CurScoreId;

		// Token: 0x04019C9B RID: 105627
		public StateRef RougeScoreMusicState = new StateRef("game_rogue_combat_combo_rank", "none");

		// Token: 0x04019C9C RID: 105628
		[Nullable(2)]
		private static BattleScoreModel _Instance;
	}
}
