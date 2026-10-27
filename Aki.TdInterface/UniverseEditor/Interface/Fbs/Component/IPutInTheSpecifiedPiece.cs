using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BA RID: 22458
	public struct IPutInTheSpecifiedPiece : IFlatbufferObject
	{
		// Token: 0x1700A7A0 RID: 42912
		// (get) Token: 0x06025B06 RID: 154374 RVA: 0x00532B91 File Offset: 0x00530D91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B07 RID: 154375 RVA: 0x00532B9E File Offset: 0x00530D9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B08 RID: 154376 RVA: 0x00532BA8 File Offset: 0x00530DA8
		public static IPutInTheSpecifiedPiece GetRootAsIPutInTheSpecifiedPiece(ByteBuffer _bb)
		{
			return IPutInTheSpecifiedPiece.GetRootAsIPutInTheSpecifiedPiece(_bb, default(IPutInTheSpecifiedPiece));
		}

		// Token: 0x06025B09 RID: 154377 RVA: 0x00532BC4 File Offset: 0x00530DC4
		public static IPutInTheSpecifiedPiece GetRootAsIPutInTheSpecifiedPiece(ByteBuffer _bb, IPutInTheSpecifiedPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B0A RID: 154378 RVA: 0x00532BE1 File Offset: 0x00530DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B0B RID: 154379 RVA: 0x00532BF0 File Offset: 0x00530DF0
		public IPutInTheSpecifiedPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7A1 RID: 42913
		// (get) Token: 0x06025B0C RID: 154380 RVA: 0x00532C00 File Offset: 0x00530E00
		public EJigsawCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return (EJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B0D RID: 154381 RVA: 0x00532C3C File Offset: 0x00530E3C
		public IJigsawPieceMatch? MatchList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPieceMatch?(default(IJigsawPieceMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7A2 RID: 42914
		// (get) Token: 0x06025B0E RID: 154382 RVA: 0x00532C9C File Offset: 0x00530E9C
		public int MatchListLength
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

		// Token: 0x06025B0F RID: 154383 RVA: 0x00532CC7 File Offset: 0x00530EC7
		public static Offset<IPutInTheSpecifiedPiece> CreateIPutInTheSpecifiedPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset MatchListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPutInTheSpecifiedPiece.AddMatchList(builder, MatchListOffset);
			IPutInTheSpecifiedPiece.AddType(builder, Type);
			return IPutInTheSpecifiedPiece.EndIPutInTheSpecifiedPiece(builder);
		}

		// Token: 0x06025B10 RID: 154384 RVA: 0x00532CE4 File Offset: 0x00530EE4
		public static void StartIPutInTheSpecifiedPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025B11 RID: 154385 RVA: 0x00532CED File Offset: 0x00530EED
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025B12 RID: 154386 RVA: 0x00532CF8 File Offset: 0x00530EF8
		public static void AddMatchList(FlatBufferBuilder builder, VectorOffset matchListOffset)
		{
			builder.AddOffset(1, matchListOffset.Value, 0);
		}

		// Token: 0x06025B13 RID: 154387 RVA: 0x00532D08 File Offset: 0x00530F08
		public static VectorOffset CreateMatchListVector(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025B14 RID: 154388 RVA: 0x00532D48 File Offset: 0x00530F48
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B15 RID: 154389 RVA: 0x00532D62 File Offset: 0x00530F62
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPieceMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B16 RID: 154390 RVA: 0x00532D80 File Offset: 0x00530F80
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPieceMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025B17 RID: 154391 RVA: 0x00532D99 File Offset: 0x00530F99
		public static void StartMatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025B18 RID: 154392 RVA: 0x00532DA4 File Offset: 0x00530FA4
		public static Offset<IPutInTheSpecifiedPiece> EndIPutInTheSpecifiedPiece(FlatBufferBuilder builder)
		{
			return new Offset<IPutInTheSpecifiedPiece>(builder.EndTable());
		}

		// Token: 0x06025B19 RID: 154393 RVA: 0x00532DB4 File Offset: 0x00530FB4
		public IPutInTheSpecifiedPieceT UnPack()
		{
			IPutInTheSpecifiedPieceT putInTheSpecifiedPieceT = new IPutInTheSpecifiedPieceT();
			this.UnPackTo(putInTheSpecifiedPieceT);
			return putInTheSpecifiedPieceT;
		}

		// Token: 0x06025B1A RID: 154394 RVA: 0x00532DD0 File Offset: 0x00530FD0
		public void UnPackTo(IPutInTheSpecifiedPieceT _o)
		{
			_o.Type = this.Type;
			_o.MatchList = new List<IJigsawPieceMatchT>();
			for (int i = 0; i < this.MatchListLength; i++)
			{
				_o.MatchList.Add((this.MatchList(i) != null) ? this.MatchList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025B1B RID: 154395 RVA: 0x00532E3C File Offset: 0x0053103C
		public static Offset<IPutInTheSpecifiedPiece> Pack(FlatBufferBuilder builder, IPutInTheSpecifiedPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPutInTheSpecifiedPiece>);
			}
			VectorOffset matchListOffset = default(VectorOffset);
			if (_o.MatchList != null)
			{
				Offset<IJigsawPieceMatch>[] array = new Offset<IJigsawPieceMatch>[_o.MatchList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IJigsawPieceMatch.Pack(builder, _o.MatchList[i]);
				}
				matchListOffset = IPutInTheSpecifiedPiece.CreateMatchListVector(builder, array);
			}
			return IPutInTheSpecifiedPiece.CreateIPutInTheSpecifiedPiece(builder, _o.Type, matchListOffset);
		}

		// Token: 0x0400EC93 RID: 60563
		private Table __p;
	}
}
