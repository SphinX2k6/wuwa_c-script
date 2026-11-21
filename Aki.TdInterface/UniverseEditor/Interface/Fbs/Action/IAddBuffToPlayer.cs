using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006784 RID: 26500
	public struct IAddBuffToPlayer : IFlatbufferObject
	{
		// Token: 0x1700C0AD RID: 49325
		// (get) Token: 0x0602CED2 RID: 184018 RVA: 0x006243E4 File Offset: 0x006225E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CED3 RID: 184019 RVA: 0x006243F1 File Offset: 0x006225F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CED4 RID: 184020 RVA: 0x006243F8 File Offset: 0x006225F8
		public static IAddBuffToPlayer GetRootAsIAddBuffToPlayer(ByteBuffer _bb)
		{
			return IAddBuffToPlayer.GetRootAsIAddBuffToPlayer(_bb, default(IAddBuffToPlayer));
		}

		// Token: 0x0602CED5 RID: 184021 RVA: 0x00624414 File Offset: 0x00622614
		public static IAddBuffToPlayer GetRootAsIAddBuffToPlayer(ByteBuffer _bb, IAddBuffToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CED6 RID: 184022 RVA: 0x00624431 File Offset: 0x00622631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CED7 RID: 184023 RVA: 0x00624440 File Offset: 0x00622640
		public IAddBuffToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CED8 RID: 184024 RVA: 0x00624450 File Offset: 0x00622650
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C0AE RID: 49326
		// (get) Token: 0x0602CED9 RID: 184025 RVA: 0x00624490 File Offset: 0x00622690
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

		// Token: 0x0602CEDA RID: 184026 RVA: 0x006244BB File Offset: 0x006226BB
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602CEDB RID: 184027 RVA: 0x006244CA File Offset: 0x006226CA
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x0602CEDC RID: 184028 RVA: 0x006244D8 File Offset: 0x006226D8
		public long PersistOnDestroyBuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C0AF RID: 49327
		// (get) Token: 0x0602CEDD RID: 184029 RVA: 0x00624518 File Offset: 0x00622718
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

		// Token: 0x0602CEDE RID: 184030 RVA: 0x00624543 File Offset: 0x00622743
		public Span<long> GetPersistOnDestroyBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x0602CEDF RID: 184031 RVA: 0x00624552 File Offset: 0x00622752
		public long[] GetPersistOnDestroyBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x1700C0B0 RID: 49328
		// (get) Token: 0x0602CEE0 RID: 184032 RVA: 0x00624560 File Offset: 0x00622760
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

		// Token: 0x0602CEE1 RID: 184033 RVA: 0x0062459C File Offset: 0x0062279C
		public static Offset<IAddBuffToPlayer> CreateIAddBuffToPlayer(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset PersistOnDestroyBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddBuffToPlayer.AddPersistOnDestroyBuffIds(builder, PersistOnDestroyBuffIdsOffset);
			IAddBuffToPlayer.AddBuffIds(builder, BuffIdsOffset);
			IAddBuffToPlayer.AddNullMask(builder, NullMask);
			return IAddBuffToPlayer.EndIAddBuffToPlayer(builder);
		}

		// Token: 0x0602CEE2 RID: 184034 RVA: 0x006245C0 File Offset: 0x006227C0
		public static void StartIAddBuffToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CEE3 RID: 184035 RVA: 0x006245C9 File Offset: 0x006227C9
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602CEE4 RID: 184036 RVA: 0x006245DC File Offset: 0x006227DC
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CEE5 RID: 184037 RVA: 0x00624613 File Offset: 0x00622813
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEE6 RID: 184038 RVA: 0x0062462D File Offset: 0x0062282D
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEE7 RID: 184039 RVA: 0x0062464B File Offset: 0x0062284B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CEE8 RID: 184040 RVA: 0x00624664 File Offset: 0x00622864
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CEE9 RID: 184041 RVA: 0x0062466F File Offset: 0x0062286F
		public static void AddPersistOnDestroyBuffIds(FlatBufferBuilder builder, VectorOffset persistOnDestroyBuffIdsOffset)
		{
			builder.AddOffset(1, persistOnDestroyBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602CEEA RID: 184042 RVA: 0x00624680 File Offset: 0x00622880
		public static VectorOffset CreatePersistOnDestroyBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CEEB RID: 184043 RVA: 0x006246B7 File Offset: 0x006228B7
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEEC RID: 184044 RVA: 0x006246D1 File Offset: 0x006228D1
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEED RID: 184045 RVA: 0x006246EF File Offset: 0x006228EF
		public static VectorOffset CreatePersistOnDestroyBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CEEE RID: 184046 RVA: 0x00624708 File Offset: 0x00622908
		public static void StartPersistOnDestroyBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CEEF RID: 184047 RVA: 0x00624713 File Offset: 0x00622913
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CEF0 RID: 184048 RVA: 0x0062471E File Offset: 0x0062291E
		public static Offset<IAddBuffToPlayer> EndIAddBuffToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToPlayer>(builder.EndTable());
		}

		// Token: 0x0602CEF1 RID: 184049 RVA: 0x0062472C File Offset: 0x0062292C
		public IAddBuffToPlayerT UnPack()
		{
			IAddBuffToPlayerT addBuffToPlayerT = new IAddBuffToPlayerT();
			this.UnPackTo(addBuffToPlayerT);
			return addBuffToPlayerT;
		}

		// Token: 0x0602CEF2 RID: 184050 RVA: 0x00624748 File Offset: 0x00622948
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

		// Token: 0x0602CEF3 RID: 184051 RVA: 0x006247C0 File Offset: 0x006229C0
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

		// Token: 0x040112F8 RID: 70392
		private Table __p;
	}
}
