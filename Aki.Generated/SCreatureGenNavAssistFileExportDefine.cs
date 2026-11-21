using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001316 RID: 4886
	public struct SCreatureGenNavAssistFileExportDefine : IFlatbufferObject
	{
		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0600F8DC RID: 63708 RVA: 0x00374FFD File Offset: 0x003731FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x0037500A File Offset: 0x0037320A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x00375014 File Offset: 0x00373214
		public static SCreatureGenNavAssistFileExportDefine GetRootAsSCreatureGenNavAssistFileExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenNavAssistFileExportDefine.GetRootAsSCreatureGenNavAssistFileExportDefine(_bb, default(SCreatureGenNavAssistFileExportDefine));
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x00375030 File Offset: 0x00373230
		public static SCreatureGenNavAssistFileExportDefine GetRootAsSCreatureGenNavAssistFileExportDefine(ByteBuffer _bb, SCreatureGenNavAssistFileExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x0037504D File Offset: 0x0037324D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x0037505C File Offset: 0x0037325C
		public SCreatureGenNavAssistFileExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F8E2 RID: 63714 RVA: 0x0037506C File Offset: 0x0037326C
		public SCreatureGenNavAssistAreaExportDefine? Areas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new SCreatureGenNavAssistAreaExportDefine?(default(SCreatureGenNavAssistAreaExportDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x0600F8E3 RID: 63715 RVA: 0x003750CC File Offset: 0x003732CC
		public int AreasLength
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

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x003750F7 File Offset: 0x003732F7
		[NullableContext(1)]
		public SCreatureGenNavAssistAreaExportDefine[] Areas()
		{
			return this.AreasIter().ToArray<SCreatureGenNavAssistAreaExportDefine>();
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00375104 File Offset: 0x00373304
		[NullableContext(1)]
		public IEnumerable<SCreatureGenNavAssistAreaExportDefine> AreasIter()
		{
			SCreatureGenNavAssistFileExportDefine.<AreasIter>d__12 <AreasIter>d__ = new SCreatureGenNavAssistFileExportDefine.<AreasIter>d__12(-2);
			<AreasIter>d__.<>3__<>4__this = this;
			return <AreasIter>d__;
		}

		// Token: 0x0400599C RID: 22940
		private Table __p;
	}
}
