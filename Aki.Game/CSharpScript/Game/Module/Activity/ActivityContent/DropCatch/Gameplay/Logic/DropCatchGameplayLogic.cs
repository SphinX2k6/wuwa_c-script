using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005686 RID: 22150
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayLogic : IGameplayLogicContext
	{
		// Token: 0x06036A51 RID: 223825 RVA: 0x00F40138 File Offset: 0x00F3E338
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

		// Token: 0x06036A52 RID: 223826 RVA: 0x00F40214 File Offset: 0x00F3E414
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

		// Token: 0x06036A53 RID: 223827 RVA: 0x00F402FA File Offset: 0x00F3E4FA
		private void InitAttributes()
		{
			this.AddScoreRate = new DropCatchGameplayAttribute("AddScoreRate", 1f);
			this.EnergyGetRate = new DropCatchGameplayAttribute("EnergyGetRate", 1f);
		}

		// Token: 0x06036A54 RID: 223828 RVA: 0x00F40326 File Offset: 0x00F3E526
		public DropCatchGameplayProxy GetProxy()
		{
			return this.Proxy;
		}

		// Token: 0x06036A55 RID: 223829 RVA: 0x00F4032E File Offset: 0x00F3E52E
		public DropCatchGameplayTimeMgr GetGameplayTimeMgr()
		{
			return this.GameplayTimeMgr;
		}

		// Token: 0x06036A56 RID: 223830 RVA: 0x00F40336 File Offset: 0x00F3E536
		public DropCatchGameplayRoleMgr GetGameplayRoleMgr()
		{
			return this.GameplayRoleMgr;
		}

		// Token: 0x06036A57 RID: 223831 RVA: 0x00F4033E File Offset: 0x00F3E53E
		public DropCatchGameplayDropItemMgr GetGameplayDropItemMgr()
		{
			return this.GameplayDropItemMgr;
		}

		// Token: 0x06036A58 RID: 223832 RVA: 0x00F40346 File Offset: 0x00F3E546
		public DropCatchGameplayCollisionMgr GetGameplayCollisionMgr()
		{
			return this.GameplayCollisionMgr;
		}

		// Token: 0x06036A59 RID: 223833 RVA: 0x00F4034E File Offset: 0x00F3E54E
		public DropCatchGameplayCommandMgr GetGameplayCommandMgr()
		{
			return this.GameplayCommandMgr;
		}

		// Token: 0x06036A5A RID: 223834 RVA: 0x00F40356 File Offset: 0x00F3E556
		public DropCatchGameplayModifierMgr GetGameplayModifierMgr()
		{
			return this.GameplayModifierMgr;
		}

		// Token: 0x06036A5B RID: 223835 RVA: 0x00F4035E File Offset: 0x00F3E55E
		public DropCatchGameplayInputMgr GetGameplayInputMgr()
		{
			return this.GameplayInputMgr;
		}

		// Token: 0x06036A5C RID: 223836 RVA: 0x00F40366 File Offset: 0x00F3E566
		public IDropCatchGameplayArea GetGameplayArea()
		{
			return this.GameplayArea;
		}

		// Token: 0x06036A5D RID: 223837 RVA: 0x00F4036E File Offset: 0x00F3E56E
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

		// Token: 0x06036A5E RID: 223838 RVA: 0x00F403AB File Offset: 0x00F3E5AB
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

		// Token: 0x06036A5F RID: 223839 RVA: 0x00F403E1 File Offset: 0x00F3E5E1
		public void Ready()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "DropCatchGameplayLogic", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.GameplayState = EDropCatchGameplayState.Ready;
		}

		// Token: 0x06036A60 RID: 223840 RVA: 0x00F40410 File Offset: 0x00F3E610
		public void Play()
		{
			this.GameplayState = EDropCatchGameplayState.Play;
			DropCatchGameplayView gameplayView = this.Proxy.GetGameplayView();
			if (gameplayView != null)
			{
				UiAudioSystem.Instance.PlayViewBgm(gameplayView, "play_ui_music_coincatch");
			}
		}

		// Token: 0x06036A61 RID: 223841 RVA: 0x00F40444 File Offset: 0x00F3E644
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
				UiAudioSystem.Instance.StopViewBgm(gameplayView);
			}
		}

		// Token: 0x06036A62 RID: 223842 RVA: 0x00F40497 File Offset: 0x00F3E697
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

		// Token: 0x06036A63 RID: 223843 RVA: 0x00F404B9 File Offset: 0x00F3E6B9
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

		// Token: 0x06036A64 RID: 223844 RVA: 0x00F404E0 File Offset: 0x00F3E6E0
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

		// Token: 0x06036A65 RID: 223845 RVA: 0x00F4056C File Offset: 0x00F3E76C
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

		// Token: 0x06036A66 RID: 223846 RVA: 0x00F405E1 File Offset: 0x00F3E7E1
		public float GetEnergyGetRate()
		{
			return this.EnergyGetRate.GetFinalValue();
		}

		// Token: 0x06036A67 RID: 223847 RVA: 0x00F405EE File Offset: 0x00F3E7EE
		public float GetAddScoreRate()
		{
			return this.AddScoreRate.GetFinalValue();
		}

		// Token: 0x06036A68 RID: 223848 RVA: 0x00F405FB File Offset: 0x00F3E7FB
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

		// Token: 0x06036A69 RID: 223849 RVA: 0x00F4060E File Offset: 0x00F3E80E
		public float GetRemainingTime()
		{
			DropCatchGameplayTimeMgr gameplayTimeMgr = this.GameplayTimeMgr;
			if (gameplayTimeMgr == null)
			{
				return 0f;
			}
			return gameplayTimeMgr.GetRemainingTime();
		}

		// Token: 0x06036A6A RID: 223850 RVA: 0x00F40625 File Offset: 0x00F3E825
		public DropCatchGameplayAttribute GetAddScoreRateAttr()
		{
			return this.AddScoreRate;
		}

		// Token: 0x06036A6B RID: 223851 RVA: 0x00F4062D File Offset: 0x00F3E82D
		public DropCatchGameplayAttribute GetEnergyGetRateAttr()
		{
			return this.EnergyGetRate;
		}

		// Token: 0x06036A6C RID: 223852 RVA: 0x00F40635 File Offset: 0x00F3E835
		public EDropCatchGameplayState GetGameplayState()
		{
			return this.GameplayState;
		}

		// Token: 0x06036A6D RID: 223853 RVA: 0x00F40640 File Offset: 0x00F3E840
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

		// Token: 0x0401CE08 RID: 118280
		[Nullable(2)]
		private Ticker TickId;

		// Token: 0x0401CE09 RID: 118281
		public DropCatchGameplayProxy Proxy;

		// Token: 0x0401CE0A RID: 118282
		[Nullable(2)]
		private DropCatchGameplayTimeMgr GameplayTimeMgr;

		// Token: 0x0401CE0B RID: 118283
		[Nullable(2)]
		private DropCatchGameplayRoleMgr GameplayRoleMgr;

		// Token: 0x0401CE0C RID: 118284
		[Nullable(2)]
		private DropCatchGameplayDropItemMgr GameplayDropItemMgr;

		// Token: 0x0401CE0D RID: 118285
		[Nullable(2)]
		private DropCatchGameplayCollisionMgr GameplayCollisionMgr;

		// Token: 0x0401CE0E RID: 118286
		[Nullable(2)]
		private DropCatchGameplayCommandMgr GameplayCommandMgr;

		// Token: 0x0401CE0F RID: 118287
		[Nullable(2)]
		private DropCatchGameplayModifierMgr GameplayModifierMgr;

		// Token: 0x0401CE10 RID: 118288
		private IDropCatchGameplayArea GameplayArea;

		// Token: 0x0401CE11 RID: 118289
		private DropCatchGameplayAttribute AddScoreRate;

		// Token: 0x0401CE12 RID: 118290
		private DropCatchGameplayAttribute EnergyGetRate;

		// Token: 0x0401CE13 RID: 118291
		private EDropCatchGameplayState GameplayState = EDropCatchGameplayState.End;

		// Token: 0x0401CE14 RID: 118292
		private EDropCatchGameplayState StateBeforePause = EDropCatchGameplayState.End;

		// Token: 0x0401CE15 RID: 118293
		[Nullable(2)]
		private DropCatchGameplayInputMgr GameplayInputMgr;
	}
}
