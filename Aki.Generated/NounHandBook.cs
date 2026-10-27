using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E99 RID: 3737
	public struct NounHandBook : IFlatbufferObject
	{
		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600A099 RID: 41113 RVA: 0x002A1129 File Offset: 0x0029F329
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x002A1136 File Offset: 0x0029F336
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x002A1140 File Offset: 0x0029F340
		public static NounHandBook GetRootAsNounHandBook(ByteBuffer _bb)
		{
			return NounHandBook.GetRootAsNounHandBook(_bb, default(NounHandBook));
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x002A115C File Offset: 0x0029F35C
		public static NounHandBook GetRootAsNounHandBook(ByteBuffer _bb, NounHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x002A1179 File Offset: 0x0029F379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A09E RID: 41118 RVA: 0x002A1188 File Offset: 0x0029F388
		public NounHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x002A1198 File Offset: 0x0029F398
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

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x002A11D4 File Offset: 0x0029F3D4
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

		// Token: 0x04004F4D RID: 20301
		private Table __p;
	}
}
