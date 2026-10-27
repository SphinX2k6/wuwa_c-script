using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x0200475E RID: 18270
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRoleController<[Nullable(0)] TRole> : WuWaGoRoleController where TRole : WuWaGoRole
	{
		// Token: 0x0602FC2F RID: 195631 RVA: 0x00B108C4 File Offset: 0x00B0EAC4
		protected WuWaGoRoleController(TRole role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode)
		{
		}

		// Token: 0x1700774D RID: 30541
		// (get) Token: 0x0602FC30 RID: 195632 RVA: 0x00B10924 File Offset: 0x00B0EB24
		public override int Id
		{
			get
			{
				return this.Role.Id;
			}
		}

		// Token: 0x1700774E RID: 30542
		// (get) Token: 0x0602FC31 RID: 195633 RVA: 0x00B10936 File Offset: 0x00B0EB36
		public override Enum Type
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x1700774F RID: 30543
		// (get) Token: 0x0602FC32 RID: 195634 RVA: 0x00B1094D File Offset: 0x00B0EB4D
		public override WuWaGoRole BaseRole
		{
			get
			{
				return this.Role;
			}
		}

		// Token: 0x17007750 RID: 30544
		// (get) Token: 0x0602FC33 RID: 195635 RVA: 0x00B1095A File Offset: 0x00B0EB5A
		public override EWuWaGoRoleType RoleType
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x0602FC34 RID: 195636 RVA: 0x00B1096C File Offset: 0x00B0EB6C
		[NullableContext(2)]
		public override UniTask TakeAttack(bool playBeHitAnim, UAnimMontage deathMontage = null)
		{
			WuWaGoRoleController<TRole>.<TakeAttack>d__18 <TakeAttack>d__;
			<TakeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TakeAttack>d__.<>4__this = this;
			<TakeAttack>d__.playBeHitAnim = playBeHitAnim;
			<TakeAttack>d__.deathMontage = deathMontage;
			<TakeAttack>d__.<>1__state = -1;
			<TakeAttack>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<TakeAttack>d__18>(ref <TakeAttack>d__);
			return <TakeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC35 RID: 195637 RVA: 0x00B109BF File Offset: 0x00B0EBBF
		public override void SyncRuntimePresentationAfterCoordinateChanged()
		{
		}

		// Token: 0x0602FC36 RID: 195638 RVA: 0x00B109C1 File Offset: 0x00B0EBC1
		public override void HideAttackRangeEffect(string reason)
		{
		}

		// Token: 0x0602FC37 RID: 195639 RVA: 0x00B109C3 File Offset: 0x00B0EBC3
		public override void ShowAttackRangeEffect(string reason)
		{
		}

		// Token: 0x0602FC38 RID: 195640 RVA: 0x00B109C5 File Offset: 0x00B0EBC5
		public override void OnRollbackRestore()
		{
			WuWaGoUtil.ResetRoleRootMotionState(this.Role, "RoleController.RollbackRestore");
		}

		// Token: 0x0602FC39 RID: 195641 RVA: 0x00B109DC File Offset: 0x00B0EBDC
		protected override bool OnCreate()
		{
			this.Role.AddStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.OnRoleStandGridChanged));
			this.RefreshRoleGridMoveParticipant(null, null);
			return true;
		}

		// Token: 0x0602FC3A RID: 195642 RVA: 0x00B10A03 File Offset: 0x00B0EC03
		protected override void OnDestroy()
		{
			this.Role.RemoveStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.OnRoleStandGridChanged));
			this.UnregisterRoleGridMoveParticipant();
		}

		// Token: 0x0602FC3B RID: 195643 RVA: 0x00B10A28 File Offset: 0x00B0EC28
		protected bool ShouldInterrupt()
		{
			WuWaGoMainControlRole mainControlRole = WuWaGoModel.Instance.GameData.MainControlRole;
			return mainControlRole == null || mainControlRole.IsDead;
		}

		// Token: 0x0602FC3C RID: 195644 RVA: 0x00B10A50 File Offset: 0x00B0EC50
		[NullableContext(0)]
		protected UniTask<bool> TryAttackForward()
		{
			WuWaGoRoleController<TRole>.<TryAttackForward>d__26 <TryAttackForward>d__;
			<TryAttackForward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryAttackForward>d__.<>4__this = this;
			<TryAttackForward>d__.<>1__state = -1;
			<TryAttackForward>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<TryAttackForward>d__26>(ref <TryAttackForward>d__);
			return <TryAttackForward>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC3D RID: 195645 RVA: 0x00B10A94 File Offset: 0x00B0EC94
		[NullableContext(0)]
		protected UniTask<bool> TryAttackOnGrid([Nullable(2)] WuWaGoGrid grid, bool requireGridLink = true)
		{
			WuWaGoRoleController<TRole>.<TryAttackOnGrid>d__27 <TryAttackOnGrid>d__;
			<TryAttackOnGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryAttackOnGrid>d__.<>4__this = this;
			<TryAttackOnGrid>d__.grid = grid;
			<TryAttackOnGrid>d__.requireGridLink = requireGridLink;
			<TryAttackOnGrid>d__.<>1__state = -1;
			<TryAttackOnGrid>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<TryAttackOnGrid>d__27>(ref <TryAttackOnGrid>d__);
			return <TryAttackOnGrid>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC3E RID: 195646 RVA: 0x00B10AE8 File Offset: 0x00B0ECE8
		protected virtual UniTask OnBeforeAttack(WuWaGoGrid targetGrid)
		{
			WuWaGoRoleController<TRole>.<OnBeforeAttack>d__28 <OnBeforeAttack>d__;
			<OnBeforeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeAttack>d__.targetGrid = targetGrid;
			<OnBeforeAttack>d__.<>1__state = -1;
			<OnBeforeAttack>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<OnBeforeAttack>d__28>(ref <OnBeforeAttack>d__);
			return <OnBeforeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC3F RID: 195647 RVA: 0x00B10B2C File Offset: 0x00B0ED2C
		[NullableContext(2)]
		protected WuWaGoRole GetHostileRoleOnGrid(WuWaGoGrid grid)
		{
			if (grid == null || !grid.IsOccupied)
			{
				return null;
			}
			WuWaGoRole wuWaGoRole = WuWaGoModel.Instance.GetUnitById(grid.OccupiedUnitId) as WuWaGoRole;
			if (wuWaGoRole == null || wuWaGoRole == this.Role || wuWaGoRole.IsDead)
			{
				return null;
			}
			if (this.Role.IsMonster == wuWaGoRole.IsMonster)
			{
				return null;
			}
			return wuWaGoRole;
		}

		// Token: 0x0602FC40 RID: 195648 RVA: 0x00B10B94 File Offset: 0x00B0ED94
		[NullableContext(2)]
		private WuWaGoGrid FindHostileForwardGridIgnoringLinks()
		{
			WuWaGoGrid wuWaGoGrid = this.FindForwardGridIgnoringLinks();
			if (this.GetHostileRoleOnGrid(wuWaGoGrid) == null)
			{
				return null;
			}
			return wuWaGoGrid;
		}

		// Token: 0x0602FC41 RID: 195649 RVA: 0x00B10BB4 File Offset: 0x00B0EDB4
		[NullableContext(2)]
		private WuWaGoGrid FindForwardGridIgnoringLinks()
		{
			WuWaGoModel instance = WuWaGoModel.Instance;
			WuWaGoGrid gridById = instance.GetGridById(this.Role.StandGridId);
			if (gridById == null)
			{
				return null;
			}
			this.Role.Rotator.Quaternion(null).RotateVector(Vector.ForwardVectorProxy, this.TempForwardDir);
			WuWaGoUtil.RoundIfNotInteger(this.TempForwardDir);
			if (this.TempForwardDir.IsNearlyZero(9.999999747378752E-05))
			{
				return null;
			}
			gridById.Coordinate.Addition(this.TempForwardDir, this.TempStepCoordinate);
			return instance.GetGrid(this.TempStepCoordinate);
		}

		// Token: 0x0602FC42 RID: 195650 RVA: 0x00B10C54 File Offset: 0x00B0EE54
		protected bool CanAttackTarget(WuWaGoRole target)
		{
			if (!target.IsMonster)
			{
				return true;
			}
			WuWaGoGrid wuWaGoGrid = this.FindRoleFrontGrid(target, 1);
			return wuWaGoGrid == null || wuWaGoGrid.Id != this.Role.StandGridId;
		}

		// Token: 0x0602FC43 RID: 195651 RVA: 0x00B10C94 File Offset: 0x00B0EE94
		[return: Nullable(2)]
		protected WuWaGoGrid FindRoleFrontGrid(WuWaGoRole role, int step = 1)
		{
			if (step < 1)
			{
				return null;
			}
			WuWaGoModel instance = WuWaGoModel.Instance;
			WuWaGoGrid gridById = instance.GetGridById(role.StandGridId);
			if (gridById == null || gridById.LinkedDirections.Count == 0)
			{
				return null;
			}
			role.Rotator.Quaternion(null).RotateVector(Vector.ForwardVectorProxy, this.TempForwardDir);
			WuWaGoGrid wuWaGoGrid = gridById;
			for (int i = 0; i < step; i++)
			{
				Vector vector = this.PickForwardLinkDelta(wuWaGoGrid);
				if (vector == null)
				{
					return null;
				}
				wuWaGoGrid.Coordinate.Addition(vector, this.TempStepCoordinate);
				WuWaGoGrid grid = instance.GetGrid(this.TempStepCoordinate);
				if (grid == null || !wuWaGoGrid.IsBidirectionalLinkedTo(grid))
				{
					return null;
				}
				wuWaGoGrid = grid;
			}
			return wuWaGoGrid;
		}

		// Token: 0x0602FC44 RID: 195652 RVA: 0x00B10D3C File Offset: 0x00B0EF3C
		[return: Nullable(2)]
		private Vector PickForwardLinkDelta(WuWaGoGrid grid)
		{
			Vector tempForwardDir = this.TempForwardDir;
			Vector result = null;
			double num = WuWaGoRoleController.ForwardAlignThresholdSquared;
			foreach (Vector vector in grid.LinkedDirections)
			{
				double num2 = tempForwardDir.DotProduct(vector);
				if (num2 > 0.0)
				{
					double num3 = vector.SizeSquared();
					if (num3 > 0.0)
					{
						double num4 = num2 * num2 / num3;
						if (num4 > num)
						{
							num = num4;
							result = vector;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0602FC45 RID: 195653 RVA: 0x00B10DD8 File Offset: 0x00B0EFD8
		[return: Nullable(2)]
		private IWuWaGoWorldMoveTarget CreateRoleWorldMoveTarget(IWuWaGoGridRelocationContext context)
		{
			if (!this.Role.IsActorValid())
			{
				return null;
			}
			return new WuWaGoWorldMoveTarget
			{
				Unit = this.Role
			};
		}

		// Token: 0x0602FC46 RID: 195654 RVA: 0x00B10E04 File Offset: 0x00B0F004
		private void OnBeforeRoleGridMove(IWuWaGoGridRelocationContext context)
		{
			this.HideAttackRangeEffect("WuWaGo.AttackRange.MovableFloor");
		}

		// Token: 0x0602FC47 RID: 195655 RVA: 0x00B10E11 File Offset: 0x00B0F011
		private void OnCommitRoleGridMove(IWuWaGoGridRelocationContext context)
		{
			this.Role.SetCoordinate(context.TargetCoordinate);
		}

		// Token: 0x0602FC48 RID: 195656 RVA: 0x00B10E2C File Offset: 0x00B0F02C
		private UniTask OnAfterRoleGridMove(IWuWaGoGridRelocationContext context)
		{
			WuWaGoRoleController<TRole>.<OnAfterRoleGridMove>d__38 <OnAfterRoleGridMove>d__;
			<OnAfterRoleGridMove>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnAfterRoleGridMove>d__.<>4__this = this;
			<OnAfterRoleGridMove>d__.context = context;
			<OnAfterRoleGridMove>d__.<>1__state = -1;
			<OnAfterRoleGridMove>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<OnAfterRoleGridMove>d__38>(ref <OnAfterRoleGridMove>d__);
			return <OnAfterRoleGridMove>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC49 RID: 195657 RVA: 0x00B10E77 File Offset: 0x00B0F077
		[NullableContext(2)]
		private void OnRoleStandGridChanged([Nullable(1)] WuWaGoRole role, WuWaGoGrid prevGrid, WuWaGoGrid currentGrid)
		{
			this.RefreshRoleGridMoveParticipant(currentGrid, prevGrid);
		}

		// Token: 0x0602FC4A RID: 195658 RVA: 0x00B10E84 File Offset: 0x00B0F084
		[NullableContext(2)]
		private void RefreshRoleGridMoveParticipant(WuWaGoGrid currentGrid = null, WuWaGoGrid prevGrid = null)
		{
			WuWaGoGrid wuWaGoGrid = currentGrid ?? WuWaGoModel.Instance.GetGridById(this.Role.StandGridId);
			if (this.RegisteredMoveGrid == wuWaGoGrid)
			{
				return;
			}
			IWuWaGoGridMoveParticipant roleGridMoveParticipant = this.GetRoleGridMoveParticipant();
			WuWaGoGrid wuWaGoGrid2 = prevGrid ?? this.RegisteredMoveGrid;
			if (wuWaGoGrid2 != null)
			{
				wuWaGoGrid2.UnregisterMoveParticipant(roleGridMoveParticipant);
			}
			this.RegisteredMoveGrid = wuWaGoGrid;
			WuWaGoGrid registeredMoveGrid = this.RegisteredMoveGrid;
			if (registeredMoveGrid == null)
			{
				return;
			}
			registeredMoveGrid.RegisterMoveParticipant(roleGridMoveParticipant);
		}

		// Token: 0x0602FC4B RID: 195659 RVA: 0x00B10EF1 File Offset: 0x00B0F0F1
		private void UnregisterRoleGridMoveParticipant()
		{
			WuWaGoGrid registeredMoveGrid = this.RegisteredMoveGrid;
			if (registeredMoveGrid != null)
			{
				registeredMoveGrid.UnregisterMoveParticipant(this.GetRoleGridMoveParticipant());
			}
			this.RegisteredMoveGrid = null;
		}

		// Token: 0x0602FC4C RID: 195660 RVA: 0x00B10F14 File Offset: 0x00B0F114
		private IWuWaGoGridMoveParticipant GetRoleGridMoveParticipant()
		{
			if (this.RoleGridMoveParticipantInner == null)
			{
				WuWaGoGridMoveParticipant wuWaGoGridMoveParticipant = new WuWaGoGridMoveParticipant();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Role:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Role.Id);
				wuWaGoGridMoveParticipant.ParticipantKey = defaultInterpolatedStringHandler.ToStringAndClear();
				wuWaGoGridMoveParticipant.MovedRoleId = new int?(this.Role.Id);
				wuWaGoGridMoveParticipant.CreateWorldMoveTarget = new Func<IWuWaGoGridRelocationContext, IWuWaGoWorldMoveTarget>(this.CreateRoleWorldMoveTarget);
				wuWaGoGridMoveParticipant.BeforeGridMove = new Action<IWuWaGoGridRelocationContext>(this.OnBeforeRoleGridMove);
				wuWaGoGridMoveParticipant.CommitGridMove = new Action<IWuWaGoGridRelocationContext>(this.OnCommitRoleGridMove);
				wuWaGoGridMoveParticipant.AfterGridMove = delegate(IWuWaGoGridRelocationContext context)
				{
					WuWaGoRoleController<TRole>.<<GetRoleGridMoveParticipant>b__42_0>d <<GetRoleGridMoveParticipant>b__42_0>d;
					<<GetRoleGridMoveParticipant>b__42_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<GetRoleGridMoveParticipant>b__42_0>d.<>4__this = this;
					<<GetRoleGridMoveParticipant>b__42_0>d.context = context;
					<<GetRoleGridMoveParticipant>b__42_0>d.<>1__state = -1;
					<<GetRoleGridMoveParticipant>b__42_0>d.<>t__builder.Start<WuWaGoRoleController<TRole>.<<GetRoleGridMoveParticipant>b__42_0>d>(ref <<GetRoleGridMoveParticipant>b__42_0>d);
					return <<GetRoleGridMoveParticipant>b__42_0>d.<>t__builder.Task;
				};
				this.RoleGridMoveParticipantInner = wuWaGoGridMoveParticipant;
			}
			return this.RoleGridMoveParticipantInner;
		}

		// Token: 0x04019C4B RID: 105547
		public readonly AttackCapability Attack = new AttackCapability(role);

		// Token: 0x04019C4C RID: 105548
		public readonly HurtCapability Hurt = new HurtCapability(role);

		// Token: 0x04019C4D RID: 105549
		private readonly Vector TempForwardDir = Vector.Create();

		// Token: 0x04019C4E RID: 105550
		private readonly Vector TempStepCoordinate = Vector.Create();

		// Token: 0x04019C4F RID: 105551
		[Nullable(2)]
		private WuWaGoGrid RegisteredMoveGrid;

		// Token: 0x04019C50 RID: 105552
		[Nullable(2)]
		private IWuWaGoGridMoveParticipant RoleGridMoveParticipantInner;

		// Token: 0x04019C51 RID: 105553
		public readonly TRole Role = role;

		// Token: 0x04019C52 RID: 105554
		public readonly WuWaGoGameData GameData = gameData;

		// Token: 0x04019C53 RID: 105555
		protected readonly WuWaGoGameModeBase GameMode = gameMode;
	}
}
