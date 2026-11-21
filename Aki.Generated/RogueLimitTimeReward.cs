using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CF RID: 4303
	public struct RogueLimitTimeReward : IFlatbufferObject
	{
		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600C608 RID: 50696 RVA: 0x00302A98 File Offset: 0x00300C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x00302AA5 File Offset: 0x00300CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C60A RID: 50698 RVA: 0x00302AAC File Offset: 0x00300CAC
		public static RogueLimitTimeReward GetRootAsRogueLimitTimeReward(ByteBuffer _bb)
		{
			return RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(_bb, default(RogueLimitTimeReward));
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x00302AC8 File Offset: 0x00300CC8
		public static RogueLimitTimeReward GetRootAsRogueLimitTimeReward(ByteBuffer _bb, RogueLimitTimeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C60C RID: 50700 RVA: 0x00302AE5 File Offset: 0x00300CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x00302AF4 File Offset: 0x00300CF4
		public RogueLimitTimeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x00302B04 File Offset: 0x00300D04
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600C60F RID: 50703 RVA: 0x00302B40 File Offset: 0x00300D40
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

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600C610 RID: 50704 RVA: 0x00302B7C File Offset: 0x00300D7C
		public string TargetName
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

		// Token: 0x0600C611 RID: 50705 RVA: 0x00302BB3 File Offset: 0x00300DB3
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x00302BC2 File Offset: 0x00300DC2
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600C613 RID: 50707 RVA: 0x00302BDC File Offset: 0x00300DDC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600C614 RID: 50708 RVA: 0x00302C1C File Offset: 0x00300E1C
		public int TargetReward
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

		// Token: 0x040056AE RID: 22190
		private Table __p;
	}
}
