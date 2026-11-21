using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE8 RID: 3816
	public struct MatchThreeSkill : IFlatbufferObject
	{
		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600994D RID: 39245 RVA: 0x002A1381 File Offset: 0x0029F581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x002A138E File Offset: 0x0029F58E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x002A1398 File Offset: 0x0029F598
		public static MatchThreeSkill GetRootAsMatchThreeSkill(ByteBuffer _bb)
		{
			return MatchThreeSkill.GetRootAsMatchThreeSkill(_bb, default(MatchThreeSkill));
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x002A13B4 File Offset: 0x0029F5B4
		public static MatchThreeSkill GetRootAsMatchThreeSkill(ByteBuffer _bb, MatchThreeSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x002A13D1 File Offset: 0x0029F5D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x002A13E0 File Offset: 0x0029F5E0
		public MatchThreeSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06009953 RID: 39251 RVA: 0x002A13F0 File Offset: 0x0029F5F0
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x002A142C File Offset: 0x0029F62C
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

		// Token: 0x06009955 RID: 39253 RVA: 0x002A1468 File Offset: 0x0029F668
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x002A14A8 File Offset: 0x0029F6A8
		public int ParamsLength
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

		// Token: 0x06009957 RID: 39255 RVA: 0x002A14D3 File Offset: 0x0029F6D3
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x002A14E2 File Offset: 0x0029F6E2
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x002A14FC File Offset: 0x0029F6FC
		public int ExtraParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x002A153C File Offset: 0x0029F73C
		public int ExtraParamsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x002A1568 File Offset: 0x0029F768
		public Span<int> GetExtraParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x002A1578 File Offset: 0x0029F778
		public int[] GetExtraParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x0600995D RID: 39261 RVA: 0x002A1590 File Offset: 0x0029F790
		public int Energy
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

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x002A15D0 File Offset: 0x0029F7D0
		public string Name
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

		// Token: 0x0600995F RID: 39263 RVA: 0x002A1608 File Offset: 0x0029F808
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x002A1618 File Offset: 0x0029F818
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x002A1630 File Offset: 0x0029F830
		public string Desc
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

		// Token: 0x06009962 RID: 39266 RVA: 0x002A1668 File Offset: 0x0029F868
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x002A1678 File Offset: 0x0029F878
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06009964 RID: 39268 RVA: 0x002A1690 File Offset: 0x0029F890
		public string Icon
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

		// Token: 0x06009965 RID: 39269 RVA: 0x002A16C8 File Offset: 0x0029F8C8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x002A16D8 File Offset: 0x0029F8D8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x002A16F0 File Offset: 0x0029F8F0
		[NullableContext(1)]
		public int[] ExtraParams()
		{
			return this.GetExtraParamsArray();
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x002A16F8 File Offset: 0x0029F8F8
		[NullableContext(1)]
		public IEnumerable<int> ExtraParamsIter()
		{
			MatchThreeSkill.<ExtraParamsIter>d__37 <ExtraParamsIter>d__ = new MatchThreeSkill.<ExtraParamsIter>d__37(-2);
			<ExtraParamsIter>d__.<>3__<>4__this = this;
			return <ExtraParamsIter>d__;
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x002A170D File Offset: 0x0029F90D
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x002A1715 File Offset: 0x0029F915
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			MatchThreeSkill.<ParamsIter>d__39 <ParamsIter>d__ = new MatchThreeSkill.<ParamsIter>d__39(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005489 RID: 21641
		private Table __p;
	}
}
