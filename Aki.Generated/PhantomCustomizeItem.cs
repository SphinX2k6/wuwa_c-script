using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC7 RID: 4039
	public struct PhantomCustomizeItem : IFlatbufferObject
	{
		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600AE6C RID: 44652 RVA: 0x002CF964 File Offset: 0x002CDB64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x002CF971 File Offset: 0x002CDB71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x002CF978 File Offset: 0x002CDB78
		public static PhantomCustomizeItem GetRootAsPhantomCustomizeItem(ByteBuffer _bb)
		{
			return PhantomCustomizeItem.GetRootAsPhantomCustomizeItem(_bb, default(PhantomCustomizeItem));
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x002CF994 File Offset: 0x002CDB94
		public static PhantomCustomizeItem GetRootAsPhantomCustomizeItem(ByteBuffer _bb, PhantomCustomizeItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x002CF9B1 File Offset: 0x002CDBB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x002CF9C0 File Offset: 0x002CDBC0
		public PhantomCustomizeItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600AE72 RID: 44658 RVA: 0x002CF9D0 File Offset: 0x002CDBD0
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

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x002CFA0C File Offset: 0x002CDC0C
		public int PhantomId
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

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600AE74 RID: 44660 RVA: 0x002CFA48 File Offset: 0x002CDC48
		public int SkinItemId
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

		// Token: 0x04005588 RID: 21896
		private Table __p;
	}
}
