using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B0 RID: 4528
	public struct Color : IFlatbufferObject
	{
		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600E9C1 RID: 59841 RVA: 0x00346C3C File Offset: 0x00344E3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9C2 RID: 59842 RVA: 0x00346C49 File Offset: 0x00344E49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9C3 RID: 59843 RVA: 0x00346C50 File Offset: 0x00344E50
		public static Color GetRootAsColor(ByteBuffer _bb)
		{
			return Color.GetRootAsColor(_bb, default(Color));
		}

		// Token: 0x0600E9C4 RID: 59844 RVA: 0x00346C6C File Offset: 0x00344E6C
		public static Color GetRootAsColor(ByteBuffer _bb, Color obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x00346C89 File Offset: 0x00344E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x00346C98 File Offset: 0x00344E98
		public Color __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x00346CA8 File Offset: 0x00344EA8
		public float R
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00346CE8 File Offset: 0x00344EE8
		public float G
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600E9C9 RID: 59849 RVA: 0x00346D28 File Offset: 0x00344F28
		public float B
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x00346D68 File Offset: 0x00344F68
		public float A
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052FD RID: 21245
		private Table __p;
	}
}
