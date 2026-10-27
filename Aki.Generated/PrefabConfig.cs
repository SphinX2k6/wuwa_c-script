using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F51 RID: 3921
	public struct PrefabConfig : IFlatbufferObject
	{
		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x002C9BBC File Offset: 0x002C7DBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x002C9BC9 File Offset: 0x002C7DC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x002C9BD0 File Offset: 0x002C7DD0
		public static PrefabConfig GetRootAsPrefabConfig(ByteBuffer _bb)
		{
			return PrefabConfig.GetRootAsPrefabConfig(_bb, default(PrefabConfig));
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x002C9BEC File Offset: 0x002C7DEC
		public static PrefabConfig GetRootAsPrefabConfig(ByteBuffer _bb, PrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x002C9C09 File Offset: 0x002C7E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x002C9C18 File Offset: 0x002C7E18
		public PrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x002C9C28 File Offset: 0x002C7E28
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

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600B297 RID: 45719 RVA: 0x002C9C64 File Offset: 0x002C7E64
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

		// Token: 0x0600B298 RID: 45720 RVA: 0x002C9C9B File Offset: 0x002C7E9B
		public Span<byte> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x002C9CAA File Offset: 0x002C7EAA
		public byte[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400501E RID: 20510
		private Table __p;
	}
}
