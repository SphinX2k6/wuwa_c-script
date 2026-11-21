using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D99 RID: 19865
	public class BaseScoreItem : BattleChildView
	{
		// Token: 0x06031E7F RID: 204415 RVA: 0x00DF55B0 File Offset: 0x00DF37B0
		protected override void OnStart()
		{
			foreach (KeyValuePair<int, bool> keyValuePair in BattleScoreModel.Instance.GetScoreEnableMap())
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int scoreId = num;
				if (flag && this.IsValidScore(scoreId))
				{
					this.IsScoreEnable = true;
					break;
				}
			}
			EventSystem.Instance.Add<int, int>(EEventName.BattleScoreChanged, new Action<int, int>(this.BattleScoreChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.BattleScoreEnableChanged));
		}

		// Token: 0x06031E80 RID: 204416 RVA: 0x00DF5658 File Offset: 0x00DF3858
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleScoreChanged, new Action<int, int>(this.BattleScoreChanged));
			EventSystem.Instance.Remove(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.BattleScoreEnableChanged));
		}

		// Token: 0x06031E81 RID: 204417 RVA: 0x00DF5692 File Offset: 0x00DF3892
		public virtual void OnShowFirstTime()
		{
			if (this.IsScoreEnable)
			{
				this.ShowScore();
			}
		}

		// Token: 0x06031E82 RID: 204418 RVA: 0x00DF56A2 File Offset: 0x00DF38A2
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x06031E83 RID: 204419 RVA: 0x00DF56A4 File Offset: 0x00DF38A4
		public virtual bool IsValidScore(int scoreId)
		{
			return false;
		}

		// Token: 0x06031E84 RID: 204420 RVA: 0x00DF56A7 File Offset: 0x00DF38A7
		private void BattleScoreChanged(int scoreId, int score)
		{
			if (!this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreChanged(scoreId, score);
		}

		// Token: 0x06031E85 RID: 204421 RVA: 0x00DF56BB File Offset: 0x00DF38BB
		private void BattleScoreEnableChanged(int scoreId, bool enable)
		{
			if (!this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreEnableChanged(scoreId, enable);
		}

		// Token: 0x06031E86 RID: 204422 RVA: 0x00DF56CF File Offset: 0x00DF38CF
		protected virtual void OnBattleScoreChanged(int scoreId, int score)
		{
		}

		// Token: 0x06031E87 RID: 204423 RVA: 0x00DF56D1 File Offset: 0x00DF38D1
		protected virtual void OnBattleScoreEnableChanged(int scoreId, bool enable)
		{
			if (this.IsScoreEnable == enable)
			{
				return;
			}
			this.IsScoreEnable = enable;
			if (enable)
			{
				this.ShowScore();
				return;
			}
			this.HideScore();
		}

		// Token: 0x06031E88 RID: 204424 RVA: 0x00DF56F4 File Offset: 0x00DF38F4
		public virtual void ShowScore()
		{
			this.IsScoreEnable = true;
		}

		// Token: 0x06031E89 RID: 204425 RVA: 0x00DF56FD File Offset: 0x00DF38FD
		public virtual void HideScore()
		{
			this.IsScoreEnable = false;
		}

		// Token: 0x0401A68A RID: 108170
		public bool IsScoreEnable;
	}
}
