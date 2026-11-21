using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA0 RID: 3488
	public struct FloroRanchToy : IFlatbufferObject
	{
		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x0025DD24 File Offset: 0x0025BF24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x0025DD31 File Offset: 0x0025BF31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x0025DD38 File Offset: 0x0025BF38
		public static FloroRanchToy GetRootAsFloroRanchToy(ByteBuffer _bb)
		{
			return FloroRanchToy.GetRootAsFloroRanchToy(_bb, default(FloroRanchToy));
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x0025DD54 File Offset: 0x0025BF54
		public static FloroRanchToy GetRootAsFloroRanchToy(ByteBuffer _bb, FloroRanchToy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x0025DD71 File Offset: 0x0025BF71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x0025DD80 File Offset: 0x0025BF80
		public FloroRanchToy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x0025DD90 File Offset: 0x0025BF90
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

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06007B0B RID: 31499 RVA: 0x0025DDCC File Offset: 0x0025BFCC
		public int Type
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

		// Token: 0x06007B0C RID: 31500 RVA: 0x0025DE08 File Offset: 0x0025C008
		public int Race(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06007B0D RID: 31501 RVA: 0x0025DE48 File Offset: 0x0025C048
		public int RaceLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x0025DE73 File Offset: 0x0025C073
		public Span<int> GetRaceBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x0025DE82 File Offset: 0x0025C082
		public int[] GetRaceArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x0025DE9C File Offset: 0x0025C09C
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

		// Token: 0x06007B11 RID: 31505 RVA: 0x0025DED4 File Offset: 0x0025C0D4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x0025DEE4 File Offset: 0x0025C0E4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06007B13 RID: 31507 RVA: 0x0025DEFC File Offset: 0x0025C0FC
		public int RarityId
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

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x0025DF3C File Offset: 0x0025C13C
		public int Tag
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

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06007B15 RID: 31509 RVA: 0x0025DF7C File Offset: 0x0025C17C
		public bool EuicklyEffectTag
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x0025DFBC File Offset: 0x0025C1BC
		public int Price
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06007B17 RID: 31511 RVA: 0x0025DFFC File Offset: 0x0025C1FC
		public string Icon
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

		// Token: 0x06007B18 RID: 31512 RVA: 0x0025E034 File Offset: 0x0025C234
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x0025E044 File Offset: 0x0025C244
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x0025E05C File Offset: 0x0025C25C
		public int Remove
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

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x0025E09C File Offset: 0x0025C29C
		public bool Unique
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x0025E0DC File Offset: 0x0025C2DC
		public string Desc
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

		// Token: 0x06007B1D RID: 31517 RVA: 0x0025E114 File Offset: 0x0025C314
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x0025E124 File Offset: 0x0025C324
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06007B1F RID: 31519 RVA: 0x0025E13C File Offset: 0x0025C33C
		public int Level
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

		// Token: 0x06007B20 RID: 31520 RVA: 0x0025E179 File Offset: 0x0025C379
		[NullableContext(1)]
		public int[] Race()
		{
			return this.GetRaceArray();
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x0025E181 File Offset: 0x0025C381
		[NullableContext(1)]
		public IEnumerable<int> RaceIter()
		{
			FloroRanchToy.<RaceIter>d__44 <RaceIter>d__ = new FloroRanchToy.<RaceIter>d__44(-2);
			<RaceIter>d__.<>3__<>4__this = this;
			return <RaceIter>d__;
		}

		// Token: 0x04005310 RID: 21264
		private Table __p;
	}
}
