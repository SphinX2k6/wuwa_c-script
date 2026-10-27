using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDB RID: 3291
	public struct FurnitureQualityConfig : IFlatbufferObject
	{
		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x002454DC File Offset: 0x002436DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x002454E9 File Offset: 0x002436E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x002454F0 File Offset: 0x002436F0
		public static FurnitureQualityConfig GetRootAsFurnitureQualityConfig(ByteBuffer _bb)
		{
			return FurnitureQualityConfig.GetRootAsFurnitureQualityConfig(_bb, default(FurnitureQualityConfig));
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x0024550C File Offset: 0x0024370C
		public static FurnitureQualityConfig GetRootAsFurnitureQualityConfig(ByteBuffer _bb, FurnitureQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00245529 File Offset: 0x00243729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00245538 File Offset: 0x00243738
		public FurnitureQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x00245548 File Offset: 0x00243748
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x060077E0 RID: 30688 RVA: 0x00245584 File Offset: 0x00243784
		public string TipBgColor
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

		// Token: 0x060077E1 RID: 30689 RVA: 0x002455BB File Offset: 0x002437BB
		public Span<byte> GetTipBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x002455CA File Offset: 0x002437CA
		public byte[] GetTipBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060077E3 RID: 30691 RVA: 0x002455E4 File Offset: 0x002437E4
		public string TipLineColor
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

		// Token: 0x060077E4 RID: 30692 RVA: 0x0024561B File Offset: 0x0024381B
		public Span<byte> GetTipLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x0024562A File Offset: 0x0024382A
		public byte[] GetTipLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x00245644 File Offset: 0x00243844
		public string ScrollItemColor
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

		// Token: 0x060077E7 RID: 30695 RVA: 0x0024567C File Offset: 0x0024387C
		public Span<byte> GetScrollItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0024568C File Offset: 0x0024388C
		public byte[] GetScrollItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D4C RID: 19788
		private Table __p;
	}
}
