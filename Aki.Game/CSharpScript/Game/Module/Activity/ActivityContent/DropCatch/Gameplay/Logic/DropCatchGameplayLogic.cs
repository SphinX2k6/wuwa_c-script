using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006736 RID: 26422
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayLogic : IGameplayLogicContext
	{
		// Token: 0x06041F05 RID: 270085 RVA: 0x00FFED6C File Offset: 0x00FFCF6C
		public void Init(DropCatchGameplayProxy proxy)
		{
			this.Proxy = proxy;
			this.End();
			DropCatchGameplay? gameplayConfig = this.Proxy.GetGameplayConfig();
			this.GameplayArea = new IDropCatchGameplayArea
			{
				MinX = (double)((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().Area(0) : 0f),
				MinY = (double)((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().Area(1) : 0f),
				MaxX = (double)((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().Area(2) : 0f),
				MaxY = (double)((gameplayConfig != null) ? gameplayConfig.GetValueOrDefault().Area(3) : 0f)
			};
			this.InitManagers();
			this.InitAttributes();
		}

		// Token: 0x06041F06 RID: 270086 RVA: 0x00FFEE48 File Offset: 0x00FFD048
		private void InitManagers()
		{
			if (this.GameplayModifierMgr == null)
			{
				this.GameplayModifierMgr = new DropCatchGameplayModifierMgr(this);
			}
			this.GameplayModifierMgr.Init();
			if (this.GameplayCommandMgr == null)
			{
				this.GameplayCommandMgr = new DropCatchGameplayCommandMgr(this);
			}
			this.GameplayCommandMgr.Init();
			if (this.GameplayTimeMgr == null)
			{
				this.GameplayTimeMgr = new DropCatchGameplayTimeMgr(this);
			}
			this.GameplayTimeMgr.Init();
			if (this.GameplayInputMgr == null)
			{
				this.GameplayInputMgr = new DropCatchGameplayInputMgr(this);
			}
			this.GameplayInputMgr.Init();
			if (this.GameplayRoleMgr == null)
			{
				this.GameplayRoleMgr = new DropCatchGameplayRoleMgr(this);
			}
			this.GameplayRoleMgr.Init();
			if (this.GameplayDropItemMgr == null)
			{
				this.GameplayDropItemMgr = new DropCatchGameplayDropItemMgr(this);
			}
			this.GameplayDropItemMgr.Init();
			if (this.GameplayCollisionMgr == null)
			{
				this.GameplayCollisionMgr = new DropCatchGameplayCollisionMgr(this);
			}
			this.GameplayCollisionMgr.Init();
		}

		// Token: 0x06041F07 RID: 270087 RVA: 0x00FFEF2E File Offset: 0x00FFD12E
		private void InitAttributes()
		{
			this.AddScoreRate = new DropCatchGameplayAttribute("AddScoreRate", 1f);
			this.EnergyGetRate = new DropCatchGameplayAttribute("EnergyGetRate", 1f);
		}

		// Token: 0x06041F08 RID: 270088 RVA: 0x00FFEF5A File Offset: 0x00FFD15A
		public DropCatchGameplayProxy GetProxy()
		{
			return this.Proxy;
		}

		// Token: 0x06041F09 RID: 270089 RVA: 0x00FFEF62 File Offset: 0x00FFD162
		public DropCatchGameplayTimeMgr GetGameplayTimeMgr()
		{
			return this.GameplayTimeMgr;
		}

		// Token: 0x06041F0A RID: 270090 RVA: 0x00FFEF6A File Offset: 0x00FFD16A
		public DropCatchGameplayRoleMgr GetGameplayRoleMgr()
		{
			return this.GameplayRoleMgr;
		}

		// Token: 0x06041F0B RID: 270091 RVA: 0x00FFEF72 File Offset: 0x00FFD172
		public DropCatchGameplayDropItemMgr GetGameplayDropItemMgr()
		{
			return this.GameplayDropItemMgr;
		}

		// Token: 0x06041F0C RID: 270092 RVA: 0x00FFEF7A File Offset: 0x00FFD17A
		public DropCatchGameplayCollisionMgr GetGameplayCollisionMgr()
		{
			return this.GameplayCollisionMgr;
		}

		// Token: 0x06041F0D RID: 270093 RVA: 0x00FFEF82 File Offset: 0x00FFD182
		public DropCatchGameplayCommandMgr GetGameplayCommandMgr()
		{
			return this.GameplayCommandMgr;
		}

		// Token: 0x06041F0E RID: 270094 RVA: 0x00FFEF8A File Offset: 0x00FFD18A
		public DropCatchGameplayModifierMgr GetGameplayModifierMgr()
		{
			return this.GameplayModifierMgr;
		}

		// Token: 0x06041F0F RID: 270095 RVA: 0x00FFEF92 File Offset: 0x00FFD192
		public DropCatchGameplayInputMgr GetGameplayInputMgr()
		{
			return this.GameplayInputMgr;
		}

		// Token: 0x06041F10 RID: 270096 RVA: 0x00FFEF9A File Offset: 0x00FFD19A
		public IDropCatchGameplayArea GetGameplayArea()
		{
			return this.GameplayArea;
		}

		// Token: 0x06041F11 RID: 270097 RVA: 0x00FFEFA2 File Offset: 0x00FFD1A2
		public void Pause()
		{
			if (this.GameplayState == EDropCatchGameplayState.Pause)
			{
				return;
			}
			if (this.TickId != null)
			{
				TickSystem.Instance.Pause(this.TickId.Id);
			}
			this.StateBeforePause = this.GameplayState;
			this.GameplayState = EDropCatchGameplayState.Pause;
		}

		// Token: 0x06041F12 RID: 270098 RVA: 0x00FFEFDF File Offset: 0x00FFD1DF
		public void Resume()
		{
			if (this.GameplayState != EDropCatchGameplayState.Pause)
			{
				return;
			}
			if (this.TickId != null)
			{
				TickSystem.Instance.Resume(this.TickId.Id);
			}
			this.GameplayState = this.StateBeforePause;
		}

		// Token: 0x06041F13 RID: 270099 RVA: 0x00FFF015 File Offset: 0x00FFD215
		public void Ready()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "DropCatchGameplayLogic", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.GameplayState = EDropCatchGameplayState.Ready;
		}

		// Token: 0x06041F14 RID: 270100 RVA: 0x00FFF044 File Offset: 0x00FFD244
		public void Play()
		{
			this.GameplayState = EDropCatchGameplayState.Play;
			DropCatchGameplayView gameplayView = this.Proxy.GetGameplayView();
			if (gameplayView != null)
			{
				UiAudioModel.Instance.SetLoopAudioEventShow(gameplayView.GetViewId(), gameplayView.GetRootActor(), "play_ui_music_coincatch");
			}
		}

		// Token: 0x06041F15 RID: 270101 RVA: 0x00FFF084 File Offset: 0x00FFD284
		public void End()
		{
			if (this.TickId != null)
			{
				TickSystem.Instance.Remove(this.TickId.Id);
				this.TickId = null;
			}
			this.GameplayState = EDropCatchGameplayState.End;
			DropCatchGameplayView gameplayView = this.Proxy.GetGameplayView();
			if (gameplayView != null)
			{
				UiAudioModel.Instance.SetLoopAudioEventDestroy(gameplayView.GetViewId(), gameplayView.GetRootActor(), "play_ui_music_coincatch");
			}
		}

		// Token: 0x06041F16 RID: 270102 RVA: 0x00FFF0E7 File Offset: 0x00FFD2E7
		private void OnTick(float deltaTime)
		{
			if (this.GameplayState == EDropCatchGameplayState.Ready)
			{
				this.OnReadyTick(deltaTime);
				return;
			}
			if (this.GameplayState == EDropCatchGameplayState.Play)
			{
				this.OnPlayTick(deltaTime);
			}
		}

		// Token: 0x06041F17 RID: 270103 RVA: 0x00FFF109 File Offset: 0x00FFD309
		private void OnReadyTick(float deltaTime)
		{
			DropCatchGameplayInputMgr gameplayInputMgr = this.GameplayInputMgr;
			if (gameplayInputMgr != null)
			{
				gameplayInputMgr.OnReadyTick(deltaTime);
			}
			DropCatchGameplayRoleMgr gameplayRoleMgr = this.GameplayRoleMgr;
			if (gameplayRoleMgr == null)
			{
				return;
			}
			gameplayRoleMgr.OnReadyTick(deltaTime);
		}

		// Token: 0x06041F18 RID: 270104 RVA: 0x00FFF130 File Offset: 0x00FFD330
		private void OnPlayTick(float deltaTime)
		{
			DropCatchGameplayTimeMgr gameplayTimeMgr = this.GameplayTimeMgr;
			if (gameplayTimeMgr != null)
			{
				gameplayTimeMgr.OnTick(deltaTime);
			}
			DropCatchGameplayModifierMgr gameplayModifierMgr = this.GameplayModifierMgr;
			if (gameplayModifierMgr != null)
			{
				gameplayModifierMgr.OnTick(deltaTime);
			}
			DropCatchGameplayDropItemMgr gameplayDropItemMgr = this.GameplayDropItemMgr;
			if (gameplayDropItemMgr != null)
			{
				gameplayDropItemMgr.OnTick(deltaTime);
			}
			DropCatchGameplayInputMgr gameplayInputMgr = this.GameplayInputMgr;
			if (gameplayInputMgr != null)
			{
				gameplayInputMgr.OnTick(deltaTime);
			}
			DropCatchGameplayRoleMgr gameplayRoleMgr = this.GameplayRoleMgr;
			if (gameplayRoleMgr != null)
			{
				gameplayRoleMgr.OnTick(deltaTime);
			}
			DropCatchGameplayCommandMgr gameplayCommandMgr = this.GameplayCommandMgr;
			if (gameplayCommandMgr != null)
			{
				gameplayCommandMgr.OnTick(deltaTime);
			}
			DropCatchGameplayCollisionMgr gameplayCollisionMgr = this.GameplayCollisionMgr;
			if (gameplayCollisionMgr == null)
			{
				return;
			}
			gameplayCollisionMgr.OnTick(deltaTime);
		}

		// Token: 0x06041F19 RID: 270105 RVA: 0x00FFF1BC File Offset: 0x00FFD3BC
		public void UseRoleSkill()
		{
			DropCatchGameplayRoleMgr gameplayRoleMgr = this.GameplayRoleMgr;
			bool flag;
			if (gameplayRoleMgr == null)
			{
				flag = true;
			}
			else
			{
				IRoleInstance role = gameplayRoleMgr.GetRole();
				flag = (((role != null) ? new EDropCatchRoleSkillState?(role.GetSkillState()) : null).GetValueOrDefault() != EDropCatchRoleSkillState.Enable);
			}
			if (flag)
			{
				return;
			}
			DropCatchGameplayRoleMgr gameplayRoleMgr2 = this.GameplayRoleMgr;
			if (gameplayRoleMgr2 != null)
			{
				IRoleInstance role2 = gameplayRoleMgr2.GetRole();
				if (role2 != null)
				{
					role2.UseSkill();
				}
			}
			DropCatchGameplayCommandMgr gameplayCommandMgr = this.GameplayCommandMgr;
			if (gameplayCommandMgr == null)
			{
				return;
			}
			gameplayCommandMgr.ExecuteSkillCommand();
		}

		// Token: 0x06041F1A RID: 270106 RVA: 0x00FFF231 File Offset: 0x00FFD431
		public float GetEnergyGetRate()
		{
			return this.EnergyGetRate.GetFinalValue();
		}

		// Token: 0x06041F1B RID: 270107 RVA: 0x00FFF23E File Offset: 0x00FFD43E
		public float GetAddScoreRate()
		{
			return this.AddScoreRate.GetFinalValue();
		}

		// Token: 0x06041F1C RID: 270108 RVA: 0x00FFF24B File Offset: 0x00FFD44B
		[NullableContext(2)]
		public IRoleInstance GetRole()
		{
			DropCatchGameplayRoleMgr gameplayRoleMgr = this.GameplayRoleMgr;
			if (gameplayRoleMgr == null)
			{
				return null;
			}
			return gameplayRoleMgr.GetRole();
		}

		// Token: 0x06041F1D RID: 270109 RVA: 0x00FFF25E File Offset: 0x00FFD45E
		public float GetRemainingTime()
		{
			DropCatchGameplayTimeMgr gameplayTimeMgr = this.GameplayTimeMgr;
			if (gameplayTimeMgr == null)
			{
				return 0f;
			}
			return gameplayTimeMgr.GetRemainingTime();
		}

		// Token: 0x06041F1E RID: 270110 RVA: 0x00FFF275 File Offset: 0x00FFD475
		public DropCatchGameplayAttribute GetAddScoreRateAttr()
		{
			return this.AddScoreRate;
		}

		// Token: 0x06041F1F RID: 270111 RVA: 0x00FFF27D File Offset: 0x00FFD47D
		public DropCatchGameplayAttribute GetEnergyGetRateAttr()
		{
			return this.EnergyGetRate;
		}

		// Token: 0x06041F20 RID: 270112 RVA: 0x00FFF285 File Offset: 0x00FFD485
		public EDropCatchGameplayState GetGameplayState()
		{
			return this.GameplayState;
		}

		// Token: 0x06041F21 RID: 270113 RVA: 0x00FFF290 File Offset: 0x00FFD490
		public void Destroy()
		{
			this.End();
			DropCatchGameplayTimeMgr gameplayTimeMgr = this.GameplayTimeMgr;
			if (gameplayTimeMgr != null)
			{
				gameplayTimeMgr.Destroy();
			}
			DropCatchGameplayRoleMgr gameplayRoleMgr = this.GameplayRoleMgr;
			if (gameplayRoleMgr != null)
			{
				gameplayRoleMgr.Destroy();
			}
			DropCatchGameplayDropItemMgr gameplayDropItemMgr = this.GameplayDropItemMgr;
			if (gameplayDropItemMgr != null)
			{
				gameplayDropItemMgr.Destroy();
			}
			DropCatchGameplayCollisionMgr gameplayCollisionMgr = this.GameplayCollisionMgr;
			if (gameplayCollisionMgr != null)
			{
				gameplayCollisionMgr.Destroy();
			}
			DropCatchGameplayCommandMgr gameplayCommandMgr = this.GameplayCommandMgr;
			if (gameplayCommandMgr != null)
			{
				gameplayCommandMgr.Destroy();
			}
			DropCatchGameplayInputMgr gameplayInputMgr = this.GameplayInputMgr;
			if (gameplayInputMgr != null)
			{
				gameplayInputMgr.Destroy();
			}
			DropCatchGameplayModifierMgr gameplayModifierMgr = this.GameplayModifierMgr;
			if (gameplayModifierMgr == null)
			{
				return;
			}
			gameplayModifierMgr.Destroy();
		}

		// Token: 0x040225AF RID: 140719
		[Nullable(2)]
		private Ticker TickId;

		// Token: 0x040225B0 RID: 140720
		public DropCatchGameplayProxy Proxy;

		// Token: 0x040225B1 RID: 140721
		[Nullable(2)]
		private DropCatchGameplayTimeMgr GameplayTimeMgr;

		// Token: 0x040225B2 RID: 140722
		[Nullable(2)]
		private DropCatchGameplayRoleMgr GameplayRoleMgr;

		// Token: 0x040225B3 RID: 140723
		[Nullable(2)]
		private DropCatchGameplayDropItemMgr GameplayDropItemMgr;

		// Token: 0x040225B4 RID: 140724
		[Nullable(2)]
		private DropCatchGameplayCollisionMgr GameplayCollisionMgr;

		// Token: 0x040225B5 RID: 140725
		[Nullable(2)]
		private DropCatchGameplayCommandMgr GameplayCommandMgr;

		// Token: 0x040225B6 RID: 140726
		[Nullable(2)]
		private DropCatchGameplayModifierMgr GameplayModifierMgr;

		// Token: 0x040225B7 RID: 140727
		private IDropCatchGameplayArea GameplayArea;

		// Token: 0x040225B8 RID: 140728
		private DropCatchGameplayAttribute AddScoreRate;

		// Token: 0x040225B9 RID: 140729
		private DropCatchGameplayAttribute EnergyGetRate;

		// Token: 0x040225BA RID: 140730
		private EDropCatchGameplayState GameplayState = EDropCatchGameplayState.End;

		// Token: 0x040225BB RID: 140731
		private EDropCatchGameplayState StateBeforePause = EDropCatchGameplayState.End;

		// Token: 0x040225BC RID: 140732
		[Nullable(2)]
		private DropCatchGameplayInputMgr GameplayInputMgr;
	}
}
