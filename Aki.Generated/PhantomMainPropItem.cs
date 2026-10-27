using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF0 RID: 3824
	public struct PhantomMainPropItem : IFlatbufferObject
	{
		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600A98D RID: 43405 RVA: 0x002B54C1 File Offset: 0x002B36C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x002B54CE File Offset: 0x002B36CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x002B54D8 File Offset: 0x002B36D8
		public static PhantomMainPropItem GetRootAsPhantomMainPropItem(ByteBuffer _bb)
		{
			return PhantomMainPropItem.GetRootAsPhantomMainPropItem(_bb, default(PhantomMainPropItem));
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x002B54F4 File Offset: 0x002B36F4
		public static PhantomMainPropItem GetRootAsPhantomMainPropItem(ByteBuffer _bb, PhantomMainPropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x002B5511 File Offset: 0x002B3711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x002B5520 File Offset: 0x002B3720
		public PhantomMainPropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600A993 RID: 43411 RVA: 0x002B5530 File Offset: 0x002B3730
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

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600A994 RID: 43412 RVA: 0x002B556C File Offset: 0x002B376C
		public int PropId
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

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x0600A995 RID: 43413 RVA: 0x002B55A8 File Offset: 0x002B37A8
		public int AddType
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

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x0600A996 RID: 43414 RVA: 0x002B55E4 File Offset: 0x002B37E4
		public int StandardProperty
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

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x002B5624 File Offset: 0x002B3824
		public int GrowthId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FB2 RID: 20402
		private Table __p;
	}
}
