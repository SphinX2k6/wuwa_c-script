using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB5 RID: 23989
	public class BaseScoreItem : BattleChildView
	{
		// Token: 0x0603CF08 RID: 249608 RVA: 0x00EA46D4 File Offset: 0x00EA28D4
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

		// Token: 0x0603CF09 RID: 249609 RVA: 0x00EA477C File Offset: 0x00EA297C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleScoreChanged, new Action<int, int>(this.BattleScoreChanged));
			EventSystem.Instance.Remove(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.BattleScoreEnableChanged));
		}

		// Token: 0x0603CF0A RID: 249610 RVA: 0x00EA47B6 File Offset: 0x00EA29B6
		public virtual void OnShowFirstTime()
		{
			if (this.IsScoreEnable)
			{
				this.ShowScore();
			}
		}

		// Token: 0x0603CF0B RID: 249611 RVA: 0x00EA47C6 File Offset: 0x00EA29C6
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x0603CF0C RID: 249612 RVA: 0x00EA47C8 File Offset: 0x00EA29C8
		public virtual bool IsValidScore(int scoreId)
		{
			return false;
		}

		// Token: 0x0603CF0D RID: 249613 RVA: 0x00EA47CB File Offset: 0x00EA29CB
		private void BattleScoreChanged(int scoreId, int score)
		{
			if (!this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreChanged(scoreId, score);
		}

		// Token: 0x0603CF0E RID: 249614 RVA: 0x00EA47DF File Offset: 0x00EA29DF
		private void BattleScoreEnableChanged(int scoreId, bool enable)
		{
			if (!this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreEnableChanged(scoreId, enable);
		}

		// Token: 0x0603CF0F RID: 249615 RVA: 0x00EA47F3 File Offset: 0x00EA29F3
		protected virtual void OnBattleScoreChanged(int scoreId, int score)
		{
		}

		// Token: 0x0603CF10 RID: 249616 RVA: 0x00EA47F5 File Offset: 0x00EA29F5
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

		// Token: 0x0603CF11 RID: 249617 RVA: 0x00EA4818 File Offset: 0x00EA2A18
		public virtual void ShowScore()
		{
			this.IsScoreEnable = true;
		}

		// Token: 0x0603CF12 RID: 249618 RVA: 0x00EA4821 File Offset: 0x00EA2A21
		public virtual void HideScore()
		{
			this.IsScoreEnable = false;
		}

		// Token: 0x0401FBCD RID: 129997
		public bool IsScoreEnable;
	}
}
