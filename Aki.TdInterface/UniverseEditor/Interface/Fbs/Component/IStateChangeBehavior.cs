using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599E RID: 22942
	public struct IStateChangeBehavior : IFlatbufferObject
	{
		// Token: 0x1700AC28 RID: 44072
		// (get) Token: 0x06026DAC RID: 159148 RVA: 0x00558DA1 File Offset: 0x00556FA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DAD RID: 159149 RVA: 0x00558DAE File Offset: 0x00556FAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DAE RID: 159150 RVA: 0x00558DB8 File Offset: 0x00556FB8
		public static IStateChangeBehavior GetRootAsIStateChangeBehavior(ByteBuffer _bb)
		{
			return IStateChangeBehavior.GetRootAsIStateChangeBehavior(_bb, default(IStateChangeBehavior));
		}

		// Token: 0x06026DAF RID: 159151 RVA: 0x00558DD4 File Offset: 0x00556FD4
		public static IStateChangeBehavior GetRootAsIStateChangeBehavior(ByteBuffer _bb, IStateChangeBehavior obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DB0 RID: 159152 RVA: 0x00558DF1 File Offset: 0x00556FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DB1 RID: 159153 RVA: 0x00558E00 File Offset: 0x00557000
		public IStateChangeBehavior __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC29 RID: 44073
		// (get) Token: 0x06026DB2 RID: 159154 RVA: 0x00558E10 File Offset: 0x00557010
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

		// Token: 0x06026DB3 RID: 159155 RVA: 0x00558E47 File Offset: 0x00557047
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026DB4 RID: 159156 RVA: 0x00558E56 File Offset: 0x00557056
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026DB5 RID: 159157 RVA: 0x00558E64 File Offset: 0x00557064
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC2A RID: 44074
		// (get) Token: 0x06026DB6 RID: 159158 RVA: 0x00558EC4 File Offset: 0x005570C4
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

		// Token: 0x1700AC2B RID: 44075
		// (get) Token: 0x06026DB7 RID: 159159 RVA: 0x00558EF0 File Offset: 0x005570F0
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

		// Token: 0x1700AC2C RID: 44076
		// (get) Token: 0x06026DB8 RID: 159160 RVA: 0x00558F50 File Offset: 0x00557150
		public bool PendingConditionAvailable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026DB9 RID: 159161 RVA: 0x00558F90 File Offset: 0x00557190
		public IConditionAction? ConditionAction(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC2D RID: 44077
		// (get) Token: 0x06026DBA RID: 159162 RVA: 0x00558FF4 File Offset: 0x005571F4
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

		// Token: 0x1700AC2E RID: 44078
		// (get) Token: 0x06026DBB RID: 159163 RVA: 0x00559020 File Offset: 0x00557220
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

		// Token: 0x06026DBC RID: 159164 RVA: 0x0055905D File Offset: 0x0055725D
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

		// Token: 0x06026DBD RID: 159165 RVA: 0x00559099 File Offset: 0x00557299
		public static void StartIStateChangeBehavior(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026DBE RID: 159166 RVA: 0x005590A2 File Offset: 0x005572A2
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026DBF RID: 159167 RVA: 0x005590B2 File Offset: 0x005572B2
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x06026DC0 RID: 159168 RVA: 0x005590C4 File Offset: 0x005572C4
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026DC1 RID: 159169 RVA: 0x00559104 File Offset: 0x00557304
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026DC2 RID: 159170 RVA: 0x0055911E File Offset: 0x0055731E
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026DC3 RID: 159171 RVA: 0x0055913C File Offset: 0x0055733C
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026DC4 RID: 159172 RVA: 0x00559155 File Offset: 0x00557355
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026DC5 RID: 159173 RVA: 0x00559160 File Offset: 0x00557360
		public static void AddDelayChangeState(FlatBufferBuilder builder, Offset<IDelayChangeState> delayChangeStateOffset)
		{
			builder.AddOffset(2, delayChangeStateOffset.Value, 0);
		}

		// Token: 0x06026DC6 RID: 159174 RVA: 0x00559170 File Offset: 0x00557370
		public static void AddPendingConditionAvailable(FlatBufferBuilder builder, bool pendingConditionAvailable)
		{
			builder.AddBool(3, pendingConditionAvailable, false);
		}

		// Token: 0x06026DC7 RID: 159175 RVA: 0x0055917B File Offset: 0x0055737B
		public static void AddConditionAction(FlatBufferBuilder builder, VectorOffset conditionActionOffset)
		{
			builder.AddOffset(4, conditionActionOffset.Value, 0);
		}

		// Token: 0x06026DC8 RID: 159176 RVA: 0x0055918C File Offset: 0x0055738C
		public static VectorOffset CreateConditionActionVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026DC9 RID: 159177 RVA: 0x005591CC File Offset: 0x005573CC
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026DCA RID: 159178 RVA: 0x005591E6 File Offset: 0x005573E6
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026DCB RID: 159179 RVA: 0x00559204 File Offset: 0x00557404
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026DCC RID: 159180 RVA: 0x0055921D File Offset: 0x0055741D
		public static void StartConditionActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026DCD RID: 159181 RVA: 0x00559228 File Offset: 0x00557428
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026DCE RID: 159182 RVA: 0x00559233 File Offset: 0x00557433
		public static Offset<IStateChangeBehavior> EndIStateChangeBehavior(FlatBufferBuilder builder)
		{
			return new Offset<IStateChangeBehavior>(builder.EndTable());
		}

		// Token: 0x06026DCF RID: 159183 RVA: 0x00559240 File Offset: 0x00557440
		public IStateChangeBehaviorT UnPack()
		{
			IStateChangeBehaviorT stateChangeBehaviorT = new IStateChangeBehaviorT();
			this.UnPackTo(stateChangeBehaviorT);
			return stateChangeBehaviorT;
		}

		// Token: 0x06026DD0 RID: 159184 RVA: 0x0055925C File Offset: 0x0055745C
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

		// Token: 0x06026DD1 RID: 159185 RVA: 0x0055936C File Offset: 0x0055756C
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

		// Token: 0x0400EFA8 RID: 61352
		private Table __p;
	}
}
