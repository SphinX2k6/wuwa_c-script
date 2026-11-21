using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA7 RID: 3751
	public struct LevelPlayInfoMappingConfig : IFlatbufferObject
	{
		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x00294E65 File Offset: 0x00293065
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x00294E72 File Offset: 0x00293072
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x00294E7C File Offset: 0x0029307C
		public static LevelPlayInfoMappingConfig GetRootAsLevelPlayInfoMappingConfig(ByteBuffer _bb)
		{
			return LevelPlayInfoMappingConfig.GetRootAsLevelPlayInfoMappingConfig(_bb, default(LevelPlayInfoMappingConfig));
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x00294E98 File Offset: 0x00293098
		public static LevelPlayInfoMappingConfig GetRootAsLevelPlayInfoMappingConfig(ByteBuffer _bb, LevelPlayInfoMappingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x00294EB5 File Offset: 0x002930B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x00294EC4 File Offset: 0x002930C4
		public LevelPlayInfoMappingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060093A3 RID: 37795 RVA: 0x00294ED4 File Offset: 0x002930D4
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

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060093A4 RID: 37796 RVA: 0x00294F10 File Offset: 0x00293110
		public int Type
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

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060093A5 RID: 37797 RVA: 0x00294F4C File Offset: 0x0029314C
		public string Data
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

		// Token: 0x060093A6 RID: 37798 RVA: 0x00294F83 File Offset: 0x00293183
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x00294F92 File Offset: 0x00293192
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400543D RID: 21565
		private Table __p;
	}
}
