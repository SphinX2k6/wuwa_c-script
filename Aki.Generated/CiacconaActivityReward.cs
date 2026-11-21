using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C56 RID: 3158
	public struct CiacconaActivityReward : IFlatbufferObject
	{
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x00214D09 File Offset: 0x00212F09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00214D16 File Offset: 0x00212F16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00214D20 File Offset: 0x00212F20
		public static CiacconaActivityReward GetRootAsCiacconaActivityReward(ByteBuffer _bb)
		{
			return CiacconaActivityReward.GetRootAsCiacconaActivityReward(_bb, default(CiacconaActivityReward));
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00214D3C File Offset: 0x00212F3C
		public static CiacconaActivityReward GetRootAsCiacconaActivityReward(ByteBuffer _bb, CiacconaActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00214D59 File Offset: 0x00212F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x00214D68 File Offset: 0x00212F68
		public CiacconaActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x00214D78 File Offset: 0x00212F78
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

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x00214DB4 File Offset: 0x00212FB4
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

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06005ADB RID: 23259 RVA: 0x00214DF0 File Offset: 0x00212FF0
		public int CondGroupId
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x00214E2C File Offset: 0x0021302C
		public int RewardId
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x00214E6C File Offset: 0x0021306C
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

		// Token: 0x06005ADE RID: 23262 RVA: 0x00214EA4 File Offset: 0x002130A4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00214EB4 File Offset: 0x002130B4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x00214ECC File Offset: 0x002130CC
		public string Desc
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

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00214F04 File Offset: 0x00213104
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x00214F14 File Offset: 0x00213114
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400515A RID: 20826
		private Table __p;
	}
}
