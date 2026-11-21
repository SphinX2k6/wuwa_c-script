using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A6 RID: 4774
	public struct TrapDefenseTech : IFlatbufferObject
	{
		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x0600F206 RID: 61958 RVA: 0x00365BDC File Offset: 0x00363DDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F207 RID: 61959 RVA: 0x00365BE9 File Offset: 0x00363DE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F208 RID: 61960 RVA: 0x00365BF0 File Offset: 0x00363DF0
		public static TrapDefenseTech GetRootAsTrapDefenseTech(ByteBuffer _bb)
		{
			return TrapDefenseTech.GetRootAsTrapDefenseTech(_bb, default(TrapDefenseTech));
		}

		// Token: 0x0600F209 RID: 61961 RVA: 0x00365C0C File Offset: 0x00363E0C
		public static TrapDefenseTech GetRootAsTrapDefenseTech(ByteBuffer _bb, TrapDefenseTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F20A RID: 61962 RVA: 0x00365C29 File Offset: 0x00363E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F20B RID: 61963 RVA: 0x00365C38 File Offset: 0x00363E38
		public TrapDefenseTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x0600F20C RID: 61964 RVA: 0x00365C48 File Offset: 0x00363E48
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

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x0600F20D RID: 61965 RVA: 0x00365C84 File Offset: 0x00363E84
		public int ActivityId
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

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x0600F20E RID: 61966 RVA: 0x00365CC0 File Offset: 0x00363EC0
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

		// Token: 0x0600F20F RID: 61967 RVA: 0x00365CF7 File Offset: 0x00363EF7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F210 RID: 61968 RVA: 0x00365D06 File Offset: 0x00363F06
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x0600F211 RID: 61969 RVA: 0x00365D20 File Offset: 0x00363F20
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

		// Token: 0x0600F212 RID: 61970 RVA: 0x00365D58 File Offset: 0x00363F58
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x00365D68 File Offset: 0x00363F68
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0600F214 RID: 61972 RVA: 0x00365D80 File Offset: 0x00363F80
		public int Type
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

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0600F215 RID: 61973 RVA: 0x00365DC0 File Offset: 0x00363FC0
		public int FuncType
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

		// Token: 0x0600F216 RID: 61974 RVA: 0x00365E00 File Offset: 0x00364000
		public int FuncParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x0600F217 RID: 61975 RVA: 0x00365E40 File Offset: 0x00364040
		public int FuncParamsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x00365E6C File Offset: 0x0036406C
		public Span<int> GetFuncParamsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x00365E7C File Offset: 0x0036407C
		public int[] GetFuncParamsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x00365E94 File Offset: 0x00364094
		public int Gainings(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x0600F21B RID: 61979 RVA: 0x00365ED4 File Offset: 0x003640D4
		public int GainingsLength
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

		// Token: 0x0600F21C RID: 61980 RVA: 0x00365F00 File Offset: 0x00364100
		public Span<int> GetGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600F21D RID: 61981 RVA: 0x00365F10 File Offset: 0x00364110
		public int[] GetGainingsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600F21E RID: 61982 RVA: 0x00365F28 File Offset: 0x00364128
		public int PreNode(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0600F21F RID: 61983 RVA: 0x00365F68 File Offset: 0x00364168
		public int PreNodeLength
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

		// Token: 0x0600F220 RID: 61984 RVA: 0x00365F94 File Offset: 0x00364194
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x00365FA4 File Offset: 0x003641A4
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0600F222 RID: 61986 RVA: 0x00365FBC File Offset: 0x003641BC
		public int UnlockCost
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

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0600F223 RID: 61987 RVA: 0x00365FFC File Offset: 0x003641FC
		public int Row
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x0600F224 RID: 61988 RVA: 0x0036603C File Offset: 0x0036423C
		public int Col
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0600F225 RID: 61989 RVA: 0x0036607C File Offset: 0x0036427C
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F226 RID: 61990 RVA: 0x003660B4 File Offset: 0x003642B4
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x003660C4 File Offset: 0x003642C4
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0600F228 RID: 61992 RVA: 0x003660DC File Offset: 0x003642DC
		public string IconPathBig
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x00366114 File Offset: 0x00364314
		public Span<byte> GetIconPathBigBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x00366124 File Offset: 0x00364324
		public byte[] GetIconPathBigArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x0036613C File Offset: 0x0036433C
		[NullableContext(1)]
		public int[] FuncParams()
		{
			return this.GetFuncParamsArray();
		}

		// Token: 0x0600F22C RID: 61996 RVA: 0x00366144 File Offset: 0x00364344
		[NullableContext(1)]
		public IEnumerable<int> FuncParamsIter()
		{
			TrapDefenseTech.<FuncParamsIter>d__54 <FuncParamsIter>d__ = new TrapDefenseTech.<FuncParamsIter>d__54(-2);
			<FuncParamsIter>d__.<>3__<>4__this = this;
			return <FuncParamsIter>d__;
		}

		// Token: 0x0600F22D RID: 61997 RVA: 0x00366159 File Offset: 0x00364359
		[NullableContext(1)]
		public int[] Gainings()
		{
			return this.GetGainingsArray();
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x00366161 File Offset: 0x00364361
		[NullableContext(1)]
		public IEnumerable<int> GainingsIter()
		{
			TrapDefenseTech.<GainingsIter>d__56 <GainingsIter>d__ = new TrapDefenseTech.<GainingsIter>d__56(-2);
			<GainingsIter>d__.<>3__<>4__this = this;
			return <GainingsIter>d__;
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x00366176 File Offset: 0x00364376
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x0600F230 RID: 62000 RVA: 0x0036617E File Offset: 0x0036437E
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			TrapDefenseTech.<PreNodeIter>d__58 <PreNodeIter>d__ = new TrapDefenseTech.<PreNodeIter>d__58(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x040058F9 RID: 22777
		private Table __p;
	}
}
