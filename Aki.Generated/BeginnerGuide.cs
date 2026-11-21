using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C10 RID: 3088
	public struct BeginnerGuide : IFlatbufferObject
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x002030F8 File Offset: 0x002012F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00203105 File Offset: 0x00201305
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x0020310C File Offset: 0x0020130C
		public static BeginnerGuide GetRootAsBeginnerGuide(ByteBuffer _bb)
		{
			return BeginnerGuide.GetRootAsBeginnerGuide(_bb, default(BeginnerGuide));
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00203128 File Offset: 0x00201328
		public static BeginnerGuide GetRootAsBeginnerGuide(ByteBuffer _bb, BeginnerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00203145 File Offset: 0x00201345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00203154 File Offset: 0x00201354
		public BeginnerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x00203164 File Offset: 0x00201364
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x002031A0 File Offset: 0x002013A0
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060052BE RID: 21182 RVA: 0x002031DC File Offset: 0x002013DC
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x00203218 File Offset: 0x00201418
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

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x00203258 File Offset: 0x00201458
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x00203298 File Offset: 0x00201498
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060052C2 RID: 21186 RVA: 0x002032D8 File Offset: 0x002014D8
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x00203318 File Offset: 0x00201518
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

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x00203358 File Offset: 0x00201558
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x00203398 File Offset: 0x00201598
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

		// Token: 0x04005108 RID: 20744
		private Table __p;
	}
}
