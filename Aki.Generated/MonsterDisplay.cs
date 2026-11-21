using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF8 RID: 3832
	public struct MonsterDisplay : IFlatbufferObject
	{
		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06009AF4 RID: 39668 RVA: 0x002A4F30 File Offset: 0x002A3130
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x002A4F3D File Offset: 0x002A313D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x002A4F44 File Offset: 0x002A3144
		public static MonsterDisplay GetRootAsMonsterDisplay(ByteBuffer _bb)
		{
			return MonsterDisplay.GetRootAsMonsterDisplay(_bb, default(MonsterDisplay));
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x002A4F60 File Offset: 0x002A3160
		public static MonsterDisplay GetRootAsMonsterDisplay(ByteBuffer _bb, MonsterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x002A4F7D File Offset: 0x002A317D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x002A4F8C File Offset: 0x002A318C
		public MonsterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06009AFA RID: 39674 RVA: 0x002A4F9C File Offset: 0x002A319C
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

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06009AFB RID: 39675 RVA: 0x002A4FD8 File Offset: 0x002A31D8
		public int NameStringKey
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

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06009AFC RID: 39676 RVA: 0x002A5014 File Offset: 0x002A3214
		public int Name
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

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x002A5050 File Offset: 0x002A3250
		public int IntroduceStringKey
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

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06009AFE RID: 39678 RVA: 0x002A5090 File Offset: 0x002A3290
		public int Introduce
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x002A50D0 File Offset: 0x002A32D0
		public string MonsterPileIconAsset
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

		// Token: 0x06009B00 RID: 39680 RVA: 0x002A5108 File Offset: 0x002A3308
		public Span<byte> GetMonsterPileIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x002A5118 File Offset: 0x002A3318
		public byte[] GetMonsterPileIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400549D RID: 21661
		private Table __p;
	}
}
