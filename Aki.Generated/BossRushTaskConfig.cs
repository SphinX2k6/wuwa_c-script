using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B48 RID: 2888
	public struct BossRushTaskConfig : IFlatbufferObject
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06004F48 RID: 20296 RVA: 0x001E7E84 File Offset: 0x001E6084
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x001E7E91 File Offset: 0x001E6091
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x001E7E98 File Offset: 0x001E6098
		public static BossRushTaskConfig GetRootAsBossRushTaskConfig(ByteBuffer _bb)
		{
			return BossRushTaskConfig.GetRootAsBossRushTaskConfig(_bb, default(BossRushTaskConfig));
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x001E7EB4 File Offset: 0x001E60B4
		public static BossRushTaskConfig GetRootAsBossRushTaskConfig(ByteBuffer _bb, BossRushTaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x001E7ED1 File Offset: 0x001E60D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x001E7EE0 File Offset: 0x001E60E0
		public BossRushTaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x001E7EF0 File Offset: 0x001E60F0
		public int TaskId
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x001E7F2C File Offset: 0x001E612C
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x001E7F68 File Offset: 0x001E6168
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x001E7FA4 File Offset: 0x001E61A4
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

		// Token: 0x06004F52 RID: 20306 RVA: 0x001E7FDC File Offset: 0x001E61DC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x001E7FEC File Offset: 0x001E61EC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06004F54 RID: 20308 RVA: 0x001E8004 File Offset: 0x001E6204
		public int DropId
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

		// Token: 0x04004B43 RID: 19267
		private Table __p;
	}
}
