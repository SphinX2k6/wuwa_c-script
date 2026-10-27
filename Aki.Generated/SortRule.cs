using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D7 RID: 4311
	public struct SortRule : IFlatbufferObject
	{
		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600D751 RID: 55121 RVA: 0x0031CBE5 File Offset: 0x0031ADE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x0031CBF2 File Offset: 0x0031ADF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x0031CBFC File Offset: 0x0031ADFC
		public static SortRule GetRootAsSortRule(ByteBuffer _bb)
		{
			return SortRule.GetRootAsSortRule(_bb, default(SortRule));
		}

		// Token: 0x0600D754 RID: 55124 RVA: 0x0031CC18 File Offset: 0x0031AE18
		public static SortRule GetRootAsSortRule(ByteBuffer _bb, SortRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D755 RID: 55125 RVA: 0x0031CC35 File Offset: 0x0031AE35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x0031CC44 File Offset: 0x0031AE44
		public SortRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600D757 RID: 55127 RVA: 0x0031CC54 File Offset: 0x0031AE54
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

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600D758 RID: 55128 RVA: 0x0031CC90 File Offset: 0x0031AE90
		public int DataId
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

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600D759 RID: 55129 RVA: 0x0031CCCC File Offset: 0x0031AECC
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

		// Token: 0x0600D75A RID: 55130 RVA: 0x0031CD03 File Offset: 0x0031AF03
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x0031CD12 File Offset: 0x0031AF12
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600D75C RID: 55132 RVA: 0x0031CD2C File Offset: 0x0031AF2C
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

		// Token: 0x0600D75D RID: 55133 RVA: 0x0031CD64 File Offset: 0x0031AF64
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x0031CD74 File Offset: 0x0031AF74
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600D75F RID: 55135 RVA: 0x0031CD8C File Offset: 0x0031AF8C
		public int AttributeId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600D760 RID: 55136 RVA: 0x0031CDCC File Offset: 0x0031AFCC
		public int AddType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400520A RID: 21002
		private Table __p;
	}
}
