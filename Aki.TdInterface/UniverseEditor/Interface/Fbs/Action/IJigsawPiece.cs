using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D2 RID: 27090
	public struct IJigsawPiece : IFlatbufferObject
	{
		// Token: 0x1700C904 RID: 51460
		// (get) Token: 0x0602F5AD RID: 193965 RVA: 0x00672F0F File Offset: 0x0067110F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5AE RID: 193966 RVA: 0x00672F1C File Offset: 0x0067111C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5AF RID: 193967 RVA: 0x00672F24 File Offset: 0x00671124
		public static IJigsawPiece GetRootAsIJigsawPiece(ByteBuffer _bb)
		{
			return IJigsawPiece.GetRootAsIJigsawPiece(_bb, default(IJigsawPiece));
		}

		// Token: 0x0602F5B0 RID: 193968 RVA: 0x00672F40 File Offset: 0x00671140
		public static IJigsawPiece GetRootAsIJigsawPiece(ByteBuffer _bb, IJigsawPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5B1 RID: 193969 RVA: 0x00672F5D File Offset: 0x0067115D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5B2 RID: 193970 RVA: 0x00672F6C File Offset: 0x0067116C
		public IJigsawPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C905 RID: 51461
		// (get) Token: 0x0602F5B3 RID: 193971 RVA: 0x00672F7C File Offset: 0x0067117C
		public IPieceIndex? Index
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C906 RID: 51462
		// (get) Token: 0x0602F5B4 RID: 193972 RVA: 0x00672FDC File Offset: 0x006711DC
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C907 RID: 51463
		// (get) Token: 0x0602F5B5 RID: 193973 RVA: 0x0067301C File Offset: 0x0067121C
		public bool IsCorrect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C908 RID: 51464
		// (get) Token: 0x0602F5B6 RID: 193974 RVA: 0x0067305C File Offset: 0x0067125C
		public EJigsawPieceState InitState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EJigsawPieceState.Disable;
				}
				return (EJigsawPieceState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F5B7 RID: 193975 RVA: 0x00673099 File Offset: 0x00671299
		public static Offset<IJigsawPiece> CreateIJigsawPiece(FlatBufferBuilder builder, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>), bool Active = false, bool IsCorrect = false, EJigsawPieceState InitState = EJigsawPieceState.Disable)
		{
			builder.StartTable(4);
			IJigsawPiece.AddIndex(builder, IndexOffset);
			IJigsawPiece.AddInitState(builder, InitState);
			IJigsawPiece.AddIsCorrect(builder, IsCorrect);
			IJigsawPiece.AddActive(builder, Active);
			return IJigsawPiece.EndIJigsawPiece(builder);
		}

		// Token: 0x0602F5B8 RID: 193976 RVA: 0x006730C5 File Offset: 0x006712C5
		public static void StartIJigsawPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F5B9 RID: 193977 RVA: 0x006730CE File Offset: 0x006712CE
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(0, indexOffset.Value, 0);
		}

		// Token: 0x0602F5BA RID: 193978 RVA: 0x006730DE File Offset: 0x006712DE
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x0602F5BB RID: 193979 RVA: 0x006730E9 File Offset: 0x006712E9
		public static void AddIsCorrect(FlatBufferBuilder builder, bool isCorrect)
		{
			builder.AddBool(2, isCorrect, false);
		}

		// Token: 0x0602F5BC RID: 193980 RVA: 0x006730F4 File Offset: 0x006712F4
		public static void AddInitState(FlatBufferBuilder builder, EJigsawPieceState initState)
		{
			builder.AddByte(3, (byte)initState, 0);
		}

		// Token: 0x0602F5BD RID: 193981 RVA: 0x006730FF File Offset: 0x006712FF
		public static Offset<IJigsawPiece> EndIJigsawPiece(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawPiece>(builder.EndTable());
		}

		// Token: 0x0602F5BE RID: 193982 RVA: 0x0067310C File Offset: 0x0067130C
		public IJigsawPieceT UnPack()
		{
			IJigsawPieceT jigsawPieceT = new IJigsawPieceT();
			this.UnPackTo(jigsawPieceT);
			return jigsawPieceT;
		}

		// Token: 0x0602F5BF RID: 193983 RVA: 0x00673128 File Offset: 0x00671328
		public void UnPackTo(IJigsawPieceT _o)
		{
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
			_o.Active = this.Active;
			_o.IsCorrect = this.IsCorrect;
			_o.InitState = this.InitState;
		}

		// Token: 0x0602F5C0 RID: 193984 RVA: 0x00673188 File Offset: 0x00671388
		public static Offset<IJigsawPiece> Pack(FlatBufferBuilder builder, IJigsawPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawPiece>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IJigsawPiece.CreateIJigsawPiece(builder, indexOffset, _o.Active, _o.IsCorrect, _o.InitState);
		}

		// Token: 0x04011190 RID: 70032
		private Table __p;
	}
}
