using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003679 RID: 13945
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoGearTrapEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x060242D0 RID: 148176 RVA: 0x00A3CFC8 File Offset: 0x00A3B1C8
		public IReadOnlyList<int> TrackEntityIds
		{
			get
			{
				return this.TrackGridEntityIds;
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x060242D1 RID: 148177 RVA: 0x00A3CFD0 File Offset: 0x00A3B1D0
		public Vector MoveDirection { get; } = Vector.Create();

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x060242D2 RID: 148178 RVA: 0x00A3CFD8 File Offset: 0x00A3B1D8
		public Vector Position { get; } = Vector.Create();

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x060242D3 RID: 148179 RVA: 0x00A3CFE0 File Offset: 0x00A3B1E0
		public Vector InitialCoordinate { get; } = Vector.Create();

		// Token: 0x060242D4 RID: 148180 RVA: 0x00A3CFE8 File Offset: 0x00A3B1E8
		public WuWaGoGearTrapEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoGear config) : base(EWuWaGoEntityType.Gear, pbDataId, coordinate, rotator)
		{
			this.TrackGridEntityIds = new List<int>(config.GridEntityIds);
			this.InitialCoordinate.DeepCopy(coordinate);
			this.InitialRotator.DeepCopy(rotator);
			this.Position.DeepCopy(coordinate);
		}

		// Token: 0x060242D5 RID: 148181 RVA: 0x00A3D061 File Offset: 0x00A3B261
		public override void Destroy()
		{
			this.PendingAttackTargetUnitId = null;
			this.ResetToInitialPosition();
			base.Destroy();
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x00A3D07B File Offset: 0x00A3B27B
		public override IRollbackCapture CaptureRollback()
		{
			return new GearTrapRollbackCapture(this);
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x00A3D083 File Offset: 0x00A3B283
		public void SetMoveDirection(Vector direction)
		{
			base.MarkRollbackDirty();
			this.MoveDirection.DeepCopy(direction);
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x00A3D097 File Offset: 0x00A3B297
		public void UpdateRotator(Rotator rotator)
		{
			base.SetRotator(rotator);
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x00A3D0A0 File Offset: 0x00A3B2A0
		public void ReverseMoveDirection()
		{
			base.MarkRollbackDirty();
			this.MoveDirection.Set(-this.MoveDirection.X, -this.MoveDirection.Y, -this.MoveDirection.Z);
		}

		// Token: 0x060242DA RID: 148186 RVA: 0x00A3D0D7 File Offset: 0x00A3B2D7
		public bool HasMoveDirection()
		{
			return !this.MoveDirection.IsNearlyZero(9.999999747378752E-05);
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x00A3D0F0 File Offset: 0x00A3B2F0
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

		// Token: 0x060242DC RID: 148188 RVA: 0x00A3D160 File Offset: 0x00A3B360
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

		// Token: 0x060242DD RID: 148189 RVA: 0x00A3D1CD File Offset: 0x00A3B3CD
		public void UpdatePosition(Vector newCoordinate)
		{
			base.MarkRollbackDirty();
			this.Position.DeepCopy(newCoordinate);
			base.SetCoordinate(newCoordinate);
		}

		// Token: 0x060242DE RID: 148190 RVA: 0x00A3D1E8 File Offset: 0x00A3B3E8
		public int? ConsumePendingAttackTargetUnitId()
		{
			int? pendingAttackTargetUnitId = this.PendingAttackTargetUnitId;
			base.MarkRollbackDirty();
			this.PendingAttackTargetUnitId = null;
			return pendingAttackTargetUnitId;
		}

		// Token: 0x060242DF RID: 148191 RVA: 0x00A3D202 File Offset: 0x00A3B402
		public int? PeekPendingAttackTargetUnitId()
		{
			return this.PendingAttackTargetUnitId;
		}

		// Token: 0x060242E0 RID: 148192 RVA: 0x00A3D20A File Offset: 0x00A3B40A
		public void SetPendingAttackTargetUnitIdForRollback(int? id)
		{
			this.PendingAttackTargetUnitId = id;
		}

		// Token: 0x060242E1 RID: 148193 RVA: 0x00A3D213 File Offset: 0x00A3B413
		public void ResetToInitialPosition()
		{
			this.UpdatePosition(this.InitialCoordinate);
			base.SetRotator(this.InitialRotator);
			this.MoveDirection.Set(0.0, 0.0, 0.0);
		}

		// Token: 0x060242E2 RID: 148194 RVA: 0x00A3D253 File Offset: 0x00A3B453
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x060242E3 RID: 148195 RVA: 0x00A3D25B File Offset: 0x00A3B45B
		[NullableContext(2)]
		protected override void OnBeforeStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid nextGrid)
		{
			if (prevGrid != null)
			{
				prevGrid.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnGridOccupiedUnitChanged));
			}
		}

		// Token: 0x060242E4 RID: 148196 RVA: 0x00A3D272 File Offset: 0x00A3B472
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

		// Token: 0x060242E5 RID: 148197 RVA: 0x00A3D296 File Offset: 0x00A3B496
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x060242E6 RID: 148198 RVA: 0x00A3D2A1 File Offset: 0x00A3B4A1
		private void OnGridOccupiedUnitChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.QueueOccupantAttack(currentUnitId);
		}

		// Token: 0x060242E7 RID: 148199 RVA: 0x00A3D2AC File Offset: 0x00A3B4AC
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

		// Token: 0x040142A0 RID: 82592
		private readonly List<int> TrackGridEntityIds;

		// Token: 0x040142A1 RID: 82593
		private readonly Rotator InitialRotator = Rotator.Create();

		// Token: 0x040142A2 RID: 82594
		private int? PendingAttackTargetUnitId;
	}
}
