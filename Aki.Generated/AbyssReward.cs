using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B87 RID: 2951
	public struct AbyssReward : IFlatbufferObject
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x001E752C File Offset: 0x001E572C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x001E7539 File Offset: 0x001E5739
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x001E7540 File Offset: 0x001E5740
		public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb)
		{
			return AbyssReward.GetRootAsAbyssReward(_bb, default(AbyssReward));
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x001E755C File Offset: 0x001E575C
		public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb, AbyssReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x001E7579 File Offset: 0x001E5779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x001E7588 File Offset: 0x001E5788
		public AbyssReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x001E7598 File Offset: 0x001E5798
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x001E75D4 File Offset: 0x001E57D4
		public int RewardType
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x001E7610 File Offset: 0x001E5810
		public int ConditionId
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x001E764C File Offset: 0x001E584C
		public int DropId
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x001E768C File Offset: 0x001E588C
		public string Title
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

		// Token: 0x060046B6 RID: 18102 RVA: 0x001E76C4 File Offset: 0x001E58C4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x001E76D4 File Offset: 0x001E58D4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400505B RID: 20571
		private Table __p;
	}
}
