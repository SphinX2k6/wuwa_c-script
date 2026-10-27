using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB3 RID: 2739
	public struct AbyssRewardTab : IFlatbufferObject
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x001C848C File Offset: 0x001C668C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x001C8499 File Offset: 0x001C6699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x001C84A0 File Offset: 0x001C66A0
		public static AbyssRewardTab GetRootAsAbyssRewardTab(ByteBuffer _bb)
		{
			return AbyssRewardTab.GetRootAsAbyssRewardTab(_bb, default(AbyssRewardTab));
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x001C84BC File Offset: 0x001C66BC
		public static AbyssRewardTab GetRootAsAbyssRewardTab(ByteBuffer _bb, AbyssRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x001C84D9 File Offset: 0x001C66D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x001C84E8 File Offset: 0x001C66E8
		public AbyssRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x001C84F8 File Offset: 0x001C66F8
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x001C8534 File Offset: 0x001C6734
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

		// Token: 0x060041C2 RID: 16834 RVA: 0x001C856B File Offset: 0x001C676B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x001C857A File Offset: 0x001C677A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x001C8594 File Offset: 0x001C6794
		public string Icon
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

		// Token: 0x060041C5 RID: 16837 RVA: 0x001C85CB File Offset: 0x001C67CB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x001C85DA File Offset: 0x001C67DA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A89 RID: 19081
		private Table __p;
	}
}
