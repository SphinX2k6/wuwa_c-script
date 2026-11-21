using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F01 RID: 3841
	public struct MonsterRarity : IFlatbufferObject
	{
		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x002A6625 File Offset: 0x002A4825
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BA5 RID: 39845 RVA: 0x002A6632 File Offset: 0x002A4832
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BA6 RID: 39846 RVA: 0x002A663C File Offset: 0x002A483C
		public static MonsterRarity GetRootAsMonsterRarity(ByteBuffer _bb)
		{
			return MonsterRarity.GetRootAsMonsterRarity(_bb, default(MonsterRarity));
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x002A6658 File Offset: 0x002A4858
		public static MonsterRarity GetRootAsMonsterRarity(ByteBuffer _bb, MonsterRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x002A6675 File Offset: 0x002A4875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x002A6684 File Offset: 0x002A4884
		public MonsterRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x002A6694 File Offset: 0x002A4894
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

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x002A66D0 File Offset: 0x002A48D0
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

		// Token: 0x06009BAC RID: 39852 RVA: 0x002A6707 File Offset: 0x002A4907
		public Span<byte> GetRarityDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009BAD RID: 39853 RVA: 0x002A6716 File Offset: 0x002A4916
		public byte[] GetRarityDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A6 RID: 21670
		private Table __p;
	}
}
