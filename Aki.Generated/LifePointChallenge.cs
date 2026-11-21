using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAB RID: 3755
	public struct LifePointChallenge : IFlatbufferObject
	{
		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060093E4 RID: 37860 RVA: 0x002956EC File Offset: 0x002938EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x002956F9 File Offset: 0x002938F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x00295700 File Offset: 0x00293900
		public static LifePointChallenge GetRootAsLifePointChallenge(ByteBuffer _bb)
		{
			return LifePointChallenge.GetRootAsLifePointChallenge(_bb, default(LifePointChallenge));
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x0029571C File Offset: 0x0029391C
		public static LifePointChallenge GetRootAsLifePointChallenge(ByteBuffer _bb, LifePointChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00295739 File Offset: 0x00293939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00295748 File Offset: 0x00293948
		public LifePointChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060093EA RID: 37866 RVA: 0x00295758 File Offset: 0x00293958
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

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060093EB RID: 37867 RVA: 0x00295794 File Offset: 0x00293994
		public int GroupId
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

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060093EC RID: 37868 RVA: 0x002957D0 File Offset: 0x002939D0
		public int Difficulty
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

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060093ED RID: 37869 RVA: 0x0029580C File Offset: 0x00293A0C
		public string SubTitle
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

		// Token: 0x060093EE RID: 37870 RVA: 0x00295844 File Offset: 0x00293A44
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00295854 File Offset: 0x00293A54
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060093F0 RID: 37872 RVA: 0x0029586C File Offset: 0x00293A6C
		public string DifficultTexture
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

		// Token: 0x060093F1 RID: 37873 RVA: 0x002958A4 File Offset: 0x00293AA4
		public Span<byte> GetDifficultTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060093F2 RID: 37874 RVA: 0x002958B4 File Offset: 0x00293AB4
		public byte[] GetDifficultTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060093F3 RID: 37875 RVA: 0x002958CC File Offset: 0x00293ACC
		public int ActivityId
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

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060093F4 RID: 37876 RVA: 0x0029590C File Offset: 0x00293B0C
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060093F5 RID: 37877 RVA: 0x0029594C File Offset: 0x00293B4C
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x0029598C File Offset: 0x00293B8C
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060093F7 RID: 37879 RVA: 0x002959CC File Offset: 0x00293BCC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x00295A04 File Offset: 0x00293C04
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x00295A14 File Offset: 0x00293C14
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x00295A2C File Offset: 0x00293C2C
		public string Desc
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

		// Token: 0x060093FB RID: 37883 RVA: 0x00295A64 File Offset: 0x00293C64
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00295A74 File Offset: 0x00293C74
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005441 RID: 21569
		private Table __p;
	}
}
