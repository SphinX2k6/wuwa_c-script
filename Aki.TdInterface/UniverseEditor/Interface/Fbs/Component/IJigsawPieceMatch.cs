using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B2 RID: 21682
	public struct IJigsawPieceMatch : IFlatbufferObject
	{
		// Token: 0x17009FB8 RID: 40888
		// (get) Token: 0x06023B66 RID: 146278 RVA: 0x004F01EB File Offset: 0x004EE3EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B67 RID: 146279 RVA: 0x004F01F8 File Offset: 0x004EE3F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B68 RID: 146280 RVA: 0x004F0200 File Offset: 0x004EE400
		public static IJigsawPieceMatch GetRootAsIJigsawPieceMatch(ByteBuffer _bb)
		{
			return IJigsawPieceMatch.GetRootAsIJigsawPieceMatch(_bb, default(IJigsawPieceMatch));
		}

		// Token: 0x06023B69 RID: 146281 RVA: 0x004F021C File Offset: 0x004EE41C
		public static IJigsawPieceMatch GetRootAsIJigsawPieceMatch(ByteBuffer _bb, IJigsawPieceMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B6A RID: 146282 RVA: 0x004F0239 File Offset: 0x004EE439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B6B RID: 146283 RVA: 0x004F0248 File Offset: 0x004EE448
		public IJigsawPieceMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FB9 RID: 40889
		// (get) Token: 0x06023B6C RID: 146284 RVA: 0x004F0258 File Offset: 0x004EE458
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

		// Token: 0x17009FBA RID: 40890
		// (get) Token: 0x06023B6D RID: 146285 RVA: 0x004F0294 File Offset: 0x004EE494
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

		// Token: 0x06023B6E RID: 146286 RVA: 0x004F02F1 File Offset: 0x004EE4F1
		public static Offset<IJigsawPieceMatch> CreateIJigsawPieceMatch(FlatBufferBuilder builder, int EntityId = 0, Offset<IPieceIndex> IndexOffset = default(Offset<IPieceIndex>))
		{
			builder.StartTable(2);
			IJigsawPieceMatch.AddIndex(builder, IndexOffset);
			IJigsawPieceMatch.AddEntityId(builder, EntityId);
			return IJigsawPieceMatch.EndIJigsawPieceMatch(builder);
		}

		// Token: 0x06023B6F RID: 146287 RVA: 0x004F030E File Offset: 0x004EE50E
		public static void StartIJigsawPieceMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023B70 RID: 146288 RVA: 0x004F0317 File Offset: 0x004EE517
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06023B71 RID: 146289 RVA: 0x004F0322 File Offset: 0x004EE522
		public static void AddIndex(FlatBufferBuilder builder, Offset<IPieceIndex> indexOffset)
		{
			builder.AddOffset(1, indexOffset.Value, 0);
		}

		// Token: 0x06023B72 RID: 146290 RVA: 0x004F0332 File Offset: 0x004EE532
		public static Offset<IJigsawPieceMatch> EndIJigsawPieceMatch(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawPieceMatch>(builder.EndTable());
		}

		// Token: 0x06023B73 RID: 146291 RVA: 0x004F0340 File Offset: 0x004EE540
		public IJigsawPieceMatchT UnPack()
		{
			IJigsawPieceMatchT jigsawPieceMatchT = new IJigsawPieceMatchT();
			this.UnPackTo(jigsawPieceMatchT);
			return jigsawPieceMatchT;
		}

		// Token: 0x06023B74 RID: 146292 RVA: 0x004F035C File Offset: 0x004EE55C
		public void UnPackTo(IJigsawPieceMatchT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Index = ((this.Index != null) ? this.Index.Value.UnPack() : null);
		}

		// Token: 0x06023B75 RID: 146293 RVA: 0x004F03A4 File Offset: 0x004EE5A4
		public static Offset<IJigsawPieceMatch> Pack(FlatBufferBuilder builder, IJigsawPieceMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawPieceMatch>);
			}
			Offset<IPieceIndex> indexOffset = (_o.Index == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Index);
			return IJigsawPieceMatch.CreateIJigsawPieceMatch(builder, _o.EntityId, indexOffset);
		}

		// Token: 0x0400E760 RID: 59232
		private Table __p;
	}
}
