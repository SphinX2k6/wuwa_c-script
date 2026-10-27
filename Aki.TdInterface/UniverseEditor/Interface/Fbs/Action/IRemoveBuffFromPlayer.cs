using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3D RID: 28221
	public struct IRemoveBuffFromPlayer : IFlatbufferObject
	{
		// Token: 0x1700D24C RID: 53836
		// (get) Token: 0x06031DE2 RID: 204258 RVA: 0x006BFB24 File Offset: 0x006BDD24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DE3 RID: 204259 RVA: 0x006BFB31 File Offset: 0x006BDD31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DE4 RID: 204260 RVA: 0x006BFB38 File Offset: 0x006BDD38
		public static IRemoveBuffFromPlayer GetRootAsIRemoveBuffFromPlayer(ByteBuffer _bb)
		{
			return IRemoveBuffFromPlayer.GetRootAsIRemoveBuffFromPlayer(_bb, default(IRemoveBuffFromPlayer));
		}

		// Token: 0x06031DE5 RID: 204261 RVA: 0x006BFB54 File Offset: 0x006BDD54
		public static IRemoveBuffFromPlayer GetRootAsIRemoveBuffFromPlayer(ByteBuffer _bb, IRemoveBuffFromPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DE6 RID: 204262 RVA: 0x006BFB71 File Offset: 0x006BDD71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DE7 RID: 204263 RVA: 0x006BFB80 File Offset: 0x006BDD80
		public IRemoveBuffFromPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031DE8 RID: 204264 RVA: 0x006BFB90 File Offset: 0x006BDD90
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700D24D RID: 53837
		// (get) Token: 0x06031DE9 RID: 204265 RVA: 0x006BFBD0 File Offset: 0x006BDDD0
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

		// Token: 0x06031DEA RID: 204266 RVA: 0x006BFBFB File Offset: 0x006BDDFB
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06031DEB RID: 204267 RVA: 0x006BFC0A File Offset: 0x006BDE0A
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x06031DEC RID: 204268 RVA: 0x006BFC18 File Offset: 0x006BDE18
		public static Offset<IRemoveBuffFromPlayer> CreateIRemoveBuffFromPlayer(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRemoveBuffFromPlayer.AddBuffIds(builder, BuffIdsOffset);
			return IRemoveBuffFromPlayer.EndIRemoveBuffFromPlayer(builder);
		}

		// Token: 0x06031DED RID: 204269 RVA: 0x006BFC2E File Offset: 0x006BDE2E
		public static void StartIRemoveBuffFromPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031DEE RID: 204270 RVA: 0x006BFC37 File Offset: 0x006BDE37
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x06031DEF RID: 204271 RVA: 0x006BFC48 File Offset: 0x006BDE48
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031DF0 RID: 204272 RVA: 0x006BFC7F File Offset: 0x006BDE7F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DF1 RID: 204273 RVA: 0x006BFC99 File Offset: 0x006BDE99
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031DF2 RID: 204274 RVA: 0x006BFCB7 File Offset: 0x006BDEB7
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031DF3 RID: 204275 RVA: 0x006BFCD0 File Offset: 0x006BDED0
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06031DF4 RID: 204276 RVA: 0x006BFCDB File Offset: 0x006BDEDB
		public static Offset<IRemoveBuffFromPlayer> EndIRemoveBuffFromPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffFromPlayer>(builder.EndTable());
		}

		// Token: 0x06031DF5 RID: 204277 RVA: 0x006BFCE8 File Offset: 0x006BDEE8
		public IRemoveBuffFromPlayerT UnPack()
		{
			IRemoveBuffFromPlayerT removeBuffFromPlayerT = new IRemoveBuffFromPlayerT();
			this.UnPackTo(removeBuffFromPlayerT);
			return removeBuffFromPlayerT;
		}

		// Token: 0x06031DF6 RID: 204278 RVA: 0x006BFD04 File Offset: 0x006BDF04
		public void UnPackTo(IRemoveBuffFromPlayerT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x06031DF7 RID: 204279 RVA: 0x006BFD40 File Offset: 0x006BDF40
		public static Offset<IRemoveBuffFromPlayer> Pack(FlatBufferBuilder builder, IRemoveBuffFromPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveBuffFromPlayer>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IRemoveBuffFromPlayer.CreateBuffIdsVector(builder, data);
			}
			return IRemoveBuffFromPlayer.CreateIRemoveBuffFromPlayer(builder, buffIdsOffset);
		}

		// Token: 0x04011823 RID: 71715
		private Table __p;
	}
}
