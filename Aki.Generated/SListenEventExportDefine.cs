using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001319 RID: 4889
	public struct SListenEventExportDefine : IFlatbufferObject
	{
		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x0600F8FA RID: 63738 RVA: 0x0037532C File Offset: 0x0037352C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x00375339 File Offset: 0x00373539
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00375340 File Offset: 0x00373540
		public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb)
		{
			return SListenEventExportDefine.GetRootAsSListenEventExportDefine(_bb, default(SListenEventExportDefine));
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x0037535C File Offset: 0x0037355C
		public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb, SListenEventExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8FE RID: 63742 RVA: 0x00375379 File Offset: 0x00373579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8FF RID: 63743 RVA: 0x00375388 File Offset: 0x00373588
		public SListenEventExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F900 RID: 63744 RVA: 0x00375398 File Offset: 0x00373598
		public int ListenConfigIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x0600F901 RID: 63745 RVA: 0x003753D8 File Offset: 0x003735D8
		public int ListenConfigIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x00375403 File Offset: 0x00373603
		public Span<int> GetListenConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x00375412 File Offset: 0x00373612
		public int[] GetListenConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0600F904 RID: 63748 RVA: 0x0037542C File Offset: 0x0037362C
		public float ListenRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x0037546C File Offset: 0x0037366C
		[NullableContext(1)]
		public int[] ListenConfigIds()
		{
			return this.GetListenConfigIdsArray();
		}

		// Token: 0x0600F906 RID: 63750 RVA: 0x00375474 File Offset: 0x00373674
		[NullableContext(1)]
		public IEnumerable<int> ListenConfigIdsIter()
		{
			SListenEventExportDefine.<ListenConfigIdsIter>d__16 <ListenConfigIdsIter>d__ = new SListenEventExportDefine.<ListenConfigIdsIter>d__16(-2);
			<ListenConfigIdsIter>d__.<>3__<>4__this = this;
			return <ListenConfigIdsIter>d__;
		}

		// Token: 0x0400599F RID: 22943
		private Table __p;
	}
}
