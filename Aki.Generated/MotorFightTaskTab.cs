using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F36 RID: 3894
	public struct MotorFightTaskTab : IFlatbufferObject
	{
		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x002AF565 File Offset: 0x002AD765
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x002AF572 File Offset: 0x002AD772
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x002AF57C File Offset: 0x002AD77C
		public static MotorFightTaskTab GetRootAsMotorFightTaskTab(ByteBuffer _bb)
		{
			return MotorFightTaskTab.GetRootAsMotorFightTaskTab(_bb, default(MotorFightTaskTab));
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x002AF598 File Offset: 0x002AD798
		public static MotorFightTaskTab GetRootAsMotorFightTaskTab(ByteBuffer _bb, MotorFightTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x002AF5B5 File Offset: 0x002AD7B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x002AF5C4 File Offset: 0x002AD7C4
		public MotorFightTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06009FBA RID: 40890 RVA: 0x002AF5D4 File Offset: 0x002AD7D4
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

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x002AF610 File Offset: 0x002AD810
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

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06009FBC RID: 40892 RVA: 0x002AF64C File Offset: 0x002AD84C
		public string TabTitle
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

		// Token: 0x06009FBD RID: 40893 RVA: 0x002AF683 File Offset: 0x002AD883
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x002AF692 File Offset: 0x002AD892
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040054DF RID: 21727
		private Table __p;
	}
}
