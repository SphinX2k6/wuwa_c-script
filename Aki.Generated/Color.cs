using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E6 RID: 4838
	public struct Color : IFlatbufferObject
	{
		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0600F732 RID: 63282 RVA: 0x003718C8 File Offset: 0x0036FAC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x003718D5 File Offset: 0x0036FAD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x003718DC File Offset: 0x0036FADC
		public static Color GetRootAsColor(ByteBuffer _bb)
		{
			return Color.GetRootAsColor(_bb, default(Color));
		}

		// Token: 0x0600F735 RID: 63285 RVA: 0x003718F8 File Offset: 0x0036FAF8
		public static Color GetRootAsColor(ByteBuffer _bb, Color obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F736 RID: 63286 RVA: 0x00371915 File Offset: 0x0036FB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F737 RID: 63287 RVA: 0x00371924 File Offset: 0x0036FB24
		public Color __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x0600F738 RID: 63288 RVA: 0x00371934 File Offset: 0x0036FB34
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

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x0600F739 RID: 63289 RVA: 0x00371974 File Offset: 0x0036FB74
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

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0600F73A RID: 63290 RVA: 0x003719B4 File Offset: 0x0036FBB4
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

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x0600F73B RID: 63291 RVA: 0x003719F4 File Offset: 0x0036FBF4
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

		// Token: 0x04005940 RID: 22848
		private Table __p;
	}
}
