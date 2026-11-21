using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEF RID: 4079
	public struct PhotoFightReward : IFlatbufferObject
	{
		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600B1DC RID: 45532 RVA: 0x002D6F99 File Offset: 0x002D5199
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x002D6FA6 File Offset: 0x002D51A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x002D6FB0 File Offset: 0x002D51B0
		public static PhotoFightReward GetRootAsPhotoFightReward(ByteBuffer _bb)
		{
			return PhotoFightReward.GetRootAsPhotoFightReward(_bb, default(PhotoFightReward));
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x002D6FCC File Offset: 0x002D51CC
		public static PhotoFightReward GetRootAsPhotoFightReward(ByteBuffer _bb, PhotoFightReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x002D6FE9 File Offset: 0x002D51E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x002D6FF8 File Offset: 0x002D51F8
		public PhotoFightReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600B1E2 RID: 45538 RVA: 0x002D7008 File Offset: 0x002D5208
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

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x0600B1E3 RID: 45539 RVA: 0x002D7044 File Offset: 0x002D5244
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

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x0600B1E4 RID: 45540 RVA: 0x002D7080 File Offset: 0x002D5280
		public int TabId
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

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600B1E5 RID: 45541 RVA: 0x002D70BC File Offset: 0x002D52BC
		public string Title
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

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x002D70F4 File Offset: 0x002D52F4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x002D7104 File Offset: 0x002D5304
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600B1E8 RID: 45544 RVA: 0x002D711C File Offset: 0x002D531C
		public int Target
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

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x002D715C File Offset: 0x002D535C
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055B7 RID: 21943
		private Table __p;
	}
}
