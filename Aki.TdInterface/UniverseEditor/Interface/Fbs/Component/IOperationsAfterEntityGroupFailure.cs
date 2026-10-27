using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AA RID: 22186
	public struct IOperationsAfterEntityGroupFailure : IFlatbufferObject
	{
		// Token: 0x1700A4FD RID: 42237
		// (get) Token: 0x06025076 RID: 151670 RVA: 0x0051CE7C File Offset: 0x0051B07C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025077 RID: 151671 RVA: 0x0051CE89 File Offset: 0x0051B089
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025078 RID: 151672 RVA: 0x0051CE90 File Offset: 0x0051B090
		public static IOperationsAfterEntityGroupFailure GetRootAsIOperationsAfterEntityGroupFailure(ByteBuffer _bb)
		{
			return IOperationsAfterEntityGroupFailure.GetRootAsIOperationsAfterEntityGroupFailure(_bb, default(IOperationsAfterEntityGroupFailure));
		}

		// Token: 0x06025079 RID: 151673 RVA: 0x0051CEAC File Offset: 0x0051B0AC
		public static IOperationsAfterEntityGroupFailure GetRootAsIOperationsAfterEntityGroupFailure(ByteBuffer _bb, IOperationsAfterEntityGroupFailure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602507A RID: 151674 RVA: 0x0051CEC9 File Offset: 0x0051B0C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602507B RID: 151675 RVA: 0x0051CED8 File Offset: 0x0051B0D8
		public IOperationsAfterEntityGroupFailure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4FE RID: 42238
		// (get) Token: 0x0602507C RID: 151676 RVA: 0x0051CEE8 File Offset: 0x0051B0E8
		public bool IsResetState
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602507D RID: 151677 RVA: 0x0051CF28 File Offset: 0x0051B128
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A4FF RID: 42239
		// (get) Token: 0x0602507E RID: 151678 RVA: 0x0051CF88 File Offset: 0x0051B188
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

		// Token: 0x1700A500 RID: 42240
		// (get) Token: 0x0602507F RID: 151679 RVA: 0x0051CFB4 File Offset: 0x0051B1B4
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

		// Token: 0x06025080 RID: 151680 RVA: 0x0051CFF0 File Offset: 0x0051B1F0
		public static Offset<IOperationsAfterEntityGroupFailure> CreateIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder, bool IsResetState = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IOperationsAfterEntityGroupFailure.AddActions(builder, ActionsOffset);
			IOperationsAfterEntityGroupFailure.AddNullMask(builder, NullMask);
			IOperationsAfterEntityGroupFailure.AddIsResetState(builder, IsResetState);
			return IOperationsAfterEntityGroupFailure.EndIOperationsAfterEntityGroupFailure(builder);
		}

		// Token: 0x06025081 RID: 151681 RVA: 0x0051D014 File Offset: 0x0051B214
		public static void StartIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025082 RID: 151682 RVA: 0x0051D01D File Offset: 0x0051B21D
		public static void AddIsResetState(FlatBufferBuilder builder, bool isResetState)
		{
			builder.AddBool(0, isResetState, false);
		}

		// Token: 0x06025083 RID: 151683 RVA: 0x0051D028 File Offset: 0x0051B228
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06025084 RID: 151684 RVA: 0x0051D038 File Offset: 0x0051B238
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025085 RID: 151685 RVA: 0x0051D078 File Offset: 0x0051B278
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025086 RID: 151686 RVA: 0x0051D092 File Offset: 0x0051B292
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025087 RID: 151687 RVA: 0x0051D0B0 File Offset: 0x0051B2B0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025088 RID: 151688 RVA: 0x0051D0C9 File Offset: 0x0051B2C9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025089 RID: 151689 RVA: 0x0051D0D4 File Offset: 0x0051B2D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602508A RID: 151690 RVA: 0x0051D0DF File Offset: 0x0051B2DF
		public static Offset<IOperationsAfterEntityGroupFailure> EndIOperationsAfterEntityGroupFailure(FlatBufferBuilder builder)
		{
			return new Offset<IOperationsAfterEntityGroupFailure>(builder.EndTable());
		}

		// Token: 0x0602508B RID: 151691 RVA: 0x0051D0EC File Offset: 0x0051B2EC
		public IOperationsAfterEntityGroupFailureT UnPack()
		{
			IOperationsAfterEntityGroupFailureT operationsAfterEntityGroupFailureT = new IOperationsAfterEntityGroupFailureT();
			this.UnPackTo(operationsAfterEntityGroupFailureT);
			return operationsAfterEntityGroupFailureT;
		}

		// Token: 0x0602508C RID: 151692 RVA: 0x0051D108 File Offset: 0x0051B308
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

		// Token: 0x0602508D RID: 151693 RVA: 0x0051D180 File Offset: 0x0051B380
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

		// Token: 0x0400EACF RID: 60111
		private Table __p;
	}
}
