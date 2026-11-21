using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8F RID: 3471
	public struct FloroRanchIns : IFlatbufferObject
	{
		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x0025A29D File Offset: 0x0025849D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x0025A2AA File Offset: 0x002584AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0025A2B4 File Offset: 0x002584B4
		public static FloroRanchIns GetRootAsFloroRanchIns(ByteBuffer _bb)
		{
			return FloroRanchIns.GetRootAsFloroRanchIns(_bb, default(FloroRanchIns));
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x0025A2D0 File Offset: 0x002584D0
		public static FloroRanchIns GetRootAsFloroRanchIns(ByteBuffer _bb, FloroRanchIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x0025A2ED File Offset: 0x002584ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x0025A2FC File Offset: 0x002584FC
		public FloroRanchIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600797B RID: 31099 RVA: 0x0025A30C File Offset: 0x0025850C
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x0025A348 File Offset: 0x00258548
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x0025A384 File Offset: 0x00258584
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

		// Token: 0x0600797E RID: 31102 RVA: 0x0025A3BB File Offset: 0x002585BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x0025A3CA File Offset: 0x002585CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06007980 RID: 31104 RVA: 0x0025A3E4 File Offset: 0x002585E4
		public int DelayTime
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x0025A424 File Offset: 0x00258624
		public int SortId
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

		// Token: 0x06007982 RID: 31106 RVA: 0x0025A464 File Offset: 0x00258664
		public int SubInsList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06007983 RID: 31107 RVA: 0x0025A4A4 File Offset: 0x002586A4
		public int SubInsListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x0025A4D0 File Offset: 0x002586D0
		public Span<int> GetSubInsListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x0025A4E0 File Offset: 0x002586E0
		public int[] GetSubInsListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x0025A4F8 File Offset: 0x002586F8
		public int Difficulty
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x0025A538 File Offset: 0x00258738
		public string RomeIconPath
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

		// Token: 0x06007988 RID: 31112 RVA: 0x0025A570 File Offset: 0x00258770
		public Span<byte> GetRomeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x0025A580 File Offset: 0x00258780
		public byte[] GetRomeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x0025A598 File Offset: 0x00258798
		[NullableContext(1)]
		public int[] SubInsList()
		{
			return this.GetSubInsListArray();
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x0025A5A0 File Offset: 0x002587A0
		[NullableContext(1)]
		public IEnumerable<int> SubInsListIter()
		{
			FloroRanchIns.<SubInsListIter>d__32 <SubInsListIter>d__ = new FloroRanchIns.<SubInsListIter>d__32(-2);
			<SubInsListIter>d__.<>3__<>4__this = this;
			return <SubInsListIter>d__;
		}

		// Token: 0x040052F3 RID: 21235
		private Table __p;
	}
}
