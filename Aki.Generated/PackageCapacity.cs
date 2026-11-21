using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8F RID: 3983
	public struct PackageCapacity : IFlatbufferObject
	{
		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x002C25BE File Offset: 0x002C07BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x002C25CB File Offset: 0x002C07CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x002C25D4 File Offset: 0x002C07D4
		public static PackageCapacity GetRootAsPackageCapacity(ByteBuffer _bb)
		{
			return PackageCapacity.GetRootAsPackageCapacity(_bb, default(PackageCapacity));
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x002C25F0 File Offset: 0x002C07F0
		public static PackageCapacity GetRootAsPackageCapacity(ByteBuffer _bb, PackageCapacity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x002C260D File Offset: 0x002C080D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x002C261C File Offset: 0x002C081C
		public PackageCapacity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x002C262C File Offset: 0x002C082C
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

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600A899 RID: 43161 RVA: 0x002C2668 File Offset: 0x002C0868
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

		// Token: 0x04005544 RID: 21828
		private Table __p;
	}
}
