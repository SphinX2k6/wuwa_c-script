using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8B RID: 3979
	public struct RacingBetsLegMatches : IFlatbufferObject
	{
		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600B82B RID: 47147 RVA: 0x002D574D File Offset: 0x002D394D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x002D575A File Offset: 0x002D395A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x002D5764 File Offset: 0x002D3964
		public static RacingBetsLegMatches GetRootAsRacingBetsLegMatches(ByteBuffer _bb)
		{
			return RacingBetsLegMatches.GetRootAsRacingBetsLegMatches(_bb, default(RacingBetsLegMatches));
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x002D5780 File Offset: 0x002D3980
		public static RacingBetsLegMatches GetRootAsRacingBetsLegMatches(ByteBuffer _bb, RacingBetsLegMatches obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x002D579D File Offset: 0x002D399D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x002D57AC File Offset: 0x002D39AC
		public RacingBetsLegMatches __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600B831 RID: 47153 RVA: 0x002D57BC File Offset: 0x002D39BC
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

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600B832 RID: 47154 RVA: 0x002D57F8 File Offset: 0x002D39F8
		public int MatchId
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

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0600B833 RID: 47155 RVA: 0x002D5834 File Offset: 0x002D3A34
		public string Name
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

		// Token: 0x0600B834 RID: 47156 RVA: 0x002D586B File Offset: 0x002D3A6B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x002D587A File Offset: 0x002D3A7A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x002D5894 File Offset: 0x002D3A94
		public string SimpleName
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

		// Token: 0x0600B837 RID: 47159 RVA: 0x002D58CC File Offset: 0x002D3ACC
		public Span<byte> GetSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x002D58DC File Offset: 0x002D3ADC
		public byte[] GetSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600B839 RID: 47161 RVA: 0x002D58F4 File Offset: 0x002D3AF4
		public string ShortName
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

		// Token: 0x0600B83A RID: 47162 RVA: 0x002D592C File Offset: 0x002D3B2C
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x002D593C File Offset: 0x002D3B3C
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600B83C RID: 47164 RVA: 0x002D5954 File Offset: 0x002D3B54
		public int Type
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

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600B83D RID: 47165 RVA: 0x002D5994 File Offset: 0x002D3B94
		public int EndPoint
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

		// Token: 0x0600B83E RID: 47166 RVA: 0x002D59D4 File Offset: 0x002D3BD4
		public int DiceTypeList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0600B83F RID: 47167 RVA: 0x002D5A14 File Offset: 0x002D3C14
		public int DiceTypeListLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x002D5A40 File Offset: 0x002D3C40
		public Span<int> GetDiceTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x002D5A50 File Offset: 0x002D3C50
		public int[] GetDiceTypeListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x002D5A68 File Offset: 0x002D3C68
		public string OrganList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0600B843 RID: 47171 RVA: 0x002D5AA4 File Offset: 0x002D3CA4
		public int OrganListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x002D5AD0 File Offset: 0x002D3CD0
		public int ShowOrganList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x002D5B10 File Offset: 0x002D3D10
		public int ShowOrganListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x002D5B3C File Offset: 0x002D3D3C
		public Span<int> GetShowOrganListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x002D5B4C File Offset: 0x002D3D4C
		public int[] GetShowOrganListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x002D5B64 File Offset: 0x002D3D64
		public string BtnBgPath
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

		// Token: 0x0600B849 RID: 47177 RVA: 0x002D5B9C File Offset: 0x002D3D9C
		public Span<byte> GetBtnBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B84A RID: 47178 RVA: 0x002D5BAC File Offset: 0x002D3DAC
		public byte[] GetBtnBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x002D5BC4 File Offset: 0x002D3DC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DiceTypeListIter()或GetDiceTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DiceTypeList()
		{
			RacingBetsLegMatches racingBetsLegMatches = this;
			return racingBetsLegMatches.GetDiceTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x002D5BE8 File Offset: 0x002D3DE8
		[NullableContext(1)]
		public readonly IEnumerable<int> DiceTypeListIter()
		{
			RacingBetsLegMatches.<DiceTypeListIter>d__46 <DiceTypeListIter>d__ = new RacingBetsLegMatches.<DiceTypeListIter>d__46(-2);
			<DiceTypeListIter>d__.<>3__<>4__this = this;
			return <DiceTypeListIter>d__;
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x002D5BFD File Offset: 0x002D3DFD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OrganListIter()或GetOrganListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OrganList()
		{
			return this.OrganListIter().ToArray<string>();
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x002D5C0A File Offset: 0x002D3E0A
		[NullableContext(1)]
		public readonly IEnumerable<string> OrganListIter()
		{
			RacingBetsLegMatches.<OrganListIter>d__48 <OrganListIter>d__ = new RacingBetsLegMatches.<OrganListIter>d__48(-2);
			<OrganListIter>d__.<>3__<>4__this = this;
			return <OrganListIter>d__;
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x002D5C20 File Offset: 0x002D3E20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowOrganListIter()或GetShowOrganListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowOrganList()
		{
			RacingBetsLegMatches racingBetsLegMatches = this;
			return racingBetsLegMatches.GetShowOrganListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x002D5C44 File Offset: 0x002D3E44
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowOrganListIter()
		{
			RacingBetsLegMatches.<ShowOrganListIter>d__50 <ShowOrganListIter>d__ = new RacingBetsLegMatches.<ShowOrganListIter>d__50(-2);
			<ShowOrganListIter>d__.<>3__<>4__this = this;
			return <ShowOrganListIter>d__;
		}

		// Token: 0x0400505A RID: 20570
		private Table __p;
	}
}
