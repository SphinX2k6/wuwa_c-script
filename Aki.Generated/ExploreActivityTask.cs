using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4B RID: 3147
	public struct ExploreActivityTask : IFlatbufferObject
	{
		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x002278AD File Offset: 0x00225AAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x002278BA File Offset: 0x00225ABA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x002278C4 File Offset: 0x00225AC4
		public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb)
		{
			return ExploreActivityTask.GetRootAsExploreActivityTask(_bb, default(ExploreActivityTask));
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x002278E0 File Offset: 0x00225AE0
		public static ExploreActivityTask GetRootAsExploreActivityTask(ByteBuffer _bb, ExploreActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x002278FD File Offset: 0x00225AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x0022790C File Offset: 0x00225B0C
		public ExploreActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06006B2C RID: 27436 RVA: 0x0022791C File Offset: 0x00225B1C
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

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06006B2D RID: 27437 RVA: 0x00227958 File Offset: 0x00225B58
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

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06006B2E RID: 27438 RVA: 0x00227994 File Offset: 0x00225B94
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

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x002279D0 File Offset: 0x00225BD0
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

		// Token: 0x06006B30 RID: 27440 RVA: 0x00227A08 File Offset: 0x00225C08
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00227A18 File Offset: 0x00225C18
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C90 RID: 19600
		private Table __p;
	}
}
