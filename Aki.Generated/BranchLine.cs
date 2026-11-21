using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2D RID: 3117
	public struct BranchLine : IFlatbufferObject
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x0020899F File Offset: 0x00206B9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x002089AC File Offset: 0x00206BAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x002089B4 File Offset: 0x00206BB4
		public static BranchLine GetRootAsBranchLine(ByteBuffer _bb)
		{
			return BranchLine.GetRootAsBranchLine(_bb, default(BranchLine));
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x002089D0 File Offset: 0x00206BD0
		public static BranchLine GetRootAsBranchLine(ByteBuffer _bb, BranchLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x002089ED File Offset: 0x00206BED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x002089FC File Offset: 0x00206BFC
		public BranchLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x00208A0C File Offset: 0x00206C0C
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x00208A48 File Offset: 0x00206C48
		public int TaskId
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x00208A84 File Offset: 0x00206C84
		public int JumpBuildingId
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x00208AC0 File Offset: 0x00206CC0
		public int AssociateRole
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005128 RID: 20776
		private Table __p;
	}
}
