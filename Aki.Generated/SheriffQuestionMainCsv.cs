using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A0 RID: 4512
	public struct SheriffQuestionMainCsv : IFlatbufferObject
	{
		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600D943 RID: 55619 RVA: 0x0032D5A5 File Offset: 0x0032B7A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x0032D5B2 File Offset: 0x0032B7B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D945 RID: 55621 RVA: 0x0032D5BC File Offset: 0x0032B7BC
		public static SheriffQuestionMainCsv GetRootAsSheriffQuestionMainCsv(ByteBuffer _bb)
		{
			return SheriffQuestionMainCsv.GetRootAsSheriffQuestionMainCsv(_bb, default(SheriffQuestionMainCsv));
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x0032D5D8 File Offset: 0x0032B7D8
		public static SheriffQuestionMainCsv GetRootAsSheriffQuestionMainCsv(ByteBuffer _bb, SheriffQuestionMainCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x0032D5F5 File Offset: 0x0032B7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D948 RID: 55624 RVA: 0x0032D604 File Offset: 0x0032B804
		public SheriffQuestionMainCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600D949 RID: 55625 RVA: 0x0032D614 File Offset: 0x0032B814
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

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600D94A RID: 55626 RVA: 0x0032D650 File Offset: 0x0032B850
		public string Remark
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x0032D687 File Offset: 0x0032B887
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x0032D696 File Offset: 0x0032B896
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D94D RID: 55629 RVA: 0x0032D6B0 File Offset: 0x0032B8B0
		public int ClueIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x0032D6F0 File Offset: 0x0032B8F0
		public int ClueIdsLength
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

		// Token: 0x0600D94F RID: 55631 RVA: 0x0032D71B File Offset: 0x0032B91B
		public Span<int> GetClueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D950 RID: 55632 RVA: 0x0032D72A File Offset: 0x0032B92A
		public int[] GetClueIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600D951 RID: 55633 RVA: 0x0032D744 File Offset: 0x0032B944
		public string QuestionConfigs
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

		// Token: 0x0600D952 RID: 55634 RVA: 0x0032D77C File Offset: 0x0032B97C
		public Span<byte> GetQuestionConfigsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D953 RID: 55635 RVA: 0x0032D78C File Offset: 0x0032B98C
		public byte[] GetQuestionConfigsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D954 RID: 55636 RVA: 0x0032D7A4 File Offset: 0x0032B9A4
		[NullableContext(1)]
		public int[] ClueIds()
		{
			return this.GetClueIdsArray();
		}

		// Token: 0x0600D955 RID: 55637 RVA: 0x0032D7AC File Offset: 0x0032B9AC
		[NullableContext(1)]
		public IEnumerable<int> ClueIdsIter()
		{
			SheriffQuestionMainCsv.<ClueIdsIter>d__24 <ClueIdsIter>d__ = new SheriffQuestionMainCsv.<ClueIdsIter>d__24(-2);
			<ClueIdsIter>d__.<>3__<>4__this = this;
			return <ClueIdsIter>d__;
		}

		// Token: 0x040057B3 RID: 22451
		private Table __p;
	}
}
