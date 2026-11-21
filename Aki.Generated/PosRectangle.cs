using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130E RID: 4878
	public struct PosRectangle : IFlatbufferObject
	{
		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0600F86F RID: 63599 RVA: 0x00373DEC File Offset: 0x00371FEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x00373DF9 File Offset: 0x00371FF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x00373E00 File Offset: 0x00372000
		public static PosRectangle GetRootAsPosRectangle(ByteBuffer _bb)
		{
			return PosRectangle.GetRootAsPosRectangle(_bb, default(PosRectangle));
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x00373E1C File Offset: 0x0037201C
		public static PosRectangle GetRootAsPosRectangle(ByteBuffer _bb, PosRectangle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F873 RID: 63603 RVA: 0x00373E39 File Offset: 0x00372039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F874 RID: 63604 RVA: 0x00373E48 File Offset: 0x00372048
		public PosRectangle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0600F875 RID: 63605 RVA: 0x00373E58 File Offset: 0x00372058
		public int XMin
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

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x00373E94 File Offset: 0x00372094
		public int YMin
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

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0600F877 RID: 63607 RVA: 0x00373ED0 File Offset: 0x003720D0
		public int XMax
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

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x0600F878 RID: 63608 RVA: 0x00373F0C File Offset: 0x0037210C
		public int YMax
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

		// Token: 0x04005989 RID: 22921
		private Table __p;
	}
}
