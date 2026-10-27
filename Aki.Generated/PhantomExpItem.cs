using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE4 RID: 3812
	public struct PhantomExpItem : IFlatbufferObject
	{
		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x002B2B00 File Offset: 0x002B0D00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x002B2B0D File Offset: 0x002B0D0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x002B2B14 File Offset: 0x002B0D14
		public static PhantomExpItem GetRootAsPhantomExpItem(ByteBuffer _bb)
		{
			return PhantomExpItem.GetRootAsPhantomExpItem(_bb, default(PhantomExpItem));
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x002B2B30 File Offset: 0x002B0D30
		public static PhantomExpItem GetRootAsPhantomExpItem(ByteBuffer _bb, PhantomExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x002B2B4D File Offset: 0x002B0D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x002B2B5C File Offset: 0x002B0D5C
		public PhantomExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x002B2B6C File Offset: 0x002B0D6C
		public int ItemId
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

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600A863 RID: 43107 RVA: 0x002B2BA8 File Offset: 0x002B0DA8
		public int Exp
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

		// Token: 0x04004FA5 RID: 20389
		private Table __p;
	}
}
