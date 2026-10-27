using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D8 RID: 4568
	public struct ProAddEntry : IFlatbufferObject
	{
		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0600EB00 RID: 60160 RVA: 0x00349259 File Offset: 0x00347459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00349266 File Offset: 0x00347466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00349270 File Offset: 0x00347470
		public static ProAddEntry GetRootAsProAddEntry(ByteBuffer _bb)
		{
			return ProAddEntry.GetRootAsProAddEntry(_bb, default(ProAddEntry));
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x0034928C File Offset: 0x0034748C
		public static ProAddEntry GetRootAsProAddEntry(ByteBuffer _bb, ProAddEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x003492A9 File Offset: 0x003474A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x003492B8 File Offset: 0x003474B8
		public ProAddEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0600EB06 RID: 60166 RVA: 0x003492C8 File Offset: 0x003474C8
		public int ProId
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

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0600EB07 RID: 60167 RVA: 0x00349304 File Offset: 0x00347504
		public bool IsPer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x00349344 File Offset: 0x00347544
		public int ProValue
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

		// Token: 0x04005346 RID: 21318
		private Table __p;
	}
}
