using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200673A RID: 26426
	public class DropCatchGameplayTimeMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041F5B RID: 270171 RVA: 0x010003BE File Offset: 0x00FFE5BE
		[NullableContext(1)]
		public DropCatchGameplayTimeMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041F5C RID: 270172 RVA: 0x010003C8 File Offset: 0x00FFE5C8
		public override void Init()
		{
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			this.TotalTime = (float)(((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().GameplayTime : 0) * TimeUtil.Instance.InverseMillisecond);
			this.GameplayTime = 0f;
			this.UpdateTime(0f);
		}

		// Token: 0x06041F5D RID: 270173 RVA: 0x01000429 File Offset: 0x00FFE629
		public override void OnTick(float deltaTime)
		{
			this.UpdateTime(deltaTime);
			this.CheckGameOver();
		}

		// Token: 0x06041F5E RID: 270174 RVA: 0x01000438 File Offset: 0x00FFE638
		private void CheckGameOver()
		{
			if (this.RemainingTime <= 0f)
			{
				this.Context.GetProxy().SettleGameplay(EDropCatchGameplaySettleReason.TimeUp);
				EventSystem.Instance.Emit<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, EArcadeGameplayType.DropCatch, this.Context.GetProxy().GetCurGameplayId());
			}
		}

		// Token: 0x06041F5F RID: 270175 RVA: 0x01000484 File Offset: 0x00FFE684
		public void UpdateTime(float deltaTime)
		{
			this.GameplayTime += deltaTime;
			this.RemainingTime = Math.Max(0f, this.TotalTime - this.GameplayTime);
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			gameplayView.UpdateRemainTime();
		}

		// Token: 0x06041F60 RID: 270176 RVA: 0x010004D6 File Offset: 0x00FFE6D6
		public float GetTime()
		{
			return this.GameplayTime;
		}

		// Token: 0x06041F61 RID: 270177 RVA: 0x010004DE File Offset: 0x00FFE6DE
		public float GetRemainingTime()
		{
			return this.RemainingTime;
		}

		// Token: 0x06041F62 RID: 270178 RVA: 0x010004E6 File Offset: 0x00FFE6E6
		public void AddTime(float time)
		{
			this.TotalTime += time * (float)TimeUtil.Instance.InverseMillisecond;
			DropCatchGameplayViewModel gameplayViewModel = this.Context.GetProxy().GetGameplayViewModel();
			if (gameplayViewModel == null)
			{
				return;
			}
			gameplayViewModel.AddAddTime(time);
		}

		// Token: 0x040225DE RID: 140766
		private float GameplayTime;

		// Token: 0x040225DF RID: 140767
		private float TotalTime;

		// Token: 0x040225E0 RID: 140768
		private float RemainingTime;
	}
}
