using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B60 RID: 2912
	public struct CalabashTransform : IFlatbufferObject
	{
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x001EF489 File Offset: 0x001ED689
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x001EF496 File Offset: 0x001ED696
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x001EF4A0 File Offset: 0x001ED6A0
		public static CalabashTransform GetRootAsCalabashTransform(ByteBuffer _bb)
		{
			return CalabashTransform.GetRootAsCalabashTransform(_bb, default(CalabashTransform));
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x001EF4BC File Offset: 0x001ED6BC
		public static CalabashTransform GetRootAsCalabashTransform(ByteBuffer _bb, CalabashTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x001EF4D9 File Offset: 0x001ED6D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x001EF4E8 File Offset: 0x001ED6E8
		public CalabashTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x001EF4F8 File Offset: 0x001ED6F8
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06005262 RID: 21090 RVA: 0x001EF534 File Offset: 0x001ED734
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x001EF594 File Offset: 0x001ED794
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06005264 RID: 21092 RVA: 0x001EF5F4 File Offset: 0x001ED7F4
		public Vector? Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x001EF654 File Offset: 0x001ED854
		public Vector? AxisRotate
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x001EF6B4 File Offset: 0x001ED8B4
		public int RotateTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B60 RID: 19296
		private Table __p;
	}
}
