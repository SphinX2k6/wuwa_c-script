using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474A RID: 18250
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoMovableFloorEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FB20 RID: 195360 RVA: 0x00B0D397 File Offset: 0x00B0B597
		public WuWaGoMovableFloorEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoMovableFloor config) : base(EWuWaGoEntityType.MovableFloor, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x17007734 RID: 30516
		// (get) Token: 0x0602FB21 RID: 195361 RVA: 0x00B0D3BB File Offset: 0x00B0B5BB
		// (set) Token: 0x0602FB22 RID: 195362 RVA: 0x00B0D3C3 File Offset: 0x00B0B5C3
		public int StateIndex { get; private set; }

		// Token: 0x17007735 RID: 30517
		// (get) Token: 0x0602FB23 RID: 195363 RVA: 0x00B0D3CC File Offset: 0x00B0B5CC
		// (set) Token: 0x0602FB24 RID: 195364 RVA: 0x00B0D3D4 File Offset: 0x00B0B5D4
		public bool NeedMove { get; private set; }

		// Token: 0x17007736 RID: 30518
		// (get) Token: 0x0602FB25 RID: 195365 RVA: 0x00B0D3DD File Offset: 0x00B0B5DD
		// (set) Token: 0x0602FB26 RID: 195366 RVA: 0x00B0D3E5 File Offset: 0x00B0B5E5
		public int TargetIndex { get; private set; }

		// Token: 0x0602FB27 RID: 195367 RVA: 0x00B0D3EE File Offset: 0x00B0B5EE
		public void InitializeMoveCoordinates(Transform originTransform)
		{
			this.InitMoveCoordinates(originTransform);
		}

		// Token: 0x0602FB28 RID: 195368 RVA: 0x00B0D3F7 File Offset: 0x00B0B5F7
		public override void Unlock()
		{
			base.Unlock();
			this.InitialStateIndex = this.ResolveStateIndex(base.State);
			this.StateIndex = this.InitialStateIndex;
			this.TargetIndex = this.StateIndex;
			this.NeedMove = false;
		}

		// Token: 0x0602FB29 RID: 195369 RVA: 0x00B0D430 File Offset: 0x00B0B630
		public override void Destroy()
		{
			this.ResetToInitialState();
			base.Destroy();
		}

		// Token: 0x0602FB2A RID: 195370 RVA: 0x00B0D43E File Offset: 0x00B0B63E
		public override IRollbackCapture CaptureRollback()
		{
			return new MovableFloorRollbackCapture(this);
		}

		// Token: 0x0602FB2B RID: 195371 RVA: 0x00B0D446 File Offset: 0x00B0B646
		public void RestoreMoveStateForRollback(int stateIndex)
		{
			this.StateIndex = stateIndex;
			this.TargetIndex = stateIndex;
			this.NeedMove = false;
		}

		// Token: 0x0602FB2C RID: 195372 RVA: 0x00B0D460 File Offset: 0x00B0B660
		public void RequestMove(EGameplayEntityState targetState)
		{
			int num = this.MoveData.ToList<IWuWaGoMovableGridStatePos>().FindIndex(delegate(IWuWaGoMovableGridStatePos d)
			{
				EGameplayEntityState egameplayEntityState;
				return EGameplayEntityStateExtensions.TryFromString(d.EntityState, out egameplayEntityState) && egameplayEntityState == targetState;
			});
			if (num < 0 || num == this.StateIndex)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.TargetIndex = num;
			this.NeedMove = true;
		}

		// Token: 0x0602FB2D RID: 195373 RVA: 0x00B0D4B9 File Offset: 0x00B0B6B9
		public void FinishMove()
		{
			if (this.StateIndex == this.TargetIndex && !this.NeedMove)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.StateIndex = this.TargetIndex;
			this.NeedMove = false;
		}

		// Token: 0x0602FB2E RID: 195374 RVA: 0x00B0D4EC File Offset: 0x00B0B6EC
		public void CancelPendingMove()
		{
			if (this.TargetIndex == this.StateIndex && !this.NeedMove)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.TargetIndex = this.StateIndex;
			this.NeedMove = false;
			base.SetStateSilently(this.GetStateByIndex(this.StateIndex));
		}

		// Token: 0x0602FB2F RID: 195375 RVA: 0x00B0D53B File Offset: 0x00B0B73B
		[NullableContext(2)]
		public IWuWaGoMovableGridStatePos GetTargetPositionConfig()
		{
			if (this.TargetIndex < 0 || this.TargetIndex >= this.MoveData.Count)
			{
				return null;
			}
			return this.MoveData[this.TargetIndex];
		}

		// Token: 0x0602FB30 RID: 195376 RVA: 0x00B0D56C File Offset: 0x00B0B76C
		[NullableContext(2)]
		public Vector GetTargetCoordinate()
		{
			if (this.TargetIndex < 0 || this.TargetIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.TargetIndex];
		}

		// Token: 0x0602FB31 RID: 195377 RVA: 0x00B0D59D File Offset: 0x00B0B79D
		[NullableContext(2)]
		public IWuWaGoMovableGridStatePos GetCurrentPositionConfig()
		{
			if (this.StateIndex < 0 || this.StateIndex >= this.MoveData.Count)
			{
				return null;
			}
			return this.MoveData[this.StateIndex];
		}

		// Token: 0x0602FB32 RID: 195378 RVA: 0x00B0D5CE File Offset: 0x00B0B7CE
		[NullableContext(2)]
		public Vector GetCurrentCoordinate()
		{
			if (this.StateIndex < 0 || this.StateIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.StateIndex];
		}

		// Token: 0x0602FB33 RID: 195379 RVA: 0x00B0D5FF File Offset: 0x00B0B7FF
		[NullableContext(2)]
		public Vector GetInitialCoordinate()
		{
			if (this.InitialStateIndex < 0 || this.InitialStateIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.InitialStateIndex];
		}

		// Token: 0x0602FB34 RID: 195380 RVA: 0x00B0D630 File Offset: 0x00B0B830
		public void ResetToInitialState()
		{
			this.StateIndex = this.InitialStateIndex;
			this.TargetIndex = this.InitialStateIndex;
			this.NeedMove = false;
			Vector initialCoordinate = this.GetInitialCoordinate();
			if (initialCoordinate != null)
			{
				base.SetCoordinate(initialCoordinate);
			}
		}

		// Token: 0x0602FB35 RID: 195381 RVA: 0x00B0D66D File Offset: 0x00B0B86D
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			if (newState == EGameplayEntityState.Locked || newState == EGameplayEntityState.Completed)
			{
				return;
			}
			this.RequestMove(newState);
		}

		// Token: 0x0602FB36 RID: 195382 RVA: 0x00B0D680 File Offset: 0x00B0B880
		private EGameplayEntityState GetStateByIndex(int index)
		{
			if (index < 0 || index >= this.MoveData.Count)
			{
				return base.State;
			}
			EGameplayEntityState result;
			if (!EGameplayEntityStateExtensions.TryFromString(this.MoveData[index].EntityState, out result))
			{
				return base.State;
			}
			return result;
		}

		// Token: 0x0602FB37 RID: 195383 RVA: 0x00B0D6C8 File Offset: 0x00B0B8C8
		private int ResolveStateIndex(EGameplayEntityState state)
		{
			if (state == EGameplayEntityState.Locked || state == EGameplayEntityState.Completed)
			{
				return 0;
			}
			int num = this.MoveData.ToList<IWuWaGoMovableGridStatePos>().FindIndex(delegate(IWuWaGoMovableGridStatePos d)
			{
				EGameplayEntityState egameplayEntityState;
				return EGameplayEntityStateExtensions.TryFromString(d.EntityState, out egameplayEntityState) && egameplayEntityState == state;
			});
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0602FB38 RID: 195384 RVA: 0x00B0D71C File Offset: 0x00B0B91C
		private unsafe void InitMoveCoordinates(Transform originTransform)
		{
			this.MoveCoordinates.Clear();
			for (int i = 0; i < this.MoveData.Count; i++)
			{
				IWuWaGoMovableGridStatePos wuWaGoMovableGridStatePos = this.MoveData[i];
				Vector vector = Vector.Create((double)wuWaGoMovableGridStatePos.GridPos.X.GetValueOrDefault(), (double)wuWaGoMovableGridStatePos.GridPos.Y.GetValueOrDefault(), (double)wuWaGoMovableGridStatePos.GridPos.Z.GetValueOrDefault());
				Vector vector2 = Vector.Create();
				if (WuWaGoUtil.ConvertWorldPositionToGridCoordinate(originTransform, vector, vector2) == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WuWaGo;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "移动板状态坐标不合法，无法推断Shape";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("pbDataId", this.EntityPbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("stateIndex", i);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("worldPosition", vector.ToString());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				this.MoveCoordinates.Add(vector2);
			}
		}

		// Token: 0x04019BF8 RID: 105464
		public readonly IReadOnlyList<IWuWaGoMovableGridStatePos> MoveData = config.MoveData;

		// Token: 0x04019BF9 RID: 105465
		private readonly List<Vector> MoveCoordinates = new List<Vector>();

		// Token: 0x04019BFA RID: 105466
		private int InitialStateIndex;
	}
}
