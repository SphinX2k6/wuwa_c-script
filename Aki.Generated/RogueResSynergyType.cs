using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FC RID: 4348
	public struct RogueResSynergyType : IFlatbufferObject
	{
		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x0030BEB1 File Offset: 0x0030A0B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x0030BEBE File Offset: 0x0030A0BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x0030BEC8 File Offset: 0x0030A0C8
		public static RogueResSynergyType GetRootAsRogueResSynergyType(ByteBuffer _bb)
		{
			return RogueResSynergyType.GetRootAsRogueResSynergyType(_bb, default(RogueResSynergyType));
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x0030BEE4 File Offset: 0x0030A0E4
		public static RogueResSynergyType GetRootAsRogueResSynergyType(ByteBuffer _bb, RogueResSynergyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x0030BF01 File Offset: 0x0030A101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x0030BF10 File Offset: 0x0030A110
		public RogueResSynergyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x0030BF20 File Offset: 0x0030A120
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

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600CA4F RID: 51791 RVA: 0x0030BF5C File Offset: 0x0030A15C
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

		// Token: 0x0600CA50 RID: 51792 RVA: 0x0030BF93 File Offset: 0x0030A193
		public Span<byte> GetSynergyTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x0030BFA2 File Offset: 0x0030A1A2
		public byte[] GetSynergyTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040056EA RID: 22250
		private Table __p;
	}
}
