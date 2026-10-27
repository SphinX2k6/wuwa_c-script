using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE6 RID: 3046
	public struct DebugEntranceTypeConfig : IFlatbufferObject
	{
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600615C RID: 24924 RVA: 0x0021188D File Offset: 0x0020FA8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x0021189A File Offset: 0x0020FA9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x002118A4 File Offset: 0x0020FAA4
		public static DebugEntranceTypeConfig GetRootAsDebugEntranceTypeConfig(ByteBuffer _bb)
		{
			return DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(_bb, default(DebugEntranceTypeConfig));
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x002118C0 File Offset: 0x0020FAC0
		public static DebugEntranceTypeConfig GetRootAsDebugEntranceTypeConfig(ByteBuffer _bb, DebugEntranceTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x002118DD File Offset: 0x0020FADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x002118EC File Offset: 0x0020FAEC
		public DebugEntranceTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x002118FC File Offset: 0x0020FAFC
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06006163 RID: 24931 RVA: 0x00211938 File Offset: 0x0020FB38
		public string Name
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

		// Token: 0x06006164 RID: 24932 RVA: 0x0021196F File Offset: 0x0020FB6F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x0021197E File Offset: 0x0020FB7E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C13 RID: 19475
		private Table __p;
	}
}
