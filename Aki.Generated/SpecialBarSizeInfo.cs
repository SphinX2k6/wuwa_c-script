using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E6 RID: 4582
	public struct SpecialBarSizeInfo : IFlatbufferObject
	{
		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x0034AD05 File Offset: 0x00348F05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x0034AD12 File Offset: 0x00348F12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x0034AD1C File Offset: 0x00348F1C
		public static SpecialBarSizeInfo GetRootAsSpecialBarSizeInfo(ByteBuffer _bb)
		{
			return SpecialBarSizeInfo.GetRootAsSpecialBarSizeInfo(_bb, default(SpecialBarSizeInfo));
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x0034AD38 File Offset: 0x00348F38
		public static SpecialBarSizeInfo GetRootAsSpecialBarSizeInfo(ByteBuffer _bb, SpecialBarSizeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x0034AD55 File Offset: 0x00348F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x0034AD64 File Offset: 0x00348F64
		public SpecialBarSizeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x0600EBB8 RID: 60344 RVA: 0x0034AD74 File Offset: 0x00348F74
		public int Index
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

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0600EBB9 RID: 60345 RVA: 0x0034ADB0 File Offset: 0x00348FB0
		public int SizeX
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

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x0600EBBA RID: 60346 RVA: 0x0034ADEC File Offset: 0x00348FEC
		public int SizeY
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

		// Token: 0x0400535F RID: 21343
		private Table __p;
	}
}
