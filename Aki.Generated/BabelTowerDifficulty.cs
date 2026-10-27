using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B21 RID: 2849
	public struct BabelTowerDifficulty : IFlatbufferObject
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x001DD381 File Offset: 0x001DB581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x001DD38E File Offset: 0x001DB58E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x001DD398 File Offset: 0x001DB598
		public static BabelTowerDifficulty GetRootAsBabelTowerDifficulty(ByteBuffer _bb)
		{
			return BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(_bb, default(BabelTowerDifficulty));
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x001DD3B4 File Offset: 0x001DB5B4
		public static BabelTowerDifficulty GetRootAsBabelTowerDifficulty(ByteBuffer _bb, BabelTowerDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x001DD3D1 File Offset: 0x001DB5D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x001DD3E0 File Offset: 0x001DB5E0
		public BabelTowerDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x001DD3F0 File Offset: 0x001DB5F0
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x001DD42C File Offset: 0x001DB62C
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

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x001DD468 File Offset: 0x001DB668
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x001DD4A4 File Offset: 0x001DB6A4
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x001DD4E4 File Offset: 0x001DB6E4
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

		// Token: 0x06004AF5 RID: 19189 RVA: 0x001DD51C File Offset: 0x001DB71C
		public Span<byte> GetTextBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x001DD52C File Offset: 0x001DB72C
		public byte[] GetTextBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x001DD544 File Offset: 0x001DB744
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

		// Token: 0x06004AF8 RID: 19192 RVA: 0x001DD57C File Offset: 0x001DB77C
		public Span<byte> GetDifficultyTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x001DD58C File Offset: 0x001DB78C
		public byte[] GetDifficultyTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B12 RID: 19218
		private Table __p;
	}
}
