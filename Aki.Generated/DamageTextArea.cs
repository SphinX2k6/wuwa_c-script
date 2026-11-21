using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9C RID: 3228
	public struct DamageTextArea : IFlatbufferObject
	{
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600622C RID: 25132 RVA: 0x00225C95 File Offset: 0x00223E95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x00225CA2 File Offset: 0x00223EA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x00225CAC File Offset: 0x00223EAC
		public static DamageTextArea GetRootAsDamageTextArea(ByteBuffer _bb)
		{
			return DamageTextArea.GetRootAsDamageTextArea(_bb, default(DamageTextArea));
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x00225CC8 File Offset: 0x00223EC8
		public static DamageTextArea GetRootAsDamageTextArea(ByteBuffer _bb, DamageTextArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00225CE5 File Offset: 0x00223EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x00225CF4 File Offset: 0x00223EF4
		public DamageTextArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06006232 RID: 25138 RVA: 0x00225D04 File Offset: 0x00223F04
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x00225D40 File Offset: 0x00223F40
		public int MinDeviationX
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06006234 RID: 25140 RVA: 0x00225D7C File Offset: 0x00223F7C
		public int MinDeviationY
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

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x00225DB8 File Offset: 0x00223FB8
		public int MaxDeviationX
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

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x00225DF8 File Offset: 0x00223FF8
		public int MaxDeviationY
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

		// Token: 0x040051C2 RID: 20930
		private Table __p;
	}
}
