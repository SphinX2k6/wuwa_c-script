using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E66 RID: 3686
	public struct MotorRoleCategory : IFlatbufferObject
	{
		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06009B97 RID: 39831 RVA: 0x002961EC File Offset: 0x002943EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x002961F9 File Offset: 0x002943F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x00296200 File Offset: 0x00294400
		public static MotorRoleCategory GetRootAsMotorRoleCategory(ByteBuffer _bb)
		{
			return MotorRoleCategory.GetRootAsMotorRoleCategory(_bb, default(MotorRoleCategory));
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x0029621C File Offset: 0x0029441C
		public static MotorRoleCategory GetRootAsMotorRoleCategory(ByteBuffer _bb, MotorRoleCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B9B RID: 39835 RVA: 0x00296239 File Offset: 0x00294439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B9C RID: 39836 RVA: 0x00296248 File Offset: 0x00294448
		public MotorRoleCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x00296258 File Offset: 0x00294458
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

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x00296294 File Offset: 0x00294494
		public string RegionName
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

		// Token: 0x06009B9F RID: 39839 RVA: 0x002962CB File Offset: 0x002944CB
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x002962DA File Offset: 0x002944DA
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06009BA1 RID: 39841 RVA: 0x002962F4 File Offset: 0x002944F4
		public int SortId
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

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x00296330 File Offset: 0x00294530
		public string Icon
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

		// Token: 0x06009BA3 RID: 39843 RVA: 0x00296368 File Offset: 0x00294568
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x00296378 File Offset: 0x00294578
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F12 RID: 20242
		private Table __p;
	}
}
