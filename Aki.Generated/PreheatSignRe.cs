using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103B RID: 4155
	public struct PreheatSignRe : IFlatbufferObject
	{
		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600B90E RID: 47374 RVA: 0x002E6F14 File Offset: 0x002E5114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002E6F21 File Offset: 0x002E5121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x002E6F28 File Offset: 0x002E5128
		public static PreheatSignRe GetRootAsPreheatSignRe(ByteBuffer _bb)
		{
			return PreheatSignRe.GetRootAsPreheatSignRe(_bb, default(PreheatSignRe));
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x002E6F44 File Offset: 0x002E5144
		public static PreheatSignRe GetRootAsPreheatSignRe(ByteBuffer _bb, PreheatSignRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x002E6F61 File Offset: 0x002E5161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x002E6F70 File Offset: 0x002E5170
		public PreheatSignRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600B914 RID: 47380 RVA: 0x002E6F80 File Offset: 0x002E5180
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

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002E6FBC File Offset: 0x002E51BC
		public int ActivityId
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

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600B916 RID: 47382 RVA: 0x002E6FF8 File Offset: 0x002E51F8
		public int DropId
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

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002E7034 File Offset: 0x002E5234
		public int QuestId
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

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600B918 RID: 47384 RVA: 0x002E7074 File Offset: 0x002E5274
		public int PreSignId
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

		// Token: 0x04005608 RID: 22024
		private Table __p;
	}
}
