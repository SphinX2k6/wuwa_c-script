using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B12 RID: 2834
	public struct AutoRole : IFlatbufferObject
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060049C8 RID: 18888 RVA: 0x001DA845 File Offset: 0x001D8A45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x001DA852 File Offset: 0x001D8A52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x001DA85C File Offset: 0x001D8A5C
		public static AutoRole GetRootAsAutoRole(ByteBuffer _bb)
		{
			return AutoRole.GetRootAsAutoRole(_bb, default(AutoRole));
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x001DA878 File Offset: 0x001D8A78
		public static AutoRole GetRootAsAutoRole(ByteBuffer _bb, AutoRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x001DA895 File Offset: 0x001D8A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x001DA8A4 File Offset: 0x001D8AA4
		public AutoRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060049CE RID: 18894 RVA: 0x001DA8B4 File Offset: 0x001D8AB4
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x001DA8F0 File Offset: 0x001D8AF0
		public int ModelId
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x001DA92C File Offset: 0x001D8B2C
		public int AiId
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

		// Token: 0x04004AFA RID: 19194
		private Table __p;
	}
}
