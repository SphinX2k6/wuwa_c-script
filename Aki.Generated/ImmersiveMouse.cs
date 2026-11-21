using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E40 RID: 3648
	public struct ImmersiveMouse : IFlatbufferObject
	{
		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x0027B930 File Offset: 0x00279B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x0027B93D File Offset: 0x00279B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x0027B944 File Offset: 0x00279B44
		public static ImmersiveMouse GetRootAsImmersiveMouse(ByteBuffer _bb)
		{
			return ImmersiveMouse.GetRootAsImmersiveMouse(_bb, default(ImmersiveMouse));
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x0027B960 File Offset: 0x00279B60
		public static ImmersiveMouse GetRootAsImmersiveMouse(ByteBuffer _bb, ImmersiveMouse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x0027B97D File Offset: 0x00279B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x0027B98C File Offset: 0x00279B8C
		public ImmersiveMouse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x0027B99C File Offset: 0x00279B9C
		public string ViewName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x0027B9D3 File Offset: 0x00279BD3
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x0027B9E2 File Offset: 0x00279BE2
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060088BE RID: 35006 RVA: 0x0027B9FC File Offset: 0x00279BFC
		public int AutoHideTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x0027BA3C File Offset: 0x00279C3C
		public float DeadZone
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0.1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040053BF RID: 21439
		private Table __p;
	}
}
