using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006738 RID: 26424
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayRole : IRoleInstance
	{
		// Token: 0x17009659 RID: 38489
		// (get) Token: 0x06041F2C RID: 270124 RVA: 0x00FFF857 File Offset: 0x00FFDA57
		// (set) Token: 0x06041F2D RID: 270125 RVA: 0x00FFF860 File Offset: 0x00FFDA60
		protected float Energy
		{
			get
			{
				return this.EnergyInner;
			}
			set
			{
				if (this.EnergyInner == value)
				{
					return;
				}
				if (value == 0f && this.SkillState == EDropCatchRoleSkillState.InSkill)
				{
					this.EndSkill();
				}
				EDropCatchRoleSkillState edropCatchRoleSkillState = this.ComputeSkillStateByEnergy(value, this.MaxEnergy);
				if (edropCatchRoleSkillState != this.SkillState)
				{
					this.SkillState = edropCatchRoleSkillState;
					DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
					if (gameplayView != null)
					{
						gameplayView.UpdateRoleSkillState();
					}
				}
				this.EnergyInner = value;
				DropCatchGameplayView gameplayView2 = this.Context.GetProxy().GetGameplayView();
				if (gameplayView2 == null)
				{
					return;
				}
				gameplayView2.UpdateRoleEnergy();
			}
		}

		// Token: 0x06041F2E RID: 270126 RVA: 0x00FFF8E8 File Offset: 0x00FFDAE8
		private EDropCatchRoleSkillState ComputeSkillStateByEnergy(float energy, float maxEnergy)
		{
			if (energy == 0f)
			{
				return EDropCatchRoleSkillState.Disable;
			}
			if (energy.Equals(maxEnergy))
			{
				if (this.SkillState != EDropCatchRoleSkillState.InSkill)
				{
					return EDropCatchRoleSkillState.Enable;
				}
				return EDropCatchRoleSkillState.InSkill;
			}
			else
			{
				if (this.SkillState != EDropCatchRoleSkillState.InSkill)
				{
					return EDropCatchRoleSkillState.Disable;
				}
				return EDropCatchRoleSkillState.InSkill;
			}
		}

		// Token: 0x06041F2F RID: 270127 RVA: 0x00FFF918 File Offset: 0x00FFDB18
		public void Init(IDropCatchRoleParams @params)
		{
			this.Context = @params.Context;
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			if (gameplayConfig == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "GetGameplayConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.MoveDirection = EDropCatchRoleDirection.None;
			this.FacingDirection = EDropCatchRoleDirection.Right;
			this.SkillStartTime = 0f;
			this.SkillState = EDropCatchRoleSkillState.Disable;
			this.ShieldTime = 0f;
			this.AnimState = EDropCatchRoleAnimState.IdleBowlRight;
			this.RoleId = @params.RoleId;
			DropCatchRole? dropCatchRoleById = DropCatchConfig.Instance.GetDropCatchRoleById(this.RoleId);
			if (dropCatchRoleById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
				defaultInterpolatedStringHandler.AppendLiteral("DropCatchRoleById is null, RoleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.RoleId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Speed = new DropCatchGameplayAttribute("RoleSpeed", dropCatchRoleById.Value.MoveSpeed);
			this.Energy = 0f;
			this.MaxEnergy = dropCatchRoleById.Value.MaxEnergy;
			this.EnergyGetRate = dropCatchRoleById.Value.EnergyGetRate;
			this.EnergySelfRecover = dropCatchRoleById.Value.EnergySelfRecover;
			this.SkillReduceEnergy = dropCatchRoleById.Value.SkillReduceEnergy;
			this.SkillReduceEnergyRateInterval = dropCatchRoleById.Value.SkillReduceEnergyRateInterval * (float)TimeUtil.Instance.InverseMillisecond;
			this.SkillReduceEnergyRate = dropCatchRoleById.Value.SkillReduceEnergyRate;
			this.RolePos.Set((double)gameplayConfig.Value.RoleBornPos(0), (double)gameplayConfig.Value.RoleBornPos(1));
			this.RoleSize.Set((double)dropCatchRoleById.Value.RoleSize(0), (double)dropCatchRoleById.Value.RoleSize(1));
			this.BowlSize.Set((double)dropCatchRoleById.Value.BowlSize(0), (double)dropCatchRoleById.Value.BowlSize(1));
			this.RoleBoundsOffset.Set((double)dropCatchRoleById.Value.RoleSizeBiasNew(0), (double)dropCatchRoleById.Value.RoleSizeBiasNew(1));
			this.BowlBoundsOffset.Set((double)dropCatchRoleById.Value.BowlSizeBiasNew(0), (double)dropCatchRoleById.Value.BowlSizeBiasNew(1));
			this.MaxOffsetX = (float)Math.Max(this.BowlSize.X, this.RoleSize.X) / 2f;
			this.UpdatePosition(0f);
			this.UpdateBounds();
		}

		// Token: 0x06041F30 RID: 270128 RVA: 0x00FFFBE7 File Offset: 0x00FFDDE7
		public void OnReadyTick(float deltaTime)
		{
			this.UpdateDirection();
			this.UpdatePosition(deltaTime);
			this.UpdateAnimationState();
		}

		// Token: 0x06041F31 RID: 270129 RVA: 0x00FFFBFC File Offset: 0x00FFDDFC
		public void OnTick(float deltaTime)
		{
			this.UpdateDirection();
			this.UpdateEnergy(deltaTime);
			this.UpdateShieldTime(deltaTime);
			this.UpdatePosition(deltaTime);
			this.UpdateBounds();
			this.UpdateAnimationState();
		}

		// Token: 0x06041F32 RID: 270130 RVA: 0x00FFFC25 File Offset: 0x00FFDE25
		protected void UpdateDirection()
		{
			this.MoveDirection = this.Context.GetGameplayInputMgr().Get(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchRoleDirection.None);
			if (this.MoveDirection != EDropCatchRoleDirection.None)
			{
				this.FacingDirection = this.MoveDirection;
			}
		}

		// Token: 0x06041F33 RID: 270131 RVA: 0x00FFFC54 File Offset: 0x00FFDE54
		protected void UpdatePosition(float deltaTime)
		{
			this.RolePos.X = MathUtils.Instance.Clamp(this.RolePos.X + (double)(this.Speed.GetFinalValue() * (float)this.MoveDirection * deltaTime), this.Context.GetGameplayArea().MinX + (double)this.MaxOffsetX, this.Context.GetGameplayArea().MaxX - (double)this.MaxOffsetX);
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView == null)
			{
				return;
			}
			DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
			if (roleView == null)
			{
				return;
			}
			roleView.UpdateRolePos(this.RolePos);
		}

		// Token: 0x06041F34 RID: 270132 RVA: 0x00FFFCF4 File Offset: 0x00FFDEF4
		protected void UpdateAnimationState()
		{
			bool flag = this.MoveDirection > EDropCatchRoleDirection.None;
			EDropCatchRoleAnimState edropCatchRoleAnimState;
			if (this.FacingDirection == EDropCatchRoleDirection.Left)
			{
				edropCatchRoleAnimState = (flag ? EDropCatchRoleAnimState.WalkBowlLeft : EDropCatchRoleAnimState.IdleBowlLeft);
			}
			else
			{
				edropCatchRoleAnimState = (flag ? EDropCatchRoleAnimState.WalkBowlRight : EDropCatchRoleAnimState.IdleBowlRight);
			}
			if (this.AnimState != edropCatchRoleAnimState)
			{
				this.AnimState = edropCatchRoleAnimState;
				DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
				if (gameplayView == null)
				{
					return;
				}
				DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
				if (roleView == null)
				{
					return;
				}
				roleView.PlayAnimation(this.AnimState);
			}
		}

		// Token: 0x06041F35 RID: 270133 RVA: 0x00FFFD60 File Offset: 0x00FFDF60
		protected void UpdateBounds()
		{
			this.RoleBoundCenter.Set(this.RolePos.X + this.RoleBoundsOffset.X, this.RolePos.Y + this.RoleBoundsOffset.Y);
			this.BowlBoundCenter.Set(this.RolePos.X + this.BowlBoundsOffset.X, this.RolePos.Y + this.BowlBoundsOffset.Y);
			DropCatchGameplayHelper.CalculateBounds(this.RoleBoundCenter, this.RoleSize, this.RoleBounds);
			DropCatchGameplayHelper.CalculateBounds(this.BowlBoundCenter, this.BowlSize, this.BowlBounds);
		}

		// Token: 0x06041F36 RID: 270134 RVA: 0x00FFFE0D File Offset: 0x00FFE00D
		protected void UpdateEnergy(float deltaTime)
		{
			if (this.SkillState == EDropCatchRoleSkillState.InSkill)
			{
				this.ConsumeEnergy(deltaTime);
				return;
			}
			this.AddEnergy((float)((double)(this.EnergySelfRecover * deltaTime) * TimeUtil.Instance.Millisecond), false);
		}

		// Token: 0x06041F37 RID: 270135 RVA: 0x00FFFE3C File Offset: 0x00FFE03C
		public IDropCatchBounds GetBowlBounds()
		{
			return this.BowlBounds;
		}

		// Token: 0x06041F38 RID: 270136 RVA: 0x00FFFE44 File Offset: 0x00FFE044
		public IDropCatchBounds GetRoleBounds()
		{
			return this.RoleBounds;
		}

		// Token: 0x06041F39 RID: 270137 RVA: 0x00FFFE4C File Offset: 0x00FFE04C
		public void AddEnergy(float energy, bool calRate)
		{
			float num = energy;
			if (num > 0f)
			{
				float num2 = num * (calRate ? this.EnergyGetRate : 1f);
				DropCatchGameplayLogic gameplayLogic = this.Context.GetProxy().GetGameplayLogic();
				num = num2 * ((gameplayLogic != null) ? gameplayLogic.GetEnergyGetRate() : 1f);
			}
			this.Energy = MathUtils.Instance.Clamp(this.Energy + num, 0f, this.MaxEnergy);
		}

		// Token: 0x06041F3A RID: 270138 RVA: 0x00FFFEBA File Offset: 0x00FFE0BA
		public void FullEnergy()
		{
			this.Energy = this.MaxEnergy;
		}

		// Token: 0x06041F3B RID: 270139 RVA: 0x00FFFEC8 File Offset: 0x00FFE0C8
		protected void ConsumeEnergy(float deltaTime)
		{
			if (this.SkillState != EDropCatchRoleSkillState.InSkill)
			{
				return;
			}
			double y = Math.Floor((double)((this.Context.GetGameplayTimeMgr().GetTime() - this.SkillStartTime) / this.SkillReduceEnergyRateInterval));
			double num = Math.Pow((double)this.SkillReduceEnergyRate, y);
			double num2 = (double)this.SkillReduceEnergy * num * (double)deltaTime * TimeUtil.Instance.Millisecond;
			this.Energy = Math.Max(0f, this.Energy - (float)num2);
		}

		// Token: 0x06041F3C RID: 270140 RVA: 0x00FFFF43 File Offset: 0x00FFE143
		public void UseSkill()
		{
			this.SkillStartTime = this.Context.GetGameplayTimeMgr().GetTime();
			this.SkillState = EDropCatchRoleSkillState.InSkill;
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView != null)
			{
				gameplayView.UpdateRoleSkillState();
			}
			this.OnSkillStart();
		}

		// Token: 0x06041F3D RID: 270141 RVA: 0x00FFFF83 File Offset: 0x00FFE183
		protected virtual void OnSkillStart()
		{
		}

		// Token: 0x06041F3E RID: 270142 RVA: 0x00FFFF88 File Offset: 0x00FFE188
		private void EndSkill()
		{
			if (this.SkillState != EDropCatchRoleSkillState.InSkill)
			{
				return;
			}
			this.SkillStartTime = 0f;
			this.SkillState = EDropCatchRoleSkillState.Disable;
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView != null)
			{
				gameplayView.UpdateRoleSkillState();
			}
			this.Context.GetGameplayModifierMgr().ClearAllSkillModifiers();
			this.OnSkillEnd();
		}

		// Token: 0x06041F3F RID: 270143 RVA: 0x00FFFFE2 File Offset: 0x00FFE1E2
		protected virtual void OnSkillEnd()
		{
		}

		// Token: 0x06041F40 RID: 270144 RVA: 0x00FFFFE4 File Offset: 0x00FFE1E4
		public void AddShield(float time)
		{
			this.ShieldTime = time * (float)TimeUtil.Instance.InverseMillisecond;
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView != null)
			{
				DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
				if (roleView != null)
				{
					DropCatchGameplayRoleFxView fxView = roleView.GetFxView();
					if (fxView != null)
					{
						fxView.PlayShield();
					}
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DropCatch;
			ELogAuthor author = ELogAuthor.CB;
			string message = "添加护盾";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("time", time);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06041F41 RID: 270145 RVA: 0x01000064 File Offset: 0x00FFE264
		public void RemoveShield()
		{
			this.ShieldTime = 0f;
			DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
			if (gameplayView != null)
			{
				DropCatchGameplayRoleView roleView = gameplayView.GetRoleView();
				if (roleView != null)
				{
					DropCatchGameplayRoleFxView fxView = roleView.GetFxView();
					if (fxView != null)
					{
						fxView.PlayShieldEnd();
					}
				}
			}
			Log.Instance.Info(ELogModule.DropCatch, ELogAuthor.CB, "移除护盾", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06041F42 RID: 270146 RVA: 0x010000CC File Offset: 0x00FFE2CC
		public void UpdateShieldTime(float deltaTime)
		{
			if (this.ShieldTime <= 0f)
			{
				return;
			}
			if (this.ShieldTime > 0f)
			{
				this.ShieldTime -= deltaTime;
				if (this.ShieldTime <= 0f)
				{
					this.RemoveShield();
				}
			}
		}

		// Token: 0x06041F43 RID: 270147 RVA: 0x0100010A File Offset: 0x00FFE30A
		public bool IsInShield()
		{
			return this.ShieldTime > 0f;
		}

		// Token: 0x06041F44 RID: 270148 RVA: 0x01000119 File Offset: 0x00FFE319
		public EDropCatchRoleSkillState GetSkillState()
		{
			return this.SkillState;
		}

		// Token: 0x06041F45 RID: 270149 RVA: 0x01000121 File Offset: 0x00FFE321
		public int GetRoleId()
		{
			return this.RoleId;
		}

		// Token: 0x06041F46 RID: 270150 RVA: 0x01000129 File Offset: 0x00FFE329
		public float GetEnergy()
		{
			return this.Energy;
		}

		// Token: 0x06041F47 RID: 270151 RVA: 0x01000131 File Offset: 0x00FFE331
		public float GetMaxEnergy()
		{
			return this.MaxEnergy;
		}

		// Token: 0x06041F48 RID: 270152 RVA: 0x01000139 File Offset: 0x00FFE339
		public Vector2D GetRolePos()
		{
			return this.RolePos;
		}

		// Token: 0x06041F49 RID: 270153 RVA: 0x01000141 File Offset: 0x00FFE341
		public DropCatchGameplayAttribute GetSpeedAttr()
		{
			return this.Speed;
		}

		// Token: 0x06041F4A RID: 270154 RVA: 0x0100014C File Offset: 0x00FFE34C
		public Vector2D GetFloatEffPos()
		{
			this.FloatEffPos.Set(this.RolePos.X, this.RolePos.Y + this.RoleSize.Y / 2.0 + this.BowlSize.Y);
			return this.FloatEffPos;
		}

		// Token: 0x06041F4B RID: 270155 RVA: 0x010001A2 File Offset: 0x00FFE3A2
		public float GetEnergyGetRate()
		{
			return this.EnergyGetRate;
		}

		// Token: 0x06041F4C RID: 270156 RVA: 0x010001AA File Offset: 0x00FFE3AA
		public float GetEnergySelfRecover()
		{
			return this.EnergySelfRecover;
		}

		// Token: 0x06041F4D RID: 270157 RVA: 0x010001B2 File Offset: 0x00FFE3B2
		public float GetSkillReduceEnergy()
		{
			return this.SkillReduceEnergy;
		}

		// Token: 0x06041F4E RID: 270158 RVA: 0x010001BA File Offset: 0x00FFE3BA
		public float GetSkillReduceEnergyRateInterval()
		{
			return this.SkillReduceEnergyRateInterval;
		}

		// Token: 0x06041F4F RID: 270159 RVA: 0x010001C2 File Offset: 0x00FFE3C2
		public float GetSkillReduceEnergyRate()
		{
			return this.SkillReduceEnergyRate;
		}

		// Token: 0x06041F50 RID: 270160 RVA: 0x010001CA File Offset: 0x00FFE3CA
		public float GetShieldTime()
		{
			return this.ShieldTime;
		}

		// Token: 0x06041F51 RID: 270161 RVA: 0x010001D2 File Offset: 0x00FFE3D2
		public EDropCatchRoleAnimState GetAnimState()
		{
			return this.AnimState;
		}

		// Token: 0x06041F52 RID: 270162 RVA: 0x010001DA File Offset: 0x00FFE3DA
		public Vector2D GetRoleSize()
		{
			return this.RoleSize;
		}

		// Token: 0x06041F53 RID: 270163 RVA: 0x010001E2 File Offset: 0x00FFE3E2
		public Vector2D GetBowlSize()
		{
			return this.BowlSize;
		}

		// Token: 0x040225C2 RID: 140738
		protected Vector2D RolePos = Vector2D.Create();

		// Token: 0x040225C3 RID: 140739
		protected Vector2D RoleBoundCenter = Vector2D.Create();

		// Token: 0x040225C4 RID: 140740
		protected Vector2D BowlBoundCenter = Vector2D.Create();

		// Token: 0x040225C5 RID: 140741
		protected Vector2D RoleSize = Vector2D.Create();

		// Token: 0x040225C6 RID: 140742
		protected Vector2D BowlSize = Vector2D.Create();

		// Token: 0x040225C7 RID: 140743
		protected Vector2D RoleBoundsOffset = Vector2D.Create();

		// Token: 0x040225C8 RID: 140744
		protected Vector2D BowlBoundsOffset = Vector2D.Create();

		// Token: 0x040225C9 RID: 140745
		protected int RoleId;

		// Token: 0x040225CA RID: 140746
		protected EDropCatchRoleAnimState AnimState = EDropCatchRoleAnimState.IdleBowlRight;

		// Token: 0x040225CB RID: 140747
		protected EDropCatchRoleSkillState SkillState;

		// Token: 0x040225CC RID: 140748
		protected DropCatchGameplayAttribute Speed;

		// Token: 0x040225CD RID: 140749
		protected float EnergyInner;

		// Token: 0x040225CE RID: 140750
		protected float MaxEnergy;

		// Token: 0x040225CF RID: 140751
		protected float EnergyGetRate;

		// Token: 0x040225D0 RID: 140752
		protected float EnergySelfRecover;

		// Token: 0x040225D1 RID: 140753
		protected float SkillReduceEnergy;

		// Token: 0x040225D2 RID: 140754
		protected float SkillReduceEnergyRateInterval;

		// Token: 0x040225D3 RID: 140755
		protected float SkillReduceEnergyRate;

		// Token: 0x040225D4 RID: 140756
		protected float SkillStartTime;

		// Token: 0x040225D5 RID: 140757
		protected readonly IDropCatchBounds BowlBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x040225D6 RID: 140758
		protected readonly IDropCatchBounds RoleBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x040225D7 RID: 140759
		protected EDropCatchRoleDirection MoveDirection;

		// Token: 0x040225D8 RID: 140760
		protected EDropCatchRoleDirection FacingDirection = EDropCatchRoleDirection.Right;

		// Token: 0x040225D9 RID: 140761
		protected float MaxOffsetX;

		// Token: 0x040225DA RID: 140762
		protected float ShieldTime;

		// Token: 0x040225DB RID: 140763
		protected IGameplayLogicContext Context;

		// Token: 0x040225DC RID: 140764
		protected Vector2D FloatEffPos = Vector2D.Create();
	}
}
