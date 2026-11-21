using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC1 RID: 24001
	public struct IPutInTheSpecifiedPiece : IFlatbufferObject
	{
		// Token: 0x1700B0C4 RID: 45252
		// (get) Token: 0x06028026 RID: 163878 RVA: 0x00578D1D File Offset: 0x00576F1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028027 RID: 163879 RVA: 0x00578D2A File Offset: 0x00576F2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028028 RID: 163880 RVA: 0x00578D34 File Offset: 0x00576F34
		public static IPutInTheSpecifiedPiece GetRootAsIPutInTheSpecifiedPiece(ByteBuffer _bb)
		{
			return IPutInTheSpecifiedPiece.GetRootAsIPutInTheSpecifiedPiece(_bb, default(IPutInTheSpecifiedPiece));
		}

		// Token: 0x06028029 RID: 163881 RVA: 0x00578D50 File Offset: 0x00576F50
		public static IPutInTheSpecifiedPiece GetRootAsIPutInTheSpecifiedPiece(ByteBuffer _bb, IPutInTheSpecifiedPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602802A RID: 163882 RVA: 0x00578D6D File Offset: 0x00576F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602802B RID: 163883 RVA: 0x00578D7C File Offset: 0x00576F7C
		public IPutInTheSpecifiedPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0C5 RID: 45253
		// (get) Token: 0x0602802C RID: 163884 RVA: 0x00578D8C File Offset: 0x00576F8C
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

		// Token: 0x0602802D RID: 163885 RVA: 0x00578DC8 File Offset: 0x00576FC8
		public IJigsawPieceMatch? MatchList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPieceMatch?(default(IJigsawPieceMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0C6 RID: 45254
		// (get) Token: 0x0602802E RID: 163886 RVA: 0x00578E28 File Offset: 0x00577028
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

		// Token: 0x0602802F RID: 163887 RVA: 0x00578E53 File Offset: 0x00577053
		public static Offset<IPutInTheSpecifiedPiece> CreateIPutInTheSpecifiedPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset MatchListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPutInTheSpecifiedPiece.AddMatchList(builder, MatchListOffset);
			IPutInTheSpecifiedPiece.AddType(builder, Type);
			return IPutInTheSpecifiedPiece.EndIPutInTheSpecifiedPiece(builder);
		}

		// Token: 0x06028030 RID: 163888 RVA: 0x00578E70 File Offset: 0x00577070
		public static void StartIPutInTheSpecifiedPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028031 RID: 163889 RVA: 0x00578E79 File Offset: 0x00577079
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028032 RID: 163890 RVA: 0x00578E84 File Offset: 0x00577084
		public static void AddMatchList(FlatBufferBuilder builder, VectorOffset matchListOffset)
		{
			builder.AddOffset(1, matchListOffset.Value, 0);
		}

		// Token: 0x06028033 RID: 163891 RVA: 0x00578E94 File Offset: 0x00577094
		public static VectorOffset CreateMatchListVector(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028034 RID: 163892 RVA: 0x00578ED4 File Offset: 0x005770D4
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPieceMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028035 RID: 163893 RVA: 0x00578EEE File Offset: 0x005770EE
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPieceMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPieceMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028036 RID: 163894 RVA: 0x00578F0C File Offset: 0x0057710C
		public static VectorOffset CreateMatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPieceMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028037 RID: 163895 RVA: 0x00578F25 File Offset: 0x00577125
		public static void StartMatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028038 RID: 163896 RVA: 0x00578F30 File Offset: 0x00577130
		public static Offset<IPutInTheSpecifiedPiece> EndIPutInTheSpecifiedPiece(FlatBufferBuilder builder)
		{
			return new Offset<IPutInTheSpecifiedPiece>(builder.EndTable());
		}

		// Token: 0x06028039 RID: 163897 RVA: 0x00578F40 File Offset: 0x00577140
		public IPutInTheSpecifiedPieceT UnPack()
		{
			IPutInTheSpecifiedPieceT putInTheSpecifiedPieceT = new IPutInTheSpecifiedPieceT();
			this.UnPackTo(putInTheSpecifiedPieceT);
			return putInTheSpecifiedPieceT;
		}

		// Token: 0x0602803A RID: 163898 RVA: 0x00578F5C File Offset: 0x0057715C
		public void UnPackTo(IPutInTheSpecifiedPieceT _o)
		{
			_o.Type = this.Type;
			_o.MatchList = new List<IJigsawPieceMatchT>();
			for (int i = 0; i < this.MatchListLength; i++)
			{
				_o.MatchList.Add((this.MatchList(i) != null) ? this.MatchList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602803B RID: 163899 RVA: 0x00578FC8 File Offset: 0x005771C8
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

		// Token: 0x0400F97E RID: 63870
		private Table __p;
	}
}
