using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D67 RID: 3431
	public struct FishingNotice : IFlatbufferObject
	{
		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x00251101 File Offset: 0x0024F301
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x0025110E File Offset: 0x0024F30E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00251118 File Offset: 0x0024F318
		public static FishingNotice GetRootAsFishingNotice(ByteBuffer _bb)
		{
			return FishingNotice.GetRootAsFishingNotice(_bb, default(FishingNotice));
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00251134 File Offset: 0x0024F334
		public static FishingNotice GetRootAsFishingNotice(ByteBuffer _bb, FishingNotice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00251151 File Offset: 0x0024F351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00251160 File Offset: 0x0024F360
		public FishingNotice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x00251170 File Offset: 0x0024F370
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

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060075C1 RID: 30145 RVA: 0x002511AC File Offset: 0x0024F3AC
		public int AlertCondition
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

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060075C2 RID: 30146 RVA: 0x002511E8 File Offset: 0x0024F3E8
		public int FinishCondition
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

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060075C3 RID: 30147 RVA: 0x00251224 File Offset: 0x0024F424
		public string AlertTip
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

		// Token: 0x060075C4 RID: 30148 RVA: 0x0025125C File Offset: 0x0024F45C
		public Span<byte> GetAlertTipBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x0025126C File Offset: 0x0024F46C
		public byte[] GetAlertTipArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B7 RID: 21175
		private Table __p;
	}
}
