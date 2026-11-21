using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E43 RID: 3651
	public struct InfoDisplayGroup : IFlatbufferObject
	{
		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x0027C400 File Offset: 0x0027A600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x0027C40D File Offset: 0x0027A60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x0027C414 File Offset: 0x0027A614
		public static InfoDisplayGroup GetRootAsInfoDisplayGroup(ByteBuffer _bb)
		{
			return InfoDisplayGroup.GetRootAsInfoDisplayGroup(_bb, default(InfoDisplayGroup));
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x0027C430 File Offset: 0x0027A630
		public static InfoDisplayGroup GetRootAsInfoDisplayGroup(ByteBuffer _bb, InfoDisplayGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x0027C44D File Offset: 0x0027A64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x0027C45C File Offset: 0x0027A65C
		public InfoDisplayGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x0027C46C File Offset: 0x0027A66C
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

		// Token: 0x0600890C RID: 35084 RVA: 0x0027C4A8 File Offset: 0x0027A6A8
		public int InfoList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x0027C4E8 File Offset: 0x0027A6E8
		public int InfoListLength
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

		// Token: 0x0600890E RID: 35086 RVA: 0x0027C513 File Offset: 0x0027A713
		public Span<int> GetInfoListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x0027C522 File Offset: 0x0027A722
		public int[] GetInfoListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x0027C539 File Offset: 0x0027A739
		[NullableContext(1)]
		public int[] InfoList()
		{
			return this.GetInfoListArray();
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x0027C541 File Offset: 0x0027A741
		[NullableContext(1)]
		public IEnumerable<int> InfoListIter()
		{
			InfoDisplayGroup.<InfoListIter>d__16 <InfoListIter>d__ = new InfoDisplayGroup.<InfoListIter>d__16(-2);
			<InfoListIter>d__.<>3__<>4__this = this;
			return <InfoListIter>d__;
		}

		// Token: 0x040053C2 RID: 21442
		private Table __p;
	}
}
