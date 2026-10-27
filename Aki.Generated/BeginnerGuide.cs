using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B30 RID: 2864
	public struct BeginnerGuide : IFlatbufferObject
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x001E2D18 File Offset: 0x001E0F18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x001E2D25 File Offset: 0x001E0F25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001E2D2C File Offset: 0x001E0F2C
		public static BeginnerGuide GetRootAsBeginnerGuide(ByteBuffer _bb)
		{
			return BeginnerGuide.GetRootAsBeginnerGuide(_bb, default(BeginnerGuide));
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x001E2D48 File Offset: 0x001E0F48
		public static BeginnerGuide GetRootAsBeginnerGuide(ByteBuffer _bb, BeginnerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x001E2D65 File Offset: 0x001E0F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x001E2D74 File Offset: 0x001E0F74
		public BeginnerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x001E2D84 File Offset: 0x001E0F84
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x001E2DC0 File Offset: 0x001E0FC0
		public int PlayerId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x001E2DFC File Offset: 0x001E0FFC
		public int WorldLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x001E2E38 File Offset: 0x001E1038
		public int PlayerLevel
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x001E2E78 File Offset: 0x001E1078
		public int Region
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x001E2EB8 File Offset: 0x001E10B8
		public int ClientPlatform
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x001E2EF8 File Offset: 0x001E10F8
		public int NetStatus
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x001E2F38 File Offset: 0x001E1138
		public int DeviceId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x001E2F78 File Offset: 0x001E1178
		public int GuideId
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x001E2FB8 File Offset: 0x001E11B8
		public int GameDuration
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

		// Token: 0x04004B28 RID: 19240
		private Table __p;
	}
}
