using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004748 RID: 18248
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGearTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x17007730 RID: 30512
		// (get) Token: 0x0602FB06 RID: 195334 RVA: 0x00B0CFFC File Offset: 0x00B0B1FC
		public IReadOnlyList<int> TrackEntityIds
		{
			get
			{
				return this.TrackGridEntityIds;
			}
		}

		// Token: 0x17007731 RID: 30513
		// (get) Token: 0x0602FB07 RID: 195335 RVA: 0x00B0D004 File Offset: 0x00B0B204
		public Vector MoveDirection { get; } = Vector.Create();

		// Token: 0x17007732 RID: 30514
		// (get) Token: 0x0602FB08 RID: 195336 RVA: 0x00B0D00C File Offset: 0x00B0B20C
		public Vector Position { get; } = Vector.Create();

		// Token: 0x17007733 RID: 30515
		// (get) Token: 0x0602FB09 RID: 195337 RVA: 0x00B0D014 File Offset: 0x00B0B214
		public Vector InitialCoordinate { get; } = Vector.Create();

		// Token: 0x0602FB0A RID: 195338 RVA: 0x00B0D01C File Offset: 0x00B0B21C
		public WuWaGoGearTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoGear config) : base(EWuWaGoEntityType.Gear, pbDataId, coordinate, rotator)
		{
			this.TrackGridEntityIds = new List<int>(config.GridEntityIds);
			this.InitialCoordinate.DeepCopy(coordinate);
			this.InitialRotator.DeepCopy(rotator);
			this.Position.DeepCopy(coordinate);
		}

		// Token: 0x0602FB0B RID: 195339 RVA: 0x00B0D095 File Offset: 0x00B0B295
		public override void Destroy()
		{
			this.PendingAttackTargetUnitId = null;
			this.ResetToInitialPosition();
			base.Destroy();
		}

		// Token: 0x0602FB0C RID: 195340 RVA: 0x00B0D0AF File Offset: 0x00B0B2AF
		public override IRollbackCapture CaptureRollback()
		{
			return new GearTrapRollbackCapture(this);
		}

		// Token: 0x0602FB0D RID: 195341 RVA: 0x00B0D0B7 File Offset: 0x00B0B2B7
		public void SetMoveDirection(Vector direction)
		{
			base.MarkRollbackDirty();
			this.MoveDirection.DeepCopy(direction);
		}

		// Token: 0x0602FB0E RID: 195342 RVA: 0x00B0D0CB File Offset: 0x00B0B2CB
		public void UpdateRotator(Rotator rotator)
		{
			base.SetRotator(rotator);
		}

		// Token: 0x0602FB0F RID: 195343 RVA: 0x00B0D0D4 File Offset: 0x00B0B2D4
		public void ReverseMoveDirection()
		{
			base.MarkRollbackDirty();
			this.MoveDirection.Set(-this.MoveDirection.X, -this.MoveDirection.Y, -this.MoveDirection.Z);
		}

		// Token: 0x0602FB10 RID: 195344 RVA: 0x00B0D10B File Offset: 0x00B0B30B
		public bool HasMoveDirection()
		{
			return !this.MoveDirection.IsNearlyZero(9.999999747378752E-05);
		}

		// Token: 0x0602FB11 RID: 195345 RVA: 0x00B0D124 File Offset: 0x00B0B324
		public unsafe void LogStay()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "齿轮轨道中断，保持原地";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("coordinate", this.Position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("direction", this.MoveDirection);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602FB12 RID: 195346 RVA: 0x00B0D194 File Offset: 0x00B0B394
		public unsafe void LogMove()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "齿轮移动";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("coordinate", this.Position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("direction", this.MoveDirection);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602FB13 RID: 195347 RVA: 0x00B0D201 File Offset: 0x00B0B401
		public void UpdatePosition(Vector newCoordinate)
		{
			base.MarkRollbackDirty();
			this.Position.DeepCopy(newCoordinate);
			base.SetCoordinate(newCoordinate);
		}

		// Token: 0x0602FB14 RID: 195348 RVA: 0x00B0D21C File Offset: 0x00B0B41C
		public int? ConsumePendingAttackTargetUnitId()
		{
			int? pendingAttackTargetUnitId = this.PendingAttackTargetUnitId;
			base.MarkRollbackDirty();
			this.PendingAttackTargetUnitId = null;
			return pendingAttackTargetUnitId;
		}

		// Token: 0x0602FB15 RID: 195349 RVA: 0x00B0D236 File Offset: 0x00B0B436
		public int? PeekPendingAttackTargetUnitId()
		{
			return this.PendingAttackTargetUnitId;
		}

		// Token: 0x0602FB16 RID: 195350 RVA: 0x00B0D23E File Offset: 0x00B0B43E
		public void SetPendingAttackTargetUnitIdForRollback(int? id)
		{
			this.PendingAttackTargetUnitId = id;
		}

		// Token: 0x0602FB17 RID: 195351 RVA: 0x00B0D247 File Offset: 0x00B0B447
		public void ResetToInitialPosition()
		{
			this.UpdatePosition(this.InitialCoordinate);
			base.SetRotator(this.InitialRotator);
			this.MoveDirection.Set(0.0, 0.0, 0.0);
		}

		// Token: 0x0602FB18 RID: 195352 RVA: 0x00B0D287 File Offset: 0x00B0B487
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602FB19 RID: 195353 RVA: 0x00B0D28F File Offset: 0x00B0B48F
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x0602FB1A RID: 195354 RVA: 0x00B0D2A6 File Offset: 0x00B0B4A6
		[NullableContext(2)]
		protected override void OnAfterStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (nextGrid == null)
			{
				return;
			}
			nextGrid.AddOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			this.QueueOccupantAttack(nextGrid.OccupiedUnitId);
		}

		// Token: 0x0602FB1B RID: 195355 RVA: 0x00B0D2CA File Offset: 0x00B0B4CA
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x0602FB1C RID: 195356 RVA: 0x00B0D2D5 File Offset: 0x00B0B4D5
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.QueueOccupantAttack(currentUnitId);
		}

		// Token: 0x0602FB1D RID: 195357 RVA: 0x00B0D2E0 File Offset: 0x00B0B4E0
		private void QueueOccupantAttack(int unitId)
		{
			int? num = (unitId == 0) ? null : new int?(unitId);
			int? pendingAttackTargetUnitId = this.PendingAttackTargetUnitId;
			int? num2 = num;
			if (pendingAttackTargetUnitId.GetValueOrDefault() == num2.GetValueOrDefault() & pendingAttackTargetUnitId != null == (num2 != null))
			{
				return;
			}
			base.MarkRollbackDirty();
			this.PendingAttackTargetUnitId = num;
		}

		// Token: 0x04019BF0 RID: 105456
		private readonly List<int> TrackGridEntityIds;

		// Token: 0x04019BF1 RID: 105457
		private readonly Rotator InitialRotator = Rotator.Create();

		// Token: 0x04019BF2 RID: 105458
		private int? PendingAttackTargetUnitId;
	}
}
