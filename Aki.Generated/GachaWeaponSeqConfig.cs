using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCB RID: 3531
	public struct GachaWeaponSeqConfig : IFlatbufferObject
	{
		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06007ED3 RID: 32467 RVA: 0x00265F3C File Offset: 0x0026413C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00265F49 File Offset: 0x00264149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x00265F50 File Offset: 0x00264150
		public static GachaWeaponSeqConfig GetRootAsGachaWeaponSeqConfig(ByteBuffer _bb)
		{
			return GachaWeaponSeqConfig.GetRootAsGachaWeaponSeqConfig(_bb, default(GachaWeaponSeqConfig));
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x00265F6C File Offset: 0x0026416C
		public static GachaWeaponSeqConfig GetRootAsGachaWeaponSeqConfig(ByteBuffer _bb, GachaWeaponSeqConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x00265F89 File Offset: 0x00264189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x00265F98 File Offset: 0x00264198
		public GachaWeaponSeqConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x00265FA8 File Offset: 0x002641A8
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

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x00265FE4 File Offset: 0x002641E4
		public string SequencePath
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

		// Token: 0x06007EDB RID: 32475 RVA: 0x0026601B File Offset: 0x0026421B
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x0026602A File Offset: 0x0026422A
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06007EDD RID: 32477 RVA: 0x00266044 File Offset: 0x00264244
		public int BeforeEndFrame
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 150;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400533C RID: 21308
		private Table __p;
	}
}
