using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9A RID: 3226
	public struct DamagePayload : IFlatbufferObject
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x002250B6 File Offset: 0x002232B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x002250C3 File Offset: 0x002232C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x002250CC File Offset: 0x002232CC
		public static DamagePayload GetRootAsDamagePayload(ByteBuffer _bb)
		{
			return DamagePayload.GetRootAsDamagePayload(_bb, default(DamagePayload));
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x002250E8 File Offset: 0x002232E8
		public static DamagePayload GetRootAsDamagePayload(ByteBuffer _bb, DamagePayload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x00225105 File Offset: 0x00223305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00225114 File Offset: 0x00223314
		public DamagePayload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x00225124 File Offset: 0x00223324
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060061E0 RID: 25056 RVA: 0x0022516C File Offset: 0x0022336C
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

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x002251A8 File Offset: 0x002233A8
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060061E2 RID: 25058 RVA: 0x002251E4 File Offset: 0x002233E4
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

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x00225224 File Offset: 0x00223424
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060061E4 RID: 25060 RVA: 0x00225264 File Offset: 0x00223464
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

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x002252A4 File Offset: 0x002234A4
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

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060061E6 RID: 25062 RVA: 0x002252E4 File Offset: 0x002234E4
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

		// Token: 0x040051C0 RID: 20928
		private Table __p;
	}
}
