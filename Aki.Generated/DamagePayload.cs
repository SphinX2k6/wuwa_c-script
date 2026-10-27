using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB8 RID: 3000
	public struct DamagePayload : IFlatbufferObject
	{
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x00205792 File Offset: 0x00203992
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x0020579F File Offset: 0x0020399F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x002057A8 File Offset: 0x002039A8
		public static DamagePayload GetRootAsDamagePayload(ByteBuffer _bb)
		{
			return DamagePayload.GetRootAsDamagePayload(_bb, default(DamagePayload));
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x002057C4 File Offset: 0x002039C4
		public static DamagePayload GetRootAsDamagePayload(ByteBuffer _bb, DamagePayload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x002057E1 File Offset: 0x002039E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x002057F0 File Offset: 0x002039F0
		public DamagePayload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x00205800 File Offset: 0x00203A00
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00205848 File Offset: 0x00203A48
		public int A
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x00205884 File Offset: 0x00203A84
		public int B
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

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x002058C0 File Offset: 0x00203AC0
		public int C
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00205900 File Offset: 0x00203B00
		public int D
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06005C0B RID: 23563 RVA: 0x00205940 File Offset: 0x00203B40
		public int E
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

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x00205980 File Offset: 0x00203B80
		public int F
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06005C0D RID: 23565 RVA: 0x002059C0 File Offset: 0x00203BC0
		public int G
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004BDE RID: 19422
		private Table __p;
	}
}
