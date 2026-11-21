using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F0 RID: 4592
	public struct SolarSchoolLetter : IFlatbufferObject
	{
		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600E211 RID: 57873 RVA: 0x003425F4 File Offset: 0x003407F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E212 RID: 57874 RVA: 0x00342601 File Offset: 0x00340801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E213 RID: 57875 RVA: 0x00342608 File Offset: 0x00340808
		public static SolarSchoolLetter GetRootAsSolarSchoolLetter(ByteBuffer _bb)
		{
			return SolarSchoolLetter.GetRootAsSolarSchoolLetter(_bb, default(SolarSchoolLetter));
		}

		// Token: 0x0600E214 RID: 57876 RVA: 0x00342624 File Offset: 0x00340824
		public static SolarSchoolLetter GetRootAsSolarSchoolLetter(ByteBuffer _bb, SolarSchoolLetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E215 RID: 57877 RVA: 0x00342641 File Offset: 0x00340841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x00342650 File Offset: 0x00340850
		public SolarSchoolLetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600E217 RID: 57879 RVA: 0x00342660 File Offset: 0x00340860
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

		// Token: 0x0600E218 RID: 57880 RVA: 0x0034269C File Offset: 0x0034089C
		public int PageList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600E219 RID: 57881 RVA: 0x003426DC File Offset: 0x003408DC
		public int PageListLength
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

		// Token: 0x0600E21A RID: 57882 RVA: 0x00342707 File Offset: 0x00340907
		public Span<int> GetPageListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E21B RID: 57883 RVA: 0x00342716 File Offset: 0x00340916
		public int[] GetPageListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x00342730 File Offset: 0x00340930
		public int PageStart
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

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600E21D RID: 57885 RVA: 0x0034276C File Offset: 0x0034096C
		public int PageEnd
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

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600E21E RID: 57886 RVA: 0x003427AC File Offset: 0x003409AC
		public int StartAnimStyle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E21F RID: 57887 RVA: 0x003427E9 File Offset: 0x003409E9
		[NullableContext(1)]
		public int[] PageList()
		{
			return this.GetPageListArray();
		}

		// Token: 0x0600E220 RID: 57888 RVA: 0x003427F1 File Offset: 0x003409F1
		[NullableContext(1)]
		public IEnumerable<int> PageListIter()
		{
			SolarSchoolLetter.<PageListIter>d__22 <PageListIter>d__ = new SolarSchoolLetter.<PageListIter>d__22(-2);
			<PageListIter>d__.<>3__<>4__this = this;
			return <PageListIter>d__;
		}

		// Token: 0x0400582E RID: 22574
		private Table __p;
	}
}
