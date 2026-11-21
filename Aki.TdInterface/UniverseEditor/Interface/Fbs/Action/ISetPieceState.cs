using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007815 RID: 30741
	public struct ISetPieceState : IFlatbufferObject
	{
		// Token: 0x1700E162 RID: 57698
		// (get) Token: 0x06036072 RID: 221298 RVA: 0x0073CBEC File Offset: 0x0073ADEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036073 RID: 221299 RVA: 0x0073CBF9 File Offset: 0x0073ADF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036074 RID: 221300 RVA: 0x0073CC00 File Offset: 0x0073AE00
		public static ISetPieceState GetRootAsISetPieceState(ByteBuffer _bb)
		{
			return ISetPieceState.GetRootAsISetPieceState(_bb, default(ISetPieceState));
		}

		// Token: 0x06036075 RID: 221301 RVA: 0x0073CC1C File Offset: 0x0073AE1C
		public static ISetPieceState GetRootAsISetPieceState(ByteBuffer _bb, ISetPieceState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036076 RID: 221302 RVA: 0x0073CC39 File Offset: 0x0073AE39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036077 RID: 221303 RVA: 0x0073CC48 File Offset: 0x0073AE48
		public ISetPieceState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E163 RID: 57699
		// (get) Token: 0x06036078 RID: 221304 RVA: 0x0073CC58 File Offset: 0x0073AE58
		public ESetJigsawFoundationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return (ESetJigsawFoundationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E164 RID: 57700
		// (get) Token: 0x06036079 RID: 221305 RVA: 0x0073CC94 File Offset: 0x0073AE94
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603607A RID: 221306 RVA: 0x0073CCD0 File Offset: 0x0073AED0
		public IJigsawPiece? PieceState(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPiece?(default(IJigsawPiece).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E165 RID: 57701
		// (get) Token: 0x0603607B RID: 221307 RVA: 0x0073CD30 File Offset: 0x0073AF30
		public int PieceStateLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603607C RID: 221308 RVA: 0x0073CD5B File Offset: 0x0073AF5B
		public static Offset<ISetPieceState> CreateISetPieceState(FlatBufferBuilder builder, ESetJigsawFoundationType Type = ESetJigsawFoundationType.SetPieceState, int EntityId = 0, VectorOffset PieceStateOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISetPieceState.AddPieceState(builder, PieceStateOffset);
			ISetPieceState.AddEntityId(builder, EntityId);
			ISetPieceState.AddType(builder, Type);
			return ISetPieceState.EndISetPieceState(builder);
		}

		// Token: 0x0603607D RID: 221309 RVA: 0x0073CD7F File Offset: 0x0073AF7F
		public static void StartISetPieceState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603607E RID: 221310 RVA: 0x0073CD88 File Offset: 0x0073AF88
		public static void AddType(FlatBufferBuilder builder, ESetJigsawFoundationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603607F RID: 221311 RVA: 0x0073CD93 File Offset: 0x0073AF93
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06036080 RID: 221312 RVA: 0x0073CD9E File Offset: 0x0073AF9E
		public static void AddPieceState(FlatBufferBuilder builder, VectorOffset pieceStateOffset)
		{
			builder.AddOffset(2, pieceStateOffset.Value, 0);
		}

		// Token: 0x06036081 RID: 221313 RVA: 0x0073CDB0 File Offset: 0x0073AFB0
		public static VectorOffset CreatePieceStateVector(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036082 RID: 221314 RVA: 0x0073CDF0 File Offset: 0x0073AFF0
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036083 RID: 221315 RVA: 0x0073CE0A File Offset: 0x0073B00A
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPiece>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036084 RID: 221316 RVA: 0x0073CE28 File Offset: 0x0073B028
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPiece>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036085 RID: 221317 RVA: 0x0073CE41 File Offset: 0x0073B041
		public static void StartPieceStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036086 RID: 221318 RVA: 0x0073CE4C File Offset: 0x0073B04C
		public static Offset<ISetPieceState> EndISetPieceState(FlatBufferBuilder builder)
		{
			return new Offset<ISetPieceState>(builder.EndTable());
		}

		// Token: 0x06036087 RID: 221319 RVA: 0x0073CE5C File Offset: 0x0073B05C
		public ISetPieceStateT UnPack()
		{
			ISetPieceStateT setPieceStateT = new ISetPieceStateT();
			this.UnPackTo(setPieceStateT);
			return setPieceStateT;
		}

		// Token: 0x06036088 RID: 221320 RVA: 0x0073CE78 File Offset: 0x0073B078
		public void UnPackTo(ISetPieceStateT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PieceState = new List<IJigsawPieceT>();
			for (int i = 0; i < this.PieceStateLength; i++)
			{
				_o.PieceState.Add((this.PieceState(i) != null) ? this.PieceState(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036089 RID: 221321 RVA: 0x0073CEF0 File Offset: 0x0073B0F0
		public static Offset<ISetPieceState> Pack(FlatBufferBuilder builder, ISetPieceStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPieceState>);
			}
			VectorOffset pieceStateOffset = default(VectorOffset);
			if (_o.PieceState != null)
			{
				Offset<IJigsawPiece>[] array = new Offset<IJigsawPiece>[_o.PieceState.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IJigsawPiece.Pack(builder, _o.PieceState[i]);
				}
				pieceStateOffset = ISetPieceState.CreatePieceStateVector(builder, array);
			}
			return ISetPieceState.CreateISetPieceState(builder, _o.Type, _o.EntityId, pieceStateOffset);
		}

		// Token: 0x04012A78 RID: 76408
		private Table __p;
	}
}
