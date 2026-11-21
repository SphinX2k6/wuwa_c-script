using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE0 RID: 3040
	public struct AreaQuestTracking : IFlatbufferObject
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06004DFD RID: 19965 RVA: 0x001F7961 File Offset: 0x001F5B61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x001F796E File Offset: 0x001F5B6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x001F7978 File Offset: 0x001F5B78
		public static AreaQuestTracking GetRootAsAreaQuestTracking(ByteBuffer _bb)
		{
			return AreaQuestTracking.GetRootAsAreaQuestTracking(_bb, default(AreaQuestTracking));
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x001F7994 File Offset: 0x001F5B94
		public static AreaQuestTracking GetRootAsAreaQuestTracking(ByteBuffer _bb, AreaQuestTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x001F79B1 File Offset: 0x001F5BB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x001F79C0 File Offset: 0x001F5BC0
		public AreaQuestTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x001F79D0 File Offset: 0x001F5BD0
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x001F7A07 File Offset: 0x001F5C07
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x001F7A16 File Offset: 0x001F5C16
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x001F7A30 File Offset: 0x001F5C30
		public int AreaList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x001F7A70 File Offset: 0x001F5C70
		public int AreaListLength
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

		// Token: 0x06004E08 RID: 19976 RVA: 0x001F7A9B File Offset: 0x001F5C9B
		public Span<int> GetAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x001F7AAA File Offset: 0x001F5CAA
		public int[] GetAreaListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x001F7AC1 File Offset: 0x001F5CC1
		[NullableContext(1)]
		public int[] AreaList()
		{
			return this.GetAreaListArray();
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x001F7AC9 File Offset: 0x001F5CC9
		[NullableContext(1)]
		public IEnumerable<int> AreaListIter()
		{
			AreaQuestTracking.<AreaListIter>d__18 <AreaListIter>d__ = new AreaQuestTracking.<AreaListIter>d__18(-2);
			<AreaListIter>d__.<>3__<>4__this = this;
			return <AreaListIter>d__;
		}

		// Token: 0x040050C5 RID: 20677
		private Table __p;
	}
}
