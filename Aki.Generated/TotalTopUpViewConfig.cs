using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126A RID: 4714
	public struct TotalTopUpViewConfig : IFlatbufferObject
	{
		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600ECBC RID: 60604 RVA: 0x0035A3D4 File Offset: 0x003585D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECBD RID: 60605 RVA: 0x0035A3E1 File Offset: 0x003585E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECBE RID: 60606 RVA: 0x0035A3E8 File Offset: 0x003585E8
		public static TotalTopUpViewConfig GetRootAsTotalTopUpViewConfig(ByteBuffer _bb)
		{
			return TotalTopUpViewConfig.GetRootAsTotalTopUpViewConfig(_bb, default(TotalTopUpViewConfig));
		}

		// Token: 0x0600ECBF RID: 60607 RVA: 0x0035A404 File Offset: 0x00358604
		public static TotalTopUpViewConfig GetRootAsTotalTopUpViewConfig(ByteBuffer _bb, TotalTopUpViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECC0 RID: 60608 RVA: 0x0035A421 File Offset: 0x00358621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x0035A430 File Offset: 0x00358630
		public TotalTopUpViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x0035A440 File Offset: 0x00358640
		public int ActivityId
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

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600ECC3 RID: 60611 RVA: 0x0035A47C File Offset: 0x0035867C
		public string ScoreIcon
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

		// Token: 0x0600ECC4 RID: 60612 RVA: 0x0035A4B3 File Offset: 0x003586B3
		public Span<byte> GetScoreIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ECC5 RID: 60613 RVA: 0x0035A4C2 File Offset: 0x003586C2
		public byte[] GetScoreIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600ECC6 RID: 60614 RVA: 0x0035A4DC File Offset: 0x003586DC
		public int ViewType
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

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600ECC7 RID: 60615 RVA: 0x0035A518 File Offset: 0x00358718
		public string EnterResourcesId
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

		// Token: 0x0600ECC8 RID: 60616 RVA: 0x0035A550 File Offset: 0x00358750
		public Span<byte> GetEnterResourcesIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ECC9 RID: 60617 RVA: 0x0035A560 File Offset: 0x00358760
		public byte[] GetEnterResourcesIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600ECCA RID: 60618 RVA: 0x0035A578 File Offset: 0x00358778
		public string TagResourcesId
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

		// Token: 0x0600ECCB RID: 60619 RVA: 0x0035A5B0 File Offset: 0x003587B0
		public Span<byte> GetTagResourcesIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ECCC RID: 60620 RVA: 0x0035A5C0 File Offset: 0x003587C0
		public byte[] GetTagResourcesIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040058B8 RID: 22712
		private Table __p;
	}
}
