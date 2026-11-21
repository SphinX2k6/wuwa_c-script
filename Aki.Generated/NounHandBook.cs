using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7E RID: 3966
	public struct NounHandBook : IFlatbufferObject
	{
		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x0600A6B9 RID: 42681 RVA: 0x002BE651 File Offset: 0x002BC851
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x002BE65E File Offset: 0x002BC85E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x002BE668 File Offset: 0x002BC868
		public static NounHandBook GetRootAsNounHandBook(ByteBuffer _bb)
		{
			return NounHandBook.GetRootAsNounHandBook(_bb, default(NounHandBook));
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x002BE684 File Offset: 0x002BC884
		public static NounHandBook GetRootAsNounHandBook(ByteBuffer _bb, NounHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x002BE6A1 File Offset: 0x002BC8A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x002BE6B0 File Offset: 0x002BC8B0
		public NounHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x0600A6BF RID: 42687 RVA: 0x002BE6C0 File Offset: 0x002BC8C0
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

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x0600A6C0 RID: 42688 RVA: 0x002BE6FC File Offset: 0x002BC8FC
		public int Type
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

		// Token: 0x04005532 RID: 21810
		private Table __p;
	}
}
