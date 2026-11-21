using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D54 RID: 3412
	public struct FilterSetting : IFlatbufferObject
	{
		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06007473 RID: 29811 RVA: 0x0024E17D File Offset: 0x0024C37D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x0024E18A File Offset: 0x0024C38A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x0024E194 File Offset: 0x0024C394
		public static FilterSetting GetRootAsFilterSetting(ByteBuffer _bb)
		{
			return FilterSetting.GetRootAsFilterSetting(_bb, default(FilterSetting));
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x0024E1B0 File Offset: 0x0024C3B0
		public static FilterSetting GetRootAsFilterSetting(ByteBuffer _bb, FilterSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x0024E1CD File Offset: 0x0024C3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x0024E1DC File Offset: 0x0024C3DC
		public FilterSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06007479 RID: 29817 RVA: 0x0024E1EC File Offset: 0x0024C3EC
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

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x0024E228 File Offset: 0x0024C428
		public int LogicIndex
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

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600747B RID: 29819 RVA: 0x0024E264 File Offset: 0x0024C464
		public string NameTextId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x0024E29B File Offset: 0x0024C49B
		public Span<byte> GetNameTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x0024E2AA File Offset: 0x0024C4AA
		public byte[] GetNameTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x0024E2C4 File Offset: 0x0024C4C4
		public string SpritePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x0024E2FC File Offset: 0x0024C4FC
		public Span<byte> GetSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x0024E30C File Offset: 0x0024C50C
		public byte[] GetSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06007481 RID: 29825 RVA: 0x0024E324 File Offset: 0x0024C524
		public string PadTexturePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x0024E35C File Offset: 0x0024C55C
		public Span<byte> GetPadTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x0024E36C File Offset: 0x0024C56C
		public byte[] GetPadTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400529F RID: 21151
		private Table __p;
	}
}
