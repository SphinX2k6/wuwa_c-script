using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C73 RID: 3187
	public struct FindSunSpirit : IFlatbufferObject
	{
		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x0022F454 File Offset: 0x0022D654
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x0022F461 File Offset: 0x0022D661
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x0022F468 File Offset: 0x0022D668
		public static FindSunSpirit GetRootAsFindSunSpirit(ByteBuffer _bb)
		{
			return FindSunSpirit.GetRootAsFindSunSpirit(_bb, default(FindSunSpirit));
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x0022F484 File Offset: 0x0022D684
		public static FindSunSpirit GetRootAsFindSunSpirit(ByteBuffer _bb, FindSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x0022F4A1 File Offset: 0x0022D6A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x0022F4B0 File Offset: 0x0022D6B0
		public FindSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x0022F4C0 File Offset: 0x0022D6C0
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

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06006E97 RID: 28311 RVA: 0x0022F4FC File Offset: 0x0022D6FC
		public string Name
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

		// Token: 0x06006E98 RID: 28312 RVA: 0x0022F533 File Offset: 0x0022D733
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x0022F542 File Offset: 0x0022D742
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x0022F55C File Offset: 0x0022D75C
		public string Level
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

		// Token: 0x06006E9B RID: 28315 RVA: 0x0022F593 File Offset: 0x0022D793
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x0022F5A2 File Offset: 0x0022D7A2
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CBE RID: 19646
		private Table __p;
	}
}
