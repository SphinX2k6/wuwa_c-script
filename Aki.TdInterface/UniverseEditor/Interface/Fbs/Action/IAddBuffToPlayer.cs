using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006122 RID: 24866
	public struct IAddBuffToPlayer : IFlatbufferObject
	{
		// Token: 0x1700B742 RID: 46914
		// (get) Token: 0x0602A7F1 RID: 174065 RVA: 0x005DA43C File Offset: 0x005D863C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A7F2 RID: 174066 RVA: 0x005DA449 File Offset: 0x005D8649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A7F3 RID: 174067 RVA: 0x005DA450 File Offset: 0x005D8650
		public static IAddBuffToPlayer GetRootAsIAddBuffToPlayer(ByteBuffer _bb)
		{
			return IAddBuffToPlayer.GetRootAsIAddBuffToPlayer(_bb, default(IAddBuffToPlayer));
		}

		// Token: 0x0602A7F4 RID: 174068 RVA: 0x005DA46C File Offset: 0x005D866C
		public static IAddBuffToPlayer GetRootAsIAddBuffToPlayer(ByteBuffer _bb, IAddBuffToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A7F5 RID: 174069 RVA: 0x005DA489 File Offset: 0x005D8689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A7F6 RID: 174070 RVA: 0x005DA498 File Offset: 0x005D8698
		public IAddBuffToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A7F7 RID: 174071 RVA: 0x005DA4A8 File Offset: 0x005D86A8
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B743 RID: 46915
		// (get) Token: 0x0602A7F8 RID: 174072 RVA: 0x005DA4E8 File Offset: 0x005D86E8
		public int BuffIdsLength
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

		// Token: 0x0602A7F9 RID: 174073 RVA: 0x005DA513 File Offset: 0x005D8713
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602A7FA RID: 174074 RVA: 0x005DA522 File Offset: 0x005D8722
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x0602A7FB RID: 174075 RVA: 0x005DA530 File Offset: 0x005D8730
		public long PersistOnDestroyBuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B744 RID: 46916
		// (get) Token: 0x0602A7FC RID: 174076 RVA: 0x005DA570 File Offset: 0x005D8770
		public int PersistOnDestroyBuffIdsLength
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

		// Token: 0x0602A7FD RID: 174077 RVA: 0x005DA59B File Offset: 0x005D879B
		public Span<long> GetPersistOnDestroyBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x0602A7FE RID: 174078 RVA: 0x005DA5AA File Offset: 0x005D87AA
		public long[] GetPersistOnDestroyBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x1700B745 RID: 46917
		// (get) Token: 0x0602A7FF RID: 174079 RVA: 0x005DA5B8 File Offset: 0x005D87B8
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

		// Token: 0x0602A800 RID: 174080 RVA: 0x005DA5F4 File Offset: 0x005D87F4
		public static Offset<IAddBuffToPlayer> CreateIAddBuffToPlayer(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset PersistOnDestroyBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddBuffToPlayer.AddPersistOnDestroyBuffIds(builder, PersistOnDestroyBuffIdsOffset);
			IAddBuffToPlayer.AddBuffIds(builder, BuffIdsOffset);
			IAddBuffToPlayer.AddNullMask(builder, NullMask);
			return IAddBuffToPlayer.EndIAddBuffToPlayer(builder);
		}

		// Token: 0x0602A801 RID: 174081 RVA: 0x005DA618 File Offset: 0x005D8818
		public static void StartIAddBuffToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A802 RID: 174082 RVA: 0x005DA621 File Offset: 0x005D8821
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602A803 RID: 174083 RVA: 0x005DA634 File Offset: 0x005D8834
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A804 RID: 174084 RVA: 0x005DA66B File Offset: 0x005D886B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A805 RID: 174085 RVA: 0x005DA685 File Offset: 0x005D8885
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A806 RID: 174086 RVA: 0x005DA6A3 File Offset: 0x005D88A3
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A807 RID: 174087 RVA: 0x005DA6BC File Offset: 0x005D88BC
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A808 RID: 174088 RVA: 0x005DA6C7 File Offset: 0x005D88C7
		public static void AddPersistOnDestroyBuffIds(FlatBufferBuilder builder, VectorOffset persistOnDestroyBuffIdsOffset)
		{
			builder.AddOffset(1, persistOnDestroyBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602A809 RID: 174089 RVA: 0x005DA6D8 File Offset: 0x005D88D8
		public static VectorOffset CreatePersistOnDestroyBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A80A RID: 174090 RVA: 0x005DA70F File Offset: 0x005D890F
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A80B RID: 174091 RVA: 0x005DA729 File Offset: 0x005D8929
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A80C RID: 174092 RVA: 0x005DA747 File Offset: 0x005D8947
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A80D RID: 174093 RVA: 0x005DA760 File Offset: 0x005D8960
		public static void StartPersistOnDestroyBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A80E RID: 174094 RVA: 0x005DA76B File Offset: 0x005D896B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A80F RID: 174095 RVA: 0x005DA776 File Offset: 0x005D8976
		public static Offset<IAddBuffToPlayer> EndIAddBuffToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToPlayer>(builder.EndTable());
		}

		// Token: 0x0602A810 RID: 174096 RVA: 0x005DA784 File Offset: 0x005D8984
		public IAddBuffToPlayerT UnPack()
		{
			IAddBuffToPlayerT addBuffToPlayerT = new IAddBuffToPlayerT();
			this.UnPackTo(addBuffToPlayerT);
			return addBuffToPlayerT;
		}

		// Token: 0x0602A811 RID: 174097 RVA: 0x005DA7A0 File Offset: 0x005D89A0
		public void UnPackTo(IAddBuffToPlayerT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
			_o.PersistOnDestroyBuffIds = new List<long>();
			for (int j = 0; j < this.PersistOnDestroyBuffIdsLength; j++)
			{
				_o.PersistOnDestroyBuffIds.Add(this.PersistOnDestroyBuffIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A812 RID: 174098 RVA: 0x005DA818 File Offset: 0x005D8A18
		public static Offset<IAddBuffToPlayer> Pack(FlatBufferBuilder builder, IAddBuffToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToPlayer>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToPlayer.CreateBuffIdsVector(builder, data);
			}
			VectorOffset persistOnDestroyBuffIdsOffset = default(VectorOffset);
			if (_o.PersistOnDestroyBuffIds != null)
			{
				long[] data2 = _o.PersistOnDestroyBuffIds.ToArray();
				persistOnDestroyBuffIdsOffset = IAddBuffToPlayer.CreatePersistOnDestroyBuffIdsVector(builder, data2);
			}
			return IAddBuffToPlayer.CreateIAddBuffToPlayer(builder, buffIdsOffset, persistOnDestroyBuffIdsOffset, _o.NullMask);
		}

		// Token: 0x040104F4 RID: 66804
		private Table __p;
	}
}
