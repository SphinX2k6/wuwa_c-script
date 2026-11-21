using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001036 RID: 4150
	public struct PrefabConfig : IFlatbufferObject
	{
		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x002E6408 File Offset: 0x002E4608
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x002E6415 File Offset: 0x002E4615
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x002E641C File Offset: 0x002E461C
		public static PrefabConfig GetRootAsPrefabConfig(ByteBuffer _bb)
		{
			return PrefabConfig.GetRootAsPrefabConfig(_bb, default(PrefabConfig));
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x002E6438 File Offset: 0x002E4638
		public static PrefabConfig GetRootAsPrefabConfig(ByteBuffer _bb, PrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x002E6455 File Offset: 0x002E4655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x002E6464 File Offset: 0x002E4664
		public PrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x002E6474 File Offset: 0x002E4674
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

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600B8B8 RID: 47288 RVA: 0x002E64B0 File Offset: 0x002E46B0
		public string Entities
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

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x002E64E7 File Offset: 0x002E46E7
		public Span<byte> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x002E64F6 File Offset: 0x002E46F6
		public byte[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005603 RID: 22019
		private Table __p;
	}
}
