using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8E RID: 3214
	public struct CustomizedThumbnail : IFlatbufferObject
	{
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x00222121 File Offset: 0x00220321
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x0022212E File Offset: 0x0022032E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00222138 File Offset: 0x00220338
		public static CustomizedThumbnail GetRootAsCustomizedThumbnail(ByteBuffer _bb)
		{
			return CustomizedThumbnail.GetRootAsCustomizedThumbnail(_bb, default(CustomizedThumbnail));
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x00222154 File Offset: 0x00220354
		public static CustomizedThumbnail GetRootAsCustomizedThumbnail(ByteBuffer _bb, CustomizedThumbnail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00222171 File Offset: 0x00220371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x00222180 File Offset: 0x00220380
		public CustomizedThumbnail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x00222190 File Offset: 0x00220390
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

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x002221CC File Offset: 0x002203CC
		public int AreaId
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

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00222208 File Offset: 0x00220408
		public int MarkId
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

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x00222244 File Offset: 0x00220444
		public bool DefaultSelected
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051B1 RID: 20913
		private Table __p;
	}
}
