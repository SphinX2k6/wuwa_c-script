using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE7 RID: 3559
	public struct GivebackScoreReward : IFlatbufferObject
	{
		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x0026AD58 File Offset: 0x00268F58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x0026AD65 File Offset: 0x00268F65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x0026AD6C File Offset: 0x00268F6C
		public static GivebackScoreReward GetRootAsGivebackScoreReward(ByteBuffer _bb)
		{
			return GivebackScoreReward.GetRootAsGivebackScoreReward(_bb, default(GivebackScoreReward));
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x0026AD88 File Offset: 0x00268F88
		public static GivebackScoreReward GetRootAsGivebackScoreReward(ByteBuffer _bb, GivebackScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x0026ADA5 File Offset: 0x00268FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x0026ADB4 File Offset: 0x00268FB4
		public GivebackScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x0026ADC4 File Offset: 0x00268FC4
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

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x0026AE00 File Offset: 0x00269000
		public int Target
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

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x0026AE3C File Offset: 0x0026903C
		public int DropId
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

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x0026AE78 File Offset: 0x00269078
		public string Name
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

		// Token: 0x06008102 RID: 33026 RVA: 0x0026AEB0 File Offset: 0x002690B0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x0026AEC0 File Offset: 0x002690C0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x0026AED8 File Offset: 0x002690D8
		public string DesText
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

		// Token: 0x06008105 RID: 33029 RVA: 0x0026AF10 File Offset: 0x00269110
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x0026AF20 File Offset: 0x00269120
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06008107 RID: 33031 RVA: 0x0026AF38 File Offset: 0x00269138
		public int ShowType
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

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x0026AF78 File Offset: 0x00269178
		public string IconLarge
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

		// Token: 0x06008109 RID: 33033 RVA: 0x0026AFB0 File Offset: 0x002691B0
		public Span<byte> GetIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x0026AFC0 File Offset: 0x002691C0
		public byte[] GetIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600810B RID: 33035 RVA: 0x0026AFD8 File Offset: 0x002691D8
		public int PlayerTitleId
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x0600810C RID: 33036 RVA: 0x0026B018 File Offset: 0x00269218
		public int SkipParam
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

		// Token: 0x0400535D RID: 21341
		private Table __p;
	}
}
