using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2A RID: 3882
	public struct MotorFightItemType : IFlatbufferObject
	{
		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06009E8B RID: 40587 RVA: 0x002ACBDF File Offset: 0x002AADDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x002ACBEC File Offset: 0x002AADEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x002ACBF4 File Offset: 0x002AADF4
		public static MotorFightItemType GetRootAsMotorFightItemType(ByteBuffer _bb)
		{
			return MotorFightItemType.GetRootAsMotorFightItemType(_bb, default(MotorFightItemType));
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x002ACC10 File Offset: 0x002AAE10
		public static MotorFightItemType GetRootAsMotorFightItemType(ByteBuffer _bb, MotorFightItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x002ACC2D File Offset: 0x002AAE2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x002ACC3C File Offset: 0x002AAE3C
		public MotorFightItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06009E91 RID: 40593 RVA: 0x002ACC4C File Offset: 0x002AAE4C
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

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x002ACC88 File Offset: 0x002AAE88
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x002ACCBF File Offset: 0x002AAEBF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x002ACCCE File Offset: 0x002AAECE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06009E95 RID: 40597 RVA: 0x002ACCE8 File Offset: 0x002AAEE8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x002ACD1F File Offset: 0x002AAF1F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x002ACD2E File Offset: 0x002AAF2E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x002ACD48 File Offset: 0x002AAF48
		public string DropBuffGateIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x002ACD80 File Offset: 0x002AAF80
		public Span<byte> GetDropBuffGateIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x002ACD90 File Offset: 0x002AAF90
		public byte[] GetDropBuffGateIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x002ACDA8 File Offset: 0x002AAFA8
		public string TextureIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x002ACDE0 File Offset: 0x002AAFE0
		public Span<byte> GetTextureIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x002ACDF0 File Offset: 0x002AAFF0
		public byte[] GetTextureIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040054D2 RID: 21714
		private Table __p;
	}
}
