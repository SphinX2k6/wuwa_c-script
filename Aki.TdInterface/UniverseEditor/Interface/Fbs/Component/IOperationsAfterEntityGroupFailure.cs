using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4E RID: 23630
	public struct IOperationsAfterEntityGroupFailure : IFlatbufferObject
	{
		// Token: 0x1700AD91 RID: 44433
		// (get) Token: 0x060272CB RID: 160459 RVA: 0x0055DDC4 File Offset: 0x0055BFC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272CC RID: 160460 RVA: 0x0055DDD1 File Offset: 0x0055BFD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272CD RID: 160461 RVA: 0x0055DDD8 File Offset: 0x0055BFD8
		public static IOperationsAfterEntityGroupFailure GetRootAsIOperationsAfterEntityGroupFailure(ByteBuffer _bb)
		{
			return IOperationsAfterEntityGroupFailure.GetRootAsIOperationsAfterEntityGroupFailure(_bb, default(IOperationsAfterEntityGroupFailure));
		}

		// Token: 0x060272CE RID: 160462 RVA: 0x0055DDF4 File Offset: 0x0055BFF4
		public static IOperationsAfterEntityGroupFailure GetRootAsIOperationsAfterEntityGroupFailure(ByteBuffer _bb, IOperationsAfterEntityGroupFailure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272CF RID: 160463 RVA: 0x0055DE11 File Offset: 0x0055C011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272D0 RID: 160464 RVA: 0x0055DE20 File Offset: 0x0055C020
		public IOperationsAfterEntityGroupFailure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD92 RID: 44434
		// (get) Token: 0x060272D1 RID: 160465 RVA: 0x0055DE30 File Offset: 0x0055C030
		public bool IsResetState
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060272D2 RID: 160466 RVA: 0x0055DE70 File Offset: 0x0055C070
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD93 RID: 44435
		// (get) Token: 0x060272D3 RID: 160467 RVA: 0x0055DED0 File Offset: 0x0055C0D0
		public int ActionsLength
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

		// Token: 0x1700AD94 RID: 44436
		// (get) Token: 0x060272D4 RID: 160468 RVA: 0x0055DEFC File Offset: 0x0055C0FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060272D5 RID: 160469 RVA: 0x0055DF38 File Offset: 0x0055C138
		public static Offset<IOperationsAfterEntityGroupFailure> CreateIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder, bool IsResetState = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IOperationsAfterEntityGroupFailure.AddActions(builder, ActionsOffset);
			IOperationsAfterEntityGroupFailure.AddNullMask(builder, NullMask);
			IOperationsAfterEntityGroupFailure.AddIsResetState(builder, IsResetState);
			return IOperationsAfterEntityGroupFailure.EndIOperationsAfterEntityGroupFailure(builder);
		}

		// Token: 0x060272D6 RID: 160470 RVA: 0x0055DF5C File Offset: 0x0055C15C
		public static void StartIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060272D7 RID: 160471 RVA: 0x0055DF65 File Offset: 0x0055C165
		public static void AddIsResetState(FlatBufferBuilder builder, bool isResetState)
		{
			builder.AddBool(0, isResetState, false);
		}

		// Token: 0x060272D8 RID: 160472 RVA: 0x0055DF70 File Offset: 0x0055C170
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060272D9 RID: 160473 RVA: 0x0055DF80 File Offset: 0x0055C180
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060272DA RID: 160474 RVA: 0x0055DFC0 File Offset: 0x0055C1C0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060272DB RID: 160475 RVA: 0x0055DFDA File Offset: 0x0055C1DA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060272DC RID: 160476 RVA: 0x0055DFF8 File Offset: 0x0055C1F8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060272DD RID: 160477 RVA: 0x0055E011 File Offset: 0x0055C211
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060272DE RID: 160478 RVA: 0x0055E01C File Offset: 0x0055C21C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060272DF RID: 160479 RVA: 0x0055E027 File Offset: 0x0055C227
		public static Offset<IOperationsAfterEntityGroupFailure> EndIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder)
		{
			return new Offset<IOperationsAfterEntityGroupFailure>(builder.EndTable());
		}

		// Token: 0x060272E0 RID: 160480 RVA: 0x0055E034 File Offset: 0x0055C234
		public IOperationsAfterEntityGroupFailureT UnPack()
		{
			IOperationsAfterEntityGroupFailureT operationsAfterEntityGroupFailureT = new IOperationsAfterEntityGroupFailureT();
			this.UnPackTo(operationsAfterEntityGroupFailureT);
			return operationsAfterEntityGroupFailureT;
		}

		// Token: 0x060272E1 RID: 160481 RVA: 0x0055E050 File Offset: 0x0055C250
		public void UnPackTo(IOperationsAfterEntityGroupFailureT _o)
		{
			_o.IsResetState = this.IsResetState;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060272E2 RID: 160482 RVA: 0x0055E0C8 File Offset: 0x0055C2C8
		public static Offset<IOperationsAfterEntityGroupFailure> Pack(FlatBufferBuilder builder, IOperationsAfterEntityGroupFailureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOperationsAfterEntityGroupFailure>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IOperationsAfterEntityGroupFailure.CreateActionsVector(builder, array);
			}
			return IOperationsAfterEntityGroupFailure.CreateIOperationsAfterEntityGroupFailure(builder, _o.IsResetState, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400F73B RID: 63291
		private Table __p;
	}
}
