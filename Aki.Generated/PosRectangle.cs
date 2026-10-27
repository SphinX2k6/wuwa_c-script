using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D7 RID: 4567
	public struct PosRectangle : IFlatbufferObject
	{
		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x0600EAF6 RID: 60150 RVA: 0x003490FC File Offset: 0x003472FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x00349109 File Offset: 0x00347309
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x00349110 File Offset: 0x00347310
		public static PosRectangle GetRootAsPosRectangle(ByteBuffer _bb)
		{
			return PosRectangle.GetRootAsPosRectangle(_bb, default(PosRectangle));
		}

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x0034912C File Offset: 0x0034732C
		public static PosRectangle GetRootAsPosRectangle(ByteBuffer _bb, PosRectangle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAFA RID: 60154 RVA: 0x00349149 File Offset: 0x00347349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x00349158 File Offset: 0x00347358
		public PosRectangle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x0600EAFC RID: 60156 RVA: 0x00349168 File Offset: 0x00347368
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

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x003491A4 File Offset: 0x003473A4
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

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x0600EAFE RID: 60158 RVA: 0x003491E0 File Offset: 0x003473E0
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

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x0034921C File Offset: 0x0034741C
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

		// Token: 0x04005345 RID: 21317
		private Table __p;
	}
}
