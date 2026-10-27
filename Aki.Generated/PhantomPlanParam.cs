using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF4 RID: 3828
	public struct PhantomPlanParam : IFlatbufferObject
	{
		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600A9DE RID: 43486 RVA: 0x002B61C6 File Offset: 0x002B43C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002B61D3 File Offset: 0x002B43D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002B61DC File Offset: 0x002B43DC
		public static PhantomPlanParam GetRootAsPhantomPlanParam(ByteBuffer _bb)
		{
			return PhantomPlanParam.GetRootAsPhantomPlanParam(_bb, default(PhantomPlanParam));
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002B61F8 File Offset: 0x002B43F8
		public static PhantomPlanParam GetRootAsPhantomPlanParam(ByteBuffer _bb, PhantomPlanParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x002B6215 File Offset: 0x002B4415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x002B6224 File Offset: 0x002B4424
		public PhantomPlanParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x002B6234 File Offset: 0x002B4434
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

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x002B6270 File Offset: 0x002B4470
		public int SkillBranchId
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

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600A9E6 RID: 43494 RVA: 0x002B62AC File Offset: 0x002B44AC
		public string SkillBranchText
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

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x002B62E3 File Offset: 0x002B44E3
		public Span<byte> GetSkillBranchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x002B62F2 File Offset: 0x002B44F2
		public byte[] GetSkillBranchTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FB9 RID: 20409
		private Table __p;
	}
}
