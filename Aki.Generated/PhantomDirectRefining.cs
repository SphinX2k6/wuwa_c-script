using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE3 RID: 3811
	public struct PhantomDirectRefining : IFlatbufferObject
	{
		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600A854 RID: 43092 RVA: 0x002B2A1C File Offset: 0x002B0C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x002B2A29 File Offset: 0x002B0C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x002B2A30 File Offset: 0x002B0C30
		public static PhantomDirectRefining GetRootAsPhantomDirectRefining(ByteBuffer _bb)
		{
			return PhantomDirectRefining.GetRootAsPhantomDirectRefining(_bb, default(PhantomDirectRefining));
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x002B2A4C File Offset: 0x002B0C4C
		public static PhantomDirectRefining GetRootAsPhantomDirectRefining(ByteBuffer _bb, PhantomDirectRefining obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A858 RID: 43096 RVA: 0x002B2A69 File Offset: 0x002B0C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x002B2A78 File Offset: 0x002B0C78
		public PhantomDirectRefining __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600A85A RID: 43098 RVA: 0x002B2A88 File Offset: 0x002B0C88
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

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x002B2AC4 File Offset: 0x002B0CC4
		public int FetterGroup
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

		// Token: 0x04004FA4 RID: 20388
		private Table __p;
	}
}
