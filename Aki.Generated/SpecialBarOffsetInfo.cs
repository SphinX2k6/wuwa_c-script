using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E5 RID: 4581
	public struct SpecialBarOffsetInfo : IFlatbufferObject
	{
		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x0600EBA6 RID: 60326 RVA: 0x0034AB25 File Offset: 0x00348D25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x0034AB32 File Offset: 0x00348D32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x0034AB3C File Offset: 0x00348D3C
		public static SpecialBarOffsetInfo GetRootAsSpecialBarOffsetInfo(ByteBuffer _bb)
		{
			return SpecialBarOffsetInfo.GetRootAsSpecialBarOffsetInfo(_bb, default(SpecialBarOffsetInfo));
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x0034AB58 File Offset: 0x00348D58
		public static SpecialBarOffsetInfo GetRootAsSpecialBarOffsetInfo(ByteBuffer _bb, SpecialBarOffsetInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x0034AB75 File Offset: 0x00348D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBAB RID: 60331 RVA: 0x0034AB84 File Offset: 0x00348D84
		public SpecialBarOffsetInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x0034AB94 File Offset: 0x00348D94
		public int MinPercent
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

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0600EBAD RID: 60333 RVA: 0x0034ABD0 File Offset: 0x00348DD0
		public int MaxPercent
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

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0600EBAE RID: 60334 RVA: 0x0034AC0C File Offset: 0x00348E0C
		public int MinOffsetX
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

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0600EBAF RID: 60335 RVA: 0x0034AC48 File Offset: 0x00348E48
		public int MinOffsetY
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

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0600EBB0 RID: 60336 RVA: 0x0034AC88 File Offset: 0x00348E88
		public int MaxOffsetX
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0600EBB1 RID: 60337 RVA: 0x0034ACC8 File Offset: 0x00348EC8
		public int MaxOffsetY
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400535E RID: 21342
		private Table __p;
	}
}
