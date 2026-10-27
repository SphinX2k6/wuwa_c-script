using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1C RID: 3612
	public struct MonsterRarity : IFlatbufferObject
	{
		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06009584 RID: 38276 RVA: 0x002888B5 File Offset: 0x00286AB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x002888C2 File Offset: 0x00286AC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x002888CC File Offset: 0x00286ACC
		public static MonsterRarity GetRootAsMonsterRarity(ByteBuffer _bb)
		{
			return MonsterRarity.GetRootAsMonsterRarity(_bb, default(MonsterRarity));
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x002888E8 File Offset: 0x00286AE8
		public static MonsterRarity GetRootAsMonsterRarity(ByteBuffer _bb, MonsterRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00288905 File Offset: 0x00286B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00288914 File Offset: 0x00286B14
		public MonsterRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600958A RID: 38282 RVA: 0x00288924 File Offset: 0x00286B24
		public int Id
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

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x00288960 File Offset: 0x00286B60
		public string RarityDesc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00288997 File Offset: 0x00286B97
		public Span<byte> GetRarityDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x002889A6 File Offset: 0x00286BA6
		public byte[] GetRarityDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EC1 RID: 20161
		private Table __p;
	}
}
