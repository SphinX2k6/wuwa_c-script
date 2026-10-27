using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE1 RID: 3041
	public struct DarkCoastDelivery : IFlatbufferObject
	{
		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x00210A6D File Offset: 0x0020EC6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00210A7A File Offset: 0x0020EC7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x00210A84 File Offset: 0x0020EC84
		public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb)
		{
			return DarkCoastDelivery.GetRootAsDarkCoastDelivery(_bb, default(DarkCoastDelivery));
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00210AA0 File Offset: 0x0020ECA0
		public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb, DarkCoastDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00210ABD File Offset: 0x0020ECBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00210ACC File Offset: 0x0020ECCC
		public DarkCoastDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x00210ADC File Offset: 0x0020ECDC
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00210B18 File Offset: 0x0020ED18
		public string Icon
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

		// Token: 0x060060F7 RID: 24823 RVA: 0x00210B4F File Offset: 0x0020ED4F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00210B5E File Offset: 0x0020ED5E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x00210B78 File Offset: 0x0020ED78
		public string LevelTexture
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

		// Token: 0x060060FA RID: 24826 RVA: 0x00210BAF File Offset: 0x0020EDAF
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00210BBE File Offset: 0x0020EDBE
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060060FC RID: 24828 RVA: 0x00210BD8 File Offset: 0x0020EDD8
		public string LevelIcon
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

		// Token: 0x060060FD RID: 24829 RVA: 0x00210C10 File Offset: 0x0020EE10
		public Span<byte> GetLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00210C20 File Offset: 0x0020EE20
		public byte[] GetLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x00210C38 File Offset: 0x0020EE38
		public string LevelSelectIcon
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

		// Token: 0x06006100 RID: 24832 RVA: 0x00210C70 File Offset: 0x0020EE70
		public Span<byte> GetLevelSelectIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00210C80 File Offset: 0x0020EE80
		public byte[] GetLevelSelectIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06006102 RID: 24834 RVA: 0x00210C98 File Offset: 0x0020EE98
		public string TipIcon
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

		// Token: 0x06006103 RID: 24835 RVA: 0x00210CD0 File Offset: 0x0020EED0
		public Span<byte> GetTipIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00210CE0 File Offset: 0x0020EEE0
		public byte[] GetTipIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x00210CF8 File Offset: 0x0020EEF8
		public string TipLockIcon
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

		// Token: 0x06006106 RID: 24838 RVA: 0x00210D30 File Offset: 0x0020EF30
		public Span<byte> GetTipLockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00210D40 File Offset: 0x0020EF40
		public byte[] GetTipLockIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06006108 RID: 24840 RVA: 0x00210D58 File Offset: 0x0020EF58
		public string TipName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00210D90 File Offset: 0x0020EF90
		public Span<byte> GetTipNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00210DA0 File Offset: 0x0020EFA0
		public byte[] GetTipNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x00210DB8 File Offset: 0x0020EFB8
		public string TipDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x00210DF0 File Offset: 0x0020EFF0
		public Span<byte> GetTipDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x00210E00 File Offset: 0x0020F000
		public byte[] GetTipDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600610E RID: 24846 RVA: 0x00210E18 File Offset: 0x0020F018
		public int RewardCount
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600610F RID: 24847 RVA: 0x00210E58 File Offset: 0x0020F058
		public string UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00210E90 File Offset: 0x0020F090
		public Span<byte> GetUnlockConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x00210EA0 File Offset: 0x0020F0A0
		public byte[] GetUnlockConditionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06006112 RID: 24850 RVA: 0x00210EB8 File Offset: 0x0020F0B8
		public string VisionTexture
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x00210EF0 File Offset: 0x0020F0F0
		public Span<byte> GetVisionTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x00210F00 File Offset: 0x0020F100
		public byte[] GetVisionTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06006115 RID: 24853 RVA: 0x00210F18 File Offset: 0x0020F118
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x00210F58 File Offset: 0x0020F158
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004C0E RID: 19470
		private Table __p;
	}
}
