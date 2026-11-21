using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012EB RID: 4843
	public struct CycleTimeLang : IFlatbufferObject
	{
		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0600F75D RID: 63325 RVA: 0x00371EAD File Offset: 0x003700AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F75E RID: 63326 RVA: 0x00371EBA File Offset: 0x003700BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F75F RID: 63327 RVA: 0x00371EC4 File Offset: 0x003700C4
		public static CycleTimeLang GetRootAsCycleTimeLang(ByteBuffer _bb)
		{
			return CycleTimeLang.GetRootAsCycleTimeLang(_bb, default(CycleTimeLang));
		}

		// Token: 0x0600F760 RID: 63328 RVA: 0x00371EE0 File Offset: 0x003700E0
		public static CycleTimeLang GetRootAsCycleTimeLang(ByteBuffer _bb, CycleTimeLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F761 RID: 63329 RVA: 0x00371EFD File Offset: 0x003700FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F762 RID: 63330 RVA: 0x00371F0C File Offset: 0x0037010C
		public CycleTimeLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x0600F763 RID: 63331 RVA: 0x00371F1C File Offset: 0x0037011C
		public int CycleType
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

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x0600F764 RID: 63332 RVA: 0x00371F58 File Offset: 0x00370158
		public int CycleParam
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

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x0600F765 RID: 63333 RVA: 0x00371F94 File Offset: 0x00370194
		public int TimeParam
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

		// Token: 0x04005949 RID: 22857
		private Table __p;
	}
}
