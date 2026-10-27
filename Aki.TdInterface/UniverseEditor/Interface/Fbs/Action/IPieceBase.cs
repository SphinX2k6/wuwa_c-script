using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCC RID: 27852
	public struct IPieceBase : IFlatbufferObject
	{
		// Token: 0x1700CF5D RID: 53085
		// (get) Token: 0x0603116B RID: 201067 RVA: 0x006A954F File Offset: 0x006A774F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603116C RID: 201068 RVA: 0x006A955C File Offset: 0x006A775C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603116D RID: 201069 RVA: 0x006A9564 File Offset: 0x006A7764
		public static IPieceBase GetRootAsIPieceBase(ByteBuffer _bb)
		{
			return IPieceBase.GetRootAsIPieceBase(_bb, default(IPieceBase));
		}

		// Token: 0x0603116E RID: 201070 RVA: 0x006A9580 File Offset: 0x006A7780
		public static IPieceBase GetRootAsIPieceBase(ByteBuffer _bb, IPieceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603116F RID: 201071 RVA: 0x006A959D File Offset: 0x006A779D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031170 RID: 201072 RVA: 0x006A95AC File Offset: 0x006A77AC
		public IPieceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF5E RID: 53086
		// (get) Token: 0x06031171 RID: 201073 RVA: 0x006A95BC File Offset: 0x006A77BC
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

		// Token: 0x1700CF5F RID: 53087
		// (get) Token: 0x06031172 RID: 201074 RVA: 0x006A961C File Offset: 0x006A781C
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031173 RID: 201075 RVA: 0x006A965B File Offset: 0x006A785B
		public static Offset<IPieceBase> CreateIPieceBase(FlatBufferBuilder builder, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>), bool Active = false)
		{
			builder.StartTable(2);
			IPieceBase.AddIndex(builder, IndexOffset);
			IPieceBase.AddActive(builder, Active);
			return IPieceBase.EndIPieceBase(builder);
		}

		// Token: 0x06031174 RID: 201076 RVA: 0x006A9678 File Offset: 0x006A7878
		public static void StartIPieceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031175 RID: 201077 RVA: 0x006A9681 File Offset: 0x006A7881
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(0, indexOffset.Value, 0);
		}

		// Token: 0x06031176 RID: 201078 RVA: 0x006A9691 File Offset: 0x006A7891
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x06031177 RID: 201079 RVA: 0x006A969C File Offset: 0x006A789C
		public static Offset<IPieceBase> EndIPieceBase(FlatBufferBuilder builder)
		{
			return new Offset<IPieceBase>(builder.EndTable());
		}

		// Token: 0x06031178 RID: 201080 RVA: 0x006A96AC File Offset: 0x006A78AC
		public IPieceBaseT UnPack()
		{
			IPieceBaseT pieceBaseT = new IPieceBaseT();
			this.UnPackTo(pieceBaseT);
			return pieceBaseT;
		}

		// Token: 0x06031179 RID: 201081 RVA: 0x006A96C8 File Offset: 0x006A78C8
		public void UnPackTo(IPieceBaseT _o)
		{
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
			_o.Active = this.Active;
		}

		// Token: 0x0603117A RID: 201082 RVA: 0x006A9710 File Offset: 0x006A7910
		public static Offset<IPieceBase> Pack(FlatBufferBuilder builder, IPieceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceBase>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IPieceBase.CreateIPieceBase(builder, indexOffset, _o.Active);
		}

		// Token: 0x04011633 RID: 71219
		private Table __p;
	}
}
