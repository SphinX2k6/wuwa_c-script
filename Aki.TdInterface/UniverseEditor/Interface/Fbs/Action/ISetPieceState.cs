using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007049 RID: 28745
	public struct ISetPieceState : IFlatbufferObject
	{
		// Token: 0x1700D581 RID: 54657
		// (get) Token: 0x06032DD5 RID: 208341 RVA: 0x006DC6C4 File Offset: 0x006DA8C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032DD6 RID: 208342 RVA: 0x006DC6D1 File Offset: 0x006DA8D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032DD7 RID: 208343 RVA: 0x006DC6D8 File Offset: 0x006DA8D8
		public static ISetPieceState GetRootAsISetPieceState(ByteBuffer _bb)
		{
			return ISetPieceState.GetRootAsISetPieceState(_bb, default(ISetPieceState));
		}

		// Token: 0x06032DD8 RID: 208344 RVA: 0x006DC6F4 File Offset: 0x006DA8F4
		public static ISetPieceState GetRootAsISetPieceState(ByteBuffer _bb, ISetPieceState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032DD9 RID: 208345 RVA: 0x006DC711 File Offset: 0x006DA911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032DDA RID: 208346 RVA: 0x006DC720 File Offset: 0x006DA920
		public ISetPieceState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D582 RID: 54658
		// (get) Token: 0x06032DDB RID: 208347 RVA: 0x006DC730 File Offset: 0x006DA930
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

		// Token: 0x1700D583 RID: 54659
		// (get) Token: 0x06032DDC RID: 208348 RVA: 0x006DC76C File Offset: 0x006DA96C
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

		// Token: 0x06032DDD RID: 208349 RVA: 0x006DC7A8 File Offset: 0x006DA9A8
		public IJigsawPiece? PieceState(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawPiece?(default(IJigsawPiece).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D584 RID: 54660
		// (get) Token: 0x06032DDE RID: 208350 RVA: 0x006DC808 File Offset: 0x006DAA08
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

		// Token: 0x06032DDF RID: 208351 RVA: 0x006DC833 File Offset: 0x006DAA33
		public static Offset<ISetPieceState> CreateISetPieceState(FlatBufferBuilder builder, ESetJigsawFoundationType Type = ESetJigsawFoundationType.SetPieceState, int EntityId = 0, VectorOffset PieceStateOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISetPieceState.AddPieceState(builder, PieceStateOffset);
			ISetPieceState.AddEntityId(builder, EntityId);
			ISetPieceState.AddType(builder, Type);
			return ISetPieceState.EndISetPieceState(builder);
		}

		// Token: 0x06032DE0 RID: 208352 RVA: 0x006DC857 File Offset: 0x006DAA57
		public static void StartISetPieceState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032DE1 RID: 208353 RVA: 0x006DC860 File Offset: 0x006DAA60
		public static void AddType(FlatBufferBuilder builder, ESetJigsawFoundationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032DE2 RID: 208354 RVA: 0x006DC86B File Offset: 0x006DAA6B
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06032DE3 RID: 208355 RVA: 0x006DC876 File Offset: 0x006DAA76
		public static void AddPieceState(FlatBufferBuilder builder, VectorOffset pieceStateOffset)
		{
			builder.AddOffset(2, pieceStateOffset.Value, 0);
		}

		// Token: 0x06032DE4 RID: 208356 RVA: 0x006DC888 File Offset: 0x006DAA88
		public static VectorOffset CreatePieceStateVector(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032DE5 RID: 208357 RVA: 0x006DC8C8 File Offset: 0x006DAAC8
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, Offset<IJigsawPiece>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032DE6 RID: 208358 RVA: 0x006DC8E2 File Offset: 0x006DAAE2
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawPiece>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawPiece>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032DE7 RID: 208359 RVA: 0x006DC900 File Offset: 0x006DAB00
		public static VectorOffset CreatePieceStateVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawPiece>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032DE8 RID: 208360 RVA: 0x006DC919 File Offset: 0x006DAB19
		public static void StartPieceStateVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032DE9 RID: 208361 RVA: 0x006DC924 File Offset: 0x006DAB24
		public static Offset<ISetPieceState> EndISetPieceState(FlatBufferBuilder builder)
		{
			return new Offset<ISetPieceState>(builder.EndTable());
		}

		// Token: 0x06032DEA RID: 208362 RVA: 0x006DC934 File Offset: 0x006DAB34
		public ISetPieceStateT UnPack()
		{
			ISetPieceStateT setPieceStateT = new ISetPieceStateT();
			this.UnPackTo(setPieceStateT);
			return setPieceStateT;
		}

		// Token: 0x06032DEB RID: 208363 RVA: 0x006DC950 File Offset: 0x006DAB50
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

		// Token: 0x06032DEC RID: 208364 RVA: 0x006DC9C8 File Offset: 0x006DABC8
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

		// Token: 0x04011A8B RID: 72331
		private Table __p;
	}
}
