using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD8 RID: 3288
	public struct FurnitureDiyTag : IFlatbufferObject
	{
		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x00244DF0 File Offset: 0x00242FF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00244DFD File Offset: 0x00242FFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00244E04 File Offset: 0x00243004
		public static FurnitureDiyTag GetRootAsFurnitureDiyTag(ByteBuffer _bb)
		{
			return FurnitureDiyTag.GetRootAsFurnitureDiyTag(_bb, default(FurnitureDiyTag));
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00244E20 File Offset: 0x00243020
		public static FurnitureDiyTag GetRootAsFurnitureDiyTag(ByteBuffer _bb, FurnitureDiyTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00244E3D File Offset: 0x0024303D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00244E4C File Offset: 0x0024304C
		public FurnitureDiyTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x00244E5C File Offset: 0x0024305C
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060077AB RID: 30635 RVA: 0x00244E98 File Offset: 0x00243098
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

		// Token: 0x060077AC RID: 30636 RVA: 0x00244ECF File Offset: 0x002430CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00244EDE File Offset: 0x002430DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x00244EF8 File Offset: 0x002430F8
		public string EmptyIcon
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

		// Token: 0x060077AF RID: 30639 RVA: 0x00244F2F File Offset: 0x0024312F
		public Span<byte> GetEmptyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00244F3E File Offset: 0x0024313E
		public byte[] GetEmptyIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060077B1 RID: 30641 RVA: 0x00244F58 File Offset: 0x00243158
		public string OccupiedIcon
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

		// Token: 0x060077B2 RID: 30642 RVA: 0x00244F90 File Offset: 0x00243190
		public Span<byte> GetOccupiedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00244FA0 File Offset: 0x002431A0
		public byte[] GetOccupiedIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x00244FB8 File Offset: 0x002431B8
		public bool CanUnPlace
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004D48 RID: 19784
		private Table __p;
	}
}
