using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005688 RID: 22152
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayRole : IRoleInstance
	{
		// Token: 0x17006998 RID: 27032
		// (get) Token: 0x06036A78 RID: 223864 RVA: 0x00F40C07 File Offset: 0x00F3EE07
		// (set) Token: 0x06036A79 RID: 223865 RVA: 0x00F40C10 File Offset: 0x00F3EE10
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

		// Token: 0x06036A7A RID: 223866 RVA: 0x00F40C98 File Offset: 0x00F3EE98
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

		// Token: 0x06036A7B RID: 223867 RVA: 0x00F40CC8 File Offset: 0x00F3EEC8
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

		// Token: 0x06036A7C RID: 223868 RVA: 0x00F40F97 File Offset: 0x00F3F197
		public void OnReadyTick(float deltaTime)
		{
			this.UpdateDirection();
			this.UpdatePosition(deltaTime);
			this.UpdateAnimationState();
		}

		// Token: 0x06036A7D RID: 223869 RVA: 0x00F40FAC File Offset: 0x00F3F1AC
		public void OnTick(float deltaTime)
		{
			this.UpdateDirection();
			this.UpdateEnergy(deltaTime);
			this.UpdateShieldTime(deltaTime);
			this.UpdatePosition(deltaTime);
			this.UpdateBounds();
			this.UpdateAnimationState();
		}

		// Token: 0x06036A7E RID: 223870 RVA: 0x00F40FD5 File Offset: 0x00F3F1D5
		protected void UpdateDirection()
		{
			this.MoveDirection = this.Context.GetGameplayInputMgr().Get(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchRoleDirection.None);
			if (this.MoveDirection != EDropCatchRoleDirection.None)
			{
				this.FacingDirection = this.MoveDirection;
			}
		}

		// Token: 0x06036A7F RID: 223871 RVA: 0x00F41004 File Offset: 0x00F3F204
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

		// Token: 0x06036A80 RID: 223872 RVA: 0x00F410A4 File Offset: 0x00F3F2A4
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

		// Token: 0x06036A81 RID: 223873 RVA: 0x00F41110 File Offset: 0x00F3F310
		protected void UpdateBounds()
		{
			this.RoleBoundCenter.Set(this.RolePos.X + this.RoleBoundsOffset.X, this.RolePos.Y + this.RoleBoundsOffset.Y);
			this.BowlBoundCenter.Set(this.RolePos.X + this.BowlBoundsOffset.X, this.RolePos.Y + this.BowlBoundsOffset.Y);
			DropCatchGameplayHelper.CalculateBounds(this.RoleBoundCenter, this.RoleSize, this.RoleBounds);
			DropCatchGameplayHelper.CalculateBounds(this.BowlBoundCenter, this.BowlSize, this.BowlBounds);
		}

		// Token: 0x06036A82 RID: 223874 RVA: 0x00F411BD File Offset: 0x00F3F3BD
		protected void UpdateEnergy(float deltaTime)
		{
			if (this.SkillState == EDropCatchRoleSkillState.InSkill)
			{
				this.ConsumeEnergy(deltaTime);
				return;
			}
			this.AddEnergy((float)((double)(this.EnergySelfRecover * deltaTime) * TimeUtil.Instance.Millisecond), false);
		}

		// Token: 0x06036A83 RID: 223875 RVA: 0x00F411EC File Offset: 0x00F3F3EC
		public IDropCatchBounds GetBowlBounds()
		{
			return this.BowlBounds;
		}

		// Token: 0x06036A84 RID: 223876 RVA: 0x00F411F4 File Offset: 0x00F3F3F4
		public IDropCatchBounds GetRoleBounds()
		{
			return this.RoleBounds;
		}

		// Token: 0x06036A85 RID: 223877 RVA: 0x00F411FC File Offset: 0x00F3F3FC
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

		// Token: 0x06036A86 RID: 223878 RVA: 0x00F4126A File Offset: 0x00F3F46A
		public void FullEnergy()
		{
			this.Energy = this.MaxEnergy;
		}

		// Token: 0x06036A87 RID: 223879 RVA: 0x00F41278 File Offset: 0x00F3F478
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

		// Token: 0x06036A88 RID: 223880 RVA: 0x00F412F3 File Offset: 0x00F3F4F3
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

		// Token: 0x06036A89 RID: 223881 RVA: 0x00F41333 File Offset: 0x00F3F533
		protected virtual void OnSkillStart()
		{
		}

		// Token: 0x06036A8A RID: 223882 RVA: 0x00F41338 File Offset: 0x00F3F538
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

		// Token: 0x06036A8B RID: 223883 RVA: 0x00F41392 File Offset: 0x00F3F592
		protected virtual void OnSkillEnd()
		{
		}

		// Token: 0x06036A8C RID: 223884 RVA: 0x00F41394 File Offset: 0x00F3F594
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

		// Token: 0x06036A8D RID: 223885 RVA: 0x00F41414 File Offset: 0x00F3F614
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

		// Token: 0x06036A8E RID: 223886 RVA: 0x00F4147C File Offset: 0x00F3F67C
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

		// Token: 0x06036A8F RID: 223887 RVA: 0x00F414BA File Offset: 0x00F3F6BA
		public bool IsInShield()
		{
			return this.ShieldTime > 0f;
		}

		// Token: 0x06036A90 RID: 223888 RVA: 0x00F414C9 File Offset: 0x00F3F6C9
		public EDropCatchRoleSkillState GetSkillState()
		{
			return this.SkillState;
		}

		// Token: 0x06036A91 RID: 223889 RVA: 0x00F414D1 File Offset: 0x00F3F6D1
		public int GetRoleId()
		{
			return this.RoleId;
		}

		// Token: 0x06036A92 RID: 223890 RVA: 0x00F414D9 File Offset: 0x00F3F6D9
		public float GetEnergy()
		{
			return this.Energy;
		}

		// Token: 0x06036A93 RID: 223891 RVA: 0x00F414E1 File Offset: 0x00F3F6E1
		public float GetMaxEnergy()
		{
			return this.MaxEnergy;
		}

		// Token: 0x06036A94 RID: 223892 RVA: 0x00F414E9 File Offset: 0x00F3F6E9
		public Vector2D GetRolePos()
		{
			return this.RolePos;
		}

		// Token: 0x06036A95 RID: 223893 RVA: 0x00F414F1 File Offset: 0x00F3F6F1
		public DropCatchGameplayAttribute GetSpeedAttr()
		{
			return this.Speed;
		}

		// Token: 0x06036A96 RID: 223894 RVA: 0x00F414FC File Offset: 0x00F3F6FC
		public Vector2D GetFloatEffPos()
		{
			this.FloatEffPos.Set(this.RolePos.X, this.RolePos.Y + this.RoleSize.Y / 2.0 + this.BowlSize.Y);
			return this.FloatEffPos;
		}

		// Token: 0x06036A97 RID: 223895 RVA: 0x00F41552 File Offset: 0x00F3F752
		public float GetEnergyGetRate()
		{
			return this.EnergyGetRate;
		}

		// Token: 0x06036A98 RID: 223896 RVA: 0x00F4155A File Offset: 0x00F3F75A
		public float GetEnergySelfRecover()
		{
			return this.EnergySelfRecover;
		}

		// Token: 0x06036A99 RID: 223897 RVA: 0x00F41562 File Offset: 0x00F3F762
		public float GetSkillReduceEnergy()
		{
			return this.SkillReduceEnergy;
		}

		// Token: 0x06036A9A RID: 223898 RVA: 0x00F4156A File Offset: 0x00F3F76A
		public float GetSkillReduceEnergyRateInterval()
		{
			return this.SkillReduceEnergyRateInterval;
		}

		// Token: 0x06036A9B RID: 223899 RVA: 0x00F41572 File Offset: 0x00F3F772
		public float GetSkillReduceEnergyRate()
		{
			return this.SkillReduceEnergyRate;
		}

		// Token: 0x06036A9C RID: 223900 RVA: 0x00F4157A File Offset: 0x00F3F77A
		public float GetShieldTime()
		{
			return this.ShieldTime;
		}

		// Token: 0x06036A9D RID: 223901 RVA: 0x00F41582 File Offset: 0x00F3F782
		public EDropCatchRoleAnimState GetAnimState()
		{
			return this.AnimState;
		}

		// Token: 0x06036A9E RID: 223902 RVA: 0x00F4158A File Offset: 0x00F3F78A
		public Vector2D GetRoleSize()
		{
			return this.RoleSize;
		}

		// Token: 0x06036A9F RID: 223903 RVA: 0x00F41592 File Offset: 0x00F3F792
		public Vector2D GetBowlSize()
		{
			return this.BowlSize;
		}

		// Token: 0x0401CE1B RID: 118299
		protected Vector2D RolePos = Vector2D.Create();

		// Token: 0x0401CE1C RID: 118300
		protected Vector2D RoleBoundCenter = Vector2D.Create();

		// Token: 0x0401CE1D RID: 118301
		protected Vector2D BowlBoundCenter = Vector2D.Create();

		// Token: 0x0401CE1E RID: 118302
		protected Vector2D RoleSize = Vector2D.Create();

		// Token: 0x0401CE1F RID: 118303
		protected Vector2D BowlSize = Vector2D.Create();

		// Token: 0x0401CE20 RID: 118304
		protected Vector2D RoleBoundsOffset = Vector2D.Create();

		// Token: 0x0401CE21 RID: 118305
		protected Vector2D BowlBoundsOffset = Vector2D.Create();

		// Token: 0x0401CE22 RID: 118306
		protected int RoleId;

		// Token: 0x0401CE23 RID: 118307
		protected EDropCatchRoleAnimState AnimState = EDropCatchRoleAnimState.IdleBowlRight;

		// Token: 0x0401CE24 RID: 118308
		protected EDropCatchRoleSkillState SkillState;

		// Token: 0x0401CE25 RID: 118309
		protected DropCatchGameplayAttribute Speed;

		// Token: 0x0401CE26 RID: 118310
		protected float EnergyInner;

		// Token: 0x0401CE27 RID: 118311
		protected float MaxEnergy;

		// Token: 0x0401CE28 RID: 118312
		protected float EnergyGetRate;

		// Token: 0x0401CE29 RID: 118313
		protected float EnergySelfRecover;

		// Token: 0x0401CE2A RID: 118314
		protected float SkillReduceEnergy;

		// Token: 0x0401CE2B RID: 118315
		protected float SkillReduceEnergyRateInterval;

		// Token: 0x0401CE2C RID: 118316
		protected float SkillReduceEnergyRate;

		// Token: 0x0401CE2D RID: 118317
		protected float SkillStartTime;

		// Token: 0x0401CE2E RID: 118318
		protected readonly IDropCatchBounds BowlBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x0401CE2F RID: 118319
		protected readonly IDropCatchBounds RoleBounds = new IDropCatchBounds
		{
			Left = 0.0,
			Right = 0.0,
			Top = 0.0,
			Bottom = 0.0
		};

		// Token: 0x0401CE30 RID: 118320
		protected EDropCatchRoleDirection MoveDirection;

		// Token: 0x0401CE31 RID: 118321
		protected EDropCatchRoleDirection FacingDirection = EDropCatchRoleDirection.Right;

		// Token: 0x0401CE32 RID: 118322
		protected float MaxOffsetX;

		// Token: 0x0401CE33 RID: 118323
		protected float ShieldTime;

		// Token: 0x0401CE34 RID: 118324
		protected IGameplayLogicContext Context;

		// Token: 0x0401CE35 RID: 118325
		protected Vector2D FloatEffPos = Vector2D.Create();
	}
}
