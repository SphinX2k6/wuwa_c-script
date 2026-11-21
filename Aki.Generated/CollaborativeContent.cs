using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C67 RID: 3175
	public struct CollaborativeContent : IFlatbufferObject
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x00217C45 File Offset: 0x00215E45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00217C52 File Offset: 0x00215E52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00217C5C File Offset: 0x00215E5C
		public static CollaborativeContent GetRootAsCollaborativeContent(ByteBuffer _bb)
		{
			return CollaborativeContent.GetRootAsCollaborativeContent(_bb, default(CollaborativeContent));
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00217C78 File Offset: 0x00215E78
		public static CollaborativeContent GetRootAsCollaborativeContent(ByteBuffer _bb, CollaborativeContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00217C95 File Offset: 0x00215E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x00217CA4 File Offset: 0x00215EA4
		public CollaborativeContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x00217CB4 File Offset: 0x00215EB4
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

		// Token: 0x0400516B RID: 20843
		private Table __p;
	}
}
