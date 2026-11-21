using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200367B RID: 13947
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoMovableFloorEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x060242EA RID: 148202 RVA: 0x00A3D363 File Offset: 0x00A3B563
		public WuWaGoMovableFloorEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoMovableFloor config) : base(EWuWaGoEntityType.MovableFloor, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x060242EB RID: 148203 RVA: 0x00A3D387 File Offset: 0x00A3B587
		// (set) Token: 0x060242EC RID: 148204 RVA: 0x00A3D38F File Offset: 0x00A3B58F
		public int StateIndex { get; private set; }

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x060242ED RID: 148205 RVA: 0x00A3D398 File Offset: 0x00A3B598
		// (set) Token: 0x060242EE RID: 148206 RVA: 0x00A3D3A0 File Offset: 0x00A3B5A0
		public bool NeedMove { get; private set; }

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x060242EF RID: 148207 RVA: 0x00A3D3A9 File Offset: 0x00A3B5A9
		// (set) Token: 0x060242F0 RID: 148208 RVA: 0x00A3D3B1 File Offset: 0x00A3B5B1
		public int TargetIndex { get; private set; }

		// Token: 0x060242F1 RID: 148209 RVA: 0x00A3D3BA File Offset: 0x00A3B5BA
		public void InitializeMoveCoordinates(Transform originTransform)
		{
			this.InitMoveCoordinates(originTransform);
		}

		// Token: 0x060242F2 RID: 148210 RVA: 0x00A3D3C3 File Offset: 0x00A3B5C3
		public override void Unlock()
		{
			base.Unlock();
			this.InitialStateIndex = this.ResolveStateIndex(base.State);
			this.StateIndex = this.InitialStateIndex;
			this.TargetIndex = this.StateIndex;
			this.NeedMove = false;
		}

		// Token: 0x060242F3 RID: 148211 RVA: 0x00A3D3FC File Offset: 0x00A3B5FC
		public override void Destroy()
		{
			this.ResetToInitialState();
			base.Destroy();
		}

		// Token: 0x060242F4 RID: 148212 RVA: 0x00A3D40A File Offset: 0x00A3B60A
		public override IRollbackCapture CaptureRollback()
		{
			return new MovableFloorRollbackCapture(this);
		}

		// Token: 0x060242F5 RID: 148213 RVA: 0x00A3D412 File Offset: 0x00A3B612
		public void RestoreMoveStateForRollback(int stateIndex)
		{
			this.StateIndex = stateIndex;
			this.TargetIndex = stateIndex;
			this.NeedMove = false;
		}

		// Token: 0x060242F6 RID: 148214 RVA: 0x00A3D42C File Offset: 0x00A3B62C
		public void RequestMove(EGameplayEntityState targetState)
		{
			int num = -1;
			for (int i = 0; i < this.MoveData.Count; i++)
			{
				EGameplayEntityState egameplayEntityState;
				if (EGameplayEntityStateExtensions.TryFromString(this.MoveData[i].EntityState, out egameplayEntityState) && egameplayEntityState == targetState)
				{
					num = i;
					break;
				}
			}
			if (num < 0 || num == this.StateIndex)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.TargetIndex = num;
			this.NeedMove = true;
		}

		// Token: 0x060242F7 RID: 148215 RVA: 0x00A3D495 File Offset: 0x00A3B695
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

		// Token: 0x060242F8 RID: 148216 RVA: 0x00A3D4C8 File Offset: 0x00A3B6C8
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

		// Token: 0x060242F9 RID: 148217 RVA: 0x00A3D517 File Offset: 0x00A3B717
		[NullableContext(2)]
		public IWuWaGoMovableGridStatePos GetTargetPositionConfig()
		{
			if (this.TargetIndex < 0 || this.TargetIndex >= this.MoveData.Count)
			{
				return null;
			}
			return this.MoveData[this.TargetIndex];
		}

		// Token: 0x060242FA RID: 148218 RVA: 0x00A3D548 File Offset: 0x00A3B748
		[NullableContext(2)]
		public Vector GetTargetCoordinate()
		{
			if (this.TargetIndex < 0 || this.TargetIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.TargetIndex];
		}

		// Token: 0x060242FB RID: 148219 RVA: 0x00A3D579 File Offset: 0x00A3B779
		[NullableContext(2)]
		public IWuWaGoMovableGridStatePos GetCurrentPositionConfig()
		{
			if (this.StateIndex < 0 || this.StateIndex >= this.MoveData.Count)
			{
				return null;
			}
			return this.MoveData[this.StateIndex];
		}

		// Token: 0x060242FC RID: 148220 RVA: 0x00A3D5AA File Offset: 0x00A3B7AA
		[NullableContext(2)]
		public Vector GetCurrentCoordinate()
		{
			if (this.StateIndex < 0 || this.StateIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.StateIndex];
		}

		// Token: 0x060242FD RID: 148221 RVA: 0x00A3D5DB File Offset: 0x00A3B7DB
		[NullableContext(2)]
		public Vector GetInitialCoordinate()
		{
			if (this.InitialStateIndex < 0 || this.InitialStateIndex >= this.MoveCoordinates.Count)
			{
				return null;
			}
			return this.MoveCoordinates[this.InitialStateIndex];
		}

		// Token: 0x060242FE RID: 148222 RVA: 0x00A3D60C File Offset: 0x00A3B80C
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

		// Token: 0x060242FF RID: 148223 RVA: 0x00A3D649 File Offset: 0x00A3B849
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			if (newState == EGameplayEntityState.Locked || newState == EGameplayEntityState.Completed)
			{
				return;
			}
			this.RequestMove(newState);
		}

		// Token: 0x06024300 RID: 148224 RVA: 0x00A3D65C File Offset: 0x00A3B85C
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

		// Token: 0x06024301 RID: 148225 RVA: 0x00A3D6A4 File Offset: 0x00A3B8A4
		private int ResolveStateIndex(EGameplayEntityState state)
		{
			if (state == EGameplayEntityState.Locked || state == EGameplayEntityState.Completed)
			{
				return 0;
			}
			int num = -1;
			for (int i = 0; i < this.MoveData.Count; i++)
			{
				EGameplayEntityState egameplayEntityState;
				if (EGameplayEntityStateExtensions.TryFromString(this.MoveData[i].EntityState, out egameplayEntityState) && egameplayEntityState == state)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06024302 RID: 148226 RVA: 0x00A3D6FC File Offset: 0x00A3B8FC
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

		// Token: 0x040142A8 RID: 82600
		public readonly IReadOnlyList<IWuWaGoMovableGridStatePos> MoveData = config.MoveData;

		// Token: 0x040142A9 RID: 82601
		private readonly List<Vector> MoveCoordinates = new List<Vector>();

		// Token: 0x040142AA RID: 82602
		private int InitialStateIndex;
	}
}
