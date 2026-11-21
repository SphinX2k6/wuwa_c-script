using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8C RID: 3468
	public struct FloroRanchEvent : IFlatbufferObject
	{
		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06007935 RID: 31029 RVA: 0x002598EC File Offset: 0x00257AEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x002598F9 File Offset: 0x00257AF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00259900 File Offset: 0x00257B00
		public static FloroRanchEvent GetRootAsFloroRanchEvent(ByteBuffer _bb)
		{
			return FloroRanchEvent.GetRootAsFloroRanchEvent(_bb, default(FloroRanchEvent));
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0025991C File Offset: 0x00257B1C
		public static FloroRanchEvent GetRootAsFloroRanchEvent(ByteBuffer _bb, FloroRanchEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00259939 File Offset: 0x00257B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x00259948 File Offset: 0x00257B48
		public FloroRanchEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x0600793B RID: 31035 RVA: 0x00259958 File Offset: 0x00257B58
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

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x0600793C RID: 31036 RVA: 0x00259994 File Offset: 0x00257B94
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

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x0600793D RID: 31037 RVA: 0x002599D0 File Offset: 0x00257BD0
		public int Unique
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

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x0600793E RID: 31038 RVA: 0x00259A0C File Offset: 0x00257C0C
		public string Title
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

		// Token: 0x0600793F RID: 31039 RVA: 0x00259A44 File Offset: 0x00257C44
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x00259A54 File Offset: 0x00257C54
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x00259A6C File Offset: 0x00257C6C
		public string Desc
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

		// Token: 0x06007942 RID: 31042 RVA: 0x00259AA4 File Offset: 0x00257CA4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00259AB4 File Offset: 0x00257CB4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00259ACC File Offset: 0x00257CCC
		public int Choice(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x00259B0C File Offset: 0x00257D0C
		public int ChoiceLength
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

		// Token: 0x06007946 RID: 31046 RVA: 0x00259B38 File Offset: 0x00257D38
		public Span<int> GetChoiceBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00259B48 File Offset: 0x00257D48
		public int[] GetChoiceArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06007948 RID: 31048 RVA: 0x00259B60 File Offset: 0x00257D60
		public int Rate
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

		// Token: 0x06007949 RID: 31049 RVA: 0x00259B9D File Offset: 0x00257D9D
		[NullableContext(1)]
		public int[] Choice()
		{
			return this.GetChoiceArray();
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00259BA5 File Offset: 0x00257DA5
		[NullableContext(1)]
		public IEnumerable<int> ChoiceIter()
		{
			FloroRanchEvent.<ChoiceIter>d__30 <ChoiceIter>d__ = new FloroRanchEvent.<ChoiceIter>d__30(-2);
			<ChoiceIter>d__.<>3__<>4__this = this;
			return <ChoiceIter>d__;
		}

		// Token: 0x040052EE RID: 21230
		private Table __p;
	}
}
