using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007442 RID: 29762
	public struct IPieceBase : IFlatbufferObject
	{
		// Token: 0x1700DA9A RID: 55962
		// (get) Token: 0x06034142 RID: 213314 RVA: 0x00704783 File Offset: 0x00702983
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034143 RID: 213315 RVA: 0x00704790 File Offset: 0x00702990
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034144 RID: 213316 RVA: 0x00704798 File Offset: 0x00702998
		public static IPieceBase GetRootAsIPieceBase(ByteBuffer _bb)
		{
			return IPieceBase.GetRootAsIPieceBase(_bb, default(IPieceBase));
		}

		// Token: 0x06034145 RID: 213317 RVA: 0x007047B4 File Offset: 0x007029B4
		public static IPieceBase GetRootAsIPieceBase(ByteBuffer _bb, IPieceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034146 RID: 213318 RVA: 0x007047D1 File Offset: 0x007029D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034147 RID: 213319 RVA: 0x007047E0 File Offset: 0x007029E0
		public IPieceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA9B RID: 55963
		// (get) Token: 0x06034148 RID: 213320 RVA: 0x007047F0 File Offset: 0x007029F0
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

		// Token: 0x1700DA9C RID: 55964
		// (get) Token: 0x06034149 RID: 213321 RVA: 0x00704850 File Offset: 0x00702A50
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603414A RID: 213322 RVA: 0x0070488F File Offset: 0x00702A8F
		public static Offset<IPieceBase> CreateIPieceBase(FlatBufferBuilder builder, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>), bool Active = false)
		{
			builder.StartTable(2);
			IPieceBase.AddIndex(builder, IndexOffset);
			IPieceBase.AddActive(builder, Active);
			return IPieceBase.EndIPieceBase(builder);
		}

		// Token: 0x0603414B RID: 213323 RVA: 0x007048AC File Offset: 0x00702AAC
		public static void StartIPieceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603414C RID: 213324 RVA: 0x007048B5 File Offset: 0x00702AB5
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(0, indexOffset.Value, 0);
		}

		// Token: 0x0603414D RID: 213325 RVA: 0x007048C5 File Offset: 0x00702AC5
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x0603414E RID: 213326 RVA: 0x007048D0 File Offset: 0x00702AD0
		public static Offset<IPieceBase> EndIPieceBase(FlatBufferBuilder builder)
		{
			return new Offset<IPieceBase>(builder.EndTable());
		}

		// Token: 0x0603414F RID: 213327 RVA: 0x007048E0 File Offset: 0x00702AE0
		public IPieceBaseT UnPack()
		{
			IPieceBaseT pieceBaseT = new IPieceBaseT();
			this.UnPackTo(pieceBaseT);
			return pieceBaseT;
		}

		// Token: 0x06034150 RID: 213328 RVA: 0x007048FC File Offset: 0x00702AFC
		public void UnPackTo(IPieceBaseT _o)
		{
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
			_o.Active = this.Active;
		}

		// Token: 0x06034151 RID: 213329 RVA: 0x00704944 File Offset: 0x00702B44
		public static Offset<IPieceBase> Pack(FlatBufferBuilder builder, IPieceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPieceBase>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IPieceBase.CreateIPieceBase(builder, indexOffset, _o.Active);
		}

		// Token: 0x040125A3 RID: 75171
		private Table __p;
	}
}
