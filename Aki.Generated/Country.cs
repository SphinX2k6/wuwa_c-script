using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8B RID: 3211
	public struct Country : IFlatbufferObject
	{
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600602A RID: 24618 RVA: 0x0022197C File Offset: 0x0021FB7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00221989 File Offset: 0x0021FB89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00221990 File Offset: 0x0021FB90
		public static Country GetRootAsCountry(ByteBuffer _bb)
		{
			return Country.GetRootAsCountry(_bb, default(Country));
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x002219AC File Offset: 0x0021FBAC
		public static Country GetRootAsCountry(ByteBuffer _bb, Country obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x002219C9 File Offset: 0x0021FBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x002219D8 File Offset: 0x0021FBD8
		public Country __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x002219E8 File Offset: 0x0021FBE8
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

		// Token: 0x06006031 RID: 24625 RVA: 0x00221A24 File Offset: 0x0021FC24
		public int Influences(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x00221A64 File Offset: 0x0021FC64
		public int InfluencesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00221A8F File Offset: 0x0021FC8F
		public Span<int> GetInfluencesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00221A9E File Offset: 0x0021FC9E
		public int[] GetInfluencesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x00221AB8 File Offset: 0x0021FCB8
		public string Title
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

		// Token: 0x06006036 RID: 24630 RVA: 0x00221AEF File Offset: 0x0021FCEF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00221AFE File Offset: 0x0021FCFE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06006038 RID: 24632 RVA: 0x00221B18 File Offset: 0x0021FD18
		public string Desc
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

		// Token: 0x06006039 RID: 24633 RVA: 0x00221B50 File Offset: 0x0021FD50
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x00221B60 File Offset: 0x0021FD60
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x00221B78 File Offset: 0x0021FD78
		public string Logo
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

		// Token: 0x0600603C RID: 24636 RVA: 0x00221BB0 File Offset: 0x0021FDB0
		public Span<byte> GetLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00221BC0 File Offset: 0x0021FDC0
		public byte[] GetLogoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x00221BD8 File Offset: 0x0021FDD8
		public int DailyTaskShow
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

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x00221C18 File Offset: 0x0021FE18
		public string AudioName
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

		// Token: 0x06006040 RID: 24640 RVA: 0x00221C50 File Offset: 0x0021FE50
		public Span<byte> GetAudioNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x00221C60 File Offset: 0x0021FE60
		public byte[] GetAudioNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x00221C78 File Offset: 0x0021FE78
		public string WwiseStateName
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

		// Token: 0x06006043 RID: 24643 RVA: 0x00221CB0 File Offset: 0x0021FEB0
		public Span<byte> GetWwiseStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x00221CC0 File Offset: 0x0021FEC0
		public byte[] GetWwiseStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x00221CD8 File Offset: 0x0021FED8
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

		// Token: 0x06006046 RID: 24646 RVA: 0x00221D10 File Offset: 0x0021FF10
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00221D20 File Offset: 0x0021FF20
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x00221D38 File Offset: 0x0021FF38
		public int SortIndex
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

		// Token: 0x06006049 RID: 24649 RVA: 0x00221D75 File Offset: 0x0021FF75
		[NullableContext(1)]
		public int[] Influences()
		{
			return this.GetInfluencesArray();
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x00221D7D File Offset: 0x0021FF7D
		[NullableContext(1)]
		public IEnumerable<int> InfluencesIter()
		{
			Country.<InfluencesIter>d__44 <InfluencesIter>d__ = new Country.<InfluencesIter>d__44(-2);
			<InfluencesIter>d__.<>3__<>4__this = this;
			return <InfluencesIter>d__;
		}

		// Token: 0x040051AE RID: 20910
		private Table __p;
	}
}
