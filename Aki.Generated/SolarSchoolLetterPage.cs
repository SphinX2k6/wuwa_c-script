using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F1 RID: 4593
	public struct SolarSchoolLetterPage : IFlatbufferObject
	{
		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600E221 RID: 57889 RVA: 0x00342806 File Offset: 0x00340A06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E222 RID: 57890 RVA: 0x00342813 File Offset: 0x00340A13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x0034281C File Offset: 0x00340A1C
		public static SolarSchoolLetterPage GetRootAsSolarSchoolLetterPage(ByteBuffer _bb)
		{
			return SolarSchoolLetterPage.GetRootAsSolarSchoolLetterPage(_bb, default(SolarSchoolLetterPage));
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x00342838 File Offset: 0x00340A38
		public static SolarSchoolLetterPage GetRootAsSolarSchoolLetterPage(ByteBuffer _bb, SolarSchoolLetterPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E225 RID: 57893 RVA: 0x00342855 File Offset: 0x00340A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E226 RID: 57894 RVA: 0x00342864 File Offset: 0x00340A64
		public SolarSchoolLetterPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600E227 RID: 57895 RVA: 0x00342874 File Offset: 0x00340A74
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

		// Token: 0x0600E228 RID: 57896 RVA: 0x003428B0 File Offset: 0x00340AB0
		public string Paragraph(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600E229 RID: 57897 RVA: 0x003428EC File Offset: 0x00340AEC
		public int ParagraphLength
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

		// Token: 0x0600E22A RID: 57898 RVA: 0x00342917 File Offset: 0x00340B17
		[NullableContext(1)]
		public string[] Paragraph()
		{
			return this.ParagraphIter().ToArray<string>();
		}

		// Token: 0x0600E22B RID: 57899 RVA: 0x00342924 File Offset: 0x00340B24
		[NullableContext(1)]
		public IEnumerable<string> ParagraphIter()
		{
			SolarSchoolLetterPage.<ParagraphIter>d__14 <ParagraphIter>d__ = new SolarSchoolLetterPage.<ParagraphIter>d__14(-2);
			<ParagraphIter>d__.<>3__<>4__this = this;
			return <ParagraphIter>d__;
		}

		// Token: 0x0400582F RID: 22575
		private Table __p;
	}
}
