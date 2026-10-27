using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E61 RID: 3681
	public struct MotorParkourNPC : IFlatbufferObject
	{
		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x002959FD File Offset: 0x00293BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x00295A0A File Offset: 0x00293C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x00295A14 File Offset: 0x00293C14
		public static MotorParkourNPC GetRootAsMotorParkourNPC(ByteBuffer _bb)
		{
			return MotorParkourNPC.GetRootAsMotorParkourNPC(_bb, default(MotorParkourNPC));
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x00295A30 File Offset: 0x00293C30
		public static MotorParkourNPC GetRootAsMotorParkourNPC(ByteBuffer _bb, MotorParkourNPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x00295A4D File Offset: 0x00293C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x00295A5C File Offset: 0x00293C5C
		public MotorParkourNPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06009B5A RID: 39770 RVA: 0x00295A6C File Offset: 0x00293C6C
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

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06009B5B RID: 39771 RVA: 0x00295AA8 File Offset: 0x00293CA8
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

		// Token: 0x06009B5C RID: 39772 RVA: 0x00295ADF File Offset: 0x00293CDF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00295AEE File Offset: 0x00293CEE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F0D RID: 20237
		private Table __p;
	}
}
