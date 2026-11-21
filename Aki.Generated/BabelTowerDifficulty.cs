using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C01 RID: 3073
	public struct BabelTowerDifficulty : IFlatbufferObject
	{
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x001FD86A File Offset: 0x001FBA6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x001FD877 File Offset: 0x001FBA77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x001FD880 File Offset: 0x001FBA80
		public static BabelTowerDifficulty GetRootAsBabelTowerDifficulty(ByteBuffer _bb)
		{
			return BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(_bb, default(BabelTowerDifficulty));
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x001FD89C File Offset: 0x001FBA9C
		public static BabelTowerDifficulty GetRootAsBabelTowerDifficulty(ByteBuffer _bb, BabelTowerDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x001FD8B9 File Offset: 0x001FBAB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x001FD8C8 File Offset: 0x001FBAC8
		public BabelTowerDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x001FD8D8 File Offset: 0x001FBAD8
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x001FD914 File Offset: 0x001FBB14
		public int ActivityId
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x001FD950 File Offset: 0x001FBB50
		public int DifficultyId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x001FD98C File Offset: 0x001FBB8C
		public int StarNum
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x001FD9CC File Offset: 0x001FBBCC
		public string TextBgColor
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

		// Token: 0x060050B7 RID: 20663 RVA: 0x001FDA04 File Offset: 0x001FBC04
		public Span<byte> GetTextBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x001FDA14 File Offset: 0x001FBC14
		public byte[] GetTextBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x001FDA2C File Offset: 0x001FBC2C
		public string DifficultyTextKey
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x001FDA64 File Offset: 0x001FBC64
		public Span<byte> GetDifficultyTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x001FDA74 File Offset: 0x001FBC74
		public byte[] GetDifficultyTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040050F2 RID: 20722
		private Table __p;
	}
}
