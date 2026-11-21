using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007082 RID: 28802
	public struct IJigsawPiece : IFlatbufferObject
	{
		// Token: 0x1700D304 RID: 54020
		// (get) Token: 0x06031F6D RID: 204653 RVA: 0x006C3267 File Offset: 0x006C1467
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F6E RID: 204654 RVA: 0x006C3274 File Offset: 0x006C1474
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F6F RID: 204655 RVA: 0x006C327C File Offset: 0x006C147C
		public static IJigsawPiece GetRootAsIJigsawPiece(ByteBuffer _bb)
		{
			return IJigsawPiece.GetRootAsIJigsawPiece(_bb, default(IJigsawPiece));
		}

		// Token: 0x06031F70 RID: 204656 RVA: 0x006C3298 File Offset: 0x006C1498
		public static IJigsawPiece GetRootAsIJigsawPiece(ByteBuffer _bb, IJigsawPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F71 RID: 204657 RVA: 0x006C32B5 File Offset: 0x006C14B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F72 RID: 204658 RVA: 0x006C32C4 File Offset: 0x006C14C4
		public IJigsawPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D305 RID: 54021
		// (get) Token: 0x06031F73 RID: 204659 RVA: 0x006C32D4 File Offset: 0x006C14D4
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

		// Token: 0x1700D306 RID: 54022
		// (get) Token: 0x06031F74 RID: 204660 RVA: 0x006C3334 File Offset: 0x006C1534
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D307 RID: 54023
		// (get) Token: 0x06031F75 RID: 204661 RVA: 0x006C3374 File Offset: 0x006C1574
		public bool IsCorrect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D308 RID: 54024
		// (get) Token: 0x06031F76 RID: 204662 RVA: 0x006C33B4 File Offset: 0x006C15B4
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

		// Token: 0x06031F77 RID: 204663 RVA: 0x006C33F1 File Offset: 0x006C15F1
		public static Offset<IJigsawPiece> CreateIJigsawPiece(FlatBufferBuilder builder, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>), bool Active = false, bool IsCorrect = false, EJigsawPieceState InitState = EJigsawPieceState.Disable)
		{
			builder.StartTable(4);
			IJigsawPiece.AddIndex(builder, IndexOffset);
			IJigsawPiece.AddInitState(builder, InitState);
			IJigsawPiece.AddIsCorrect(builder, IsCorrect);
			IJigsawPiece.AddActive(builder, Active);
			return IJigsawPiece.EndIJigsawPiece(builder);
		}

		// Token: 0x06031F78 RID: 204664 RVA: 0x006C341D File Offset: 0x006C161D
		public static void StartIJigsawPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031F79 RID: 204665 RVA: 0x006C3426 File Offset: 0x006C1626
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(0, indexOffset.Value, 0);
		}

		// Token: 0x06031F7A RID: 204666 RVA: 0x006C3436 File Offset: 0x006C1636
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x06031F7B RID: 204667 RVA: 0x006C3441 File Offset: 0x006C1641
		public static void AddIsCorrect(FlatBufferBuilder builder, bool isCorrect)
		{
			builder.AddBool(2, isCorrect, false);
		}

		// Token: 0x06031F7C RID: 204668 RVA: 0x006C344C File Offset: 0x006C164C
		public static void AddInitState(FlatBufferBuilder builder, EJigsawPieceState initState)
		{
			builder.AddByte(3, (byte)initState, 0);
		}

		// Token: 0x06031F7D RID: 204669 RVA: 0x006C3457 File Offset: 0x006C1657
		public static Offset<IJigsawPiece> EndIJigsawPiece(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawPiece>(builder.EndTable());
		}

		// Token: 0x06031F7E RID: 204670 RVA: 0x006C3464 File Offset: 0x006C1664
		public IJigsawPieceT UnPack()
		{
			IJigsawPieceT jigsawPieceT = new IJigsawPieceT();
			this.UnPackTo(jigsawPieceT);
			return jigsawPieceT;
		}

		// Token: 0x06031F7F RID: 204671 RVA: 0x006C3480 File Offset: 0x006C1680
		public void UnPackTo(IJigsawPieceT _o)
		{
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
			_o.Active = this.Active;
			_o.IsCorrect = this.IsCorrect;
			_o.InitState = this.InitState;
		}

		// Token: 0x06031F80 RID: 204672 RVA: 0x006C34E0 File Offset: 0x006C16E0
		public static Offset<IJigsawPiece> Pack(FlatBufferBuilder builder, IJigsawPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawPiece>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IJigsawPiece.CreateIJigsawPiece(builder, indexOffset, _o.Active, _o.IsCorrect, _o.InitState);
		}

		// Token: 0x04011FFA RID: 73722
		private Table __p;
	}
}
