using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9B RID: 2971
	public struct ConsumptiveTaskTab : IFlatbufferObject
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06005914 RID: 22804 RVA: 0x001FEF75 File Offset: 0x001FD175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001FEF82 File Offset: 0x001FD182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001FEF8C File Offset: 0x001FD18C
		public static ConsumptiveTaskTab GetRootAsConsumptiveTaskTab(ByteBuffer _bb)
		{
			return ConsumptiveTaskTab.GetRootAsConsumptiveTaskTab(_bb, default(ConsumptiveTaskTab));
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x001FEFA8 File Offset: 0x001FD1A8
		public static ConsumptiveTaskTab GetRootAsConsumptiveTaskTab(ByteBuffer _bb, ConsumptiveTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001FEFC5 File Offset: 0x001FD1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x001FEFD4 File Offset: 0x001FD1D4
		public ConsumptiveTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600591A RID: 22810 RVA: 0x001FEFE4 File Offset: 0x001FD1E4
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x001FF020 File Offset: 0x001FD220
		public string Title
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

		// Token: 0x0600591C RID: 22812 RVA: 0x001FF057 File Offset: 0x001FD257
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x001FF066 File Offset: 0x001FD266
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x001FF080 File Offset: 0x001FD280
		public string SpriteIcon
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

		// Token: 0x0600591F RID: 22815 RVA: 0x001FF0B7 File Offset: 0x001FD2B7
		public Span<byte> GetSpriteIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x001FF0C6 File Offset: 0x001FD2C6
		public byte[] GetSpriteIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BBC RID: 19388
		private Table __p;
	}
}
