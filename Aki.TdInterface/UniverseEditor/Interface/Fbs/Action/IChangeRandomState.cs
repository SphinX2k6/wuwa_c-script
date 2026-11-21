using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698B RID: 27019
	public struct IChangeRandomState : IFlatbufferObject
	{
		// Token: 0x1700C6EF RID: 50927
		// (get) Token: 0x0602E580 RID: 189824 RVA: 0x006539E6 File Offset: 0x00651BE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E581 RID: 189825 RVA: 0x006539F3 File Offset: 0x00651BF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E582 RID: 189826 RVA: 0x006539FC File Offset: 0x00651BFC
		public static IChangeRandomState GetRootAsIChangeRandomState(ByteBuffer _bb)
		{
			return IChangeRandomState.GetRootAsIChangeRandomState(_bb, default(IChangeRandomState));
		}

		// Token: 0x0602E583 RID: 189827 RVA: 0x00653A18 File Offset: 0x00651C18
		public static IChangeRandomState GetRootAsIChangeRandomState(ByteBuffer _bb, IChangeRandomState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E584 RID: 189828 RVA: 0x00653A35 File Offset: 0x00651C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E585 RID: 189829 RVA: 0x00653A44 File Offset: 0x00651C44
		public IChangeRandomState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E586 RID: 189830 RVA: 0x00653A54 File Offset: 0x00651C54
		public int StateIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C6F0 RID: 50928
		// (get) Token: 0x0602E587 RID: 189831 RVA: 0x00653A94 File Offset: 0x00651C94
		public int StateIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602E588 RID: 189832 RVA: 0x00653ABF File Offset: 0x00651CBF
		public Span<int> GetStateIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602E589 RID: 189833 RVA: 0x00653ACE File Offset: 0x00651CCE
		public int[] GetStateIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602E58A RID: 189834 RVA: 0x00653ADC File Offset: 0x00651CDC
		public static Offset<IChangeRandomState> CreateIChangeRandomState(FlatBufferBuilder builder, VectorOffset StateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IChangeRandomState.AddStateIds(builder, StateIdsOffset);
			return IChangeRandomState.EndIChangeRandomState(builder);
		}

		// Token: 0x0602E58B RID: 189835 RVA: 0x00653AF2 File Offset: 0x00651CF2
		public static void StartIChangeRandomState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E58C RID: 189836 RVA: 0x00653AFB File Offset: 0x00651CFB
		public static void AddStateIds(FlatBufferBuilder builder, VectorOffset stateIdsOffset)
		{
			builder.AddOffset(0, stateIdsOffset.Value, 0);
		}

		// Token: 0x0602E58D RID: 189837 RVA: 0x00653B0C File Offset: 0x00651D0C
		public static VectorOffset CreateStateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E58E RID: 189838 RVA: 0x00653B43 File Offset: 0x00651D43
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E58F RID: 189839 RVA: 0x00653B5D File Offset: 0x00651D5D
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E590 RID: 189840 RVA: 0x00653B7B File Offset: 0x00651D7B
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E591 RID: 189841 RVA: 0x00653B94 File Offset: 0x00651D94
		public static void StartStateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E592 RID: 189842 RVA: 0x00653B9F File Offset: 0x00651D9F
		public static Offset<IChangeRandomState> EndIChangeRandomState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeRandomState>(builder.EndTable());
		}

		// Token: 0x0602E593 RID: 189843 RVA: 0x00653BAC File Offset: 0x00651DAC
		public IChangeRandomStateT UnPack()
		{
			IChangeRandomStateT changeRandomStateT = new IChangeRandomStateT();
			this.UnPackTo(changeRandomStateT);
			return changeRandomStateT;
		}

		// Token: 0x0602E594 RID: 189844 RVA: 0x00653BC8 File Offset: 0x00651DC8
		public void UnPackTo(IChangeRandomStateT _o)
		{
			_o.StateIds = new List<int>();
			for (int i = 0; i < this.StateIdsLength; i++)
			{
				_o.StateIds.Add(this.StateIds(i));
			}
		}

		// Token: 0x0602E595 RID: 189845 RVA: 0x00653C04 File Offset: 0x00651E04
		public static Offset<IChangeRandomState> Pack(FlatBufferBuilder builder, IChangeRandomStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeRandomState>);
			}
			VectorOffset stateIdsOffset = default(VectorOffset);
			if (_o.StateIds != null)
			{
				int[] data = _o.StateIds.ToArray();
				stateIdsOffset = IChangeRandomState.CreateStateIdsVector(builder, data);
			}
			return IChangeRandomState.CreateIChangeRandomState(builder, stateIdsOffset);
		}

		// Token: 0x040116F4 RID: 71412
		private Table __p;
	}
}
