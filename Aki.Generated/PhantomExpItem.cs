using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC9 RID: 4041
	public struct PhantomExpItem : IFlatbufferObject
	{
		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x002CFB68 File Offset: 0x002CDD68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x002CFB75 File Offset: 0x002CDD75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x002CFB7C File Offset: 0x002CDD7C
		public static PhantomExpItem GetRootAsPhantomExpItem(ByteBuffer _bb)
		{
			return PhantomExpItem.GetRootAsPhantomExpItem(_bb, default(PhantomExpItem));
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x002CFB98 File Offset: 0x002CDD98
		public static PhantomExpItem GetRootAsPhantomExpItem(ByteBuffer _bb, PhantomExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x002CFBB5 File Offset: 0x002CDDB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x002CFBC4 File Offset: 0x002CDDC4
		public PhantomExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600AE83 RID: 44675 RVA: 0x002CFBD4 File Offset: 0x002CDDD4
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

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x002CFC10 File Offset: 0x002CDE10
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

		// Token: 0x0400558A RID: 21898
		private Table __p;
	}
}
