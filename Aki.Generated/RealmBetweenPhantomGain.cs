using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001083 RID: 4227
	public struct RealmBetweenPhantomGain : IFlatbufferObject
	{
		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x002F4B58 File Offset: 0x002F2D58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x002F4B65 File Offset: 0x002F2D65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x002F4B6C File Offset: 0x002F2D6C
		public static RealmBetweenPhantomGain GetRootAsRealmBetweenPhantomGain(ByteBuffer _bb)
		{
			return RealmBetweenPhantomGain.GetRootAsRealmBetweenPhantomGain(_bb, default(RealmBetweenPhantomGain));
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x002F4B88 File Offset: 0x002F2D88
		public static RealmBetweenPhantomGain GetRootAsRealmBetweenPhantomGain(ByteBuffer _bb, RealmBetweenPhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x002F4BA5 File Offset: 0x002F2DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x002F4BB4 File Offset: 0x002F2DB4
		public RealmBetweenPhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600BFA7 RID: 49063 RVA: 0x002F4BC4 File Offset: 0x002F2DC4
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

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600BFA8 RID: 49064 RVA: 0x002F4C00 File Offset: 0x002F2E00
		public int MonsterInfoId
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

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600BFA9 RID: 49065 RVA: 0x002F4C3C File Offset: 0x002F2E3C
		public int ActivityId
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

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600BFAA RID: 49066 RVA: 0x002F4C78 File Offset: 0x002F2E78
		public int UnLockReward
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

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600BFAB RID: 49067 RVA: 0x002F4CB8 File Offset: 0x002F2EB8
		public int Sort
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

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600BFAC RID: 49068 RVA: 0x002F4CF8 File Offset: 0x002F2EF8
		public string Name
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

		// Token: 0x0600BFAD RID: 49069 RVA: 0x002F4D30 File Offset: 0x002F2F30
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x002F4D40 File Offset: 0x002F2F40
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x002F4D58 File Offset: 0x002F2F58
		public string TexPhantom
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x002F4D90 File Offset: 0x002F2F90
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x002F4DA0 File Offset: 0x002F2FA0
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005653 RID: 22099
		private Table __p;
	}
}
