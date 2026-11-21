using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CF RID: 4815
	public struct WeaponQualityInfo : IFlatbufferObject
	{
		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x0600F57A RID: 62842 RVA: 0x0036DD11 File Offset: 0x0036BF11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F57B RID: 62843 RVA: 0x0036DD1E File Offset: 0x0036BF1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F57C RID: 62844 RVA: 0x0036DD28 File Offset: 0x0036BF28
		public static WeaponQualityInfo GetRootAsWeaponQualityInfo(ByteBuffer _bb)
		{
			return WeaponQualityInfo.GetRootAsWeaponQualityInfo(_bb, default(WeaponQualityInfo));
		}

		// Token: 0x0600F57D RID: 62845 RVA: 0x0036DD44 File Offset: 0x0036BF44
		public static WeaponQualityInfo GetRootAsWeaponQualityInfo(ByteBuffer _bb, WeaponQualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F57E RID: 62846 RVA: 0x0036DD61 File Offset: 0x0036BF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F57F RID: 62847 RVA: 0x0036DD70 File Offset: 0x0036BF70
		public WeaponQualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x0600F580 RID: 62848 RVA: 0x0036DD80 File Offset: 0x0036BF80
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

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x0600F581 RID: 62849 RVA: 0x0036DDBC File Offset: 0x0036BFBC
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

		// Token: 0x0600F582 RID: 62850 RVA: 0x0036DDF3 File Offset: 0x0036BFF3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F583 RID: 62851 RVA: 0x0036DE02 File Offset: 0x0036C002
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x0600F584 RID: 62852 RVA: 0x0036DE1C File Offset: 0x0036C01C
		public string QualityColor
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

		// Token: 0x0600F585 RID: 62853 RVA: 0x0036DE53 File Offset: 0x0036C053
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F586 RID: 62854 RVA: 0x0036DE62 File Offset: 0x0036C062
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x0600F587 RID: 62855 RVA: 0x0036DE7C File Offset: 0x0036C07C
		public int LevelLimit
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

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x0600F588 RID: 62856 RVA: 0x0036DEBC File Offset: 0x0036C0BC
		public int Cost
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

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x0600F589 RID: 62857 RVA: 0x0036DEFC File Offset: 0x0036C0FC
		public int BasicExp
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

		// Token: 0x04005927 RID: 22823
		private Table __p;
	}
}
