using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200568A RID: 22154
	public class DropCatchGameplayTimeMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06036AA7 RID: 223911 RVA: 0x00F4176E File Offset: 0x00F3F96E
		[NullableContext(1)]
		public DropCatchGameplayTimeMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036AA8 RID: 223912 RVA: 0x00F41778 File Offset: 0x00F3F978
		public override void Init()
		{
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			this.TotalTime = (float)(((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().GameplayTime : 0) * TimeUtil.Instance.InverseMillisecond);
			this.GameplayTime = 0f;
			this.UpdateTime(0f);
		}

		// Token: 0x06036AA9 RID: 223913 RVA: 0x00F417D9 File Offset: 0x00F3F9D9
		public override void OnTick(float deltaTime)
		{
			this.UpdateTime(deltaTime);
			this.CheckGameOver();
		}

		// Token: 0x06036AAA RID: 223914 RVA: 0x00F417E8 File Offset: 0x00F3F9E8
		private void CheckGameOver()
		{
			if (this.RemainingTime <= 0f)
			{
				this.Context.GetProxy().SettleGameplay(EDropCatchGameplaySettleReason.TimeUp);
				EventSystem.Instance.Emit<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, EArcadeGameplayType.DropCatch, this.Context.GetProxy().GetCurGameplayId());
			}
		}

		// Token: 0x06036AAB RID: 223915 RVA: 0x00F41834 File Offset: 0x00F3FA34
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

		// Token: 0x06036AAC RID: 223916 RVA: 0x00F41886 File Offset: 0x00F3FA86
		public float GetTime()
		{
			return this.GameplayTime;
		}

		// Token: 0x06036AAD RID: 223917 RVA: 0x00F4188E File Offset: 0x00F3FA8E
		public float GetRemainingTime()
		{
			return this.RemainingTime;
		}

		// Token: 0x06036AAE RID: 223918 RVA: 0x00F41896 File Offset: 0x00F3FA96
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

		// Token: 0x0401CE37 RID: 118327
		private float GameplayTime;

		// Token: 0x0401CE38 RID: 118328
		private float TotalTime;

		// Token: 0x0401CE39 RID: 118329
		private float RemainingTime;
	}
}
