using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFA RID: 3834
	public struct PhantomSubProperty : IFlatbufferObject
	{
		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x002B77F5 File Offset: 0x002B59F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x002B7802 File Offset: 0x002B5A02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x002B780C File Offset: 0x002B5A0C
		public static PhantomSubProperty GetRootAsPhantomSubProperty(ByteBuffer _bb)
		{
			return PhantomSubProperty.GetRootAsPhantomSubProperty(_bb, default(PhantomSubProperty));
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x002B7828 File Offset: 0x002B5A28
		public static PhantomSubProperty GetRootAsPhantomSubProperty(ByteBuffer _bb, PhantomSubProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x002B7845 File Offset: 0x002B5A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x002B7854 File Offset: 0x002B5A54
		public PhantomSubProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600AA78 RID: 43640 RVA: 0x002B7864 File Offset: 0x002B5A64
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

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x0600AA79 RID: 43641 RVA: 0x002B78A0 File Offset: 0x002B5AA0
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

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600AA7A RID: 43642 RVA: 0x002B78DC File Offset: 0x002B5ADC
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

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600AA7B RID: 43643 RVA: 0x002B7918 File Offset: 0x002B5B18
		public int SubStandardProperty
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

		// Token: 0x04004FC1 RID: 20417
		private Table __p;
	}
}
