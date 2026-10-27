using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E29 RID: 3625
	public struct MoraleLvPower : IFlatbufferObject
	{
		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06009645 RID: 38469 RVA: 0x0028A0BD File Offset: 0x002882BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0028A0CA File Offset: 0x002882CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0028A0D4 File Offset: 0x002882D4
		public static MoraleLvPower GetRootAsMoraleLvPower(ByteBuffer _bb)
		{
			return MoraleLvPower.GetRootAsMoraleLvPower(_bb, default(MoraleLvPower));
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x0028A0F0 File Offset: 0x002882F0
		public static MoraleLvPower GetRootAsMoraleLvPower(ByteBuffer _bb, MoraleLvPower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x0028A10D File Offset: 0x0028830D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600964A RID: 38474 RVA: 0x0028A11C File Offset: 0x0028831C
		public MoraleLvPower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600964B RID: 38475 RVA: 0x0028A12C File Offset: 0x0028832C
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

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x0028A168 File Offset: 0x00288368
		public int LvStage
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

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600964D RID: 38477 RVA: 0x0028A1A4 File Offset: 0x002883A4
		public string BuffName
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

		// Token: 0x0600964E RID: 38478 RVA: 0x0028A1DB File Offset: 0x002883DB
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x0028A1EA File Offset: 0x002883EA
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06009650 RID: 38480 RVA: 0x0028A204 File Offset: 0x00288404
		public string BuffDesc
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

		// Token: 0x06009651 RID: 38481 RVA: 0x0028A23C File Offset: 0x0028843C
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x0028A24C File Offset: 0x0028844C
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x0028A264 File Offset: 0x00288464
		public string BuffDescDetail
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

		// Token: 0x06009654 RID: 38484 RVA: 0x0028A29C File Offset: 0x0028849C
		public Span<byte> GetBuffDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x0028A2AC File Offset: 0x002884AC
		public byte[] GetBuffDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x0028A2C4 File Offset: 0x002884C4
		public string IconPathNormal
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

		// Token: 0x06009657 RID: 38487 RVA: 0x0028A2FC File Offset: 0x002884FC
		public Span<byte> GetIconPathNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x0028A30C File Offset: 0x0028850C
		public byte[] GetIconPathNormalArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06009659 RID: 38489 RVA: 0x0028A324 File Offset: 0x00288524
		public string IconPathActive
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

		// Token: 0x0600965A RID: 38490 RVA: 0x0028A35C File Offset: 0x0028855C
		public Span<byte> GetIconPathActiveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0028A36C File Offset: 0x0028856C
		public byte[] GetIconPathActiveArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ECE RID: 20174
		private Table __p;
	}
}
