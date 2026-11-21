using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA2 RID: 3234
	public struct DangoBrawlEffect : IFlatbufferObject
	{
		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600634C RID: 25420 RVA: 0x00228821 File Offset: 0x00226A21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x0022882E File Offset: 0x00226A2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00228838 File Offset: 0x00226A38
		public static DangoBrawlEffect GetRootAsDangoBrawlEffect(ByteBuffer _bb)
		{
			return DangoBrawlEffect.GetRootAsDangoBrawlEffect(_bb, default(DangoBrawlEffect));
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00228854 File Offset: 0x00226A54
		public static DangoBrawlEffect GetRootAsDangoBrawlEffect(ByteBuffer _bb, DangoBrawlEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00228871 File Offset: 0x00226A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00228880 File Offset: 0x00226A80
		public DangoBrawlEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x00228890 File Offset: 0x00226A90
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06006353 RID: 25427 RVA: 0x002288CC File Offset: 0x00226ACC
		public int ActionType
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06006354 RID: 25428 RVA: 0x00228908 File Offset: 0x00226B08
		public int TriggerLimit
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06006355 RID: 25429 RVA: 0x00228944 File Offset: 0x00226B44
		public int ShowId
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

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x00228984 File Offset: 0x00226B84
		public bool IsClient
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051CB RID: 20939
		private Table __p;
	}
}
