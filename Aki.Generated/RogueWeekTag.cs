using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001032 RID: 4146
	public struct RogueWeekTag : IFlatbufferObject
	{
		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600C69E RID: 50846 RVA: 0x002F5EB8 File Offset: 0x002F40B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x002F5EC5 File Offset: 0x002F40C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x002F5ECC File Offset: 0x002F40CC
		public static RogueWeekTag GetRootAsRogueWeekTag(ByteBuffer _bb)
		{
			return RogueWeekTag.GetRootAsRogueWeekTag(_bb, default(RogueWeekTag));
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x002F5EE8 File Offset: 0x002F40E8
		public static RogueWeekTag GetRootAsRogueWeekTag(ByteBuffer _bb, RogueWeekTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x002F5F05 File Offset: 0x002F4105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x002F5F14 File Offset: 0x002F4114
		public RogueWeekTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600C6A4 RID: 50852 RVA: 0x002F5F24 File Offset: 0x002F4124
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

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600C6A5 RID: 50853 RVA: 0x002F5F60 File Offset: 0x002F4160
		public string Type
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

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x002F5F97 File Offset: 0x002F4197
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x002F5FA6 File Offset: 0x002F41A6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600C6A8 RID: 50856 RVA: 0x002F5FC0 File Offset: 0x002F41C0
		public string Name
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

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x002F5FF7 File Offset: 0x002F41F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x002F6006 File Offset: 0x002F4206
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600C6AB RID: 50859 RVA: 0x002F6020 File Offset: 0x002F4220
		public string Color
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

		// Token: 0x0600C6AC RID: 50860 RVA: 0x002F6058 File Offset: 0x002F4258
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x002F6068 File Offset: 0x002F4268
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400512A RID: 20778
		private Table __p;
	}
}
