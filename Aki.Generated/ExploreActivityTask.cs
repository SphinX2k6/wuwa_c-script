using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2E RID: 3374
	public struct ExploreActivityTask : IFlatbufferObject
	{
		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06007128 RID: 28968 RVA: 0x00246B5B File Offset: 0x00244D5B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x00246B68 File Offset: 0x00244D68
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x00246B70 File Offset: 0x00244D70
		public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb)
		{
			return ExploreActivityTask.GetRootAsExploreActivityTask(_bb, default(ExploreActivityTask));
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x00246B8C File Offset: 0x00244D8C
		public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb, ExploreActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x00246BA9 File Offset: 0x00244DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x00246BB8 File Offset: 0x00244DB8
		public ExploreActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x00246BC8 File Offset: 0x00244DC8
		public int TaskId
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

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600712F RID: 28975 RVA: 0x00246C04 File Offset: 0x00244E04
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

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x00246C40 File Offset: 0x00244E40
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06007131 RID: 28977 RVA: 0x00246C7C File Offset: 0x00244E7C
		public string Desc
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

		// Token: 0x06007132 RID: 28978 RVA: 0x00246CB4 File Offset: 0x00244EB4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x00246CC4 File Offset: 0x00244EC4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005273 RID: 21107
		private Table __p;
	}
}
