using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FAB RID: 24491
	public struct IStateChangeBehavior : IFlatbufferObject
	{
		// Token: 0x1700B55C RID: 46428
		// (get) Token: 0x06029316 RID: 168726 RVA: 0x0059FA0D File Offset: 0x0059DC0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029317 RID: 168727 RVA: 0x0059FA1A File Offset: 0x0059DC1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029318 RID: 168728 RVA: 0x0059FA24 File Offset: 0x0059DC24
		public static IStateChangeBehavior GetRootAsIStateChangeBehavior(ByteBuffer _bb)
		{
			return IStateChangeBehavior.GetRootAsIStateChangeBehavior(_bb, default(IStateChangeBehavior));
		}

		// Token: 0x06029319 RID: 168729 RVA: 0x0059FA40 File Offset: 0x0059DC40
		public static IStateChangeBehavior GetRootAsIStateChangeBehavior(ByteBuffer _bb, IStateChangeBehavior obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602931A RID: 168730 RVA: 0x0059FA5D File Offset: 0x0059DC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602931B RID: 168731 RVA: 0x0059FA6C File Offset: 0x0059DC6C
		public IStateChangeBehavior __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B55D RID: 46429
		// (get) Token: 0x0602931C RID: 168732 RVA: 0x0059FA7C File Offset: 0x0059DC7C
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602931D RID: 168733 RVA: 0x0059FAB3 File Offset: 0x0059DCB3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602931E RID: 168734 RVA: 0x0059FAC2 File Offset: 0x0059DCC2
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602931F RID: 168735 RVA: 0x0059FAD0 File Offset: 0x0059DCD0
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B55E RID: 46430
		// (get) Token: 0x06029320 RID: 168736 RVA: 0x0059FB30 File Offset: 0x0059DD30
		public int ActionLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B55F RID: 46431
		// (get) Token: 0x06029321 RID: 168737 RVA: 0x0059FB5C File Offset: 0x0059DD5C
		public IDelayChangeState? DelayChangeState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDelayChangeState?(default(IDelayChangeState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B560 RID: 46432
		// (get) Token: 0x06029322 RID: 168738 RVA: 0x0059FBBC File Offset: 0x0059DDBC
		public bool PendingConditionAvailable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029323 RID: 168739 RVA: 0x0059FBFC File Offset: 0x0059DDFC
		public IConditionAction? ConditionAction(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B561 RID: 46433
		// (get) Token: 0x06029324 RID: 168740 RVA: 0x0059FC60 File Offset: 0x0059DE60
		public int ConditionActionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B562 RID: 46434
		// (get) Token: 0x06029325 RID: 168741 RVA: 0x0059FC8C File Offset: 0x0059DE8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029326 RID: 168742 RVA: 0x0059FCC9 File Offset: 0x0059DEC9
		public static Offset<IStateChangeBehavior> CreateIStateChangeBehavior(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), VectorOffset ActionOffset = default(VectorOffset), Offset<IDelayChangeState> DelayChangeStateOffset = default(Offset<IDelayChangeState>), bool PendingConditionAvailable = false, VectorOffset ConditionActionOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IStateChangeBehavior.AddConditionAction(builder, ConditionActionOffset);
			IStateChangeBehavior.AddDelayChangeState(builder, DelayChangeStateOffset);
			IStateChangeBehavior.AddAction(builder, ActionOffset);
			IStateChangeBehavior.AddState(builder, StateOffset);
			IStateChangeBehavior.AddNullMask(builder, NullMask);
			IStateChangeBehavior.AddPendingConditionAvailable(builder, PendingConditionAvailable);
			return IStateChangeBehavior.EndIStateChangeBehavior(builder);
		}

		// Token: 0x06029327 RID: 168743 RVA: 0x0059FD05 File Offset: 0x0059DF05
		public static void StartIStateChangeBehavior(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029328 RID: 168744 RVA: 0x0059FD0E File Offset: 0x0059DF0E
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06029329 RID: 168745 RVA: 0x0059FD1E File Offset: 0x0059DF1E
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x0602932A RID: 168746 RVA: 0x0059FD30 File Offset: 0x0059DF30
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602932B RID: 168747 RVA: 0x0059FD70 File Offset: 0x0059DF70
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602932C RID: 168748 RVA: 0x0059FD8A File Offset: 0x0059DF8A
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602932D RID: 168749 RVA: 0x0059FDA8 File Offset: 0x0059DFA8
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602932E RID: 168750 RVA: 0x0059FDC1 File Offset: 0x0059DFC1
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602932F RID: 168751 RVA: 0x0059FDCC File Offset: 0x0059DFCC
		public static void AddDelayChangeState(FlatBufferBuilder builder, Offset<IDelayChangeState> delayChangeStateOffset)
		{
			builder.AddOffset(2, delayChangeStateOffset.Value, 0);
		}

		// Token: 0x06029330 RID: 168752 RVA: 0x0059FDDC File Offset: 0x0059DFDC
		public static void AddPendingConditionAvailable(FlatBufferBuilder builder, bool pendingConditionAvailable)
		{
			builder.AddBool(3, pendingConditionAvailable, false);
		}

		// Token: 0x06029331 RID: 168753 RVA: 0x0059FDE7 File Offset: 0x0059DFE7
		public static void AddConditionAction(FlatBufferBuilder builder, VectorOffset conditionActionOffset)
		{
			builder.AddOffset(4, conditionActionOffset.Value, 0);
		}

		// Token: 0x06029332 RID: 168754 RVA: 0x0059FDF8 File Offset: 0x0059DFF8
		public static VectorOffset CreateConditionActionVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029333 RID: 168755 RVA: 0x0059FE38 File Offset: 0x0059E038
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029334 RID: 168756 RVA: 0x0059FE52 File Offset: 0x0059E052
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029335 RID: 168757 RVA: 0x0059FE70 File Offset: 0x0059E070
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029336 RID: 168758 RVA: 0x0059FE89 File Offset: 0x0059E089
		public static void StartConditionActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029337 RID: 168759 RVA: 0x0059FE94 File Offset: 0x0059E094
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06029338 RID: 168760 RVA: 0x0059FE9F File Offset: 0x0059E09F
		public static Offset<IStateChangeBehavior> EndIStateChangeBehavior(FlatBufferBuilder builder)
		{
			return new Offset<IStateChangeBehavior>(builder.EndTable());
		}

		// Token: 0x06029339 RID: 168761 RVA: 0x0059FEAC File Offset: 0x0059E0AC
		public IStateChangeBehaviorT UnPack()
		{
			IStateChangeBehaviorT stateChangeBehaviorT = new IStateChangeBehaviorT();
			this.UnPackTo(stateChangeBehaviorT);
			return stateChangeBehaviorT;
		}

		// Token: 0x0602933A RID: 168762 RVA: 0x0059FEC8 File Offset: 0x0059E0C8
		public void UnPackTo(IStateChangeBehaviorT _o)
		{
			_o.State = this.State;
			_o.Action = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionLength; i++)
			{
				_o.Action.Add((this.Action(i) != null) ? this.Action(i).Value.UnPack() : null);
			}
			_o.DelayChangeState = ((this.DelayChangeState != null) ? this.DelayChangeState.Value.UnPack() : null);
			_o.PendingConditionAvailable = this.PendingConditionAvailable;
			_o.ConditionAction = new List<IConditionActionT>();
			for (int j = 0; j < this.ConditionActionLength; j++)
			{
				_o.ConditionAction.Add((this.ConditionAction(j) != null) ? this.ConditionAction(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602933B RID: 168763 RVA: 0x0059FFD8 File Offset: 0x0059E1D8
		public static Offset<IStateChangeBehavior> Pack(FlatBufferBuilder builder, IStateChangeBehaviorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateChangeBehavior>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			VectorOffset actionOffset = default(VectorOffset);
			if (_o.Action != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Action.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Action[i]);
				}
				actionOffset = IStateChangeBehavior.CreateActionVector(builder, array);
			}
			Offset<IDelayChangeState> delayChangeStateOffset = (_o.DelayChangeState == null) ? default(Offset<IDelayChangeState>) : IDelayChangeState.Pack(builder, _o.DelayChangeState);
			VectorOffset conditionActionOffset = default(VectorOffset);
			if (_o.ConditionAction != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.ConditionAction.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.ConditionAction[j]);
				}
				conditionActionOffset = IStateChangeBehavior.CreateConditionActionVector(builder, array2);
			}
			return IStateChangeBehavior.CreateIStateChangeBehavior(builder, stateOffset, actionOffset, delayChangeStateOffset, _o.PendingConditionAvailable, conditionActionOffset, _o.NullMask);
		}

		// Token: 0x0400FC9D RID: 64669
		private Table __p;
	}
}
