using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE2 RID: 3810
	public struct PhantomCustomizeItem : IFlatbufferObject
	{
		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600A84B RID: 43083 RVA: 0x002B28FC File Offset: 0x002B0AFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x002B2909 File Offset: 0x002B0B09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x002B2910 File Offset: 0x002B0B10
		public static PhantomCustomizeItem GetRootAsPhantomCustomizeItem(ByteBuffer _bb)
		{
			return PhantomCustomizeItem.GetRootAsPhantomCustomizeItem(_bb, default(PhantomCustomizeItem));
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x002B292C File Offset: 0x002B0B2C
		public static PhantomCustomizeItem GetRootAsPhantomCustomizeItem(ByteBuffer _bb, PhantomCustomizeItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x002B2949 File Offset: 0x002B0B49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x002B2958 File Offset: 0x002B0B58
		public PhantomCustomizeItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600A851 RID: 43089 RVA: 0x002B2968 File Offset: 0x002B0B68
		public int ItemId
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

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600A852 RID: 43090 RVA: 0x002B29A4 File Offset: 0x002B0BA4
		public int PhantomId
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

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600A853 RID: 43091 RVA: 0x002B29E0 File Offset: 0x002B0BE0
		public int SkinItemId
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

		// Token: 0x04004FA3 RID: 20387
		private Table __p;
	}
}
