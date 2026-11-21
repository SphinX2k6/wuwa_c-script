using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001129 RID: 4393
	public struct RoleDevelopCurve : IFlatbufferObject
	{
		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600CE2A RID: 52778 RVA: 0x00314CBF File Offset: 0x00312EBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x00314CCC File Offset: 0x00312ECC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x00314CD4 File Offset: 0x00312ED4
		public static RoleDevelopCurve GetRootAsRoleDevelopCurve(ByteBuffer _bb)
		{
			return RoleDevelopCurve.GetRootAsRoleDevelopCurve(_bb, default(RoleDevelopCurve));
		}

		// Token: 0x0600CE2D RID: 52781 RVA: 0x00314CF0 File Offset: 0x00312EF0
		public static RoleDevelopCurve GetRootAsRoleDevelopCurve(ByteBuffer _bb, RoleDevelopCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x00314D0D File Offset: 0x00312F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x00314D1C File Offset: 0x00312F1C
		public RoleDevelopCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600CE30 RID: 52784 RVA: 0x00314D2C File Offset: 0x00312F2C
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

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x00314D68 File Offset: 0x00312F68
		public int GroupId
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

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600CE32 RID: 52786 RVA: 0x00314DA4 File Offset: 0x00312FA4
		public int TrainType
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

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x00314DE0 File Offset: 0x00312FE0
		public string TrainContent
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

		// Token: 0x0600CE34 RID: 52788 RVA: 0x00314E18 File Offset: 0x00313018
		public Span<byte> GetTrainContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CE35 RID: 52789 RVA: 0x00314E28 File Offset: 0x00313028
		public byte[] GetTrainContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600CE36 RID: 52790 RVA: 0x00314E40 File Offset: 0x00313040
		public int WishConsume
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

		// Token: 0x04005727 RID: 22311
		private Table __p;
	}
}
