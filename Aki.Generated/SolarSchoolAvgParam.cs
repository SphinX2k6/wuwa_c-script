using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D5 RID: 4565
	public struct SolarSchoolAvgParam : IFlatbufferObject
	{
		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600DF5D RID: 57181 RVA: 0x0033C184 File Offset: 0x0033A384
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF5E RID: 57182 RVA: 0x0033C191 File Offset: 0x0033A391
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF5F RID: 57183 RVA: 0x0033C198 File Offset: 0x0033A398
		public static SolarSchoolAvgParam GetRootAsSolarSchoolAvgParam(ByteBuffer _bb)
		{
			return SolarSchoolAvgParam.GetRootAsSolarSchoolAvgParam(_bb, default(SolarSchoolAvgParam));
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x0033C1B4 File Offset: 0x0033A3B4
		public static SolarSchoolAvgParam GetRootAsSolarSchoolAvgParam(ByteBuffer _bb, SolarSchoolAvgParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x0033C1D1 File Offset: 0x0033A3D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF62 RID: 57186 RVA: 0x0033C1E0 File Offset: 0x0033A3E0
		public SolarSchoolAvgParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600DF63 RID: 57187 RVA: 0x0033C1F0 File Offset: 0x0033A3F0
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

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600DF64 RID: 57188 RVA: 0x0033C22C File Offset: 0x0033A42C
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

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600DF65 RID: 57189 RVA: 0x0033C268 File Offset: 0x0033A468
		public string Key
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

		// Token: 0x0600DF66 RID: 57190 RVA: 0x0033C29F File Offset: 0x0033A49F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF67 RID: 57191 RVA: 0x0033C2AE File Offset: 0x0033A4AE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x0033C2C8 File Offset: 0x0033A4C8
		public int BitFlag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400580C RID: 22540
		private Table __p;
	}
}
