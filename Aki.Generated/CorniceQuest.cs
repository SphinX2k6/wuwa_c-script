using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA8 RID: 2984
	public struct CorniceQuest : IFlatbufferObject
	{
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x00201B52 File Offset: 0x001FFD52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00201B5F File Offset: 0x001FFD5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00201B68 File Offset: 0x001FFD68
		public static CorniceQuest GetRootAsCorniceQuest(ByteBuffer _bb)
		{
			return CorniceQuest.GetRootAsCorniceQuest(_bb, default(CorniceQuest));
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00201B84 File Offset: 0x001FFD84
		public static CorniceQuest GetRootAsCorniceQuest(ByteBuffer _bb, CorniceQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00201BA1 File Offset: 0x001FFDA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00201BB0 File Offset: 0x001FFDB0
		public CorniceQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06005A4F RID: 23119 RVA: 0x00201BC0 File Offset: 0x001FFDC0
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06005A50 RID: 23120 RVA: 0x00201BFC File Offset: 0x001FFDFC
		public int QuestId
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

		// Token: 0x04004BCB RID: 19403
		private Table __p;
	}
}
