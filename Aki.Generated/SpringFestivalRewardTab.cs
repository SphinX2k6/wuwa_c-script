using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001220 RID: 4640
	public struct SpringFestivalRewardTab : IFlatbufferObject
	{
		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600E625 RID: 58917 RVA: 0x0034B872 File Offset: 0x00349A72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x0034B87F File Offset: 0x00349A7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x0034B888 File Offset: 0x00349A88
		public static SpringFestivalRewardTab GetRootAsSpringFestivalRewardTab(ByteBuffer _bb)
		{
			return SpringFestivalRewardTab.GetRootAsSpringFestivalRewardTab(_bb, default(SpringFestivalRewardTab));
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x0034B8A4 File Offset: 0x00349AA4
		public static SpringFestivalRewardTab GetRootAsSpringFestivalRewardTab(ByteBuffer _bb, SpringFestivalRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E629 RID: 58921 RVA: 0x0034B8C1 File Offset: 0x00349AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x0034B8D0 File Offset: 0x00349AD0
		public SpringFestivalRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x0034B8E0 File Offset: 0x00349AE0
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

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600E62C RID: 58924 RVA: 0x0034B91C File Offset: 0x00349B1C
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

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600E62D RID: 58925 RVA: 0x0034B958 File Offset: 0x00349B58
		public string Name
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

		// Token: 0x0600E62E RID: 58926 RVA: 0x0034B98F File Offset: 0x00349B8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x0034B99E File Offset: 0x00349B9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600E630 RID: 58928 RVA: 0x0034B9B8 File Offset: 0x00349BB8
		public int Sort
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

		// Token: 0x04005861 RID: 22625
		private Table __p;
	}
}
