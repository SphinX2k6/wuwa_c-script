using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAA RID: 3754
	public struct PackageCapacity : IFlatbufferObject
	{
		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600A272 RID: 41586 RVA: 0x002A5225 File Offset: 0x002A3425
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x002A5232 File Offset: 0x002A3432
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x002A523C File Offset: 0x002A343C
		public static PackageCapacity GetRootAsPackageCapacity(ByteBuffer _bb)
		{
			return PackageCapacity.GetRootAsPackageCapacity(_bb, default(PackageCapacity));
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x002A5258 File Offset: 0x002A3458
		public static PackageCapacity GetRootAsPackageCapacity(ByteBuffer _bb, PackageCapacity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x002A5275 File Offset: 0x002A3475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x002A5284 File Offset: 0x002A3484
		public PackageCapacity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600A278 RID: 41592 RVA: 0x002A5294 File Offset: 0x002A3494
		public int PackageId
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

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x002A52D0 File Offset: 0x002A34D0
		public int Capacity
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

		// Token: 0x04004F5F RID: 20319
		private Table __p;
	}
}
