using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A38 RID: 23096
	public struct IJigsawPieceMatch : IFlatbufferObject
	{
		// Token: 0x1700A7F2 RID: 42994
		// (get) Token: 0x06025C1E RID: 154654 RVA: 0x0052D25F File Offset: 0x0052B45F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C1F RID: 154655 RVA: 0x0052D26C File Offset: 0x0052B46C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C20 RID: 154656 RVA: 0x0052D274 File Offset: 0x0052B474
		public static IJigsawPieceMatch GetRootAsIJigsawPieceMatch(ByteBuffer _bb)
		{
			return IJigsawPieceMatch.GetRootAsIJigsawPieceMatch(_bb, default(IJigsawPieceMatch));
		}

		// Token: 0x06025C21 RID: 154657 RVA: 0x0052D290 File Offset: 0x0052B490
		public static IJigsawPieceMatch GetRootAsIJigsawPieceMatch(ByteBuffer _bb, IJigsawPieceMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C22 RID: 154658 RVA: 0x0052D2AD File Offset: 0x0052B4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C23 RID: 154659 RVA: 0x0052D2BC File Offset: 0x0052B4BC
		public IJigsawPieceMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7F3 RID: 42995
		// (get) Token: 0x06025C24 RID: 154660 RVA: 0x0052D2CC File Offset: 0x0052B4CC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A7F4 RID: 42996
		// (get) Token: 0x06025C25 RID: 154661 RVA: 0x0052D308 File Offset: 0x0052B508
		public IPieceIndex? Index
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025C26 RID: 154662 RVA: 0x0052D365 File Offset: 0x0052B565
		public static Offset<IJigsawPieceMatch> CreateIJigsawPieceMatch(FlatBufferBuilder builder, int EntityId = 0, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>))
		{
			builder.StartTable(2);
			IJigsawPieceMatch.AddIndex(builder, IndexOffset);
			IJigsawPieceMatch.AddEntityId(builder, EntityId);
			return IJigsawPieceMatch.EndIJigsawPieceMatch(builder);
		}

		// Token: 0x06025C27 RID: 154663 RVA: 0x0052D382 File Offset: 0x0052B582
		public static void StartIJigsawPieceMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025C28 RID: 154664 RVA: 0x0052D38B File Offset: 0x0052B58B
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06025C29 RID: 154665 RVA: 0x0052D396 File Offset: 0x0052B596
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(1, indexOffset.Value, 0);
		}

		// Token: 0x06025C2A RID: 154666 RVA: 0x0052D3A6 File Offset: 0x0052B5A6
		public static Offset<IJigsawPieceMatch> EndIJigsawPieceMatch(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawPieceMatch>(builder.EndTable());
		}

		// Token: 0x06025C2B RID: 154667 RVA: 0x0052D3B4 File Offset: 0x0052B5B4
		public IJigsawPieceMatchT UnPack()
		{
			IJigsawPieceMatchT jigsawPieceMatchT = new IJigsawPieceMatchT();
			this.UnPackTo(jigsawPieceMatchT);
			return jigsawPieceMatchT;
		}

		// Token: 0x06025C2C RID: 154668 RVA: 0x0052D3D0 File Offset: 0x0052B5D0
		public void UnPackTo(IJigsawPieceMatchT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
		}

		// Token: 0x06025C2D RID: 154669 RVA: 0x0052D418 File Offset: 0x0052B618
		public static Offset<IJigsawPieceMatch> Pack(FlatBufferBuilder builder, IJigsawPieceMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawPieceMatch>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IJigsawPieceMatch.CreateIJigsawPieceMatch(builder, _o.EntityId, indexOffset);
		}

		// Token: 0x0400F391 RID: 62353
		private Table __p;
	}
}
