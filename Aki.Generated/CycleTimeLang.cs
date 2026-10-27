using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B5 RID: 4533
	public struct CycleTimeLang : IFlatbufferObject
	{
		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600E9EC RID: 59884 RVA: 0x00347221 File Offset: 0x00345421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9ED RID: 59885 RVA: 0x0034722E File Offset: 0x0034542E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x00347238 File Offset: 0x00345438
		public static CycleTimeLang GetRootAsCycleTimeLang(ByteBuffer _bb)
		{
			return CycleTimeLang.GetRootAsCycleTimeLang(_bb, default(CycleTimeLang));
		}

		// Token: 0x0600E9EF RID: 59887 RVA: 0x00347254 File Offset: 0x00345454
		public static CycleTimeLang GetRootAsCycleTimeLang(ByteBuffer _bb, CycleTimeLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x00347271 File Offset: 0x00345471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9F1 RID: 59889 RVA: 0x00347280 File Offset: 0x00345480
		public CycleTimeLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600E9F2 RID: 59890 RVA: 0x00347290 File Offset: 0x00345490
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

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x003472CC File Offset: 0x003454CC
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

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600E9F4 RID: 59892 RVA: 0x00347308 File Offset: 0x00345508
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

		// Token: 0x04005306 RID: 21254
		private Table __p;
	}
}
