using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001315 RID: 4885
	public struct SCreatureGenNavAssistAreaExportDefine : IFlatbufferObject
	{
		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0600F8D2 RID: 63698 RVA: 0x00374EE4 File Offset: 0x003730E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x00374EF1 File Offset: 0x003730F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x00374EF8 File Offset: 0x003730F8
		public static SCreatureGenNavAssistAreaExportDefine GetRootAsSCreatureGenNavAssistAreaExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenNavAssistAreaExportDefine.GetRootAsSCreatureGenNavAssistAreaExportDefine(_bb, default(SCreatureGenNavAssistAreaExportDefine));
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x00374F14 File Offset: 0x00373114
		public static SCreatureGenNavAssistAreaExportDefine GetRootAsSCreatureGenNavAssistAreaExportDefine(ByteBuffer _bb, SCreatureGenNavAssistAreaExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00374F31 File Offset: 0x00373131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00374F40 File Offset: 0x00373140
		public SCreatureGenNavAssistAreaExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00374F50 File Offset: 0x00373150
		public IntVector? Points(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0600F8D9 RID: 63705 RVA: 0x00374FB0 File Offset: 0x003731B0
		public int PointsLength
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

		// Token: 0x0600F8DA RID: 63706 RVA: 0x00374FDB File Offset: 0x003731DB
		[NullableContext(1)]
		public IntVector[] Points()
		{
			return this.PointsIter().ToArray<IntVector>();
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x00374FE8 File Offset: 0x003731E8
		[NullableContext(1)]
		public IEnumerable<IntVector> PointsIter()
		{
			SCreatureGenNavAssistAreaExportDefine.<PointsIter>d__12 <PointsIter>d__ = new SCreatureGenNavAssistAreaExportDefine.<PointsIter>d__12(-2);
			<PointsIter>d__.<>3__<>4__this = this;
			return <PointsIter>d__;
		}

		// Token: 0x0400599B RID: 22939
		private Table __p;
	}
}
