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
	// Token: 0x0200368F RID: 13967
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRoleController<[Nullable(0)] TRole> : WuWaGoRoleController where TRole : WuWaGoRole
	{
		// Token: 0x060243F9 RID: 148473 RVA: 0x00A40884 File Offset: 0x00A3EA84
		protected WuWaGoRoleController(TRole role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode)
		{
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x060243FA RID: 148474 RVA: 0x00A408E4 File Offset: 0x00A3EAE4
		public override int Id
		{
			get
			{
				return this.Role.Id;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x060243FB RID: 148475 RVA: 0x00A408F6 File Offset: 0x00A3EAF6
		public override Enum Type
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x060243FC RID: 148476 RVA: 0x00A4090D File Offset: 0x00A3EB0D
		public override WuWaGoRole BaseRole
		{
			get
			{
				return this.Role;
			}
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x060243FD RID: 148477 RVA: 0x00A4091A File Offset: 0x00A3EB1A
		public override EWuWaGoRoleType RoleType
		{
			get
			{
				return this.Role.Type;
			}
		}

		// Token: 0x060243FE RID: 148478 RVA: 0x00A4092C File Offset: 0x00A3EB2C
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

		// Token: 0x060243FF RID: 148479 RVA: 0x00A4097F File Offset: 0x00A3EB7F
		public override void SyncRuntimePresentationAfterCoordinateChanged()
		{
		}

		// Token: 0x06024400 RID: 148480 RVA: 0x00A40981 File Offset: 0x00A3EB81
		public override void HideAttackRangeEffect(string reason)
		{
		}

		// Token: 0x06024401 RID: 148481 RVA: 0x00A40983 File Offset: 0x00A3EB83
		public override void ShowAttackRangeEffect(string reason)
		{
		}

		// Token: 0x06024402 RID: 148482 RVA: 0x00A40985 File Offset: 0x00A3EB85
		public override void OnRollbackRestore()
		{
			WuWaGoUtil.ResetRoleRootMotionState(this.Role, "RoleController.RollbackRestore");
		}

		// Token: 0x06024403 RID: 148483 RVA: 0x00A4099C File Offset: 0x00A3EB9C
		protected override bool OnCreate()
		{
			this.Role.AddStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.OnRoleStandGridChanged));
			this.RefreshRoleGridMoveParticipant(null, null);
			return true;
		}

		// Token: 0x06024404 RID: 148484 RVA: 0x00A409C3 File Offset: 0x00A3EBC3
		protected override void OnDestroy()
		{
			this.Role.RemoveStandGridChangedListener(new WuWaGoRoleStandGridChangedListener(this.OnRoleStandGridChanged));
			this.UnregisterRoleGridMoveParticipant();
		}

		// Token: 0x06024405 RID: 148485 RVA: 0x00A409E8 File Offset: 0x00A3EBE8
		protected bool ShouldInterrupt()
		{
			WuWaGoMainControlRole mainControlRole = WuWaGoModel.Instance.GameData.MainControlRole;
			return mainControlRole == null || mainControlRole.IsDead;
		}

		// Token: 0x06024406 RID: 148486 RVA: 0x00A40A10 File Offset: 0x00A3EC10
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

		// Token: 0x06024407 RID: 148487 RVA: 0x00A40A54 File Offset: 0x00A3EC54
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

		// Token: 0x06024408 RID: 148488 RVA: 0x00A40AA8 File Offset: 0x00A3ECA8
		protected virtual UniTask OnBeforeAttack(WuWaGoGrid targetGrid)
		{
			WuWaGoRoleController<TRole>.<OnBeforeAttack>d__28 <OnBeforeAttack>d__;
			<OnBeforeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeAttack>d__.targetGrid = targetGrid;
			<OnBeforeAttack>d__.<>1__state = -1;
			<OnBeforeAttack>d__.<>t__builder.Start<WuWaGoRoleController<TRole>.<OnBeforeAttack>d__28>(ref <OnBeforeAttack>d__);
			return <OnBeforeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x06024409 RID: 148489 RVA: 0x00A40AEC File Offset: 0x00A3ECEC
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

		// Token: 0x0602440A RID: 148490 RVA: 0x00A40B54 File Offset: 0x00A3ED54
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

		// Token: 0x0602440B RID: 148491 RVA: 0x00A40B74 File Offset: 0x00A3ED74
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

		// Token: 0x0602440C RID: 148492 RVA: 0x00A40C14 File Offset: 0x00A3EE14
		protected bool CanAttackTarget(WuWaGoRole target)
		{
			if (!target.IsMonster)
			{
				return true;
			}
			WuWaGoGrid wuWaGoGrid = this.FindRoleFrontGrid(target, 1);
			return wuWaGoGrid == null || wuWaGoGrid.Id != this.Role.StandGridId;
		}

		// Token: 0x0602440D RID: 148493 RVA: 0x00A40C54 File Offset: 0x00A3EE54
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

		// Token: 0x0602440E RID: 148494 RVA: 0x00A40CFC File Offset: 0x00A3EEFC
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

		// Token: 0x0602440F RID: 148495 RVA: 0x00A40D98 File Offset: 0x00A3EF98
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

		// Token: 0x06024410 RID: 148496 RVA: 0x00A40DC4 File Offset: 0x00A3EFC4
		private void OnBeforeRoleGridMove(IWuWaGoGridRelocationContext context)
		{
			this.HideAttackRangeEffect("WuWaGo.AttackRange.MovableFloor");
		}

		// Token: 0x06024411 RID: 148497 RVA: 0x00A40DD1 File Offset: 0x00A3EFD1
		private void OnCommitRoleGridMove(IWuWaGoGridRelocationContext context)
		{
			this.Role.SetCoordinate(context.TargetCoordinate);
		}

		// Token: 0x06024412 RID: 148498 RVA: 0x00A40DEC File Offset: 0x00A3EFEC
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

		// Token: 0x06024413 RID: 148499 RVA: 0x00A40E37 File Offset: 0x00A3F037
		[NullableContext(2)]
		private void OnRoleStandGridChanged([Nullable(1)] WuWaGoRole role, WuWaGoGrid prevGrid, WuWaGoGrid currentGrid)
		{
			this.RefreshRoleGridMoveParticipant(currentGrid, prevGrid);
		}

		// Token: 0x06024414 RID: 148500 RVA: 0x00A40E44 File Offset: 0x00A3F044
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

		// Token: 0x06024415 RID: 148501 RVA: 0x00A40EB1 File Offset: 0x00A3F0B1
		private void UnregisterRoleGridMoveParticipant()
		{
			WuWaGoGrid registeredMoveGrid = this.RegisteredMoveGrid;
			if (registeredMoveGrid != null)
			{
				registeredMoveGrid.UnregisterMoveParticipant(this.GetRoleGridMoveParticipant());
			}
			this.RegisteredMoveGrid = null;
		}

		// Token: 0x06024416 RID: 148502 RVA: 0x00A40ED4 File Offset: 0x00A3F0D4
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

		// Token: 0x040142FB RID: 82683
		public readonly AttackCapability Attack = new AttackCapability(role);

		// Token: 0x040142FC RID: 82684
		public readonly HurtCapability Hurt = new HurtCapability(role);

		// Token: 0x040142FD RID: 82685
		private readonly Vector TempForwardDir = Vector.Create();

		// Token: 0x040142FE RID: 82686
		private readonly Vector TempStepCoordinate = Vector.Create();

		// Token: 0x040142FF RID: 82687
		[Nullable(2)]
		private WuWaGoGrid RegisteredMoveGrid;

		// Token: 0x04014300 RID: 82688
		[Nullable(2)]
		private IWuWaGoGridMoveParticipant RoleGridMoveParticipantInner;

		// Token: 0x04014301 RID: 82689
		public readonly TRole Role = role;

		// Token: 0x04014302 RID: 82690
		public readonly WuWaGoGameData GameData = gameData;

		// Token: 0x04014303 RID: 82691
		protected readonly WuWaGoGameModeBase GameMode = gameMode;
	}
}
