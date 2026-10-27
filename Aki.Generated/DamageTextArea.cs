using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBA RID: 3002
	public struct DamageTextArea : IFlatbufferObject
	{
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x00206371 File Offset: 0x00204571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x0020637E File Offset: 0x0020457E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x00206388 File Offset: 0x00204588
		public static DamageTextArea GetRootAsDamageTextArea(ByteBuffer _bb)
		{
			return DamageTextArea.GetRootAsDamageTextArea(_bb, default(DamageTextArea));
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x002063A4 File Offset: 0x002045A4
		public static DamageTextArea GetRootAsDamageTextArea(ByteBuffer _bb, DamageTextArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x002063C1 File Offset: 0x002045C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x002063D0 File Offset: 0x002045D0
		public DamageTextArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06005C59 RID: 23641 RVA: 0x002063E0 File Offset: 0x002045E0
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x0020641C File Offset: 0x0020461C
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

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06005C5B RID: 23643 RVA: 0x00206458 File Offset: 0x00204658
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

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x00206494 File Offset: 0x00204694
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x002064D4 File Offset: 0x002046D4
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

		// Token: 0x04004BE0 RID: 19424
		private Table __p;
	}
}
