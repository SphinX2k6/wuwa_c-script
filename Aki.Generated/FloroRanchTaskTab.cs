using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB8 RID: 3256
	public struct FloroRanchTaskTab : IFlatbufferObject
	{
		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x0023E2E9 File Offset: 0x0023C4E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x0023E2F6 File Offset: 0x0023C4F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x0023E300 File Offset: 0x0023C500
		public static FloroRanchTaskTab GetRootAsFloroRanchTaskTab(ByteBuffer _bb)
		{
			return FloroRanchTaskTab.GetRootAsFloroRanchTaskTab(_bb, default(FloroRanchTaskTab));
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x0023E31C File Offset: 0x0023C51C
		public static FloroRanchTaskTab GetRootAsFloroRanchTaskTab(ByteBuffer _bb, FloroRanchTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x0023E339 File Offset: 0x0023C539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x0023E348 File Offset: 0x0023C548
		public FloroRanchTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060074A9 RID: 29865 RVA: 0x0023E358 File Offset: 0x0023C558
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

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x0023E394 File Offset: 0x0023C594
		public string TabName
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

		// Token: 0x060074AB RID: 29867 RVA: 0x0023E3CB File Offset: 0x0023C5CB
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x0023E3DA File Offset: 0x0023C5DA
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060074AD RID: 29869 RVA: 0x0023E3F4 File Offset: 0x0023C5F4
		public int Sort
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

		// Token: 0x04004D25 RID: 19749
		private Table __p;
	}
}
