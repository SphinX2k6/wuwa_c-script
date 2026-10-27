using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001014 RID: 4116
	public struct RogueResSynergyType : IFlatbufferObject
	{
		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600C3FE RID: 50174 RVA: 0x002EFDF1 File Offset: 0x002EDFF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x002EFDFE File Offset: 0x002EDFFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C400 RID: 50176 RVA: 0x002EFE08 File Offset: 0x002EE008
		public static RogueResSynergyType GetRootAsRogueResSynergyType(ByteBuffer _bb)
		{
			return RogueResSynergyType.GetRootAsRogueResSynergyType(_bb, default(RogueResSynergyType));
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x002EFE24 File Offset: 0x002EE024
		public static RogueResSynergyType GetRootAsRogueResSynergyType(ByteBuffer _bb, RogueResSynergyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C402 RID: 50178 RVA: 0x002EFE41 File Offset: 0x002EE041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x002EFE50 File Offset: 0x002EE050
		public RogueResSynergyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600C404 RID: 50180 RVA: 0x002EFE60 File Offset: 0x002EE060
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

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600C405 RID: 50181 RVA: 0x002EFE9C File Offset: 0x002EE09C
		public string SynergyTypeName
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

		// Token: 0x0600C406 RID: 50182 RVA: 0x002EFED3 File Offset: 0x002EE0D3
		public Span<byte> GetSynergyTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x002EFEE2 File Offset: 0x002EE0E2
		public byte[] GetSynergyTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005102 RID: 20738
		private Table __p;
	}
}
